using Microsoft.Owin.Security;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using TiendaOnlineMVC.MVC.Costants;
using TiendaOnlineMVC.MVC.Security;

namespace TiendaOnlineMVC.MVC.Utils
{
    public class Connect
    {
        public string Url { get; private set; }
        public Connect()
        {

            this.Url = ConfigurationManager.AppSettings["ApiBaseUri"];

        }
        public Connect(string username, string password):this()
        {
            GetToken(username, password);
        }

        public IUserSession UserSession
        {
            get
            {
                return new UserSession();
            }
        }

        private void GetToken(string username, string password)
        {
            var getTokenUrl = string.Format(ApiEndPoints.GetToken, Url);
            ///el using para establecer un rango de ejecución (IDisposable) se borra de memoria una vez que termina la ejecución
            using (HttpClient httpClient = new HttpClient())
            {
                HttpContent content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password)
                });

                HttpResponseMessage result = httpClient.PostAsync(getTokenUrl, content).Result;

                string resultContent = result.Content.ReadAsStringAsync().Result;

                var token = JsonConvert.DeserializeObject<Token>(resultContent);

                AuthenticationProperties options = new AuthenticationProperties();

                options.AllowRefresh = true;
                options.IsPersistent = true;
                options.ExpiresUtc = DateTime.UtcNow.AddSeconds(token.expires_in);

                //Todos los datos que me quiero guardar en la cookie
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim("AcessToken", string.Format("Bearer {0}", token.access_token)),
                };
                claims.AddRange(token.Roles.Split(',').Select(e => new Claim(ClaimTypes.Role, e)));
                var identity = new ClaimsIdentity(claims, "ApplicationCookie");

                HttpContext.Current.Request.GetOwinContext().Authentication.SignIn(options, identity);

            }
            
        }

    }
}