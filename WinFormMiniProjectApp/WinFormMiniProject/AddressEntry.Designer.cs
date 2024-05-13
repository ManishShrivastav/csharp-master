
namespace WinFormMiniProject
{
    partial class AddressEntry
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
            this.cityText = new System.Windows.Forms.TextBox();
            this.streetAddressText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.stateText = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(264, 153);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(432, 41);
            this.cityText.TabIndex = 6;
            // 
            // streetAddressText
            // 
            this.streetAddressText.Location = new System.Drawing.Point(264, 94);
            this.streetAddressText.Name = "streetAddressText";
            this.streetAddressText.Size = new System.Drawing.Size(432, 41);
            this.streetAddressText.TabIndex = 5;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(192, 156);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(66, 36);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City";
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(46, 97);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(212, 36);
            this.streetAddressLabel.TabIndex = 4;
            this.streetAddressLabel.Text = "Street Address";
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(264, 275);
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(432, 41);
            this.zipCodeText.TabIndex = 10;
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(264, 214);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(432, 41);
            this.stateText.TabIndex = 9;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(122, 278);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(136, 36);
            this.zipCodeLabel.TabIndex = 7;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(175, 217);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(83, 36);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Address Entry";
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(264, 335);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(105, 48);
            this.saveRecord.TabIndex = 12;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.SaveRecord_Click);
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 491);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.streetAddressText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetAddressLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "AddressEntry";
            this.Text = "Address Entry Form by Manish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox streetAddressText;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveRecord;
    }
}