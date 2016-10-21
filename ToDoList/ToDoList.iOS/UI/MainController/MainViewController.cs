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
            #endregion

            this.PushViewController( new LoginViewController(), false);
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


