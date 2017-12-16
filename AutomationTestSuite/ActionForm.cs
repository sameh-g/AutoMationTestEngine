using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationTestSuite
{
    public partial class ActionForm : Form
    {
        MyList<string> _actions;
        public ActionForm(MyList<string> actions)
        {
            _actions = actions;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _actions.Add(comboBox1.SelectedItem.ToString());
            this.Close();
        }

        private void ActionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
