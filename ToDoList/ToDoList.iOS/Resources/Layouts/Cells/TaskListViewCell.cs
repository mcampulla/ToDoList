using System;

using Foundation;
using UIKit;

namespace ToDoList.iOS
{
    public partial class TaskListViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString ("TaskListViewCell");
        public static readonly UINib Nib;

        static TaskListViewCell ()
        {
            Nib = UINib.FromName ("TaskListViewCell", NSBundle.MainBundle);
        }

        protected TaskListViewCell (IntPtr handle) : base (handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
