namespace modulum.Client.Infrastructure.Routes
{
    public static class UserEndpoints
    {
        // Endpoint Raiz do controller
        public const string Raiz = "identity/";

        public static string Get(string userId)
        {
            return $"identity/{userId}";
        }

        public static string GetUserRoles(string userId)
        {
            return $"identity/roles/{userId}";
        }

        public static string ExportFiltered(string searchString)
        {
            return $"{Export}?searchString={searchString}";
        }

        public const string ConfirmEmail = "identity/confirm-email";
        public const string Export = "identity/export";
        public const string Register = "identity/user";
        public const string ToggleUserStatus = "identity/toggle-status";
        public const string ForgotPassword = "identity/forgot-password";
        public const string ResetPassword = "identity/reset-password";
    }
}