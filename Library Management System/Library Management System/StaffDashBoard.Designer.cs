namespace Library_Management_System
{
    partial class StaffDashBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashBoard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAddNewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_New_Member1 = new Library_Management_System.Add_New_Member();
            this.add_New_Books1 = new Library_Management_System.Add_New_Books();
            this.bookDetails1 = new Library_Management_System.BookDetails();
            this.student_Details1 = new Library_Management_System.Student_Details();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddNewMember,
            this.booksToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 104);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddNewMember
            // 
            this.menuAddNewMember.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuAddNewMember.Image = ((System.Drawing.Image)(resources.GetObject("menuAddNewMember.Image")));
            this.menuAddNewMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAddNewMember.Name = "menuAddNewMember";
            this.menuAddNewMember.Size = new System.Drawing.Size(192, 100);
            this.menuAddNewMember.Text = "Add New Student";
            this.menuAddNewMember.Click += new System.EventHandler(this.menuAddNewMember_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.bookDetailsToolStripMenuItem});
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(136, 100);
            this.booksToolStripMenuItem.Text = "    Books   ";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBookToolStripMenuItem.Image")));
            this.addNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(244, 86);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // bookDetailsToolStripMenuItem
            // 
            this.bookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookDetailsToolStripMenuItem.Image")));
            this.bookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookDetailsToolStripMenuItem.Name = "bookDetailsToolStripMenuItem";
            this.bookDetailsToolStripMenuItem.Size = new System.Drawing.Size(244, 86);
            this.bookDetailsToolStripMenuItem.Text = "Book Details";
            this.bookDetailsToolStripMenuItem.Click += new System.EventHandler(this.bookDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBookDetailsToolStripMenuItem,
            this.editBookDetailsToolStripMenuItem1});
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(144, 100);
            this.editToolStripMenuItem.Text = " Edit  ";
            // 
            // editBookDetailsToolStripMenuItem
            // 
            this.editBookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editBookDetailsToolStripMenuItem.Image")));
            this.editBookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editBookDetailsToolStripMenuItem.Name = "editBookDetailsToolStripMenuItem";
            this.editBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(240, 86);
            this.editBookDetailsToolStripMenuItem.Text = "Edit Student Details";
            this.editBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.editBookDetailsToolStripMenuItem_Click);
            // 
            // editBookDetailsToolStripMenuItem1
            // 
            this.editBookDetailsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editBookDetailsToolStripMenuItem1.Image")));
            this.editBookDetailsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editBookDetailsToolStripMenuItem1.Name = "editBookDetailsToolStripMenuItem1";
            this.editBookDetailsToolStripMenuItem1.Size = new System.Drawing.Size(240, 86);
            this.editBookDetailsToolStripMenuItem1.Text = "Edit Book Details";
            this.editBookDetailsToolStripMenuItem1.Click += new System.EventHandler(this.editBookDetailsToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 100);
            this.toolStripMenuItem1.Text = " Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.student_Details1);
            this.panel1.Controls.Add(this.bookDetails1);
            this.panel1.Controls.Add(this.add_New_Books1);
            this.panel1.Controls.Add(this.add_New_Member1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 522);
            this.panel1.TabIndex = 4;
            // 
            // add_New_Member1
            // 
            this.add_New_Member1.Location = new System.Drawing.Point(1, 2);
            this.add_New_Member1.Name = "add_New_Member1";
            this.add_New_Member1.Size = new System.Drawing.Size(745, 520);
            this.add_New_Member1.TabIndex = 0;
            // 
            // add_New_Books1
            // 
            this.add_New_Books1.Location = new System.Drawing.Point(2, 1);
            this.add_New_Books1.Name = "add_New_Books1";
            this.add_New_Books1.Size = new System.Drawing.Size(747, 520);
            this.add_New_Books1.TabIndex = 1;
            // 
            // bookDetails1
            // 
            this.bookDetails1.Location = new System.Drawing.Point(4, 3);
            this.bookDetails1.Name = "bookDetails1";
            this.bookDetails1.Size = new System.Drawing.Size(745, 518);
            this.bookDetails1.TabIndex = 2;
            // 
            // student_Details1
            // 
            this.student_Details1.Location = new System.Drawing.Point(6, 0);
            this.student_Details1.Name = "student_Details1";
            this.student_Details1.Size = new System.Drawing.Size(743, 521);
            this.student_Details1.TabIndex = 3;
            // 
            // StaffDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StaffDashBoard";
            this.Size = new System.Drawing.Size(749, 626);
            this.Load += new System.EventHandler(this.StaffDashBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddNewMember;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private Student_Details student_Details1;
        private BookDetails bookDetails1;
        private Add_New_Books add_New_Books1;
        private Add_New_Member add_New_Member1;
    }
}
