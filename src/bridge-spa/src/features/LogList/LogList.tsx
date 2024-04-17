import { FC, useState } from "react";
import { MenuBook } from "@mui/icons-material";
import NavBar from "../../components/NavBar/NavBar";
import './LogList.scss';

const LogList: FC = () => {
    const [search, setSearch] = useState('');

    return (
        <NavBar
            title="Logs"
            icon={<MenuBook className="log-list-icon" />}
            search={{
                value: search,
                setValue: setSearch
            }}
        />
    );
};

export default LogList;