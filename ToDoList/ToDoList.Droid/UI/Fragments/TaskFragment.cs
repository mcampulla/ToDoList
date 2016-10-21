namespace ToDoList.Droid.UI.Fragments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;

    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Android.Util;
    using Android.Views;
    using Android.Widget;

    public class TaskFragment : Android.Support.V4.App.Fragment
    {
        #region Inner Classes
        #endregion

        #region Constants and Fields
        #endregion

        #region Widgets

        private EditText _titleText;

        #endregion

        #region Constructors

        public TaskFragment()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Fragment Methods

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            #region Desinger Stuff

            View view = inflater.Inflate(Resource.Layout.FragmentTask, container, false);

            #endregion           

            _titleText = view.FindViewById<EditText>(Resource.Id.TitleText);

            Bundle bundle = this.Arguments;
            int position = bundle.GetInt("id", 0);

            _titleText.Text = "Title :: " + position.ToString();

            return view;
        }

        public override void OnDestroyView()
        {
            base.OnDestroyView();
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