namespace Library_Management_System
{
    partial class AdminDashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMemberDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStudentDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaffDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookDetails1 = new Library_Management_System.BookDetails();
            this.addNewStaff2 = new Library_Management_System.AddNewStaff();
            this.student_Details1 = new Library_Management_System.Student_Details();
            this.staffDetails1 = new Library_Management_System.StaffDetails();
            this.add_New_Books1 = new Library_Management_System.Add_New_Books();
            this.addNewStaff1 = new Library_Management_System.AddNewStaff();
            this.add_New_Member1 = new Library_Management_System.Add_New_Member();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddNew,
            this.menuMemberDetails,
            this.menuBooks,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 88);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddNew
            // 
            this.menuAddNew.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuAddNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewStudent,
            this.addNewStuffToolStripMenuItem});
            this.menuAddNew.Image = ((System.Drawing.Image)(resources.GetObject("menuAddNew.Image")));
            this.menuAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAddNew.Name = "menuAddNew";
            this.menuAddNew.Size = new System.Drawing.Size(148, 84);
            this.menuAddNew.Text = "Add New";
            // 
            // AddNewStudent
            // 
            this.AddNewStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("AddNewStudent.Image")));
            this.AddNewStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewStudent.Name = "AddNewStudent";
            this.AddNewStudent.Size = new System.Drawing.Size(231, 86);
            this.AddNewStudent.Text = "Add New Student";
            this.AddNewStudent.Click += new System.EventHandler(this.AddNewStudent_Click);
            // 
            // addNewStuffToolStripMenuItem
            // 
            this.addNewStuffToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addNewStuffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewStuffToolStripMenuItem.Image")));
            this.addNewStuffToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewStuffToolStripMenuItem.Name = "addNewStuffToolStripMenuItem";
            this.addNewStuffToolStripMenuItem.Size = new System.Drawing.Size(231, 86);
            this.addNewStuffToolStripMenuItem.Text = "Add New Staff";
            this.addNewStuffToolStripMenuItem.Click += new System.EventHandler(this.addNewStuffToolStripMenuItem_Click);
            // 
            // menuMemberDetails
            // 
            this.menuMemberDetails.BackColor = System.Drawing.Color.Aquamarine;
            this.menuMemberDetails.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStudentDetails,
            this.menuStaffDetails});
            this.menuMemberDetails.Image = global::Library_Management_System.Properties.Resources.icons8_member_80;
            this.menuMemberDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMemberDetails.Name = "menuMemberDetails";
            this.menuMemberDetails.Size = new System.Drawing.Size(182, 84);
            this.menuMemberDetails.Text = "Member Details";
            // 
            // menuStudentDetails
            // 
            this.menuStudentDetails.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStudentDetails.Image = ((System.Drawing.Image)(resources.GetObject("menuStudentDetails.Image")));
            this.menuStudentDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuStudentDetails.Name = "menuStudentDetails";
            this.menuStudentDetails.Size = new System.Drawing.Size(187, 56);
            this.menuStudentDetails.Text = "Student Details";
            this.menuStudentDetails.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // menuStaffDetails
            // 
            this.menuStaffDetails.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStaffDetails.Image = ((System.Drawing.Image)(resources.GetObject("menuStaffDetails.Image")));
            this.menuStaffDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuStaffDetails.Name = "menuStaffDetails";
            this.menuStaffDetails.Size = new System.Drawing.Size(187, 56);
            this.menuStaffDetails.Text = "Staff Details";
            this.menuStaffDetails.Click += new System.EventHandler(this.stuffDetailsToolStripMenuItem_Click);
            // 
            // menuBooks
            // 
            this.menuBooks.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.bookDetailsToolStripMenuItem1});
            this.menuBooks.Image = ((System.Drawing.Image)(resources.GetObject("menuBooks.Image")));
            this.menuBooks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuBooks.Name = "menuBooks";
            this.menuBooks.Size = new System.Drawing.Size(202, 84);
            this.menuBooks.Text = "        Books                     ";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.addNewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBookToolStripMenuItem.Image")));
            this.addNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(244, 86);
            this.addNewBookToolStripMenuItem.Text = "Add New Books";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // bookDetailsToolStripMenuItem1
            // 
            this.bookDetailsToolStripMenuItem1.BackColor = System.Drawing.Color.Aquamarine;
            this.bookDetailsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("bookDetailsToolStripMenuItem1.Image")));
            this.bookDetailsToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookDetailsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookDetailsToolStripMenuItem1.Name = "bookDetailsToolStripMenuItem1";
            this.bookDetailsToolStripMenuItem1.Size = new System.Drawing.Size(244, 86);
            this.bookDetailsToolStripMenuItem1.Text = "Book Details";
            this.bookDetailsToolStripMenuItem1.Click += new System.EventHandler(this.bookDetailsToolStripMenuItem1_Click_1);
            // 
            // menuExit
            // 
            this.menuExit.BackColor = System.Drawing.Color.Aquamarine;
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(134, 84);
            this.menuExit.Text = "      Exit    ";
            this.menuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bookDetails1);
            this.panel1.Controls.Add(this.addNewStaff2);
            this.panel1.Controls.Add(this.student_Details1);
            this.panel1.Controls.Add(this.staffDetails1);
            this.panel1.Controls.Add(this.add_New_Books1);
            this.panel1.Controls.Add(this.addNewStaff1);
            this.panel1.Controls.Add(this.add_New_Member1);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 535);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bookDetails1
            // 
            this.bookDetails1.Location = new System.Drawing.Point(3, -2);
            this.bookDetails1.Name = "bookDetails1";
            this.bookDetails1.Size = new System.Drawing.Size(747, 531);
            this.bookDetails1.TabIndex = 12;
            // 
            // addNewStaff2
            // 
            this.addNewStaff2.Location = new System.Drawing.Point(-1, 0);
            this.addNewStaff2.Name = "addNewStaff2";
            this.addNewStaff2.Size = new System.Drawing.Size(751, 546);
            this.addNewStaff2.TabIndex = 11;
            // 
            // student_Details1
            // 
            this.student_Details1.Location = new System.Drawing.Point(-1, 0);
            this.student_Details1.Name = "student_Details1";
            this.student_Details1.Size = new System.Drawing.Size(751, 536);
            this.student_Details1.TabIndex = 10;
            // 
            // staffDetails1
            // 
            this.staffDetails1.Location = new System.Drawing.Point(1, -2);
            this.staffDetails1.Name = "staffDetails1";
            this.staffDetails1.Size = new System.Drawing.Size(749, 537);
            this.staffDetails1.TabIndex = 9;
            // 
            // add_New_Books1
            // 
            this.add_New_Books1.Location = new System.Drawing.Point(-1, 1);
            this.add_New_Books1.Name = "add_New_Books1";
            this.add_New_Books1.Size = new System.Drawing.Size(751, 534);
            this.add_New_Books1.TabIndex = 8;
            // 
            // addNewStaff1
            // 
            this.addNewStaff1.Location = new System.Drawing.Point(-1, 0);
            this.addNewStaff1.Name = "addNewStaff1";
            this.addNewStaff1.Size = new System.Drawing.Size(751, 532);
            this.addNewStaff1.TabIndex = 7;
            // 
            // add_New_Member1
            // 
            this.add_New_Member1.Location = new System.Drawing.Point(-1, 2);
            this.add_New_Member1.Name = "add_New_Member1";
            this.add_New_Member1.Size = new System.Drawing.Size(748, 530);
            this.add_New_Member1.TabIndex = 4;
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdminDashBoard";
            this.Size = new System.Drawing.Size(750, 620);
            this.Load += new System.EventHandler(this.AdminDashBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddNew;
        private System.Windows.Forms.ToolStripMenuItem AddNewStudent;
        private System.Windows.Forms.ToolStripMenuItem addNewStuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMemberDetails;
        private System.Windows.Forms.ToolStripMenuItem menuStudentDetails;
        private System.Windows.Forms.ToolStripMenuItem menuStaffDetails;
        private System.Windows.Forms.ToolStripMenuItem menuBooks;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel panel1;
        private Add_New_Member add_New_Member1;
        private AddNewStaff addNewStaff1;
        private AddNewStaff addNewStaff2;
        private Student_Details student_Details1;
        private StaffDetails staffDetails1;
        private Add_New_Books add_New_Books1;
        private BookDetails bookDetails1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
