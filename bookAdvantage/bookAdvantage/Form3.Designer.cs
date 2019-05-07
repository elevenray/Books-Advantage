namespace bookAdvantage
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.ViewBooks = new System.Windows.Forms.Button();
            this.Rent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.logOff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewRented = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // ViewBooks
            // 
            this.ViewBooks.Location = new System.Drawing.Point(111, 67);
            this.ViewBooks.Name = "ViewBooks";
            this.ViewBooks.Size = new System.Drawing.Size(75, 23);
            this.ViewBooks.TabIndex = 1;
            this.ViewBooks.Text = "View Books";
            this.ViewBooks.UseVisualStyleBackColor = true;
            this.ViewBooks.Click += new System.EventHandler(this.ViewBooks_Click);
            // 
            // Rent
            // 
            this.Rent.Location = new System.Drawing.Point(43, 293);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(75, 23);
            this.Rent.TabIndex = 3;
            this.Rent.Text = "Rent";
            this.Rent.UseVisualStyleBackColor = true;
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter email and name of book you want to rent or return";
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(113, 252);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(176, 20);
            this.BookID.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "BookID";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(186, 293);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 9;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // logOff
            // 
            this.logOff.Location = new System.Drawing.Point(667, 305);
            this.logOff.Name = "logOff";
            this.logOff.Size = new System.Drawing.Size(75, 23);
            this.logOff.TabIndex = 10;
            this.logOff.Text = "Log Off";
            this.logOff.UseVisualStyleBackColor = true;
            this.logOff.Click += new System.EventHandler(this.logOff_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 205);
            this.dataGridView1.TabIndex = 11;
            // 
            // ViewRented
            // 
            this.ViewRented.Location = new System.Drawing.Point(92, 331);
            this.ViewRented.Name = "ViewRented";
            this.ViewRented.Size = new System.Drawing.Size(118, 23);
            this.ViewRented.TabIndex = 12;
            this.ViewRented.Text = "View Rented Books";
            this.ViewRented.UseVisualStyleBackColor = true;
            this.ViewRented.Click += new System.EventHandler(this.ViewRented_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(324, 41);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(440, 20);
            this.searchBox.TabIndex = 13;
            this.searchBox.TextChanged += new System.EventHandler(this.seachBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Search Book name";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.ViewRented);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOff);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.ViewBooks);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewBooks;
        private System.Windows.Forms.Button Rent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button logOff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewRented;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label5;
    }
}