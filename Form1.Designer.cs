namespace who_to_pet
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
            generateButton = new Button();
            whoToPet = new Label();
            SuspendLayout();
            // 
            // generateButton
            // 
            generateButton.BackColor = Color.Blue;
            generateButton.ForeColor = Color.FromArgb(128, 255, 255);
            generateButton.Location = new Point(240, 68);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(316, 86);
            generateButton.TabIndex = 0;
            generateButton.Text = "Who should I pet?";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click;
            // 
            // whoToPet
            // 
            whoToPet.AutoSize = true;
            whoToPet.Location = new Point(37, 301);
            whoToPet.Name = "whoToPet";
            whoToPet.Size = new Size(0, 29);
            whoToPet.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(whoToPet);
            Controls.Add(generateButton);
            Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Cyan;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Who Should I Pet?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateButton;
        private Label whoToPet;
    }
}
