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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 266);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(672, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(609, 305);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstToDo
            // 
            lstToDo.FormattingEnabled = true;
            lstToDo.ItemHeight = 15;
            lstToDo.Location = new Point(12, 12);
            lstToDo.Name = "lstToDo";
            lstToDo.Size = new Size(220, 244);
            lstToDo.TabIndex = 3;
            // 
            // lstInProgress
            // 
            lstInProgress.FormattingEnabled = true;
            lstInProgress.ItemHeight = 15;
            lstInProgress.Location = new Point(238, 12);
            lstInProgress.Name = "lstInProgress";
            lstInProgress.Size = new Size(220, 244);
            lstInProgress.TabIndex = 4;
            lstInProgress.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // lstDone
            // 
            lstDone.FormattingEnabled = true;
            lstDone.ItemHeight = 15;
            lstDone.Location = new Point(464, 12);
            lstDone.Name = "lstDone";
            lstDone.Size = new Size(220, 244);
            lstDone.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
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
    }
}
