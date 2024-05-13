
namespace MessageWall
{
    partial class Dashboard
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.messageListBoxLabel = new System.Windows.Forms.Label();
            this.addMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(40, 49);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(135, 36);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(181, 46);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(554, 41);
            this.messageText.TabIndex = 1;
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 36;
            this.messageListBox.Location = new System.Drawing.Point(46, 157);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(689, 328);
            this.messageListBox.TabIndex = 3;
            this.messageListBox.TabStop = false;
            // 
            // messageListBoxLabel
            // 
            this.messageListBoxLabel.AutoSize = true;
            this.messageListBoxLabel.Location = new System.Drawing.Point(40, 118);
            this.messageListBoxLabel.Name = "messageListBoxLabel";
            this.messageListBoxLabel.Size = new System.Drawing.Size(150, 36);
            this.messageListBoxLabel.TabIndex = 0;
            this.messageListBoxLabel.Text = "Messages";
            // 
            // addMessage
            // 
            this.addMessage.Location = new System.Drawing.Point(741, 46);
            this.addMessage.Name = "addMessage";
            this.addMessage.Size = new System.Drawing.Size(112, 41);
            this.addMessage.TabIndex = 2;
            this.addMessage.Text = "Add";
            this.addMessage.UseVisualStyleBackColor = true;
            this.addMessage.Click += new System.EventHandler(this.AddMessage_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 525);
            this.Controls.Add(this.addMessage);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageListBoxLabel);
            this.Controls.Add(this.messageLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Label messageListBoxLabel;
        private System.Windows.Forms.Button addMessage;
    }
}

