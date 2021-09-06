using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moop_LR11
{
    public partial class Form1 : Form
    {
        Component component;
        OpenFileDialog open;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            if (NameCheckBox.Checked) list.Add(1);
            if (AddressCheckBox.Checked) list.Add(2);
            if (SumCheckBox.Checked) list.Add(3);
            if (advertisingCheckBox.Checked) list.Add(4);

            component = new Additions();

            richTextBox1.Text = component.ReturnText(list);
        }
    }
}
