
namespace SWD502_Forms_ClassActivity_21_03_2022
{
    partial class LogInForm
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
            this.UserLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.WelcomLable = new System.Windows.Forms.Label();
            this.UserTBox = new System.Windows.Forms.TextBox();
            this.PassTBox = new System.Windows.Forms.TextBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.Location = new System.Drawing.Point(84, 168);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(114, 24);
            this.UserLbl.TabIndex = 0;
            this.UserLbl.Text = "User Name";
            this.UserLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLbl.Location = new System.Drawing.Point(84, 271);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(100, 24);
            this.PassLbl.TabIndex = 1;
            this.PassLbl.Text = "Password";
            this.PassLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // WelcomLable
            // 
            this.WelcomLable.AutoSize = true;
            this.WelcomLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomLable.Location = new System.Drawing.Point(342, 49);
            this.WelcomLable.Name = "WelcomLable";
            this.WelcomLable.Size = new System.Drawing.Size(368, 39);
            this.WelcomLable.TabIndex = 2;
            this.WelcomLable.Text = "Welcome To My Form";
            this.WelcomLable.Click += new System.EventHandler(this.label3_Click);
            // 
            // UserTBox
            // 
            this.UserTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTBox.Location = new System.Drawing.Point(296, 168);
            this.UserTBox.Name = "UserTBox";
            this.UserTBox.Size = new System.Drawing.Size(351, 28);
            this.UserTBox.TabIndex = 0;
            // 
            // PassTBox
            // 
            this.PassTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTBox.Location = new System.Drawing.Point(296, 273);
            this.PassTBox.Name = "PassTBox";
            this.PassTBox.Size = new System.Drawing.Size(351, 28);
            this.PassTBox.TabIndex = 1;
            this.PassTBox.UseSystemPasswordChar = true;
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.Location = new System.Drawing.Point(296, 389);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(350, 33);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 616);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.PassTBox);
            this.Controls.Add(this.UserTBox);
            this.Controls.Add(this.WelcomLable);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.UserLbl);
            this.Name = "LogInForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Label WelcomLable;
        private System.Windows.Forms.TextBox UserTBox;
        private System.Windows.Forms.TextBox PassTBox;
        private System.Windows.Forms.Button LogInBtn;
    }
}

