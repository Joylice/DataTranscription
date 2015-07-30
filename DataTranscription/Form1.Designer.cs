namespace DataTranscription
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.combDataBaseOld = new System.Windows.Forms.ComboBox();
            this.comOldtable = new System.Windows.Forms.ComboBox();
            this.combDataBaseNew = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comNewtable = new System.Windows.Forms.ComboBox();
            this.btn_biaoOld = new System.Windows.Forms.Button();
            this.btn_biaoNew = new System.Windows.Forms.Button();
            this.btn_OldZiDuan = new System.Windows.Forms.Button();
            this.btn_NewZiDuan = new System.Windows.Forms.Button();
            this.btn_StartZhuanLu = new System.Windows.Forms.Button();
            this.OldZiDuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewZiDuan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isTrue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧数据库";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "字段";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OldZiDuan,
            this.NewZiDuan,
            this.isTrue});
            this.dataGridView1.Location = new System.Drawing.Point(79, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(673, 275);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "新数据库";
            // 
            // combDataBaseOld
            // 
            this.combDataBaseOld.FormattingEnabled = true;
            this.combDataBaseOld.Location = new System.Drawing.Point(111, 32);
            this.combDataBaseOld.Name = "combDataBaseOld";
            this.combDataBaseOld.Size = new System.Drawing.Size(121, 20);
            this.combDataBaseOld.TabIndex = 7;
            // 
            // comOldtable
            // 
            this.comOldtable.FormattingEnabled = true;
            this.comOldtable.Location = new System.Drawing.Point(111, 84);
            this.comOldtable.Name = "comOldtable";
            this.comOldtable.Size = new System.Drawing.Size(121, 20);
            this.comOldtable.TabIndex = 8;
            // 
            // combDataBaseNew
            // 
            this.combDataBaseNew.FormattingEnabled = true;
            this.combDataBaseNew.Location = new System.Drawing.Point(441, 32);
            this.combDataBaseNew.Name = "combDataBaseNew";
            this.combDataBaseNew.Size = new System.Drawing.Size(121, 20);
            this.combDataBaseNew.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "表";
            // 
            // comNewtable
            // 
            this.comNewtable.FormattingEnabled = true;
            this.comNewtable.Location = new System.Drawing.Point(441, 84);
            this.comNewtable.Name = "comNewtable";
            this.comNewtable.Size = new System.Drawing.Size(121, 20);
            this.comNewtable.TabIndex = 11;
            // 
            // btn_biaoOld
            // 
            this.btn_biaoOld.Location = new System.Drawing.Point(238, 32);
            this.btn_biaoOld.Name = "btn_biaoOld";
            this.btn_biaoOld.Size = new System.Drawing.Size(120, 23);
            this.btn_biaoOld.TabIndex = 12;
            this.btn_biaoOld.Text = "读取此数据库的表";
            this.btn_biaoOld.UseVisualStyleBackColor = true;
            this.btn_biaoOld.Click += new System.EventHandler(this.btn_biaoOld_Click);
            // 
            // btn_biaoNew
            // 
            this.btn_biaoNew.Location = new System.Drawing.Point(594, 31);
            this.btn_biaoNew.Name = "btn_biaoNew";
            this.btn_biaoNew.Size = new System.Drawing.Size(136, 23);
            this.btn_biaoNew.TabIndex = 13;
            this.btn_biaoNew.Text = "读取此数据库内的表";
            this.btn_biaoNew.UseVisualStyleBackColor = true;
            this.btn_biaoNew.Click += new System.EventHandler(this.btn_biaoNew_Click);
            // 
            // btn_OldZiDuan
            // 
            this.btn_OldZiDuan.Location = new System.Drawing.Point(238, 81);
            this.btn_OldZiDuan.Name = "btn_OldZiDuan";
            this.btn_OldZiDuan.Size = new System.Drawing.Size(120, 23);
            this.btn_OldZiDuan.TabIndex = 14;
            this.btn_OldZiDuan.Text = "读取该表字段";
            this.btn_OldZiDuan.UseVisualStyleBackColor = true;
            this.btn_OldZiDuan.Click += new System.EventHandler(this.btn_OldZiDuan_Click);
            // 
            // btn_NewZiDuan
            // 
            this.btn_NewZiDuan.Location = new System.Drawing.Point(594, 80);
            this.btn_NewZiDuan.Name = "btn_NewZiDuan";
            this.btn_NewZiDuan.Size = new System.Drawing.Size(118, 23);
            this.btn_NewZiDuan.TabIndex = 15;
            this.btn_NewZiDuan.Text = "读取该表字段";
            this.btn_NewZiDuan.UseVisualStyleBackColor = true;
            this.btn_NewZiDuan.Click += new System.EventHandler(this.btn_NewZiDuan_Click);
            // 
            // btn_StartZhuanLu
            // 
            this.btn_StartZhuanLu.Location = new System.Drawing.Point(360, 438);
            this.btn_StartZhuanLu.Name = "btn_StartZhuanLu";
            this.btn_StartZhuanLu.Size = new System.Drawing.Size(75, 23);
            this.btn_StartZhuanLu.TabIndex = 16;
            this.btn_StartZhuanLu.Text = "开始转录";
            this.btn_StartZhuanLu.UseVisualStyleBackColor = true;
            this.btn_StartZhuanLu.Click += new System.EventHandler(this.btn_StartZhuanLu_Click);
            // 
            // OldZiDuan
            // 
            this.OldZiDuan.DataPropertyName = "name";
            this.OldZiDuan.HeaderText = "字段";
            this.OldZiDuan.Name = "OldZiDuan";
            // 
            // NewZiDuan
            // 
            this.NewZiDuan.HeaderText = "对应新数据库字段";
            this.NewZiDuan.Name = "NewZiDuan";
            this.NewZiDuan.Width = 200;
            // 
            // isTrue
            // 
            this.isTrue.HeaderText = "是否启用";
            this.isTrue.Name = "isTrue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 491);
            this.Controls.Add(this.btn_StartZhuanLu);
            this.Controls.Add(this.btn_NewZiDuan);
            this.Controls.Add(this.btn_OldZiDuan);
            this.Controls.Add(this.btn_biaoNew);
            this.Controls.Add(this.btn_biaoOld);
            this.Controls.Add(this.comNewtable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combDataBaseNew);
            this.Controls.Add(this.comOldtable);
            this.Controls.Add(this.combDataBaseOld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combDataBaseOld;
        private System.Windows.Forms.ComboBox comOldtable;
        private System.Windows.Forms.ComboBox combDataBaseNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comNewtable;
        private System.Windows.Forms.Button btn_biaoOld;
        private System.Windows.Forms.Button btn_biaoNew;
        private System.Windows.Forms.Button btn_OldZiDuan;
        private System.Windows.Forms.Button btn_NewZiDuan;
        private System.Windows.Forms.Button btn_StartZhuanLu;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldZiDuan;
        private System.Windows.Forms.DataGridViewComboBoxColumn NewZiDuan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isTrue;
    }
}

