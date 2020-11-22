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
        private int _tryCount = 0;

        public Task2MainWindow()
        {
            InitializeComponent();
            PreapreGame();
        }

        void PreapreGame()
        {
            Random rnd = new Random();
            _number = rnd.Next(_minNumberValue, _maxNumberValue);
            _tryCount = _maxTryCount;

            lblResultMessage.Text =
                string.Format("У вас {0} попыток. ", _tryCount);
        }

        private void btnCheckNumber_Click(object sender, EventArgs e)
        {
            _inputForm.ShowDialog();
        }

        void ReadInt(int inputValue)
        {
            _inputForm.Hide();

            string tryCountString =
                string.Format("Осталось {0} попыток. ", --_tryCount);

            if (inputValue == _number)
            {
                MessageBox.Show("Вы угадали! Начинаем новую игру! ", "Победа!",
                        MessageBoxButtons.OK);

                PreapreGame();
                return;
            }

            if (0 == _tryCount)
            {
                lblResultMessage.Text = tryCountString;
                string message = string.Format(
                    "Вы проиграли. Было загадано число {0}. " +
                    "Начинаем новую игру.", _number);
                MessageBox.Show(message,
                    "Проигрыш!",
                    MessageBoxButtons.OK);

                PreapreGame();
                return;
            }

            if (inputValue < _number)
                lblResultMessage.Text = "Ваше число меньше загаданного." +
                    tryCountString;
            else if (inputValue > _number)
                lblResultMessage.Text = "Ваше число больше загаданного." +
                    tryCountString;
        }
    }
}
