using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public static class AppController
    {

        public static async Task Login(string username, string password, Action<Poco.User> success, Action<string> fail, Action<Exception> exception = null)
        {
            try
            {
                RestClient svc = new RestClient("http://listy.azurewebsites.net/");
                svc.IgnoreResponseStatusCode = true;
                RestRequest req = new RestRequest("users/login", Method.POST);
                req.AddJsonBody(new Poco.User() { Email = username, Password = password });
                var res = await svc.Execute<Dto.Response<Poco.User>>(req);                
                if(res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Poco.User user = res.Data.Content;
                    success?.Invoke(user);
                }
                else
                {
                    fail?.Invoke(res.Data.Message ?? res.StatusDescription);
                }

            }
            catch (Exception ex)
            {
                exception?.Invoke(ex);
            }
        }

        public static async Task Register(string username, string password, Action<Poco.User> success, Action<string> fail, Action<Exception> exception = null)
        {
            try
            {
                RestClient svc = new RestClient("http://listy.azurewebsites.net/");
                svc.IgnoreResponseStatusCode = true;
                RestRequest req = new RestRequest("users/register", Method.POST);
                req.AddJsonBody(new Poco.User() { Email = username, Password = password });
                var res = await svc.Execute<Dto.Response<Poco.User>>(req);
                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Poco.User user = res.Data.Content;
                    success?.Invoke(user);
                }
                else
                {
                    fail?.Invoke(res.Data.Message ?? res.StatusDescription);
                }

            }
            catch (Exception ex)
            {
                exception?.Invoke(ex);
            }
        }
    }
}
