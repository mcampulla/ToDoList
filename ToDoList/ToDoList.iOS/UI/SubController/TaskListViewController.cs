namespace ToDoList.iOS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Foundation;
    using UIKit;

    public partial class TaskListViewController : UIViewController
    {
        #region Inner Classes

        public class TaskListViewSource : UITableViewSource
        {
            List<string> _tasks = new List<string>();

            public TaskListViewSource(UIViewController parent, IEnumerable<string> items)
            {
                _tasks = items.ToList();
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                //nome dello xib
                TaskListViewCell cell = tableView.DequeueReusableCell("TaskListViewCell") as TaskListViewCell;
                if (cell == null)
                {
                    //oggetto che rappresenta il pacchetto applicativo
                    //prendo il primo oggetto (la cella) ovvero lo zero
                    cell = NSBundle.MainBundle.LoadNib("TaskListViewCell", this, null).GetItem<TaskListViewCell>(0);
                }

                //con l'istanza corretta della classe ho accesso agli outlet
                //posso già accedere alle proprietà della cella ie background, stili etc
                //cell.BackgroundColor. = 
                string value = _tasks.ElementAt(indexPath.Row);
                int max = value.Length > 30 ? 30 : value.Length;
                cell.TitleLabel.Text = (_tasks.ElementAt(indexPath.Row) as string).Substring(0, max);
                cell.BodyLabel.Text = (_tasks.ElementAt(indexPath.Row) as string);
                //indexPath.Section 
                //indexPath.Row

                return cell;

                //TaskListViewHolder h = (TaskListViewHolder)holder;
                //Poco.TodoItem item = _tasks[position];
                //h.TitleLabel.Text = item.Title;
                //h.DescriptionLabel.Text = item.Description;

                //LayoutInflater inflater = LayoutInflater.From(parent.Context);
                //View view = inflater.Inflate(Resource.Layout.CellTask, parent, false);
                //RecyclerView.ViewHolder holder = new TaskListViewHolder(view, OnClick);
                //return holder;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                //va ritornato il totale di elementi per la sezione passata come parametro
                return _tasks.Count;
            }
        }

        #endregion

        #region Constants and Fields

        private UITableViewSource _source;

        #endregion

        #region Constructors

        public TaskListViewController()
            : base("TaskListViewController", null)
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

            _source = new TaskListViewSource(this, new List<string>() { "one", "two", "Lorem Ipsum è un testo segnaposto utilizzato nel settore della tipografia e della stampa. Lorem Ipsum è considerato il testo segnaposto standard sin dal sedicesimo secolo, quando un anonimo tipografo prese una cassetta di caratteri e li assemblò per preparare un testo campione", "four", "five" });
            this.TaskList.Source = _source;
            this.TaskList.EstimatedRowHeight = UITableView.AutomaticDimension;
            //va impostata l'altezza della cella come compare nello xib
            this.TaskList.RowHeight = 90;
            //trick per nascondere le righe vuote se non sono sufficienti ad "riempire" tutta lo schermo
            this.TaskList.TableFooterView = new UIView();

            this.NavigationController.SetNavigationBarHidden(false, false);
            this.NavigationItem.Title = "Sticazzi";
            this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("New", UIBarButtonItemStyle.Plain
                , (sender, args) => { this.NavigationController.PushViewController(new RegistrationViewController(), false); }), false);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
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


