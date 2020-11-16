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
    public partial class Task2MainWindow : Form
    {
        private int _number = 0;
        private const int _minNumberValue = 1;
        private const int _maxNumberValue = 100;
        private const int _maxTryCount = 5;
        private int _tryCount;

        public Task2MainWindow()
        {
            InitializeComponent();

        }

        void PreapreGame()
        {
            Random rnd = new Random();
            _number = rnd.Next(_minNumberValue, _maxNumberValue);
            _tryCount = _maxTryCount;
        }

        private void btnCheckNumber_Click(object sender, EventArgs e)
        {
            int actualNumber;
            if (!int.TryParse(textInput.Text, out actualNumber))
            {
                lblResultMessage.Text = "Введённая строка неудовлетвоярет " +
                    "требовниям игры. Введите число.";
                return;
            }

            if (actualNumber < _number)
            {
                lblResultMessage.Text = "Ваше число меньше загаданного.";
            }
            else if (actualNumber > _number)
            {
                lblResultMessage.Text = "Ваше число больше загаданного.";
            }
            else 
            {
               
                MessageBox.Show("Вы угадали! Начинаем новую игру.", "Победа!", 
                    MessageBoxButtons.OK);

                PreapreGame();
            }

        }

    }
}
