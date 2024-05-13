
namespace WinFormMiniProject
{
    partial class PersonEntry
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.addressesList = new System.Windows.Forms.ListBox();
            this.addressesListLabel = new System.Windows.Forms.Label();
            this.addNewAddress = new System.Windows.Forms.Button();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(34, 42);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(158, 36);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(221, 42);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(432, 41);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(34, 115);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(156, 36);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(221, 115);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(432, 41);
            this.lastNameText.TabIndex = 2;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(221, 194);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(18, 17);
            this.isActive.TabIndex = 3;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(34, 183);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(97, 36);
            this.isActiveLabel.TabIndex = 0;
            this.isActiveLabel.Text = "Active";
            // 
            // addressesList
            // 
            this.addressesList.FormattingEnabled = true;
            this.addressesList.ItemHeight = 36;
            this.addressesList.Location = new System.Drawing.Point(40, 280);
            this.addressesList.Name = "addressesList";
            this.addressesList.Size = new System.Drawing.Size(613, 508);
            this.addressesList.TabIndex = 3;
            // 
            // addressesListLabel
            // 
            this.addressesListLabel.AutoSize = true;
            this.addressesListLabel.Location = new System.Drawing.Point(34, 241);
            this.addressesListLabel.Name = "addressesListLabel";
            this.addressesListLabel.Size = new System.Drawing.Size(157, 36);
            this.addressesListLabel.TabIndex = 0;
            this.addressesListLabel.Text = "Addresses";
            // 
            // addNewAddress
            // 
            this.addNewAddress.Location = new System.Drawing.Point(547, 228);
            this.addNewAddress.Name = "addNewAddress";
            this.addNewAddress.Size = new System.Drawing.Size(105, 48);
            this.addNewAddress.TabIndex = 4;
            this.addNewAddress.Text = "Add";
            this.addNewAddress.UseVisualStyleBackColor = true;
            this.addNewAddress.Click += new System.EventHandler(this.AddNewAddress_Click);
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(547, 794);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(105, 48);
            this.saveRecord.TabIndex = 5;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.SaveRecord_Click);
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 895);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.addNewAddress);
            this.Controls.Add(this.addressesList);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.addressesListLabel);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PersonEntry";
            this.Text = "Person Entry From by Manish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.ListBox addressesList;
        private System.Windows.Forms.Label addressesListLabel;
        private System.Windows.Forms.Button addNewAddress;
        private System.Windows.Forms.Button saveRecord;
    }
}

