namespace ToDoList.iOS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Foundation;
    using UIKit;

    public partial class LoginViewController : UIViewController
    {
        #region Inner Classes
        #endregion

        #region Constants and Fields
        #endregion

        #region Constructors

        public LoginViewController()
            : base("LoginViewController", null)
        {
        }

        #endregion

        #region Properties
        #endregion

        #region ViewController Methods

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            #region Designer Stuff
            #endregion

            this.NavigationController.SetNavigationBarHidden(true, false);
            this.LoginButton.TouchUpInside += LoginButton_TouchUpInside;
            this.RegisterButton.TouchUpInside += RegisterButton_TouchUpInside;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            this.LoginButton.TouchUpInside -= LoginButton_TouchUpInside;
            this.RegisterButton.TouchUpInside -= RegisterButton_TouchUpInside;
        }

        #endregion

        #region Public Methods
        #endregion

        #region Methods
        #endregion

        #region Event Handlers

        void LoginButton_TouchUpInside (object sender, EventArgs e)
        {
            this.NavigationController.PushViewController(new TaskListViewController(), true);
        }

        void RegisterButton_TouchUpInside (object sender, EventArgs e)
        {
            this.NavigationController.PushViewController(new RegistrationViewController(), true);
        }
        #endregion

       
    }
}


