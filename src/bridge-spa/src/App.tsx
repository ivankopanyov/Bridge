import { useHttpClient } from './services/useHttpClient';
import { useServiceViewModel } from './viewModels/useServiceViewModel';
import ServiceListView from './components/ServiceListView';

function App() {
    const httpClient = useHttpClient("http://localhost:8080/api/v1.0");
    const serviceViewModel = useServiceViewModel();
    
    return (
        <ServiceListView
            serviceViewModel={serviceViewModel}
            httpClient={httpClient} />
    );
}

export default App;
