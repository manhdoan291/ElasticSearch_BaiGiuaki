namespace CRUDElasticsearch
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
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxVoiceActor = new System.Windows.Forms.TextBox();
            this.tbxDebut = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVoiceActor = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lvwDisneyCharacter = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(199, 21);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(190, 21);
            this.tbxID.TabIndex = 0;
            this.tbxID.TextChanged += new System.EventHandler(this.tbxID_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(199, 50);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(190, 21);
            this.tbxName.TabIndex = 1;
            // 
            // tbxVoiceActor
            // 
            this.tbxVoiceActor.Location = new System.Drawing.Point(199, 79);
            this.tbxVoiceActor.Name = "tbxVoiceActor";
            this.tbxVoiceActor.Size = new System.Drawing.Size(190, 21);
            this.tbxVoiceActor.TabIndex = 2;
            // 
            // tbxDebut
            // 
            this.tbxDebut.Location = new System.Drawing.Point(199, 108);
            this.tbxDebut.Multiline = true;
            this.tbxDebut.Name = "tbxDebut";
            this.tbxDebut.Size = new System.Drawing.Size(190, 55);
            this.tbxDebut.TabIndex = 3;
            this.tbxDebut.TextChanged += new System.EventHandler(this.tbxDebut_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(92, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(95, 15);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Mã số văn bản:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(83, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Tiêu đề văn bản:";
            // 
            // lblVoiceActor
            // 
            this.lblVoiceActor.AutoSize = true;
            this.lblVoiceActor.Location = new System.Drawing.Point(70, 82);
            this.lblVoiceActor.Name = "lblVoiceActor";
            this.lblVoiceActor.Size = new System.Drawing.Size(117, 15);
            this.lblVoiceActor.TabIndex = 6;
            this.lblVoiceActor.Text = "Cơ quan ban hành:";
            this.lblVoiceActor.Click += new System.EventHandler(this.lblVoiceActor_Click);
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(120, 111);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(62, 15);
            this.lblDebut.TabIndex = 7;
            this.lblDebut.Text = "Nội dung:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.tbxDebut);
            this.panel1.Controls.Add(this.lblDebut);
            this.panel1.Controls.Add(this.tbxVoiceActor);
            this.panel1.Controls.Add(this.tbxID);
            this.panel1.Controls.Add(this.lblVoiceActor);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 449);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnIndex);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(442, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 126);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elastic search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(177, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(44, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(44, 21);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(90, 35);
            this.btnIndex.TabIndex = 0;
            this.btnIndex.Text = "Thêm văn bản";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tìm kiếm tiêu đề";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(657, 176);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 19);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Có tất cả từ trên";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(486, 176);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 19);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Chính xác cụm từ trên";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lvwDisneyCharacter
            // 
            this.lvwDisneyCharacter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwDisneyCharacter.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDisneyCharacter.FullRowSelect = true;
            this.lvwDisneyCharacter.GridLines = true;
            this.lvwDisneyCharacter.Location = new System.Drawing.Point(12, 239);
            this.lvwDisneyCharacter.Name = "lvwDisneyCharacter";
            this.lvwDisneyCharacter.Size = new System.Drawing.Size(805, 198);
            this.lvwDisneyCharacter.TabIndex = 9;
            this.lvwDisneyCharacter.UseCompatibleStateImageBehavior = false;
            this.lvwDisneyCharacter.View = System.Windows.Forms.View.Details;
            this.lvwDisneyCharacter.SelectedIndexChanged += new System.EventHandler(this.lvwDisneyCharacter_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã số văn bản";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên văn bản";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tiêu đề";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 233;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nội dung";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(840, 449);
            this.Controls.Add(this.lvwDisneyCharacter);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Văn bản pháp luật";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxVoiceActor;
        private System.Windows.Forms.TextBox tbxDebut;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVoiceActor;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.ListView lvwDisneyCharacter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

