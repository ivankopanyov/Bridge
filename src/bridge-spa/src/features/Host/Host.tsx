import { useState, FC } from "react";
import { Accordion } from "@mui/material";
import { Computer } from "@mui/icons-material";
import { HostInfo } from "../HostList/data";
import { Text, AccordionBody, AccordionHeader } from "../../components";
import Service from "../Service/Service";
import "./Host.scss";

interface HostProps {
  host: HostInfo;
}

const Host: FC<Readonly<HostProps>> = ({ host }) => {
  const [expanded, setExpanded] = useState<boolean>(false);

  return (
    <Accordion expanded={expanded} onChange={(e, s) => setExpanded(s)}>
      <AccordionHeader>
        <div className="host-container">
          <Computer
            className={`host-indent-right ${
              host.services.length > host.activeServiceCount
                ? "host-fail-icon"
                : "host-success-icon"
            }`}
          />
          <div className="host-indent-right">
            <Text>{host.name}</Text>
          </div>
          <Text assignment="description">{`(${host.activeServiceCount}/${host.services.length})`}</Text>
        </div>
      </AccordionHeader>
      <AccordionBody indent>
        {host.services.map((service, index) => (
          <Service key={index} service={service} />
        ))}
      </AccordionBody>
    </Accordion>
  );
};

export default Host;
