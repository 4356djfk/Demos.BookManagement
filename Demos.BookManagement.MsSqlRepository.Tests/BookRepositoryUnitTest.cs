using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demos.BookManagement.Domain;
using System.Transactions;

namespace Demos.BookManagement.MsSqlRepository.Tests
{
    [TestClass]
    public class BookRepositoryUnitTest
    {
        /// <summary>
        /// 事务
        /// </summary>
        private TransactionScope _scope;
        /// <summary>
        /// 图书
        /// </summary>
        private Book _book;
        /// <summary>
        /// 图书仓储
        /// </summary>
        private BookRepository _repository;

        /// <summary>
        /// 设置数据文件的存取路径
        /// </summary>
        private void SetDataDirectory()
        {
            var dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug")
                || dataDir.EndsWith(@"\bin\Release"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.FullName + "\\App_Data";
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }
        }
        /// <summary>
        /// 测试初始化
        /// </summary>
        [TestInitialize]
        public void Initial()
        {
            _scope = new TransactionScope();
            _book = new Book()
            {
                Title = "测试图书",
                Author = "南华大学",
                Isbn = "00000000000",
                Press = "计算机学院",
                Price = 25.5
            };
            SetDataDirectory();
            _repository = new BookRepository();
        }
        /// <summary>
        /// 测试清理
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            _scope.Dispose();
        }

        [TestMethod]
        public void Add_Book_CountIncreaseOne()
        {
            //arrange
            var before = _repository.FindAll().Count;
            //act
            _repository.Add(_book);
            var after = _repository.FindAll().Count;
            var actual = after - before;
            //assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Remove_Book_CountDecreaseOne()
        {
            //arrange
            var before = _repository.FindAll().Count;
            //act
            _repository.Remove(1);
            var after = _repository.FindAll().Count;
            var actual = before - after;
            //assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Modify_Title_AreEqual()
        {
            //arrange
            var before = _repository.FindById(1);
            var expected = "测试图书";
            before.Title = expected;
            //act
            _repository.Modify(before);
            var after = _repository.FindById(1);
            //assert
            Assert.AreEqual(expected, after.Title);
        }

        [TestMethod]
        public void FindAll_None_CountGreatThanOne()
        {
            //arrange

            //act
            var count = _repository.FindAll().Count;
            //assert
            Assert.IsTrue(count >= 1);
        }

        [TestMethod]
        public void FindById_One_InstanceOfBook()
        {
            //arrange

            //act
            var book = _repository.FindById(1);
            //assert
            Assert.IsInstanceOfType(book, typeof(Book));
        }
    }
}
