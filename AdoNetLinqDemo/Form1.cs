using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetLinqDemo
{
    public partial class Form1 : Form
    {
        private DbContext context;
        public Form1()
        {
            InitializeComponent();

            this.context = Program.Context;

            booksDateGridViev.DataSource =
                this.context.booksRepository.dataTable;
            this.context.booksRepository.Load();
            
            authorsDataGridView.DataSource =
                this.context.authorsRepository.dataTable;
            this.context.authorsRepository.Load();
        }

        private void saveAuthorsButton_Click(object sender, EventArgs e)
        {
            this.context.authorsRepository.Save();
        }

        private void saveBooksButton_Click(object sender, EventArgs e)
        {
            this.context.booksRepository.Save();
        }
    }
}
