using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetLinqDemo
{
    class DbContext
    {
        private SqlConnection connection;
        public BooksRepository booksRepository;
        public AuthorsRepository authorsRepository;
        public DbContext()
        {
            this.connection = new SqlConnection(@"Data Source = (localdb)\mssqllocaldb; Initial Catalog = Liblary; Integrated Security = True");
            this.booksRepository = new BooksRepository(connection);
            this.authorsRepository = new AuthorsRepository(connection);
        }
    }
}
