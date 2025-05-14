using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demos.BookManagement.Domain;
using Demos.BookManagement.IRepository;

namespace Demos.BookManagement.MsSqlRepository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public override void Add(Book entity)
        {
            Db.Books.Insert(entity);
        }

        public override void Remove(int id)
        {
            Db.Books.DeleteById(id);
        }

        public override void Modify(Book entity)
        {
            Db.Books.Update(entity);
        }

        public override IList<Book> FindAll()
        {
            IEnumerable<Book> data = Db.Books.All();
            return data.ToList();
        }

        public override Book FindById(int id)
        {
            var data = Db.Books.Get(id);
            return data;
        }
    }
}
