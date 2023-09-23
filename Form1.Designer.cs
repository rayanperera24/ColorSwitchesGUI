namespace login_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(53, 304);
            button1.Name = "button1";
            button1.Size = new Size(158, 89);
            button1.TabIndex = 0;
            button1.Text = "RED";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(274, 304);
            button2.Name = "button2";
            button2.Size = new Size(158, 89);
            button2.TabIndex = 1;
            button2.Text = "BLUE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Location = new Point(491, 304);
            button3.Name = "button3";
            button3.Size = new Size(158, 89);
            button3.TabIndex = 2;
            button3.Text = "YELLOW";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(53, 39);
            txt1.Multiline = true;
            txt1.Name = "txt1";
            txt1.Size = new Size(158, 229);
            txt1.TabIndex = 3;
            // 
            // txt2
            // 
            txt2.Location = new Point(274, 39);
            txt2.Multiline = true;
            txt2.Name = "txt2";
            txt2.Size = new Size(158, 229);
            txt2.TabIndex = 4;
            // 
            // txt3
            // 
            txt3.Location = new Point(491, 39);
            txt3.Multiline = true;
            txt3.Name = "txt3";
            txt3.Size = new Size(158, 229);
            txt3.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(53, 399);
            button4.Name = "button4";
            button4.Size = new Size(596, 50);
            button4.TabIndex = 6;
            button4.Text = "CLEAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 461);
            Controls.Add(button4);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private Button button4;
    }
}