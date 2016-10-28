using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ToDoList.Droid
{
#if DEBUG
    [Application(Name = "todolist.droid.ToDoApplication")]
#else
     [Application(Name = "todolist.droid.ToDoApplication", Debuggable = false)]
#endif
    public class ToDoApplication : Application
    {
        protected ToDoApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            
        }

        public override void OnCreate()
        {
            base.OnCreate();

            string path = System.IO.Path.Combine(Android.App.Application.Context.GetExternalFilesDir(null).Path
                , "todolist.db3");
            AppController.InitSqlite(path);
        }
    }
}