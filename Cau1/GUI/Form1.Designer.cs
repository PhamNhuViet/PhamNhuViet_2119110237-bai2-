
namespace Cau1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deparment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNoiSinh = new System.Windows.Forms.TextBox();
            this.combDonVi = new System.Windows.Forms.ComboBox();
            this.cbGoiTinh = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.birthday,
            this.gender,
            this.born,
            this.deparment});
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Ma";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Ho Ten";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // birthday
            // 
            this.birthday.HeaderText = "Ngay Sinh";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.Width = 125;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gioi Tinh";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 125;
            // 
            // born
            // 
            this.born.HeaderText = "Noi Sinh";
            this.born.MinimumWidth = 6;
            this.born.Name = "born";
            this.born.Width = 125;
            // 
            // deparment
            // 
            this.deparment.HeaderText = "Don Vi";
            this.deparment.MinimumWidth = 6;
            this.deparment.Name = "deparment";
            this.deparment.Width = 125;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(470, 415);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 1;
            this.btNew.Text = "Them";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(551, 415);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xoa";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(632, 415);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "Sua";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(713, 415);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoat";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Don Vi";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(86, 11);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(121, 22);
            this.tbId.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(317, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(137, 22);
            this.tbName.TabIndex = 9;
            // 
            // tbNoiSinh
            // 
            this.tbNoiSinh.Location = new System.Drawing.Point(317, 40);
            this.tbNoiSinh.Name = "tbNoiSinh";
            this.tbNoiSinh.Size = new System.Drawing.Size(471, 22);
            this.tbNoiSinh.TabIndex = 10;
            // 
            // combDonVi
            // 
            this.combDonVi.FormattingEnabled = true;
            this.combDonVi.Location = new System.Drawing.Point(86, 40);
            this.combDonVi.Name = "combDonVi";
            this.combDonVi.Size = new System.Drawing.Size(121, 24);
            this.combDonVi.TabIndex = 12;
            // 
            // cbGoiTinh
            // 
            this.cbGoiTinh.AutoSize = true;
            this.cbGoiTinh.Location = new System.Drawing.Point(668, 12);
            this.cbGoiTinh.Name = "cbGoiTinh";
            this.cbGoiTinh.Size = new System.Drawing.Size(120, 21);
            this.cbGoiTinh.TabIndex = 13;
            this.cbGoiTinh.Text = "Gioi Tinh Nam";
            this.cbGoiTinh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ho Ten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Noi Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngay sinh";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(551, 12);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(101, 22);
            this.dtNgaySinh.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGoiTinh);
            this.Controls.Add(this.combDonVi);
            this.Controls.Add(this.tbNoiSinh);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn born;
        private System.Windows.Forms.DataGridViewTextBoxColumn deparment;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNoiSinh;
        private System.Windows.Forms.ComboBox combDonVi;
        private System.Windows.Forms.CheckBox cbGoiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
    }
}

