using System;
using System.Windows.Forms;
using CRUD.Logger;

namespace CRUD
{
    public partial class FormLog : Form
    {
        private static ILogger _logger;
        public FormLog()
        {
            InitializeComponent();
        }

        private void buttonCosLogger_Click(object sender, EventArgs e)
        {
            _logger = new ConsoleLogger();
            var form1 = new Form1(_logger);
            form1.Show();
            this.Hide();
        }

        private void buttonFileLogging_Click(object sender, EventArgs e)
        {
            _logger = new FileLogger();
            var form1 = new Form1(_logger);
            form1.Show();
            this.Hide();
        }
    }
}