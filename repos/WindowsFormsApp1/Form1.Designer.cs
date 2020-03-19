namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.sexInput = new System.Windows.Forms.TextBox();
            this.insertDataBtn = new System.Windows.Forms.Button();
            this.queryDataBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(375, 47);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "点击我";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 370);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(321, 175);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "下面是数据列表";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "这里可以输入";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 75);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(321, 81);
            this.textBox2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(497, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(338, 109);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 79);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.Info;
            this.nameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameInput.Location = new System.Drawing.Point(23, 304);
            this.nameInput.MaxLength = 4;
            this.nameInput.Name = "nameInput";
            this.nameInput.PlaceholderText = "姓名";
            this.nameInput.Size = new System.Drawing.Size(100, 23);
            this.nameInput.TabIndex = 7;
            // 
            // ageInput
            // 
            this.ageInput.BackColor = System.Drawing.SystemColors.Info;
            this.ageInput.CausesValidation = false;
            this.ageInput.Location = new System.Drawing.Point(130, 303);
            this.ageInput.MaxLength = 3;
            this.ageInput.Name = "ageInput";
            this.ageInput.PlaceholderText = "年龄";
            this.ageInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ageInput.Size = new System.Drawing.Size(100, 23);
            this.ageInput.TabIndex = 8;
            // 
            // sexInput
            // 
            this.sexInput.BackColor = System.Drawing.SystemColors.Info;
            this.sexInput.Location = new System.Drawing.Point(237, 303);
            this.sexInput.MaxLength = 1;
            this.sexInput.Name = "sexInput";
            this.sexInput.PlaceholderText = "性别";
            this.sexInput.Size = new System.Drawing.Size(100, 23);
            this.sexInput.TabIndex = 9;
            // 
            // insertDataBtn
            // 
            this.insertDataBtn.BackColor = System.Drawing.SystemColors.Control;
            this.insertDataBtn.Location = new System.Drawing.Point(347, 292);
            this.insertDataBtn.Name = "insertDataBtn";
            this.insertDataBtn.Size = new System.Drawing.Size(75, 34);
            this.insertDataBtn.TabIndex = 10;
            this.insertDataBtn.Text = "插入数据";
            this.insertDataBtn.UseVisualStyleBackColor = true;
            // 
            // queryDataBtn
            // 
            this.queryDataBtn.Location = new System.Drawing.Point(122, 332);
            this.queryDataBtn.Name = "queryDataBtn";
            this.queryDataBtn.Size = new System.Drawing.Size(99, 32);
            this.queryDataBtn.TabIndex = 11;
            this.queryDataBtn.Text = "查询数据库";
            this.queryDataBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1031, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.queryDataBtn);
            this.Controls.Add(this.insertDataBtn);
            this.Controls.Add(this.sexInput);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.TextBox sexInput;
        private System.Windows.Forms.Button insertDataBtn;
        private System.Windows.Forms.Button queryDataBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

