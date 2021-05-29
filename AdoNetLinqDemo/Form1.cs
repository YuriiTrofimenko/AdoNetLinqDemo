using System;
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
            authorsDataGridView.DataSource =
                this.context.authorsRepository.dataTable;
            this.context.authorsRepository.Load();

            booksDateGridViev.DataSource =
                this.context.booksRepository.dataTable;
            this.context.booksRepository.Load();
        }

    }
}
