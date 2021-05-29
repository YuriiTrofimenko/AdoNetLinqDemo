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
        public AuthorsRepository authorsRepository;
        public DbContext()
        {
            this.connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True");
            this.authorsRepository = new AuthorsRepository(connection);
        }
    }
}
