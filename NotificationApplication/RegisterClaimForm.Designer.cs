namespace NotificationApplication
{
    partial class RegisterClaimForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.policyNumberControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.claimTypeControl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.incidentDateControl = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.responseControl = new System.Windows.Forms.TextBox();
            this.registerClaimErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.registerClaimErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Policy Number";
            // 
            // policyNumberControl
            // 
            this.policyNumberControl.Location = new System.Drawing.Point(107, 34);
            this.policyNumberControl.Name = "policyNumberControl";
            this.policyNumberControl.Size = new System.Drawing.Size(100, 20);
            this.policyNumberControl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Claim Type";
            // 
            // claimTypeControl
            // 
            this.claimTypeControl.FormattingEnabled = true;
            this.claimTypeControl.Location = new System.Drawing.Point(107, 83);
            this.claimTypeControl.Name = "claimTypeControl";
            this.claimTypeControl.Size = new System.Drawing.Size(121, 21);
            this.claimTypeControl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incident Date:";
            // 
            // incidentDateControl
            // 
            this.incidentDateControl.Location = new System.Drawing.Point(107, 131);
            this.incidentDateControl.Name = "incidentDateControl";
            this.incidentDateControl.Size = new System.Drawing.Size(200, 20);
            this.incidentDateControl.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(62, 177);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // responseControl
            // 
            this.responseControl.Location = new System.Drawing.Point(62, 206);
            this.responseControl.Multiline = true;
            this.responseControl.Name = "responseControl";
            this.responseControl.ReadOnly = true;
            this.responseControl.Size = new System.Drawing.Size(245, 60);
            this.responseControl.TabIndex = 7;
            this.responseControl.Text = "not submitted";
            // 
            // registerClaimErrorProvider
            // 
            this.registerClaimErrorProvider.ContainerControl = this;
            // 
            // RegisterClaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 278);
            this.Controls.Add(this.responseControl);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.incidentDateControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.claimTypeControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.policyNumberControl);
            this.Controls.Add(this.label1);
            this.Name = "RegisterClaimForm";
            this.Text = "Register a claim";
            ((System.ComponentModel.ISupportInitialize)(this.registerClaimErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox policyNumberControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox claimTypeControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker incidentDateControl;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox responseControl;
        private System.Windows.Forms.ErrorProvider registerClaimErrorProvider;
    }
}

