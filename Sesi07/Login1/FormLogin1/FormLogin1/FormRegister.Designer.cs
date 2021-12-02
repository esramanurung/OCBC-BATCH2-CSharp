
namespace FormLogin1
{
    partial class FormRegister
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
            this.btnReg2 = new System.Windows.Forms.Button();
            this.bntExit2 = new System.Windows.Forms.Button();
            this.btnLog2 = new System.Windows.Forms.Button();
            this.txtnames = new System.Windows.Forms.Label();
            this.txtUser2 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.Label();
            this.textBoxReg1 = new System.Windows.Forms.TextBox();
            this.textBoxReg2 = new System.Windows.Forms.TextBox();
            this.textBoxReg3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReg2
            // 
            this.btnReg2.Location = new System.Drawing.Point(133, 260);
            this.btnReg2.Name = "btnReg2";
            this.btnReg2.Size = new System.Drawing.Size(75, 23);
            this.btnReg2.TabIndex = 0;
            this.btnReg2.Text = "Register";
            this.btnReg2.UseVisualStyleBackColor = true;
            this.btnReg2.Click += new System.EventHandler(this.btnReg2_Click);
            // 
            // bntExit2
            // 
            this.bntExit2.Location = new System.Drawing.Point(432, 260);
            this.bntExit2.Name = "bntExit2";
            this.bntExit2.Size = new System.Drawing.Size(75, 23);
            this.bntExit2.TabIndex = 1;
            this.bntExit2.Text = "Exit";
            this.bntExit2.UseVisualStyleBackColor = true;
            this.bntExit2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLog2
            // 
            this.btnLog2.Location = new System.Drawing.Point(432, 311);
            this.btnLog2.Name = "btnLog2";
            this.btnLog2.Size = new System.Drawing.Size(75, 23);
            this.btnLog2.TabIndex = 2;
            this.btnLog2.Text = "Login";
            this.btnLog2.UseVisualStyleBackColor = true;
            this.btnLog2.Click += new System.EventHandler(this.btnLog2_Click);
            // 
            // txtnames
            // 
            this.txtnames.AutoSize = true;
            this.txtnames.Location = new System.Drawing.Point(130, 69);
            this.txtnames.Name = "txtnames";
            this.txtnames.Size = new System.Drawing.Size(38, 13);
            this.txtnames.TabIndex = 3;
            this.txtnames.Text = "names";
            this.txtnames.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUser2
            // 
            this.txtUser2.AutoSize = true;
            this.txtUser2.Location = new System.Drawing.Point(130, 118);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(55, 13);
            this.txtUser2.TabIndex = 4;
            this.txtUser2.Text = "Username";
            // 
            // txtPass2
            // 
            this.txtPass2.AutoSize = true;
            this.txtPass2.Location = new System.Drawing.Point(130, 173);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(53, 13);
            this.txtPass2.TabIndex = 5;
            this.txtPass2.Text = "Password";
            // 
            // textBoxReg1
            // 
            this.textBoxReg1.Location = new System.Drawing.Point(350, 62);
            this.textBoxReg1.Name = "textBoxReg1";
            this.textBoxReg1.Size = new System.Drawing.Size(224, 20);
            this.textBoxReg1.TabIndex = 6;
            // 
            // textBoxReg2
            // 
            this.textBoxReg2.Location = new System.Drawing.Point(350, 118);
            this.textBoxReg2.Name = "textBoxReg2";
            this.textBoxReg2.Size = new System.Drawing.Size(224, 20);
            this.textBoxReg2.TabIndex = 7;
            // 
            // textBoxReg3
            // 
            this.textBoxReg3.Location = new System.Drawing.Point(350, 185);
            this.textBoxReg3.Name = "textBoxReg3";
            this.textBoxReg3.Size = new System.Drawing.Size(224, 20);
            this.textBoxReg3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReg2);
            this.panel1.Controls.Add(this.bntExit2);
            this.panel1.Controls.Add(this.btnLog2);
            this.panel1.Controls.Add(this.txtnames);
            this.panel1.Controls.Add(this.txtUser2);
            this.panel1.Controls.Add(this.txtPass2);
            this.panel1.Controls.Add(this.textBoxReg1);
            this.panel1.Controls.Add(this.textBoxReg2);
            this.panel1.Controls.Add(this.textBoxReg3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Do you have an account? Click";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegister";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReg2;
        private System.Windows.Forms.Button bntExit2;
        private System.Windows.Forms.Button btnLog2;
        private System.Windows.Forms.Label txtnames;
        private System.Windows.Forms.Label txtUser2;
        private System.Windows.Forms.Label txtPass2;
        private System.Windows.Forms.TextBox textBoxReg1;
        private System.Windows.Forms.TextBox textBoxReg2;
        private System.Windows.Forms.TextBox textBoxReg3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}