using System.Windows.Forms;

namespace Helper
{
    public partial class NewActionForm : Form, INewActionView
    {
        private readonly ApplicationContext _context;
        public NewActionForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }
    }
}
