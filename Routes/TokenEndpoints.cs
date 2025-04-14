namespace modulum.Client.Infrastructure.Routes
{
    public static class TokenEndpoints
    {
        public static string Get = "identity/token";
        public static string Refresh = "identity/token/refresh";
        public static string Logout = "identity/token/logout";
    }
}