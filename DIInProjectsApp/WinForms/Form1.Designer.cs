namespace WinForms
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
            helloText = new Label();
            goodbyeText = new Label();
            SuspendLayout();
            // 
            // helloText
            // 
            helloText.AutoSize = true;
            helloText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            helloText.Location = new Point(27, 105);
            helloText.Name = "helloText";
            helloText.Size = new Size(109, 46);
            helloText.TabIndex = 0;
            helloText.Text = "label1";
            // 
            // goodbyeText
            // 
            goodbyeText.AutoSize = true;
            goodbyeText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            goodbyeText.Location = new Point(27, 173);
            goodbyeText.Name = "goodbyeText";
            goodbyeText.Size = new Size(109, 46);
            goodbyeText.TabIndex = 0;
            goodbyeText.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 450);
            Controls.Add(goodbyeText);
            Controls.Add(helloText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label helloText;
        private Label goodbyeText;
    }
}
