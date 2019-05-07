namespace bookAdvantage
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewS = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.ViewStudents = new System.Windows.Forms.Button();
            this.ViewBooks = new System.Windows.Forms.Button();
            this.LogOff = new System.Windows.Forms.Button();
            this.ViewRented = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher";
            // 
            // AddNewS
            // 
            this.AddNewS.Location = new System.Drawing.Point(26, 51);
            this.AddNewS.Name = "AddNewS";
            this.AddNewS.Size = new System.Drawing.Size(144, 23);
            this.AddNewS.TabIndex = 1;
            this.AddNewS.Text = "Add/Delete Student";
            this.AddNewS.UseVisualStyleBackColor = true;
            this.AddNewS.Click += new System.EventHandler(this.AddNewS_Click);
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(449, 51);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(144, 23);
            this.AddB.TabIndex = 2;
            this.AddB.Text = "Add/Delete Book";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // ViewStudents
            // 
            this.ViewStudents.Location = new System.Drawing.Point(26, 97);
            this.ViewStudents.Name = "ViewStudents";
            this.ViewStudents.Size = new System.Drawing.Size(144, 23);
            this.ViewStudents.TabIndex = 3;
            this.ViewStudents.Text = "View Enrolled People";
            this.ViewStudents.UseVisualStyleBackColor = true;
            this.ViewStudents.Click += new System.EventHandler(this.ViewStudents_Click);
            // 
            // ViewBooks
            // 
            this.ViewBooks.Location = new System.Drawing.Point(449, 97);
            this.ViewBooks.Name = "ViewBooks";
            this.ViewBooks.Size = new System.Drawing.Size(144, 23);
            this.ViewBooks.TabIndex = 4;
            this.ViewBooks.Text = "View Available Books";
            this.ViewBooks.UseVisualStyleBackColor = true;
            this.ViewBooks.Click += new System.EventHandler(this.ViewBooks_Click);
            // 
            // LogOff
            // 
            this.LogOff.Location = new System.Drawing.Point(670, 292);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(75, 23);
            this.LogOff.TabIndex = 6;
            this.LogOff.Text = "Log Off";
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // ViewRented
            // 
            this.ViewRented.Location = new System.Drawing.Point(618, 97);
            this.ViewRented.Name = "ViewRented";
            this.ViewRented.Size = new System.Drawing.Size(144, 23);
            this.ViewRented.TabIndex = 7;
            this.ViewRented.Text = "View Rented Books";
            this.ViewRented.UseVisualStyleBackColor = true;
            this.ViewRented.Click += new System.EventHandler(this.ViewRented_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(162, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(162, 164);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(363, 20);
            this.searchBox.TabIndex = 9;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search book or people name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewRented);
            this.Controls.Add(this.LogOff);
            this.Controls.Add(this.ViewBooks);
            this.Controls.Add(this.ViewStudents);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.AddNewS);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewS;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button ViewStudents;
        private System.Windows.Forms.Button ViewBooks;
        private System.Windows.Forms.Button LogOff;
        private System.Windows.Forms.Button ViewRented;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
    }
}