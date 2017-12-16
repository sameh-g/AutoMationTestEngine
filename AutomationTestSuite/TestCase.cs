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
    public partial class TestCase : Form
    {
        MyList<string> _cases;
        MyList<string> _actions = new MyList<string>();

        public TestCase(MyList<string> cases)
        {
            _cases = cases;
            _actions.OnAdd += _actions_OnAdd;
            InitializeComponent();
        }

        private void _actions_OnAdd(object sender, EventArgs e)
        {
            listBox1.Items.Add(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ActionForm(_actions).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cases.Add(textBox1.Text);
            this.Close();
        }
    }
}
