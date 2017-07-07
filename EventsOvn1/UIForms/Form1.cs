using EventsOvn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIForms
{
    public partial class Form1 : Form
    {
            NumberGenerator numberGenerator = new NumberGenerator();

        public Form1()
        {
            InitializeComponent();
            numberGenerator.Even += NumberGenerator_Even;
        }

        private void NumberGenerator_Even(int i, bool isEven)
        {
            listBox1.Items.Add($"{i} is even.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberGenerator.Start();
        }
    }
}
