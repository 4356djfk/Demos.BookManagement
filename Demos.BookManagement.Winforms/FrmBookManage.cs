using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Demos.BookManagement.Domain;
using Demos.BookManagement.IRepository;

namespace Demos.BookManagement.Winforms
{
    public partial class FrmBookManage : Form
    {
        #region 属性

        /// <summary>
        /// 图书仓储
        /// 属性注入
        /// </summary>
        public IBookRepository Repository { get; set; }

        /// <summary>
        /// 操作成功消息
        /// </summary>
        private const string SuccessMessage = @"操作成功";
        /// <summary>
        /// 删除错误提示
        /// </summary>
        private const string RemoveErrorMessage= @"请先选择图书";

        #endregion

        public FrmBookManage()
        {
            InitializeComponent();
            dgv_Result.AutoGenerateColumns = false;
        }

        #region 帮助方法

        /// <summary>
        /// 字符串转整型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private int ConvertToInt(string str)
        {
            var result = 0;
            int.TryParse(str, out result);
            return result;
        }

        /// <summary>
        /// 字符串转double
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private double ConvertToDouble(string str)
        {
            var result = 0.0;
            double.TryParse(str, out result);
            return result;
        }

        /// <summary>
        /// 加载图书列表
        /// </summary>
        private void LoadBook()
        {
            var strId = txt_QueryId.Text.Trim();
            var id = ConvertToInt(strId);
            if (id != 0)
            {
                var list = new List<Book>();
                var book = Repository.FindById(id);
                book = book ?? new Book();
                list.Add(book);
                dgv_Result.DataSource = list;
            }
            else
            {
                dgv_Result.DataSource = Repository.FindAll();
            }
        }

        /// <summary>
        /// 获取图书
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        private Book GetBook()
        {
            return new Book
            {
                Id = ConvertToInt(txt_Id.Text),
                Author = txt_Author.Text.Trim(),
                Isbn = txt_Isbn.Text.Trim(),
                Press = txt_Press.Text.Trim(),
                Title = txt_Title.Text.Trim(),
                Price = ConvertToDouble(txt_Price.Text)
            };
        }

        /// <summary>
        /// 显示图书详情
        /// </summary>
        /// <param name="book"></param>
        private void ShowBook(Book book)
        {
            txt_Id.Text = book.Id.ToString();
            txt_Author.Text = book.Author;
            txt_Isbn.Text = book.Isbn;
            txt_Press.Text = book.Press;
            txt_Title.Text = book.Title;
            txt_Price.Text = book.Price.ToString();
        }

        /// <summary>
        /// 清空图书详情
        /// </summary>
        private void ClearBookDetail()
        {
            ShowBook(new Book());
        }

        #endregion

        #region 事件处理

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            LoadBook();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            ClearBookDetail();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            var id = ConvertToInt(txt_Id.Text);
            if (id != 0)
            {
                Repository.Remove(id);
                MessageBox.Show(SuccessMessage);
                LoadBook();
                ClearBookDetail();
            }
            else
                MessageBox.Show(RemoveErrorMessage);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            var book = GetBook();
            if (book.Id != 0)
            {
                Repository.Modify(book);
            }
            else
            {
                Repository.Add(book);
            }
            MessageBox.Show(SuccessMessage);
            LoadBook();
            ClearBookDetail();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearBookDetail();
        }

        /// <summary>
        /// 点击列表单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var book = dgv_Result.CurrentRow == null ? new Book() : (Book) dgv_Result.CurrentRow.DataBoundItem;
            ShowBook(book);
        }

        #endregion

    }
}
