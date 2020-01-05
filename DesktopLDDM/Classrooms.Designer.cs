namespace DesktopLDDM
{
    partial class Classrooms
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
            this.classroom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.choosed = new System.Windows.Forms.Button();
            this.choose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.classroom,
            this.capacity,
            this.choose});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(244, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(276, 190);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // classroom
            // 
            this.classroom.Text = "classroom";
            // 
            // capacity
            // 
            this.capacity.Text = "capacity";
            // 
            // choosed
            // 
            this.choosed.Location = new System.Drawing.Point(346, 308);
            this.choosed.Name = "choosed";
            this.choosed.Size = new System.Drawing.Size(75, 42);
            this.choosed.TabIndex = 1;
            this.choosed.Text = "Ok";
            this.choosed.UseVisualStyleBackColor = true;
            this.choosed.Click += new System.EventHandler(this.choosed_Click);
            // 
            // choose
            // 
            this.choose.Text = "";
            this.choose.Width = 150;
            // 
            // Classrooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choosed);
            this.Controls.Add(this.listView1);
            this.Name = "Classrooms";
            this.Text = "Classrooms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader classroom;
        private System.Windows.Forms.ColumnHeader capacity;
        private System.Windows.Forms.ColumnHeader choose;
        private System.Windows.Forms.Button choosed;
    }
}