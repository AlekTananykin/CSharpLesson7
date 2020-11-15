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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIncreament_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = (long.Parse(lblNumbers.Text) + 1).ToString();
            IncrementCommandsCount();
            PushState();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            
            lblNumbers.Text = (long.Parse(lblNumbers.Text) * 2).ToString();
            IncrementCommandsCount();
            PushState();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = "0";
            IncrementCommandsCount();
            PushState();
        }

        private void IncrementCommandsCount()
        {
            lblCommandsCount.Text = 
                (long.Parse(lblCommandsCount.Text) + 1).ToString();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = "0";
            lblCommandsCount.Text = "0";
            Random rnd = new Random();
            lblTargetNumber.Text = Math.Abs(rnd.Next()).ToString();

            lblTargetNumber.Visible = true;
            lblCommandsCountText.Visible = true;
        }

        private struct GameState
        {
            public string Number { get; set; }
            public string TargetNumber { get; set; }
            public string CommandsCount { get; set; }
        }

        Stack<GameState> _statesStack = new Stack<GameState>();

        private void PushState()
        {
            _statesStack.Push(new GameState()
            {
                Number = lblNumbers.Text,
                TargetNumber = (lblTargetNumber.Visible)? 
                    lblTargetNumber.Text: String.Empty,
                CommandsCount = lblCommandsCount.Text
            });
        }

        private void PopState()
        {
            if (2 > _statesStack.Count)
                return;

            _statesStack.Pop();
            GameState state = _statesStack.Peek();

            if (0 == state.TargetNumber.Length)
            {
                lblTargetNumber.Visible = false;
                lblCommandsCountText.Visible = false;
            }
            else
            {
                lblTargetNumber.Visible = true;
                lblCommandsCountText.Visible = true;
                lblCommandsCountText.Text = state.TargetNumber;
            }
            lblNumbers.Text = state.Number;
            lblCommandsCount.Text = state.CommandsCount;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            PopState();
        }
    }
}
