﻿using System;

using UIKit;

namespace ToDoList.iOS
{
    public partial class SplashViewController : UIViewController
    {
        public SplashViewController () : base ("SplashViewController", null)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

