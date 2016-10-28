namespace ToDoList.iOS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Foundation;
    using UIKit;

    public partial class MainViewController : UINavigationController
    {
        #region Inner Classes
        #endregion

        #region Constants and Fields
        UIView loadView;
        #endregion

        #region Constructors

        public MainViewController()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region ViewController Methods

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            #region Designer Stuff

            loadView = new UIView(UIScreen.MainScreen.Bounds);
            loadView.BackgroundColor = UIColor.Black;
            loadView.Alpha = .8f;
            UIActivityIndicatorView progress = new UIActivityIndicatorView(UIActivityIndicatorViewStyle.WhiteLarge);
            //progress.TintColor = UIColor.Yellow;
            //var frame = progress.Frame;
            //frame.X = (loadView.Frame.Width - frame.Width) / 2;
            //frame.Y = (loadView.Frame.Height - frame.Height) / 2;
            loadView.AddSubview(progress);
            this.View.AddSubview(loadView);

            loadView.UserInteractionEnabled = true;
            loadView.Hidden = true;
            #endregion

            this.PushViewController( new LoginViewController(), false);
        }

        public override void ViewDidUnload()
        {
            base.ViewDidUnload();
        }

        #endregion

        #region Public Methods

        public void BlockUI()
        {
            loadView.Hidden = false;
        }

        public void UnBlockUI()
        {
            loadView.Hidden = true;
        }

        #endregion

        #region Methods
        #endregion

        #region Event Handlers
        #endregion
    }
}


