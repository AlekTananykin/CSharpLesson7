namespace Task1
{
    partial class MainWindow
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
            this.btnIncreament = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblCommandsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCommandsCountText = new System.Windows.Forms.Label();
            this.lblTargetNumber = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGamePlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIncreament
            // 
            this.btnIncreament.Location = new System.Drawing.Point(396, 85);
            this.btnIncreament.Name = "btnIncreament";
            this.btnIncreament.Size = new System.Drawing.Size(130, 50);
            this.btnIncreament.TabIndex = 0;
            this.btnIncreament.Text = "+1";
            this.btnIncreament.UseVisualStyleBackColor = true;
            this.btnIncreament.Click += new System.EventHandler(this.btnIncreament_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(396, 144);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(130, 50);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "x2";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(396, 256);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 50);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(284, 100);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(18, 20);
            this.lblNumbers.TabIndex = 3;
            this.lblNumbers.Text = "0";
            // 
            // lblCommandsCount
            // 
            this.lblCommandsCount.AutoSize = true;
            this.lblCommandsCount.Location = new System.Drawing.Point(284, 174);
            this.lblCommandsCount.Name = "lblCommandsCount";
            this.lblCommandsCount.Size = new System.Drawing.Size(18, 20);
            this.lblCommandsCount.TabIndex = 4;
            this.lblCommandsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество команд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Число";
            // 
            // lblCommandsCountText
            // 
            this.lblCommandsCountText.AutoSize = true;
            this.lblCommandsCountText.Location = new System.Drawing.Point(12, 133);
            this.lblCommandsCountText.Name = "lblCommandsCountText";
            this.lblCommandsCountText.Size = new System.Drawing.Size(244, 20);
            this.lblCommandsCountText.TabIndex = 8;
            this.lblCommandsCountText.Text = "Число, которое надо получить";
            this.lblCommandsCountText.Visible = false;
            // 
            // lblTargetNumber
            // 
            this.lblTargetNumber.AutoSize = true;
            this.lblTargetNumber.Location = new System.Drawing.Point(284, 133);
            this.lblTargetNumber.Name = "lblTargetNumber";
            this.lblTargetNumber.Size = new System.Drawing.Size(18, 20);
            this.lblTargetNumber.TabIndex = 9;
            this.lblTargetNumber.Text = "0";
            this.lblTargetNumber.Visible = false;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(396, 200);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(130, 50);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.Text = "Отменить";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGamePlay });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 33);
            this.menuStrip1.TabIndex = 12;
            // 
            // menuGamePlay
            // 
            this.menuGamePlay.Name = "menuGamePlay";
            this.menuGamePlay.Size = new System.Drawing.Size(84, 29);
            this.menuGamePlay.Text = "Играть";
            this.menuGamePlay.Click += new System.EventHandler(this.menuGamePlay_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 464);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblTargetNumber);
            this.Controls.Add(this.lblCommandsCountText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCommandsCount);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnIncreament);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncreament;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblCommandsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCommandsCountText;
        private System.Windows.Forms.Label lblTargetNumber;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGamePlay;
    }
}

