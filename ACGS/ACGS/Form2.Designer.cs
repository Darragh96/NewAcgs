namespace ACGS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LogoSignInBox = new System.Windows.Forms.PictureBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSignInBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoSignInBox
            // 
            this.LogoSignInBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoSignInBox.Image")));
            this.LogoSignInBox.Location = new System.Drawing.Point(11, 11);
            this.LogoSignInBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogoSignInBox.Name = "LogoSignInBox";
            this.LogoSignInBox.Size = new System.Drawing.Size(117, 114);
            this.LogoSignInBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoSignInBox.TabIndex = 1;
            this.LogoSignInBox.TabStop = false;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(314, 176);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(125, 27);
            this.textPass.TabIndex = 12;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(314, 114);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(125, 27);
            this.textUser.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(385, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(233, 265);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(94, 29);
            this.btnPass.TabIndex = 9;
            this.btnPass.Text = "Login";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1Name
            // 
            this.label1Name.AutoSize = true;
            this.label1Name.Location = new System.Drawing.Point(205, 115);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(78, 20);
            this.label1Name.TabIndex = 7;
            this.label1Name.Text = "UserName";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(714, 432);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1Name);
            this.Controls.Add(this.LogoSignInBox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.LogoSignInBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoSignInBox;
        private TextBox textPass;
        private TextBox textUser;
        private Button btnExit;
        private Button btnPass;
        private Label label2;
        private Label label1Name;
    }
}