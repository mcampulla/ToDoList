using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model;

namespace ToDoList
{
    public static class AppController
    {
        private static string _connectionString = string.Empty;

        public static async Task Login(string username, string password, Action<Poco.User> success, Action<string> fail, Action<Exception> exception = null)
        {
            try
            {
                RestClient svc = new RestClient("http://listy-api.azurewebsites.net/");
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

        public static void InitSqlite(string path)
        {
            _connectionString = path;
            using (var conn = new SQLiteConnection(_connectionString, false))
            {
                conn.CreateTable<TaskItem>();
            }
        }

        public static TaskItem[] GetTasks()
        {
            using (var conn = new SQLiteConnection(_connectionString, false))
            {
                return conn.Table<TaskItem>().ToArray();
            }
        }

        public static TaskItem GetTask(int itemId)
        {
            using (var conn = new SQLiteConnection(_connectionString, false))
            {
                return conn.Get<TaskItem>(i => i.TaskId == itemId);
            }
        }

        public static void AddTask(TaskItem item)
        {
            using (var conn = new SQLiteConnection(_connectionString, false))
            {
                conn.Insert(item);
            }
        }

        public static void UpdateTask(TaskItem item)
        {
            using (var conn = new SQLiteConnection(_connectionString, false))
            {
                conn.Update(item);
            }
        }

        public static void DeleteTask(int taskId)
        {
            using (var conn = new SQLiteConnection(_connectionString, false))
            {
                conn.Delete(taskId);
            }
        }

    }
}
