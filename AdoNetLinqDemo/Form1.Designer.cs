
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBooksButton = new System.Windows.Forms.Button();
            this.saveAuthorsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDateGridViev)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorsDataGridView
            // 
            this.authorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.authorsDataGridView.Name = "authorsDataGridView";
            this.authorsDataGridView.RowTemplate.Height = 25;
            this.authorsDataGridView.Size = new System.Drawing.Size(600, 200);
            this.authorsDataGridView.TabIndex = 0;
            // 
            // booksDateGridViev
            // 
            this.booksDateGridViev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDateGridViev.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.booksDateGridViev.Location = new System.Drawing.Point(0, 200);
            this.booksDateGridViev.Name = "booksDateGridViev";
            this.booksDateGridViev.RowTemplate.Height = 25;
            this.booksDateGridViev.Size = new System.Drawing.Size(600, 250);
            this.booksDateGridViev.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBooksButton);
            this.panel1.Controls.Add(this.saveAuthorsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
            // 
            // saveBooksButton
            // 
            this.saveBooksButton.Location = new System.Drawing.Point(7, 43);
            this.saveBooksButton.Name = "saveBooksButton";
            this.saveBooksButton.Size = new System.Drawing.Size(181, 23);
            this.saveBooksButton.TabIndex = 1;
            this.saveBooksButton.Text = "Save Books";
            this.saveBooksButton.UseVisualStyleBackColor = true;
            // 
            // saveAuthorsButton
            // 
            this.saveAuthorsButton.Location = new System.Drawing.Point(7, 13);
            this.saveAuthorsButton.Name = "saveAuthorsButton";
            this.saveAuthorsButton.Size = new System.Drawing.Size(181, 23);
            this.saveAuthorsButton.TabIndex = 0;
            this.saveAuthorsButton.Text = "Save Authors";
            this.saveAuthorsButton.UseVisualStyleBackColor = true;
            this.saveAuthorsButton.Click += new System.EventHandler(this.saveAuthorsButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.booksDateGridViev);
            this.panel2.Controls.Add(this.authorsDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDateGridViev)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView authorsDataGridView;
        private System.Windows.Forms.DataGridView booksDateGridViev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveBooksButton;
        private System.Windows.Forms.Button saveAuthorsButton;
    }
}

