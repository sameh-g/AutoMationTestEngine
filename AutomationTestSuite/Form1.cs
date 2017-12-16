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
    public partial class Form1 : Form
    {
        MyList<string> cases;// = new MyList<string>();
        
        public Form1()
        {
            cases = new MyList<string>();
            cases.OnAdd += Cases_OnAdd;
            InitializeComponent();
        }

        private void Cases_OnAdd(object sender, EventArgs e)
        {
            listBox1.Items.Add(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TestCase(cases).ShowDialog();
        }
    }

    public class MyList<T> : List<T>
    {

        public event EventHandler OnAdd;

        public void Add(T item)
        {
            if (null != OnAdd)
            {
                OnAdd(item, null);
            }
            base.Add(item);
        }

    }
}
