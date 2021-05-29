using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetLinqDemo
{
    class BooksRepository
    {
        private SqlConnection connection;
        private SqlDataAdapter da;
        public DataTable dataTable;
        public BooksRepository(SqlConnection connection)
        {
            this.connection = connection;
            this.da = new SqlDataAdapter("SELECT * FROM [Books]", this.connection);
            this.dataTable = new DataTable();
        }
        public void Load() {
            this.da.Fill(dataTable);
        }
    }
}
