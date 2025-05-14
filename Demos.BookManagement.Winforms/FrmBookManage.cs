using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Demos.BookManagement.Domain;
using Demos.BookManagement.IRepository;
using ClosedXML.Excel;
using System.Data;
using System.IO;
using System.Linq;

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
        private const string RemoveErrorMessage = @"请先选择图书";

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

        /// <summary>
        /// 从 Excel 文件导入图书数据到数据库
        /// </summary>
        /// <summary>
        /// 从 Excel 文件导入图书数据到数据库
        /// </summary>
        private void ImportBooksFromExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel 文件 (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var dataTable = new DataTable();

                        // 获取表头
                        var firstRow = worksheet.FirstRowUsed();
                        foreach (var cell in firstRow.Cells())
                        {
                            dataTable.Columns.Add(cell.Value.ToString());
                        }

                        // 获取数据行
                        foreach (var row in worksheet.RowsUsed().Skip(1))
                        {
                            var newRow = dataTable.NewRow();
                            for (int i = 0; i < dataTable.Columns.Count; i++)
                            {
                                newRow[i] = row.Cell(i + 1).Value.ToString();
                            }
                            dataTable.Rows.Add(newRow);
                        }

                        // 将数据写入数据库
                        foreach (DataRow row in dataTable.Rows)
                        {
                            var book = new Book
                            {
                                Title = row["书名"].ToString(),
                                Author = row["作者"].ToString(),
                                Press = row["出版社"].ToString(),
                                Isbn = row["ISBN"].ToString(),
                                // 将 row["Price"] 转换为 string 类型
                                Price = ConvertToDouble(row["定价"].ToString())
                            };
                            Repository.Add(book);
                        }

                        MessageBox.Show("数据导入成功！");
                        LoadBook(); // 重新加载图书列表
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"导入数据时出错：{ex.Message}");
                }
            }
        }

        /// <summary>
        /// 将图书数据导出到 Excel 文件
        /// </summary>
        private void ExportBooksToExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 文件 (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var books = Repository.FindAll();
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("图书列表");

                        // 添加表头
                        worksheet.Cell(1, 1).Value = "编号";
                        worksheet.Cell(1, 2).Value = "书名";
                        worksheet.Cell(1, 3).Value = "作者";
                        worksheet.Cell(1, 4).Value = "出版社";
                        worksheet.Cell(1, 5).Value = "ISBN";
                        worksheet.Cell(1, 6).Value = "定价";

                        // 添加数据行
                        for (int i = 0; i < books.Count; i++)
                        {
                            var book = books[i];
                            worksheet.Cell(i + 2, 1).Value = book.Id;
                            worksheet.Cell(i + 2, 2).Value = book.Title;
                            worksheet.Cell(i + 2, 3).Value = book.Author;
                            worksheet.Cell(i + 2, 4).Value = book.Press;
                            worksheet.Cell(i + 2, 5).Value = book.Isbn;
                            worksheet.Cell(i + 2, 6).Value = book.Price;
                        }

                        // 保存文件
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("数据导出成功！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"导出数据时出错：{ex.Message}");
                }
            }
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
            var book = dgv_Result.CurrentRow == null ? new Book() : (Book)dgv_Result.CurrentRow.DataBoundItem;
            ShowBook(book);
        }

        /// <summary>
        /// 导入 Excel 按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Import_Click(object sender, EventArgs e)
        {
            ImportBooksFromExcel();
        }

        /// <summary>
        /// 导出 Excel 按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            ExportBooksToExcel();
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Isbn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}