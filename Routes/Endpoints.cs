using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Shared.Routes
{
    public static class EndpointsUser
    {
        public const string Raiz = "user/"; // Raiz do Controller

        public const string GetUserById = "{id}";
        public const string PreCadastro = "pre-cadastro";
        public const string ConfirmEmail = "confirm-email";
        public const string FimCadastro = "fim-cadastro";
        public const string EsqueciSenha = "forgot-password";
        public const string ResetarSenha = "reset-password";
        public const string ChangePassword = "change-password";
        public const string IsEmailConfirmed = "is-confirm-email";
        public const string Info = "info";
    }

    public static class EndpointsToken
    {
        public const string Raiz = "token/"; // Raiz do Controller

        public const string Login = "login";
        public const string Refresh = "refresh";
        public const string Logout = "logout";
    }

    public static class EndpointsDynamic
    {
        public const string Raiz = "dynamic/"; // Raiz do Controller

        public const string Operacao = "{operacao}";
    }

    public static class EndpointGetVersao
    {
        public const string Raiz = "versao/"; // Raiz do Controller
    }
}
