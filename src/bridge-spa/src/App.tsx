import React, { ReactNode } from 'react';
import { HttpClient, useHttpClient } from './services/useHttpClient';
import Host from './models/Host';
import Property from './models/Property';

import Typography from '@mui/material/Typography';
import Checkbox from '@mui/material/Checkbox';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import CircularProgress from '@mui/material/CircularProgress';
import Accordion from '@mui/material/Accordion';
import AccordionSummary from '@mui/material/AccordionSummary';
import AccordionDetails from '@mui/material/AccordionDetails';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';

function App() {
  const my: number = 20;
  const successColor: string = "#a6ffbb";
  const failColor: string = "#ffa6a6";

  const httpClient = useHttpClient("http://localhost:8080/api/v1.0");
  const [services, setServices] = React.useState<Host[] | null>(null);
  const [error, setError] = React.useState<string | null>(null);

  const getProperty = (name: string, value: any) : Property => {
    let type = typeof value;
    if (type === "string" || type === 'undefined' || type === 'function')
      return {
        name: name,
        value: value,
        type: "string"
      };

    if (type === "number" || type === "bigint" || type === "boolean" || type === "symbol")
      return {
        name: name,
        value: value,
        type: type
      };
    
    if (Array.isArray(value))
      return {
        name: name,
        value: value,
        type: "array",
        valueType: getValueType(value)
      };
    
    try {
      let map = new Map(Object.entries(value));
      return {
        name: name,
        value: value,
        type: "map",
        valueType: map.size === 0 ? "string" : getValueType(map.values())
      };
    } catch {
      return {
        name: name,
        value: value,
        type: "string"
      };
    }
  }

  const getValueType = (propertyValue: any) : "string" | "number" | "bigint" | "boolean" | "symbol" => {
    try {
      let array = [...propertyValue];
      if (array.length === 0)
        return "string";

      let type = typeof array[0];

      if (type === "string" || type === 'undefined' || type === 'function')
        return "string";

      if (type === "number" || type === "bigint" || type === "boolean" || type === "symbol")
        return type;
    } catch {
      return "string";
    }

    return "string";
  }
  
  const getServices = async () => await httpClient.get<Host[]>("hosts")
    .then(async data => {
      setError(null);
      setServices(data);
    })
    .catch(async error => {
      setError(error.message ?? error.status);
      setTimeout(async () => await getServices(), 1000);
    });

  const getProperties = (options: string | null | undefined): Property[] | null => {
    if (!options)
      return null;
    
    try {
      let keys = Object.keys(JSON.parse(options));
      if (keys.length === 0)
        return null;
      
      let values = Object.values<any>(JSON.parse(options));
      return keys.map<Property>((k, i) => getProperty(k, values[i]));
    } catch {
      return null;
    }
  };
  
  React.useEffect(() => { getServices(); }, []);
  
  return (
    <div>
      <Component
        title={"Services (" + (services?.flatMap(h => h.services).filter(s => s.state.isActive).length ?? 0) + " / " + (services?.flatMap(h => h.services).length ?? 0) + ")"}
        titleColor={!services ? successColor : (services.flatMap(h => h.services).find(s => !s.state.isActive) ? failColor : successColor)}>
        {error && <div>{error}</div>}
        {services && services.map((h, i) =>
          <Component
            key={i}
            title={h.name + " (" + h.services.filter(s => s.state.isActive).length + " / " + h.services.length + ")"}
            titleColor={h.services.find(s => !s.state.isActive) ? failColor : successColor}
            contentColor='gray'>
            {h.services.map((s, i) => 
              <Component
                key={i}
                title={s.name}
                titleColor={s.state.isActive ? successColor : failColor}>
                {(s.state.error || s.state.stackTrace) && 
                  <Component
                    title={s.state.error ?? s.state.stackTrace}
                    openTitle='Error'
                    titleColor={failColor}
                    contentColor={failColor}>
                    {s.state.error && 
                      <Text>
                        {s.state.error}
                      </Text>}
                    {s.state.stackTrace && 
                      <Component
                        title='Stack Trace'
                        titleColor='#9c3636'>
                        <Text>
                          {s.state.stackTrace}
                        </Text>
                      </Component>}
                  </Component>}
                <Properties
                  hostName={h.name}
                  serviceName={s.name}
                  properties={getProperties(s.options?.options)}
                  httpClient={httpClient}
                  my={my} />
              </Component> )}
          </Component>
        )}
      </Component>
    </div>
  );
};

interface PropertiesProps {
  hostName: string;
  serviceName: string;
  properties: Property[] | null;
  httpClient: HttpClient;
  my?: number;
}

