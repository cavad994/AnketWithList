namespace AnketWithList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataside = new System.Windows.Forms.GroupBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.numbox = new System.Windows.Forms.MaskedTextBox();
            this.emailbox = new System.Windows.Forms.MaskedTextBox();
            this.surnamebox = new System.Windows.Forms.MaskedTextBox();
            this.namebox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.loadbox = new System.Windows.Forms.TextBox();
            this.Listbox = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataside.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataside
            // 
            this.dataside.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataside.Controls.Add(this.savebutton);
            this.dataside.Controls.Add(this.editbutton);
            this.dataside.Controls.Add(this.datebox);
            this.dataside.Controls.Add(this.numbox);
            this.dataside.Controls.Add(this.emailbox);
            this.dataside.Controls.Add(this.surnamebox);
            this.dataside.Controls.Add(this.namebox);
            this.dataside.Controls.Add(this.label5);
            this.dataside.Controls.Add(this.label4);
            this.dataside.Controls.Add(this.label3);
            this.dataside.Controls.Add(this.label2);
            this.dataside.Controls.Add(this.label1);
            this.dataside.Location = new System.Drawing.Point(12, 12);
            this.dataside.Name = "dataside";
            this.dataside.Size = new System.Drawing.Size(375, 426);
            this.dataside.TabIndex = 0;
            this.dataside.TabStop = false;
            this.dataside.Text = "Data";
            // 
            // savebutton
            // 
            this.savebutton.Enabled = false;
            this.savebutton.Location = new System.Drawing.Point(266, 381);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 11;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Enabled = false;
            this.editbutton.Location = new System.Drawing.Point(266, 352);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(75, 23);
            this.editbutton.TabIndex = 10;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(160, 244);
            this.datebox.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(200, 23);
            this.datebox.TabIndex = 9;
            this.datebox.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.datebox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numbox
            // 
            this.numbox.Location = new System.Drawing.Point(174, 200);
            this.numbox.Mask = "(999) 000-0000";
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(173, 23);
            this.numbox.TabIndex = 8;
            this.numbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numbox.TextChanged += new System.EventHandler(this.numbox_TextChanged);
            // 
            // emailbox
            // 
            this.emailbox.AsciiOnly = true;
            this.emailbox.Location = new System.Drawing.Point(174, 157);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(173, 23);
            this.emailbox.SkipLiterals = false;
            this.emailbox.TabIndex = 7;
            this.emailbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailbox.TextChanged += new System.EventHandler(this.emailbox_TextChanged);
            // 
            // surnamebox
            // 
            this.surnamebox.Location = new System.Drawing.Point(174, 111);
            this.surnamebox.Name = "surnamebox";
            this.surnamebox.Size = new System.Drawing.Size(173, 23);
            this.surnamebox.TabIndex = 6;
            this.surnamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surnamebox.TextChanged += new System.EventHandler(this.surnamebox_TextChanged);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(174, 61);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(173, 23);
            this.namebox.TabIndex = 5;
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.loadbox);
            this.groupBox1.Controls.Add(this.Listbox);
            this.groupBox1.Location = new System.Drawing.Point(413, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(56, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filename";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loadbox
            // 
            this.loadbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadbox.Location = new System.Drawing.Point(147, 247);
            this.loadbox.Name = "loadbox";
            this.loadbox.Size = new System.Drawing.Size(182, 20);
            this.loadbox.TabIndex = 1;
            this.loadbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.ItemHeight = 15;
            this.Listbox.Location = new System.Drawing.Point(56, 24);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(273, 199);
            this.Listbox.TabIndex = 0;
            this.Listbox.SelectedIndexChanged += new System.EventHandler(this.Listbox_SelectedIndexChanged);
            this.Listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Listbox_MouseDoubleClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(269, 269);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "#list.json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataside);
            this.Name = "Form1";
            this.Text = "Form1";
            this.dataside.ResumeLayout(false);
            this.dataside.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox dataside;
        private DateTimePicker datebox;
        private MaskedTextBox numbox;
        private MaskedTextBox emailbox;
        private MaskedTextBox surnamebox;
        private MaskedTextBox namebox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Button savebutton;
        private Button editbutton;
        private ListBox Listbox;
        private Label label6;
        private TextBox loadbox;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}