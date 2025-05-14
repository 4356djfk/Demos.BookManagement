namespace Demos.BookManagement.Domain
{
    public class Book : IEntity
    {
        /// <summary>
        /// 标识
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 出版社
        /// </summary>
        public string Press { get; set; }
        /// <summary>
        /// ISO国际标准书号
        /// International Standard Book Number
        /// </summary>
        public string Isbn { get; set; }
        /// <summary>
        /// 定价
        /// </summary>
        public double Price { get; set; }
    }
}
