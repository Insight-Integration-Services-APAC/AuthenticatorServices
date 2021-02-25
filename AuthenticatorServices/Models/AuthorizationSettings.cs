using System.Collections.Generic;

namespace AuthenticatorServices.Models
{
    public class AuthenticatorServiceModel
    {
        public class SettingsModel
        {
            public string Endpoint { get; set; }

            public string AuthorisationUrl { get; set; }

            public string Scopes { get; set; }

            public string ClientId { get; set; }

            public string ClientSecret { get; set; }

            public string UserName { get; set; }

            public string Password { get; set; }
        }
        public List<SettingsModel> Settings { get; set; }
    }
}