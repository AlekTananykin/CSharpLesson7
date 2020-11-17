namespace Task2
{
    partial class Task2MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheckNumber = new System.Windows.Forms.Button();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckNumber
            // 
            this.btnCheckNumber.Location = new System.Drawing.Point(42, 159);
            this.btnCheckNumber.Name = "btnCheckNumber";
            this.btnCheckNumber.Size = new System.Drawing.Size(211, 50);
            this.btnCheckNumber.TabIndex = 1;
            this.btnCheckNumber.Text = "Введите число";
            this.btnCheckNumber.UseVisualStyleBackColor = true;
            this.btnCheckNumber.Click += new System.EventHandler(this.btnCheckNumber_Click);
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.Location = new System.Drawing.Point(42, 260);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(211, 79);
            this.lblResultMessage.TabIndex = 5;
            this.lblResultMessage.Text = "lblResultMessage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите число от 1 до 100";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(42, 270);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 20);
            this.answer.TabIndex = 4;
            //
            _inputForm = new NumberInput();
            // 
            // Task2MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 404);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultMessage);
            this.Controls.Add(this.btnCheckNumber);
            
            this.Name = "Task2MainWindow";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

            _inputForm.InputNumberEvent += 
                new NumberInput.InputNumberHandler(ReadInt);
        }

        #endregion

        private System.Windows.Forms.Button btnCheckNumber;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label answer;
        private NumberInput _inputForm;
    }
}

