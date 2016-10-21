namespace ToDoList.iOS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Foundation;
    using UIKit;

    using System.Threading.Tasks;

    public partial class SplashViewController : UIViewController
    {
        #region Inner Classes
        #endregion

        #region Constants and Fields
        #endregion

        #region Constructors

        public SplashViewController()
            : base("SplashViewController", null)
        {
            

        }

        #endregion

        #region Properties
        #endregion

        #region ViewController Methods

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TaskFactory factory = new TaskFactory();
            factory.StartNew(() => System.Threading.Thread.Sleep(2500)).ContinueWith((t) => {
                InvokeOnMainThread(() => UIApplication.SharedApplication.Windows[0].RootViewController = new MainViewController());
            });

            #region Designer Stuff
            #endregion
        }

        public override void ViewDidUnload()
        {
            base.ViewDidUnload();
        }

        #endregion

        #region Public Methods
        #endregion

        #region Methods
        #endregion

        #region Event Handlers
        #endregion
    }
}


