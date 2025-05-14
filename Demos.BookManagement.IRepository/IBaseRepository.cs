using Demos.BookManagement.Domain;
using System.Collections.Generic;

namespace Demos.BookManagement.IRepository
{
    /// <summary>
    /// 泛型接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T> where T : IEntity, new()
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Add(T entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Remove(int id);
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Modify(T entity);
        /// <summary>
        /// 取全部
        /// </summary>
        /// <returns></returns>
        IList<T> FindAll();
        /// <summary>
        /// 根据ID，取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T FindById(int id);
    }
}
