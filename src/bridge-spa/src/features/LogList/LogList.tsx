import { FC, useState } from "react";
import { MenuBook } from "@mui/icons-material";
import { useAppSelector } from '../../redux/hooks';
import { RootState } from '../../redux/store';
import NavBar from "../../components/NavBar/NavBar";
import Task from "../Task/Task";
import './LogList.scss';

const LogList: FC = () => {
    const logList = useAppSelector(({ logList }: RootState) => logList);
    const [search, setSearch] = useState('');

    return (
        <NavBar
            title="Logs"
            icon={<MenuBook className="log-list-icon" />}
            search={{
                value: search,
                setValue: setSearch
            }}
        >
            { logList.tasks.length > 0 && logList.tasks.map(task => <Task key={task.taskId} task={task} />) }
        </NavBar>
    );
};

export default LogList;