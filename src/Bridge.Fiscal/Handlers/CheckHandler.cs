namespace Bridge.Fiscal.Handlers;

public class CheckHandler(IFiscalService fiscalService, IEventBusService eventBusService)
    : EventHandler<Check, PostResponseInfo>(eventBusService)
{
    protected override async Task<PostResponseInfo> HandleAsync(Check @in, string? taskId)
    {
        var fiscalCheck = new FiscalCheck
        {
            uws = 1,
            rvc = @in.Rvc,
            cknum = @in.CheckNumber,
            open_time = @in.DateTime,
            close_time = @in.DateTime,
            total = @in.Total,
            tremp = 99,
            tremp_fname = "IFC",
            tremp_lname = "Sanatorium",
            cashier = 99,
            dtl = @in.Details.Select(item => new CheckItem
            {
                type = 'M',
                objnum = item.ObjectNumber,
                name = item.Name,
                qty = (int)item.Quantity,
                qtf = item.Quantity,
                ttl = item.Total.ToString(),
                tax = item.Tax,
                taxps = item.TaxPosting
            }).ToArray()
        };

        var response = await fiscalService.SetCheckAsync(fiscalCheck);

        return new PostResponseInfo
        {
            Succeeded = response.SetCheckResult.success,
            ErrorMessage = response.SetCheckResult.errtext
        };
    }
}
