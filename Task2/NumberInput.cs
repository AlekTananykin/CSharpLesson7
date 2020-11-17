using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{

    public partial class NumberInput : Form
    {
        public delegate void InputNumberHandler(int number);

        public event InputNumberHandler InputNumberEvent;
        public NumberInput()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter != e.KeyCode)
                return;

            int inputValue = 0;
            if (!int.TryParse(textBox1.Text, out inputValue))
            {
                MessageBox.Show("По условиям игры требуется ввести " +
                   "число от 1 до 100.",
                  "Внимание!", MessageBoxButtons.OK);
                textBox1.Text = string.Empty;
                return;
            }

            InputNumberEvent(inputValue);
        }
    }
}
