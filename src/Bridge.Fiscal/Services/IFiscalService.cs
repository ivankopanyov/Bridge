namespace Bridge.Fiscal.Services;

public interface IFiscalService : IOptinable
{
    Task<SetCheckResponse> SetCheckAsync(FiscalCheck check);
}
