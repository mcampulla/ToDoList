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
    using Android.Support.V7.Widget;
    using Android.Util;
    using Android.Views;
    using Android.Widget;

    public class TaskListFragment : Android.Support.V4.App.Fragment
    {
        #region Inner Classes

        private class TaskListViewHolder : RecyclerView.ViewHolder
        {
            public TextView TitleLabel;
            public TextView DescriptionLabel;

            public TaskListViewHolder(View view) : base(view)
            {
                this.TitleLabel = view.FindViewById<TextView>(Resource.Id.TitleLabel);
                this.DescriptionLabel = view.FindViewById<TextView>(Resource.Id.DescriptionLabel);
            }
        }

        private class TaskListAdapter : RecyclerView.Adapter
        {
            private List<Poco.TodoItem> _tasks = null;

            public TaskListAdapter(IEnumerable<Poco.TodoItem> items)
            {
                _tasks = new List<Poco.TodoItem>(items);
            }

            public override int ItemCount
            {
                get
                {
                    return _tasks.Count;
                }
            }

            public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
            {
                TaskListViewHolder h = (TaskListViewHolder)holder;
                Poco.TodoItem item = _tasks[position];
                h.TitleLabel.Text = item.Title;
                h.DescriptionLabel.Text = item.Description;
            }

            public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
            {
                LayoutInflater inflater = LayoutInflater.From(parent.Context);
                View view = inflater.Inflate(Resource.Layout.CellTask, parent, false);
                RecyclerView.ViewHolder holder = new TaskListViewHolder(view);
                return holder;
            }
        }

        #endregion

        #region Constants and Fields

        private TaskListAdapter _adapter;

        #endregion

        #region Widgets

        private RecyclerView _taskList;

        #endregion

        #region Constructors

        public TaskListFragment()
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

            View view = inflater.Inflate(Resource.Layout.FragmentTaskList, container, false);

            #endregion           

            _taskList = view.FindViewById<RecyclerView>(Resource.Id.TaskList);
            _adapter = new TaskListAdapter(new [] {
                new Poco.TodoItem() { Title = "Title1", Description = "Description 1" },
                new Poco.TodoItem() { Title = "Title2", Description = "Description 2" },
                new Poco.TodoItem() { Title = "Title3", Description = "Description 3" },
                new Poco.TodoItem() { Title = "Title4", Description = "Description 4" },
                new Poco.TodoItem() { Title = "Title5", Description = "Description 5" },
                new Poco.TodoItem() { Title = "Title6", Description = "Description 6" },
                new Poco.TodoItem() { Title = "Title7", Description = "Description 7" },
                new Poco.TodoItem() { Title = "Title8", Description = "Description 8" },
                new Poco.TodoItem() { Title = "Title9", Description = "Description 9" },
                new Poco.TodoItem() { Title = "Title10", Description = "Description 10" },
                new Poco.TodoItem() { Title = "Title11", Description = "Description 11" },
                new Poco.TodoItem() { Title = "Title12", Description = "Description 12" },
                new Poco.TodoItem() { Title = "Title13", Description = "Description 13" }});
            _taskList.SetLayoutManager(new LinearLayoutManager(this.Context));
            _taskList.SetAdapter(_adapter);

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