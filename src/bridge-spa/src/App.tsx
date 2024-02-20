import { useHttpClient } from './services/useHttpClient';
import { useServiceViewModel } from './viewModels/useServiceViewModel';
import ServiceListView from './components/ServiceListView';
import Text from './components/Text';
import React from 'react';
import { CircularProgress } from '@mui/material';

function App() {
    const httpClient = useHttpClient("http://localhost:8080/api/v1.0");
    const serviceViewModel = useServiceViewModel();
    const [error, setError] = React.useState<string | undefined>(undefined);
    
    return (
        <div>
            { error && 
                <div
                    style={{
                        display: 'flex',
                        alignItems: 'center',
                        margin: '10px'
                    }}>
                    <CircularProgress 
                        size='20px'
                        sx={{
                            mx: '10px'
                        }} />
                    <Text short>
                        {error}
                    </Text>
                </div>
            }
            <ServiceListView
                serviceViewModel={serviceViewModel}
                httpClient={httpClient}
                error={error}
                setError={setError} />
        </div>
    );
}

export default App;
