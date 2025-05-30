﻿namespace modulum.Shared.Constants.Application
{
    public static class ApplicationConstants
    {
        public static class SignalR
        {
            public const string HubUrl = "/signalRHub";
            public const string SendUpdateDashboard = "UpdateDashboardAsync";
            public const string ReceiveUpdateDashboard = "UpdateDashboard";
            public const string SendRegenerateTokens = "RegenerateTokensAsync";
            public const string ReceiveRegenerateTokens = "RegenerateTokens";
            public const string ReceiveChatNotification = "ReceiveChatNotification";
            public const string SendChatNotification = "ChatNotificationAsync";
            public const string ReceiveMessage = "ReceiveMessage";
            public const string SendMessage = "SendMessageAsync";

            public const string OnConnect = "OnConnectAsync";
            public const string ConnectUser = "ConnectUser";
            public const string OnDisconnect = "OnDisconnectAsync";
            public const string DisconnectUser = "DisconnectUser";
            public const string OnChangeRolePermissions = "OnChangeRolePermissions";
            public const string LogoutUsersByRole = "LogoutUsersByRole";

            public const string PingRequest = "PingRequestAsync";
            public const string PingResponse = "PingResponseAsync";

        }

        public static class Variable
        {
            public const string ModulumSecretJWT = "MODULUM_SECRET_JWT";
            public const string ModulumConnectionString = "MODULUM_CONNECTION_STRING";
            public const string UrlAPI = "URL_API";
            public const string UrlClient = "URL_CLIENT";
            public const string SendGridMailAPIKey = "SEND_GRID_MAIL_API_KEY";
            public const string BlobDataSeeder = "MODULUM_BLOB_DATASEEDER";
        }
    }
}