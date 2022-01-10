namespace Recover_Password
{
    partial class FrmRecoverPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnSendReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEnterEmail
            // 
            this.txtEnterEmail.Location = new System.Drawing.Point(34, 75);
            this.txtEnterEmail.Name = "txtEnterEmail";
            this.txtEnterEmail.Size = new System.Drawing.Size(402, 23);
            this.txtEnterEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Did you forget your password?";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(34, 101);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(231, 15);
            this.lbInfo.TabIndex = 3;
            this.lbInfo.Text = "We have sent you your password by email.";
            // 
            // btnSendReset
            // 
            this.btnSendReset.Location = new System.Drawing.Point(170, 137);
            this.btnSendReset.Name = "btnSendReset";
            this.btnSendReset.Size = new System.Drawing.Size(128, 23);
            this.btnSendReset.TabIndex = 4;
            this.btnSendReset.Text = "Send password reset";
            this.btnSendReset.UseVisualStyleBackColor = true;
            this.btnSendReset.Click += new System.EventHandler(this.btnSendReset_Click);
            // 
            // FrmRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 189);
            this.Controls.Add(this.btnSendReset);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnterEmail);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecoverPassword";
            this.Text = "Recover Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtEnterEmail;
        private Label label2;
        private Label lbInfo;
        private Button btnSendReset;
    }
}