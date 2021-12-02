
namespace FormLogin1
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassLog = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.inputPasswordLog = new System.Windows.Forms.TextBox();
            this.inputUsernameLog = new System.Windows.Forms.TextBox();
            this.bntRegis1 = new System.Windows.Forms.Button();
            this.bntExit1 = new System.Windows.Forms.Button();
            this.btnLogin1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassLog);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.inputPasswordLog);
            this.panel1.Controls.Add(this.inputUsernameLog);
            this.panel1.Controls.Add(this.bntRegis1);
            this.panel1.Controls.Add(this.bntExit1);
            this.panel1.Controls.Add(this.btnLogin1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Create an account with us? Click";
            // 
            // txtPassLog
            // 
            this.txtPassLog.AutoSize = true;
            this.txtPassLog.Location = new System.Drawing.Point(125, 165);
            this.txtPassLog.Name = "txtPassLog";
            this.txtPassLog.Size = new System.Drawing.Size(53, 13);
            this.txtPassLog.TabIndex = 6;
            this.txtPassLog.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Location = new System.Drawing.Point(125, 98);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(55, 13);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "Username";
            // 
            // inputPasswordLog
            // 
            this.inputPasswordLog.Location = new System.Drawing.Point(312, 158);
            this.inputPasswordLog.Name = "inputPasswordLog";
            this.inputPasswordLog.Size = new System.Drawing.Size(145, 20);
            this.inputPasswordLog.TabIndex = 4;
            // 
            // inputUsernameLog
            // 
            this.inputUsernameLog.Location = new System.Drawing.Point(312, 98);
            this.inputUsernameLog.Name = "inputUsernameLog";
            this.inputUsernameLog.Size = new System.Drawing.Size(145, 20);
            this.inputUsernameLog.TabIndex = 3;
            // 
            // bntRegis1
            // 
            this.bntRegis1.Location = new System.Drawing.Point(363, 303);
            this.bntRegis1.Name = "bntRegis1";
            this.bntRegis1.Size = new System.Drawing.Size(75, 23);
            this.bntRegis1.TabIndex = 2;
            this.bntRegis1.Text = "Register";
            this.bntRegis1.UseVisualStyleBackColor = true;
            this.bntRegis1.Click += new System.EventHandler(this.bntRegis1_Click);
            // 
            // bntExit1
            // 
            this.bntExit1.Location = new System.Drawing.Point(363, 246);
            this.bntExit1.Name = "bntExit1";
            this.bntExit1.Size = new System.Drawing.Size(75, 23);
            this.bntExit1.TabIndex = 1;
            this.bntExit1.Text = "Exit";
            this.bntExit1.UseVisualStyleBackColor = true;
            this.bntExit1.Click += new System.EventHandler(this.bntExit1_Click);
            // 
            // btnLogin1
            // 
            this.btnLogin1.Location = new System.Drawing.Point(127, 246);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(75, 23);
            this.btnLogin1.TabIndex = 0;
            this.btnLogin1.Text = "Login";
            this.btnLogin1.UseVisualStyleBackColor = true;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPassLog;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.TextBox inputPasswordLog;
        private System.Windows.Forms.TextBox inputUsernameLog;
        private System.Windows.Forms.Button bntRegis1;
        private System.Windows.Forms.Button bntExit1;
        private System.Windows.Forms.Button btnLogin1;
    }
}