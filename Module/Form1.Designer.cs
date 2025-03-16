namespace Module
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
            textBox1 = new TextBox();
            button1 = new Button();
            lstToDo = new ListBox();
            lstInProgress = new ListBox();
            lstDone = new ListBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(639, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 325);
            button1.Name = "button1";
            button1.Size = new Size(209, 54);
            button1.TabIndex = 2;
            button1.Text = "Додати задачу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstToDo
            // 
            lstToDo.FormattingEnabled = true;
            lstToDo.ItemHeight = 15;
            lstToDo.Location = new Point(12, 28);
            lstToDo.Name = "lstToDo";
            lstToDo.Size = new Size(209, 259);
            lstToDo.TabIndex = 3;
            // 
            // lstInProgress
            // 
            lstInProgress.FormattingEnabled = true;
            lstInProgress.ItemHeight = 15;
            lstInProgress.Location = new Point(227, 28);
            lstInProgress.Name = "lstInProgress";
            lstInProgress.Size = new Size(209, 259);
            lstInProgress.TabIndex = 4;
            // 
            // lstDone
            // 
            lstDone.FormattingEnabled = true;
            lstDone.ItemHeight = 15;
            lstDone.Location = new Point(442, 28);
            lstDone.Name = "lstDone";
            lstDone.Size = new Size(209, 259);
            lstDone.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(227, 325);
            button2.Name = "button2";
            button2.Size = new Size(209, 54);
            button2.TabIndex = 6;
            button2.Text = "Перенести задачу до \"В процесі\"";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(442, 325);
            button3.Name = "button3";
            button3.Size = new Size(209, 54);
            button3.TabIndex = 7;
            button3.Text = "Перенести задачу до виконаних";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 8;
            label1.Text = "Задачи";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 10);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "В процесі";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 10);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Виконані";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 387);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lstDone);
            Controls.Add(lstInProgress);
            Controls.Add(lstToDo);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private ListBox lstToDo;
        private ListBox lstInProgress;
        private ListBox lstDone;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
