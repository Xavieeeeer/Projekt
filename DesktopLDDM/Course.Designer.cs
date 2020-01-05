namespace DesktopLDDM
{
    partial class Course
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateCourse = new System.Windows.Forms.Button();
            this.FindCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.first_name,
            this.last_name,
            this.level});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(215, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 218);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // first_name
            // 
            this.first_name.Text = "first_name";
            this.first_name.Width = 80;
            // 
            // last_name
            // 
            this.last_name.Text = "last_name";
            this.last_name.Width = 80;
            // 
            // level
            // 
            this.level.Text = "level";
            this.level.Width = 80;
            // 
            // CreateCourse
            // 
            this.CreateCourse.Location = new System.Drawing.Point(357, 366);
            this.CreateCourse.Name = "CreateCourse";
            this.CreateCourse.Size = new System.Drawing.Size(111, 23);
            this.CreateCourse.TabIndex = 1;
            this.CreateCourse.Text = "Vytvořit";
            this.CreateCourse.UseVisualStyleBackColor = true;
            this.CreateCourse.Click += new System.EventHandler(this.CreateCourse_Click);
            // 
            // FindCourse
            // 
            this.FindCourse.Location = new System.Drawing.Point(647, 168);
            this.FindCourse.Name = "FindCourse";
            this.FindCourse.Size = new System.Drawing.Size(104, 23);
            this.FindCourse.TabIndex = 2;
            this.FindCourse.Text = "Vyhledat";
            this.FindCourse.UseVisualStyleBackColor = true;
            this.FindCourse.Click += new System.EventHandler(this.FindCourse_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FindCourse);
            this.Controls.Add(this.CreateCourse);
            this.Controls.Add(this.listView1);
            this.Name = "Course";
            this.Text = "Course";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader first_name;
        private System.Windows.Forms.ColumnHeader last_name;
        private System.Windows.Forms.ColumnHeader level;
        private System.Windows.Forms.Button CreateCourse;
        private System.Windows.Forms.Button FindCourse;
    }
}