
namespace AdoNetLinqDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorsDataGridView = new System.Windows.Forms.DataGridView();
            this.booksDateGridViev = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDateGridViev)).BeginInit();
            this.SuspendLayout();
            // 
            // authorsDataGridView
            // 
            this.authorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.authorsDataGridView.Name = "authorsDataGridView";
            this.authorsDataGridView.RowTemplate.Height = 25;
            this.authorsDataGridView.Size = new System.Drawing.Size(800, 450);
            this.authorsDataGridView.TabIndex = 0;
            // 
            // booksDateGridViev
            // 
            this.booksDateGridViev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDateGridViev.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.booksDateGridViev.Location = new System.Drawing.Point(0, 201);
            this.booksDateGridViev.Name = "booksDateGridViev";
            this.booksDateGridViev.RowTemplate.Height = 25;
            this.booksDateGridViev.Size = new System.Drawing.Size(800, 249);
            this.booksDateGridViev.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.booksDateGridViev);
            this.Controls.Add(this.authorsDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDateGridViev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView authorsDataGridView;
        private System.Windows.Forms.DataGridView booksDateGridViev;
    }
}

