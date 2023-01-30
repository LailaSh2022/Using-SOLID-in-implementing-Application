
namespace SWD502_Forms_ClassActivity_21_03_2022
{
    partial class CarMoreInfoForm
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
            this.CarNameLbl = new System.Windows.Forms.Label();
            this.CarInfoLbl = new System.Windows.Forms.Label();
            this.CarInfoLBox = new System.Windows.Forms.ListBox();
            this.pictureCarBox = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CarNameLbl
            // 
            this.CarNameLbl.AutoSize = true;
            this.CarNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameLbl.Location = new System.Drawing.Point(149, 42);
            this.CarNameLbl.Name = "CarNameLbl";
            this.CarNameLbl.Size = new System.Drawing.Size(0, 39);
            this.CarNameLbl.TabIndex = 1;
            // 
            // CarInfoLbl
            // 
            this.CarInfoLbl.AutoSize = true;
            this.CarInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarInfoLbl.Location = new System.Drawing.Point(131, 479);
            this.CarInfoLbl.Name = "CarInfoLbl";
            this.CarInfoLbl.Size = new System.Drawing.Size(0, 24);
            this.CarInfoLbl.TabIndex = 2;
            // 
            // CarInfoLBox
            // 
            this.CarInfoLBox.FormattingEnabled = true;
            this.CarInfoLBox.ItemHeight = 16;
            this.CarInfoLBox.Location = new System.Drawing.Point(263, 479);
            this.CarInfoLBox.Name = "CarInfoLBox";
            this.CarInfoLBox.Size = new System.Drawing.Size(400, 116);
            this.CarInfoLBox.TabIndex = 3;
            // 
            // pictureCarBox
            // 
            this.pictureCarBox.Location = new System.Drawing.Point(263, 125);
            this.pictureCarBox.Name = "pictureCarBox";
            this.pictureCarBox.Size = new System.Drawing.Size(517, 328);
            this.pictureCarBox.TabIndex = 0;
            this.pictureCarBox.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(82, 640);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(227, 46);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(899, 640);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(227, 46);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // CarMoreInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 714);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.CarInfoLBox);
            this.Controls.Add(this.CarInfoLbl);
            this.Controls.Add(this.CarNameLbl);
            this.Controls.Add(this.pictureCarBox);
            this.Name = "CarMoreInfoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CarMoreInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCarBox;
        private System.Windows.Forms.Label CarNameLbl;
        private System.Windows.Forms.Label CarInfoLbl;
        private System.Windows.Forms.ListBox CarInfoLBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}