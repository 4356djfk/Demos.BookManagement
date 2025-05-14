using Demos.BookManagement.IRepository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Demos.BookManagement.Domain;
using LiteDB;

namespace Demos.BookManagement.LiteDbRepository
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : IEntity, new()
    {
        /// <summary>
        /// 从配置文件
        /// 读取数据库连接字符串
        /// </summary>
        private readonly string _connectionString = ConfigurationManager
            .ConnectionStrings["LiteDb"].ConnectionString;
        /// <summary>
        /// 数据库
        /// </summary>
        protected LiteDatabase Db
        {
            get
            {
                //取数据目录变量所指路径
                var dataDir = (string)AppDomain.CurrentDomain.GetData("DataDirectory");
                //将连接字符串中数据目录替换为绝对路径
                var connectionString = _connectionString.Replace("|DataDirectory|", dataDir);
                return new LiteDatabase(connectionString);
            }
        }
        /// <summary>
        /// 集合名称
        /// </summary>
        protected string CollectionName { get; set; }
        /// <summary>
        /// 数据集合
        /// </summary>
        protected LiteCollection<T> Collection { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        protected BaseRepository()
        {
            Collection = Db.GetCollection<T>(CollectionName);
        }
        public void Add(T entity)
        {
            Collection.Insert(entity);
        }

        public IList<T> FindAll()
        {
            var data = Collection.FindAll();
            return data.ToList();
        }

        public T FindById(int id)
        {
            var data = Collection.FindById(id);
            return data;
        }

        public void Modify(T entity)
        {
            Collection.Update(entity);
        }

        public void Remove(int id)
        {
            Collection.Delete(id);
        }
    }
}
