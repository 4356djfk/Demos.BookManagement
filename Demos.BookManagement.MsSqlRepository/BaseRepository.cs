using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demos.BookManagement.Domain;
using Demos.BookManagement.IRepository;
using System.Configuration;
using Simple.Data;

namespace Demos.BookManagement.MsSqlRepository
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : IEntity, new()
    {

        /// <summary>
        /// 连接字符串
        /// </summary>
        private readonly string _connectionString = ConfigurationManager
            .ConnectionStrings["MsSqlDb"].ConnectionString;
        /// <summary>
        /// 数据库
        /// </summary>
        protected dynamic Db
        {
            get
            {
                //取数据目录变量所指路径
                var dataDir = (string)AppDomain.CurrentDomain.GetData("DataDirectory");
                //将连接字符串中数据目录替换为绝对路径
                var connectionString = _connectionString.Replace("|DataDirectory|", dataDir);
                return Database.OpenConnection(connectionString);
            }
        }

        public abstract void Add(T entity);

        public abstract void Remove(int id);

        public abstract void Modify(T entity);

        public abstract IList<T> FindAll();

        public abstract T FindById(int id);

    }
}
