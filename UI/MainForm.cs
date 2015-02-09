using System;
using System.Windows.Forms;

namespace Helper
{
    public partial class MainForm : Form, IMainView
    {
        private readonly ApplicationContext _context;
        public MainForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            btnAddAction.Click += (sender, args) => ActionAdded();
        }

        public void Open()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public void AddAction(IHelperAction action)
        {
            Actions.Items.Add(action);
        }

        public event Action ActionAdded;

        public void Perform()
        {
            throw new NotImplementedException();
        }
    }
}
