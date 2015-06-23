namespace MovieManagerForms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MovieListUpdateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieListUpdateBtn
            // 
            this.MovieListUpdateBtn.Location = new System.Drawing.Point(30, 32);
            this.MovieListUpdateBtn.Name = "MovieListUpdateBtn";
            this.MovieListUpdateBtn.Size = new System.Drawing.Size(151, 38);
            this.MovieListUpdateBtn.TabIndex = 0;
            this.MovieListUpdateBtn.Text = "Update movie list";
            this.MovieListUpdateBtn.UseVisualStyleBackColor = true;
            this.MovieListUpdateBtn.Click += new System.EventHandler(this.MovieListUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(355, 418);
            this.dataGridView1.TabIndex = 1;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(565, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MovieListUpdateBtn);
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MovieListUpdateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}