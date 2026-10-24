namespace BTW_nummer
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
            label1 = new Label();
            JuistOfFoutLabel = new Label();
            button1 = new Button();
            BtwNummerTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 0;
            label1.Text = "Controle BTW nummer";
            // 
            // JuistOfFoutLabel
            // 
            JuistOfFoutLabel.AutoSize = true;
            JuistOfFoutLabel.Location = new Point(248, 45);
            JuistOfFoutLabel.Name = "JuistOfFoutLabel";
            JuistOfFoutLabel.Size = new Size(12, 15);
            JuistOfFoutLabel.TabIndex = 1;
            JuistOfFoutLabel.Text = "?";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 71);
            button1.Name = "button1";
            button1.Size = new Size(288, 32);
            button1.TabIndex = 2;
            button1.Text = "Controle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtwNummerTextBox
            // 
            BtwNummerTextBox.Location = new Point(12, 42);
            BtwNummerTextBox.Name = "BtwNummerTextBox";
            BtwNummerTextBox.Size = new Size(222, 23);
            BtwNummerTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 115);
            Controls.Add(BtwNummerTextBox);
            Controls.Add(button1);
            Controls.Add(JuistOfFoutLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label JuistOfFoutLabel;
        private Button button1;
        private TextBox BtwNummerTextBox;
    }
}
