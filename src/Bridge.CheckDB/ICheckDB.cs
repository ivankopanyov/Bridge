namespace Bridge.CheckDB;

[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ICheckDB")]
public interface ICheckDB
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICheckDB/SetCheckJson", ReplyAction = "http://tempuri.org/ICheckDB/SetCheckJsonResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
    System.Threading.Tasks.Task<SetCheckJsonResponse> SetCheckJsonAsync(SetCheckJsonRequest request);

    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
    System.Threading.Tasks.Task<GetCheckJsonResponse> GetCheckJsonAsync(GetCheckJsonRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICheckDB/GetCheckJsonByNum", ReplyAction = "http://tempuri.org/ICheckDB/GetCheckJsonByNumResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
    System.Threading.Tasks.Task<GetCheckJsonByNumResponse> GetCheckJsonByNumAsync(GetCheckJsonByNumRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICheckDB/SetCheck", ReplyAction = "http://tempuri.org/ICheckDB/SetCheckResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
    System.Threading.Tasks.Task<SetCheckResponse> SetCheckAsync(SetCheckRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICheckDB/GetCheck", ReplyAction = "http://tempuri.org/ICheckDB/GetCheckResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
    System.Threading.Tasks.Task<GetCheckResponse> GetCheckAsync(GetCheckRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICheckDB/GetCheckByNum", ReplyAction = "http://tempuri.org/ICheckDB/GetCheckByNumResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
    System.Threading.Tasks.Task<GetCheckByNumResponse> GetCheckByNumAsync(GetCheckByNumRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICheckDB/ExecuteReader", ReplyAction = "http://tempuri.org/ICheckDB/ExecuteReaderResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
    System.Threading.Tasks.Task<ExecuteReaderResponse> ExecuteReaderAsync(ExecuteReaderRequest request);
}
