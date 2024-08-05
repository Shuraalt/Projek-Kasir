namespace Cashier
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_title = new System.Windows.Forms.Label();
            this.in_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID_Icon = new System.Windows.Forms.PictureBox();
            this.Pass_Icon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Login_button = new System.Windows.Forms.Button();
            this.Exit_lbl = new System.Windows.Forms.Label();
            this.Clear_lbl = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // login_title
            // 
            this.login_title.AutoSize = true;
            this.login_title.BackColor = System.Drawing.Color.Transparent;
            this.login_title.Font = new System.Drawing.Font("Futura Bk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_title.Location = new System.Drawing.Point(12, 9);
            this.login_title.Name = "login_title";
            this.login_title.Size = new System.Drawing.Size(74, 42);
            this.login_title.TabIndex = 0;
            this.login_title.Text = "Log";
            // 
            // in_title
            // 
            this.in_title.AutoSize = true;
            this.in_title.BackColor = System.Drawing.Color.Transparent;
            this.in_title.Font = new System.Drawing.Font("Futura Bk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.in_title.Location = new System.Drawing.Point(75, 9);
            this.in_title.Name = "in_title";
            this.in_title.Size = new System.Drawing.Size(45, 42);
            this.in_title.TabIndex = 1;
            this.in_title.Text = "in";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(43, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 2;
            // 
            // ID_Icon
            // 
            this.ID_Icon.Image = ((System.Drawing.Image)(resources.GetObject("ID_Icon.Image")));
            this.ID_Icon.InitialImage = ((System.Drawing.Image)(resources.GetObject("ID_Icon.InitialImage")));
            this.ID_Icon.Location = new System.Drawing.Point(44, 153);
            this.ID_Icon.Name = "ID_Icon";
            this.ID_Icon.Size = new System.Drawing.Size(23, 23);
            this.ID_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ID_Icon.TabIndex = 3;
            this.ID_Icon.TabStop = false;
            // 
            // Pass_Icon
            // 
            this.Pass_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Pass_Icon.Image")));
            this.Pass_Icon.InitialImage = null;
            this.Pass_Icon.Location = new System.Drawing.Point(44, 231);
            this.Pass_Icon.Name = "Pass_Icon";
            this.Pass_Icon.Size = new System.Drawing.Size(23, 23);
            this.Pass_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pass_Icon.TabIndex = 5;
            this.Pass_Icon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(43, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 4;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.Black;
            this.Login_button.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(69, 308);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(150, 37);
            this.Login_button.TabIndex = 6;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Exit_lbl
            // 
            this.Exit_lbl.AutoSize = true;
            this.Exit_lbl.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_lbl.Location = new System.Drawing.Point(122, 361);
            this.Exit_lbl.Name = "Exit_lbl";
            this.Exit_lbl.Size = new System.Drawing.Size(42, 25);
            this.Exit_lbl.TabIndex = 7;
            this.Exit_lbl.Text = "Exit";
            this.Exit_lbl.Click += new System.EventHandler(this.Exit_lbl_Click);
            // 
            // Clear_lbl
            // 
            this.Clear_lbl.AutoSize = true;
            this.Clear_lbl.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_lbl.Location = new System.Drawing.Point(172, 259);
            this.Clear_lbl.Name = "Clear_lbl";
            this.Clear_lbl.Size = new System.Drawing.Size(71, 19);
            this.Clear_lbl.TabIndex = 8;
            this.Clear_lbl.Text = "Clear All";
            this.Clear_lbl.Click += new System.EventHandler(this.Clear_lbl_Click);
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_id.Location = new System.Drawing.Point(74, 158);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(169, 16);
            this.txt_id.TabIndex = 9;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_pass.Location = new System.Drawing.Point(74, 237);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(169, 16);
            this.txt_pass.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.Clear_lbl);
            this.Controls.Add(this.Exit_lbl);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Pass_Icon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ID_Icon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.in_title);
            this.Controls.Add(this.login_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ID_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_title;
        private System.Windows.Forms.Label in_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ID_Icon;
        private System.Windows.Forms.PictureBox Pass_Icon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label Exit_lbl;
        private System.Windows.Forms.Label Clear_lbl;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_pass;
    }
}

