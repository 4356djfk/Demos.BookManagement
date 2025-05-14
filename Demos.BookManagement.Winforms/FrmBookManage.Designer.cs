namespace Demos.BookManagement.Winforms
{
    partial class FrmBookManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Query = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.txt_QueryId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Isbn = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Press = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Result);
            this.groupBox1.Controls.Add(this.btn_Query);
            this.groupBox1.Controls.Add(this.btn_Import);
            this.groupBox1.Controls.Add(this.btn_Export);
            this.groupBox1.Controls.Add(this.txt_QueryId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(668, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_Result
            // 
            this.dgv_Result.AllowUserToAddRows = false;
            this.dgv_Result.AllowUserToDeleteRows = false;
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookPress,
            this.BookTitle});
            this.dgv_Result.Location = new System.Drawing.Point(14, 66);
            this.dgv_Result.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.ReadOnly = true;
            this.dgv_Result.RowHeadersWidth = 62;
            this.dgv_Result.RowTemplate.Height = 23;
            this.dgv_Result.Size = new System.Drawing.Size(645, 225);
            this.dgv_Result.TabIndex = 3;
            this.dgv_Result.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Result_CellClick);
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "Id";
            this.BookId.HeaderText = "编号";
            this.BookId.MinimumWidth = 8;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Width = 150;
            // 
            // BookPress
            // 
            this.BookPress.DataPropertyName = "Press";
            this.BookPress.HeaderText = "出版社";
            this.BookPress.MinimumWidth = 8;
            this.BookPress.Name = "BookPress";
            this.BookPress.ReadOnly = true;
            this.BookPress.Width = 150;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.DataPropertyName = "Title";
            this.BookTitle.HeaderText = "书名";
            this.BookTitle.MinimumWidth = 8;
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(276, 22);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(112, 34);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(400, 22);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(112, 34);
            this.btn_Import.TabIndex = 4;
            this.btn_Import.Text = "导入";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(524, 22);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(112, 34);
            this.btn_Export.TabIndex = 5;
            this.btn_Export.Text = "导出";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // txt_QueryId
            // 
            this.txt_QueryId.Location = new System.Drawing.Point(63, 27);
            this.txt_QueryId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_QueryId.Name = "txt_QueryId";
            this.txt_QueryId.Size = new System.Drawing.Size(148, 28);
            this.txt_QueryId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Price);
            this.groupBox2.Controls.Add(this.txt_Isbn);
            this.groupBox2.Controls.Add(this.txt_Title);
            this.groupBox2.Controls.Add(this.txt_Press);
            this.groupBox2.Controls.Add(this.txt_Author);
            this.groupBox2.Controls.Add(this.txt_Id);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(20, 326);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(668, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(99, 201);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(148, 28);
            this.txt_Price.TabIndex = 1;
            this.txt_Price.Text = "0.0";
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.Location = new System.Drawing.Point(412, 154);
            this.txt_Isbn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(148, 28);
            this.txt_Isbn.TabIndex = 1;
            this.txt_Isbn.TextChanged += new System.EventHandler(this.txt_Isbn_TextChanged);
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(99, 70);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(462, 28);
            this.txt_Title.TabIndex = 1;
            // 
            // txt_Press
            // 
            this.txt_Press.Location = new System.Drawing.Point(99, 154);
            this.txt_Press.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Press.Name = "txt_Press";
            this.txt_Press.Size = new System.Drawing.Size(148, 28);
            this.txt_Press.TabIndex = 1;
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(99, 114);
            this.txt_Author.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(462, 28);
            this.txt_Author.TabIndex = 1;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(99, 27);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(148, 28);
            this.txt_Id.TabIndex = 1;
            this.txt_Id.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "定价";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "出版社";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "作者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "编号";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(33, 624);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(112, 34);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "新建";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(204, 624);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(112, 34);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "删除";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(392, 624);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 34);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(566, 624);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FrmBookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 693);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBookManage";
            this.Text = "图书管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.TextBox txt_QueryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Isbn;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Press;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPress;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
    }
}

