namespace FormsApp
{
    partial class Anket
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(349, 291);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(98, 29);
            button1.TabIndex = 0;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += save;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "type1 ", "type2", "type3", "type4" });
            comboBox1.Location = new Point(334, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(349, 233);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "0.0";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(98, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += check_easy;
            textBox1.Leave += check_hard;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(334, 204);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "name";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(266, 207);
            label1.Name = "label1";
            label1.Size = new Size(68, 18);
            label1.TabIndex = 4;
            label1.Text = "username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10F);
            label2.Location = new Point(266, 234);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 5;
            label2.Text = "value:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10F);
            label3.Location = new Point(266, 263);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 6;
            label3.Text = "type:";
            // 
            // Anket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Anket";
            Text = "anket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