const Properties: React.FC<PropertiesProps> = (props: PropertiesProps) => {
  const [disabled, setDisabled] = React.useState<boolean>(false);
  const [error, setError] = React.useState<string | undefined>(undefined);

  const setOptions = async () => await props.httpClient
    .update("hosts/" + props.hostName + "/" + props.serviceName, {
      options: null
    })
    .then(() => {
      setDisabled(false);
      setError(undefined);
    })
    .catch(error => {
      setDisabled(false);
      setError(error.message ?? error.status);
    });

  return (
    <div>
      { props.properties && 
        <div>{props.properties.map((p, i) => 
          <div key={i}>
            { p.type === "boolean" && 
              <CheckboxProperty
                label={p.name}
                defaultChecked={Boolean(p.value)}
                onChange={checked => p.value = checked}
                mt={props.my ? props.my + "px" : undefined}
                disabled={disabled} /> }
            { (p.type === "string" || p.type === "number" || p.type === "bigint" || p.type === "symbol") && 
              <InputProperty
                label={p.name}
                defaultValue={p.value}
                onChange={text => p.value = text}
                mt={props.my ? props.my + "px" : undefined}
                disabled={disabled} /> }
            {/* { p.type === 'array' && <span>{[...p.value].map((v, i) => <span><input key={i} value={v} /><button>-</button></span>)}<button>+</button></span> }
            { p.type === "map" && Object.keys(p.value).map((k, i) => <div key={i}><input value={k} /><input value={Object.values<string>(p.value)[i]} /><button>-</button></div>) } */}
          </div>)}
        { error &&
          <div style={{ width: "100%", marginTop: "10px", display: "flex", justifyContent: "center" }}>
            <Text fontSize='12px' color='red'>
              {error}
            </Text>
          </div>}
        <ButtonProperty
          label='Save and Restart'
          onClick={() => { 
            setDisabled(true);
            setError(undefined);
            setOptions();
          }}
          mt={props.my ? props.my + "px" : undefined}
          disabled={disabled} />
      </div>}
    </div>
  );
};

interface InputPropertyProps {
  label: string;
  defaultValue: string;
  onChange: (value: string) => void;
  onlyNumber?: boolean;
  maxLength?: number;
  mt?: string;
  disabled?: boolean;
}

const InputProperty: React.FC<InputPropertyProps> = (props: InputPropertyProps) => {

  const fixValue = (value: string): string => {
    let text = props.onlyNumber ? value.toString().replace(/\D/g, "") : value;
    return text;
  }

  const [value, setValue] = React.useState<string>(fixValue(props.defaultValue));

  return (
    <TextField
      id="outlined-required"
      label={props.label}
      value={value}
      onChange={e => { 
        let text = fixValue(e.target.value);
        setValue(text);
        props.onChange(text);
      }}
      sx={{ mt: props.mt }}
      fullWidth
      disabled={props.disabled}
    />
  );
};

interface CheckboxPropertyProps {
  label: string;
  defaultChecked: boolean;
  onChange: (checked: boolean) => void;
  mt?: string;
  disabled?: boolean;
}

const CheckboxProperty: React.FC<CheckboxPropertyProps> = (props: CheckboxPropertyProps) => {
  const [checked, setChecked] = React.useState<boolean>(props.defaultChecked);

  return (
    <div style={{ display: 'flex' }}>
      <Text short>
        {props.label}
      </Text>
      <Checkbox
        checked={checked}
        onChange={(_e, c) => {
          setChecked(c);
          props.onChange(c);
        }}
        sx={{ mt: props.mt }}
        disabled={props.disabled} />
    </div>
  );
};

interface ComponentProps {
  children?: React.ReactNode;
  title?: string;
  openTitle?: string;
  titleColor?: string;
  contentColor?: string;
}

const Component: React.FC<ComponentProps> = (props: ComponentProps) => {
  const [expanded, setExpanded] = React.useState<boolean>(false);

  return (
    <Accordion
      defaultExpanded={expanded}
      onChange={(_e, s) => setExpanded(s)}>
      <AccordionSummary
        sx={{ backgroundColor: props.titleColor }}
        expandIcon={<ExpandMoreIcon />}>
        { <Text short>{!expanded ? props.title : props.openTitle ?? props.title}</Text> }
      </AccordionSummary>
      <AccordionDetails 
        sx={{ backgroundColor: props.contentColor }}>
        {props.children}
      </AccordionDetails>
    </Accordion>
  );
};

interface TextProps {
  children?: React.ReactNode;
  short?: boolean;
  fontSize?: string;
  color?: string;
}

const Text: React.FC<TextProps> = (props: TextProps) => {
  return (
    <Typography sx={{
      fontSize: !props.fontSize ? "14px" : props.fontSize,
      color: props.color,
      overflowWrap: 'anywhere',
      display: '-webkit-box',
      overflow: 'hidden',
      WebkitBoxOrient: 'vertical',
      WebkitLineClamp: props.short ? 1 : undefined }}>
      { props.children }
    </Typography>
  );
};

interface ButtonPropertyProps {
  label: string;
  onClick: () => void;
  mt?: string;
  disabled?: boolean;
}

const ButtonProperty: React.FC<ButtonPropertyProps> = (props: ButtonPropertyProps) => {
  return (
    <div
      style={{ display: 'flex', justifyContent: 'center', width: '100%', marginTop: props.mt }}>
      <Button
        onClick={props.onClick}
        disabled={props.disabled}>
        { !props.disabled ? props.label : <CircularProgress size='25px' /> }
      </Button>
    </div>
  );
};

export default App;
