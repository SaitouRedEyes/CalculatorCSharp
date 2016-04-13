namespace Calculadora
{
    //Class partial para o design do form.
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnFib = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(14, 54);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(25, 25);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(45, 54);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(25, 25);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(76, 54);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(25, 25);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(76, 85);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(25, 25);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(45, 85);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(25, 25);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(14, 85);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(25, 25);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(76, 116);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(25, 25);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(45, 116);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(25, 25);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(14, 116);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(25, 25);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(45, 147);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(25, 25);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(12, 20);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 10;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(107, 54);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 25);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.SimpleMathOpButtonClick);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(107, 85);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(25, 25);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.SimpleMathOpButtonClick);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(107, 116);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(25, 25);
            this.btnMult.TabIndex = 13;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.SimpleMathOpButtonClick);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(107, 147);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(25, 25);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.SimpleMathOpButtonClick);
            // 
            // btnFib
            // 
            this.btnFib.Location = new System.Drawing.Point(138, 54);
            this.btnFib.Name = "btnFib";
            this.btnFib.Size = new System.Drawing.Size(29, 25);
            this.btnFib.TabIndex = 15;
            this.btnFib.Text = "Fib";
            this.btnFib.UseVisualStyleBackColor = true;
            this.btnFib.Click += new System.EventHandler(this.FiboButtonClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(138, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(43, 25);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.IOButtonClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(138, 116);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(43, 25);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.IOButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 175);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFib);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnFib;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

