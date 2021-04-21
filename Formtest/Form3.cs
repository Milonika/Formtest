using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formtest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string text)
        {
            InitializeComponent();
            label.Text = "Welcome " + text + "!";
        }

        private void label_Click(object sender, EventArgs e)
        {
        }
    }
}
