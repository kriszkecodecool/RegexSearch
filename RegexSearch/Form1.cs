using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtMatched.Text = "";
            string pattern = txtPattern.Text;
            string input = txtText.Text;

            foreach (Match m in Regex.Matches(input, pattern))
            {
                txtMatched.AppendText(m + "\n");
            }
        }
    }
}
