namespace PasswordGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.upperCase = new System.Windows.Forms.CheckBox();
            this.lowerCase = new System.Windows.Forms.CheckBox();
            this.numbers = new System.Windows.Forms.CheckBox();
            this.specialCharacters = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passLength = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.copy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // upperCase
            // 
            this.upperCase.AutoSize = true;
            this.upperCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upperCase.Location = new System.Drawing.Point(14, 92);
            this.upperCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upperCase.Name = "upperCase";
            this.upperCase.Size = new System.Drawing.Size(155, 24);
            this.upperCase.TabIndex = 0;
            this.upperCase.Text = "Include uppercase ";
            this.upperCase.UseVisualStyleBackColor = true;
            this.upperCase.CheckedChanged += new System.EventHandler(this.upperCase_CheckedChanged);
            // 
            // lowerCase
            // 
            this.lowerCase.AutoSize = true;
            this.lowerCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lowerCase.Location = new System.Drawing.Point(227, 92);
            this.lowerCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lowerCase.Name = "lowerCase";
            this.lowerCase.Size = new System.Drawing.Size(149, 24);
            this.lowerCase.TabIndex = 1;
            this.lowerCase.Text = "Include lowercase";
            this.lowerCase.UseVisualStyleBackColor = true;
            this.lowerCase.CheckedChanged += new System.EventHandler(this.lowerCase_CheckedChanged);
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numbers.Location = new System.Drawing.Point(227, 125);
            this.numbers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(140, 24);
            this.numbers.TabIndex = 2;
            this.numbers.Text = "Include numbers";
            this.numbers.UseVisualStyleBackColor = true;
            this.numbers.CheckedChanged += new System.EventHandler(this.numbers_CheckedChanged);
            // 
            // specialCharacters
            // 
            this.specialCharacters.AutoSize = true;
            this.specialCharacters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialCharacters.Location = new System.Drawing.Point(14, 125);
            this.specialCharacters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.specialCharacters.Name = "specialCharacters";
            this.specialCharacters.Size = new System.Drawing.Size(200, 24);
            this.specialCharacters.TabIndex = 3;
            this.specialCharacters.Text = "Include special characters";
            this.specialCharacters.UseVisualStyleBackColor = true;
            this.specialCharacters.CheckedChanged += new System.EventHandler(this.specialCharacters_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password length";
            // 
            // passLength
            // 
            this.passLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passLength.Location = new System.Drawing.Point(131, 33);
            this.passLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passLength.MaxLength = 4;
            this.passLength.Name = "passLength";
            this.passLength.Size = new System.Drawing.Size(41, 27);
            this.passLength.TabIndex = 6;
            this.passLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passLength.TextChanged += new System.EventHandler(this.passLength_TextChanged);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.Gray;
            this.generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generate.Location = new System.Drawing.Point(14, 185);
            this.generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(86, 31);
            this.generate.TabIndex = 7;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 187);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.Gray;
            this.copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copy.Location = new System.Drawing.Point(378, 185);
            this.copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(51, 31);
            this.copy.TabIndex = 9;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(305, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password copied!";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(442, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.passLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specialCharacters);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.lowerCase);
            this.Controls.Add(this.upperCase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox upperCase;
        private CheckBox lowerCase;
        private CheckBox numbers;
        private CheckBox specialCharacters;
        private Label label1;
        private TextBox passLength;
        private Button generate;
        private TextBox textBox1;
        private Button copy;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}