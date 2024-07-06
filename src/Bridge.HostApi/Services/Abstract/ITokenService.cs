namespace Bridge.HostApi.Services.Abstract;

public interface ITokenService
{
    string AccessToken(long userId);

    string RefreshToken();
}
