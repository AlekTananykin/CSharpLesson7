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
            this.SuspendLayout();
            // 
            // btnIncreament
            // 
            this.btnIncreament.Location = new System.Drawing.Point(241, 47);
            this.btnIncreament.Name = "btnIncreament";
            this.btnIncreament.Size = new System.Drawing.Size(130, 50);
            this.btnIncreament.TabIndex = 0;
            this.btnIncreament.Text = "+1";
            this.btnIncreament.UseVisualStyleBackColor = true;
            this.btnIncreament.Click += new System.EventHandler(this.btnIncreament_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(241, 113);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(130, 50);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "x2";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(241, 191);
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
            this.lblNumbers.Location = new System.Drawing.Point(45, 47);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(18, 20);
            this.lblNumbers.TabIndex = 3;
            this.lblNumbers.Text = "0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 294);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnIncreament);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncreament;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumbers;
    }
}

