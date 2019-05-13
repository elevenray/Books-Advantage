namespace bookAdvantage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login = new System.Windows.Forms.Button();
            this.MailE = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Show_pass = new System.Windows.Forms.CheckBox();
            this.Role_Selection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(221, 191);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 21);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // MailE
            // 
            this.MailE.AutoSize = true;
            this.MailE.Location = new System.Drawing.Point(118, 58);
            this.MailE.Name = "MailE";
            this.MailE.Size = new System.Drawing.Size(32, 13);
            this.MailE.TabIndex = 1;
            this.MailE.Text = "Email";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(118, 99);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(53, 13);
            this.Pass.TabIndex = 2;
            this.Pass.Text = "Password";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(221, 58);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 3;
            this.Email.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(221, 99);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 4;
            // 
            // Show_pass
            // 
            this.Show_pass.AutoSize = true;
            this.Show_pass.Location = new System.Drawing.Point(355, 98);
            this.Show_pass.Name = "Show_pass";
            this.Show_pass.Size = new System.Drawing.Size(102, 17);
            this.Show_pass.TabIndex = 9;
            this.Show_pass.Text = "Show Password";
            this.Show_pass.UseVisualStyleBackColor = true;
            this.Show_pass.CheckedChanged += new System.EventHandler(this.Show_pass_CheckedChanged);
            // 
            // Role_Selection
            // 
            this.Role_Selection.FormattingEnabled = true;
            this.Role_Selection.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.Role_Selection.Location = new System.Drawing.Point(221, 147);
            this.Role_Selection.Name = "Role_Selection";
            this.Role_Selection.Size = new System.Drawing.Size(99, 21);
            this.Role_Selection.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Techer or Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(166, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Books Advantage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(526, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Role_Selection);
            this.Controls.Add(this.Show_pass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.MailE);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label MailE;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.CheckBox Show_pass;
        private System.Windows.Forms.ComboBox Role_Selection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

