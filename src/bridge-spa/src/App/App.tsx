import { useEffect, FC } from "react";
import { useAppDispatch, useAppSelector } from "../redux/hooks";
import { RootState } from "../redux/store";
import { refresh } from "./AppStore";
import { Loading } from "../components";
import Error from "../components/Error/Error";
import TabBar from "../features/TabBar/TabBar";
import Auth from "../features/Auth/Auth";

const App: FC = () => {
  const dispatch = useAppDispatch();
  const app = useAppSelector(({ app }: RootState) => app);

  useEffect(() => {
    dispatch(refresh());
  }, []);

  useEffect(() => {
    if (!app.loading && !app.auth)
      setTimeout(async () => await dispatch(refresh()), 3000);
  }, [app.loading]);

  return (
    <>
      {
        {
          authorized: <TabBar />,
          unauthorized: <Auth />,
          unknown: (
            <div>
              {app.error && <Error error={app.error} />}
              <Loading />
            </div>
          ),
        }[app.auth ?? "unknown"]
      }
    </>
  );
};

export default App;
