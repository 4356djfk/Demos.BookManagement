using Demos.BookManagement.Domain;
using Demos.BookManagement.IRepository;

namespace Demos.BookManagement.LiteDbRepository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {

    }
}