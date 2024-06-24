namespace Bridge.Opera.Services.Implement;

public class OperaService(IControl<OperaOptions, BridgeEnvironment> control) : IOperaService
{
    private OperaDbContext Context => new(control.Options.ConnectionString, control.Options.OracleSqlCompatibility);

    public BridgeEnvironment Environment => control.Environment;

    public void Exec(Action<OperaDbContext> action)
    {
        ArgumentNullException.ThrowIfNull(action, nameof(action));

        try
        {
            using var context = Context;
            action.Invoke(context);
            control.Active();
        }
        catch (Exception ex) 
        {
            control.Unactive(ex);
            throw;
        }
    }

    public T Exec<T>(Func<OperaDbContext, T> func)
    {
        ArgumentNullException.ThrowIfNull(func, nameof(func));

        try
        {
            using var context = Context;
            var result = func.Invoke(context);
            control.Active();
            return result;
        }
        catch (Exception ex)
        {
            control.Unactive(ex);
            throw;
        }
    }

    public async Task ChangedOptionsHandleAsync(OperaOptions options) 
    {
        using var context = Context;
        await Context.ReservationNames.AsNoTracking().AnyAsync();
    }

    public Task ChangedEnvironmentHandleAsync(BridgeEnvironment current, BridgeEnvironment previous) => Task.CompletedTask;
}
