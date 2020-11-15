using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIncreament_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = (int.Parse(lblNumbers.Text) + 1).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = (int.Parse(lblNumbers.Text) * 2).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = "0";
        }
    }
}
