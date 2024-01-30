namespace Bridge.Opera.Services;

public class OperaService : IOperaService
{
    private static string? _connectionString = null;

    public static string? ConnectionString => _connectionString;

    private readonly IWritableOptions<OperaOptions> _writableOperaOptions;

    private bool _isActive = false;

    private Exception? _currentException = null;

    public bool IsActive => _isActive;

    public Exception? CurrentException => _currentException;

    public event ChangeStateOperaHandle? ChangeStateEvent;

    public OperaService(IWritableOptions<OperaOptions> writableOperaOptions)
    {
        _writableOperaOptions = writableOperaOptions;

        var optionsValue = writableOperaOptions?.Value;
        _connectionString = optionsValue?.ConnectionString;
    }

    public void SetOperaOptions(OperaOptions? options)
    {
        if ((_connectionString == null && options?.ConnectionString == null)
            || (_connectionString != null && options?.ConnectionString != null && _connectionString == options?.ConnectionString))
            return;

        _writableOperaOptions.Update(opt =>
        {
            opt.ConnectionString = options?.ConnectionString;
        });

        _connectionString = options?.ConnectionString;
    }

    public void Active()
    {
        if (_isActive)
            return;

        _isActive = true;
        _currentException = null;
        ChangeStateEvent?.Invoke(true, null);
    }

    public void Unactive(Exception ex)
    {
        if (!_isActive && _currentException != null && ex?.Message == _currentException.Message)
            return;

        _isActive = false;
        _currentException = ex;
        ChangeStateEvent?.Invoke(false, ex);
    }
}
