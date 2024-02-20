import React from "react";
import MarginProps from "./MarginProps";
import Text from "./Text";
import { Accordion, AccordionDetails, AccordionSummary, IconButton } from "@mui/material";
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import AddIcon from '@mui/icons-material/Add';
import ReplayIcon from '@mui/icons-material/Replay';

interface ComponentProps extends MarginProps {
    children?: React.ReactNode;
    title?: string;
    openTitle?: string;
    titleColor?: string;
    contentColor?: string;
    onAddClick?: () => void;
    onResetClick?: () => void;
    disabled?: boolean;
}
  
const Component: React.FC<ComponentProps> = (props: ComponentProps) => {
    const [expanded, setExpanded] = React.useState<boolean>(false);
    const expandedState = React.useRef<boolean>(true);
  
    return (
        <Accordion
            sx={{ 
                mt: props.mt ? props.mt + "px" : props.mt,
                mb: props.mb ? props.mb + "px" : props.mb,
                ml: props.ml ? props.ml + "px" : props.ml,
                mr: props.mr ? props.mr + "px" : props.mr
            }}
            expanded={expanded}
            onChange={(_e, s) => { 
                setExpanded(expandedState.current ? s : true);
                expandedState.current = true; 
            }}>
            <AccordionSummary
                sx={{ 
                    backgroundColor: props.titleColor 
                }}
                expandIcon={<ExpandMoreIcon />}>
                { 
                    <div style={{ width: "100%", display: "flex", justifyContent: "space-between", alignItems: "center" }}>
                        <Text short>{!expanded ? props.title : props.openTitle ?? props.title}</Text>
                        { props.onAddClick && 
                        <IconButton
                            onClick={() => {
                                expandedState.current = false;
                                props.onAddClick && props.onAddClick();
                            }}
                            disabled={props.disabled}>
                            <AddIcon />
                        </IconButton> }
                        { props.onResetClick && expanded &&
                        <IconButton
                            onClick={() => {
                                expandedState.current = false;
                                props.onResetClick && props.onResetClick();
                            }}
                            disabled={props.disabled}>
                            <ReplayIcon />
                        </IconButton> }
                    </div>
                }
            </AccordionSummary>
            <AccordionDetails 
                sx={{ 
                    backgroundColor: props.contentColor
                }}>
                {props.children}
            </AccordionDetails>
      </Accordion>
    );
};

export default Component;