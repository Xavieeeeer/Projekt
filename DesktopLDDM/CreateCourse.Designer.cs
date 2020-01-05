namespace DesktopLDDM
{
    partial class CreateCourse
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TextBox();
            this.level = new System.Windows.Forms.ComboBox();
            this.lector = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.course_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vytvořit kurz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Název";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Úroveň";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kapacita";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(333, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(143, 20);
            this.name.TabIndex = 5;
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(333, 242);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(143, 20);
            this.capacity.TabIndex = 8;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(223, 334);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(88, 23);
            this.back.TabIndex = 9;
            this.back.Text = "Zpět";
            this.back.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(424, 333);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(101, 24);
            this.Create.TabIndex = 10;
            this.Create.Text = "Vyvtořit";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Třída";
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(333, 286);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(143, 20);
            this.room.TabIndex = 12;
            // 
            // level
            // 
            this.level.FormattingEnabled = true;
            this.level.Location = new System.Drawing.Point(333, 146);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(143, 21);
            this.level.TabIndex = 13;
            // 
            // lector
            // 
            this.lector.FormattingEnabled = true;
            this.lector.Location = new System.Drawing.Point(333, 196);
            this.lector.Name = "lector";
            this.lector.Size = new System.Drawing.Size(143, 21);
            this.lector.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pořadové číslo";
            // 
            // course_id
            // 
            this.course_id.Location = new System.Drawing.Point(333, 62);
            this.course_id.Name = "course_id";
            this.course_id.Size = new System.Drawing.Size(143, 20);
            this.course_id.TabIndex = 16;
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.course_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lector);
            this.Controls.Add(this.level);
            this.Controls.Add(this.room);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.back);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateCourse";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.ComboBox lector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox course_id;
    }
}

