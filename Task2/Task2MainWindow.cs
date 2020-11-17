﻿using System;
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

            //textInput.Text = _number.ToString();
        }

        private void btnCheckNumber_Click(object sender, EventArgs e)
        {
            int actualNumber;
            if (!int.TryParse(textInput.Text, out actualNumber))
            {
                MessageBox.Show("Введённая строка неудовлетвоярет " +
                    "требовниям игры. Введите число от 1 до 100.",
                   "Внимание!", MessageBoxButtons.OK);

                return;
            }

            string tryCountString =
                string.Format("Осталось {0} попыток. ", --_tryCount);

            if (actualNumber == _number)
            {
                MessageBox.Show("Вы угадали! Начинаем новое число! ", "Победа!",
                        MessageBoxButtons.OK);

                PreapreGame();
                return;
            }

            if (0 == _tryCount)
            {
                lblResultMessage.Text = tryCountString;
                MessageBox.Show("Вы проиграли. Начинаем новую игру.",
                    "Проигрыш!",
                    MessageBoxButtons.OK);

                PreapreGame();
                return;
            }

            if (actualNumber < _number)
                lblResultMessage.Text = "Ваше число меньше загаданного." + 
                    tryCountString;
            else if (actualNumber > _number)
                lblResultMessage.Text = "Ваше число больше загаданного." + 
                    tryCountString;
        }

    }
}
