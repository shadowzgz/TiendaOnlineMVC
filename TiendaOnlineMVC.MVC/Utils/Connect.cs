using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace TiendaOnlineMVC.MVC.Utils
{
    public class Connect
    {
        public string Url { get; private set; }
        public string Token { get; private set; }
        public Connect(string url)
        {

            Url = url;

        }
        public Connect(string url, string username, string password):this(url)
        {
            Token = GetToken(username, password);
        }

        private string GetToken(string username, string password)
        {
            string token = string.Empty;
            ///el using para establecer un rango de ejecución (IDisposable) se borra de memoria una vez que termina la ejecución
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Url);
                client.DefaultRequestHeaders.Accept.Clear();

                var formData = new List<KeyValuePair<string, string>>();
                formData.Add(new KeyValuePair<string, string>("grant_type", "password"));
                formData.Add(new KeyValuePair<string, string>("username", username));
                formData.Add(new KeyValuePair<string, string>("password", password));

                var request = new HttpRequestMessage(HttpMethod.Post, "/Token");
                request.Content = new FormUrlEncodedContent(formData);
                var response = client.SendAsync(request).Result;
                token = response.Content.ReadAsStringAsync().Result;



            }
            return token;
        }

    }
}