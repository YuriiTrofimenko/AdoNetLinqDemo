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
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.InsertCommand = builder.GetInsertCommand();
            da.UpdateCommand = builder.GetUpdateCommand();
            da.DeleteCommand = builder.GetDeleteCommand();
            this.dataTable = new DataTable();
        }
        public void Load() {
            this.da.Fill(dataTable);
        }

        public void Save()
        {
            /* MessageBox.Show(this.da.InsertCommand.CommandText);
            MessageBox.Show(this.da.UpdateCommand.CommandText);
            MessageBox.Show(this.da.DeleteCommand.CommandText); */
            da.Update(dataTable);
            dataTable.Clear();
            this.Load();
        }
    }
}
