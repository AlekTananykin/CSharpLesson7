using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Тананыкин
 * 
 * а) Добавить в программу «Удвоитель» подсчёт количества отданных команд 
 * удвоителю.
 * б) Добавить меню и команду «Играть». При нажатии появляется сообщение, 
 * какое число должен получить игрок. Игрок должен получить это число за 
 * минимальное количество ходов.
 * в) *Добавить кнопку «Отменить», которая отменяет последние ходы. 
 * Используйте обобщенный класс Stack.
 * Вся логика игры должна быть реализована в классе с удвоителем.
 */

namespace Task1
{
    public partial class MainWindow : Form
    {
        private int _targetNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.btnIncreament.Enabled = false;
            this.btnMultiply.Enabled = false;
            this.btnReset.Enabled = false;
            this.btnUndo.Enabled = false;
        }

        private void btnIncreament_Click(object sender, EventArgs e)
        {
            PushState();
            lblNumbers.Text = (long.Parse(lblNumbers.Text) + 1).ToString();
            IncrementCommandsCount();
            
            CheckVictory();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PushState();
            lblNumbers.Text = (long.Parse(lblNumbers.Text) * 2).ToString();
            IncrementCommandsCount();
            
            CheckVictory();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PushState();
            lblNumbers.Text = "0";
            IncrementCommandsCount();
        }

        private void IncrementCommandsCount()
        {
            lblCommandsCount.Text = 
                (long.Parse(lblCommandsCount.Text) + 1).ToString();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            PrepareGame();
        }

        private void PrepareGame()
        {
            lblNumbers.Text = "0";
            lblCommandsCount.Text = "0";
            Random rnd = new Random();
            _targetNumber = Math.Abs(rnd.Next(10, 100));

            _statesStack.Clear();
            string messageString = String.Format(
                "Вам нужно получить число {0}", _targetNumber);
            MessageBox.Show(messageString, "Начинаем!", MessageBoxButtons.OK);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            PopState();
            IncrementCommandsCount();
        }

        Stack<string> _statesStack = new Stack<string>();

        private void PushState()
        {
            _statesStack.Push(lblNumbers.Text);
        }

        private void PopState()
        {
            if (0 == _statesStack.Count)
                return;

            lblNumbers.Text = _statesStack.Pop();
        }

        private void CheckVictory()
        {
            if (_targetNumber != int.Parse(lblNumbers.Text))
                return;

            string messageString = string.Format(
                "Победа за {0} ходов! Начинаем новую игру.", 
                lblCommandsCount.Text);

            MessageBox.Show(messageString, "Победа!", MessageBoxButtons.OK);

            PrepareGame();
        }

        private void menuGamePlay_Click(object sender, EventArgs e)
        {
            PrepareGame();

            this.btnIncreament.Enabled = true;
            this.btnMultiply.Enabled = true;
            this.btnReset.Enabled = true;
            this.btnUndo.Enabled = true;
        }
    }
}
