namespace Bridge.HostApi.Hubs;

[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class SearchArgsHub : Hub { }
