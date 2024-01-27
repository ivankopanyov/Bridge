namespace Bridge.CheckDB;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
public partial class CheckDBClient : System.ServiceModel.ClientBase<ICheckDB>, ICheckDB
{

    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

    public CheckDBClient() :
            base(CheckDBClient.GetDefaultBinding(), CheckDBClient.GetDefaultEndpointAddress())
    {
        this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICheckDB.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }

    public CheckDBClient(EndpointConfiguration endpointConfiguration) :
            base(CheckDBClient.GetBindingForEndpoint(endpointConfiguration), CheckDBClient.GetEndpointAddress(endpointConfiguration))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }

    public CheckDBClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
            base(CheckDBClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }

    public CheckDBClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
            base(CheckDBClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }

    public CheckDBClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<SetCheckJsonResponse> ICheckDB.SetCheckJsonAsync(SetCheckJsonRequest request)
    {
        return base.Channel.SetCheckJsonAsync(request);
    }

    public System.Threading.Tasks.Task<SetCheckJsonResponse> SetCheckJsonAsync(string json)
    {
        SetCheckJsonRequest inValue = new SetCheckJsonRequest();
        inValue.json = json;
        return ((ICheckDB)(this)).SetCheckJsonAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetCheckJsonResponse> ICheckDB.GetCheckJsonAsync(GetCheckJsonRequest request)
    {
        return base.Channel.GetCheckJsonAsync(request);
    }

    public System.Threading.Tasks.Task<GetCheckJsonResponse> GetCheckJsonAsync(string json)
    {
        GetCheckJsonRequest inValue = new GetCheckJsonRequest();
        inValue.json = json;
        return ((ICheckDB)(this)).GetCheckJsonAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetCheckJsonByNumResponse> ICheckDB.GetCheckJsonByNumAsync(GetCheckJsonByNumRequest request)
    {
        return base.Channel.GetCheckJsonByNumAsync(request);
    }

    public System.Threading.Tasks.Task<GetCheckJsonByNumResponse> GetCheckJsonByNumAsync(int rvc, int cknum, System.DateTime ckopen)
    {
        GetCheckJsonByNumRequest inValue = new GetCheckJsonByNumRequest();
        inValue.rvc = rvc;
        inValue.cknum = cknum;
        inValue.ckopen = ckopen;
        return ((ICheckDB)(this)).GetCheckJsonByNumAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<SetCheckResponse> ICheckDB.SetCheckAsync(SetCheckRequest request)
    {
        return base.Channel.SetCheckAsync(request);
    }

    public System.Threading.Tasks.Task<SetCheckResponse> SetCheckAsync(FiscalCheck check)
    {
        SetCheckRequest inValue = new SetCheckRequest();
        inValue.check = check;
        return ((ICheckDB)(this)).SetCheckAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetCheckResponse> ICheckDB.GetCheckAsync(GetCheckRequest request)
    {
        return base.Channel.GetCheckAsync(request);
    }

    public System.Threading.Tasks.Task<GetCheckResponse> GetCheckAsync(Request check)
    {
        GetCheckRequest inValue = new GetCheckRequest();
        inValue.check = check;
        return ((ICheckDB)(this)).GetCheckAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetCheckByNumResponse> ICheckDB.GetCheckByNumAsync(GetCheckByNumRequest request)
    {
        return base.Channel.GetCheckByNumAsync(request);
    }

    public System.Threading.Tasks.Task<GetCheckByNumResponse> GetCheckByNumAsync(int rvc, int cknum, System.DateTime ckopen)
    {
        GetCheckByNumRequest inValue = new GetCheckByNumRequest();
        inValue.rvc = rvc;
        inValue.cknum = cknum;
        inValue.ckopen = ckopen;
        return ((ICheckDB)(this)).GetCheckByNumAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<ExecuteReaderResponse> ICheckDB.ExecuteReaderAsync(ExecuteReaderRequest request)
    {
        return base.Channel.ExecuteReaderAsync(request);
    }

    public System.Threading.Tasks.Task<ExecuteReaderResponse> ExecuteReaderAsync(string sql)
    {
        ExecuteReaderRequest inValue = new ExecuteReaderRequest();
        inValue.sql = sql;
        return ((ICheckDB)(this)).ExecuteReaderAsync(inValue);
    }

    public virtual System.Threading.Tasks.Task OpenAsync()
    {
        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
    }

    private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICheckDB))
        {
            System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
            result.MaxBufferSize = int.MaxValue;
            result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            result.MaxReceivedMessageSize = int.MaxValue;
            result.AllowCookies = true;
            return result;
        }
        throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
    }

    private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICheckDB))
        {
            return new System.ServiceModel.EndpointAddress("http://localhost/FiscalService/CheckDB");
        }
        throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
    }

    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
        return CheckDBClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICheckDB);
    }

    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
        return CheckDBClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICheckDB);
    }

    public enum EndpointConfiguration
    {

        BasicHttpBinding_ICheckDB,
    }
}
