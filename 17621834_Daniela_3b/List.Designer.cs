namespace _17621834_Daniela_3b
{
    partial class List
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.show_list = new System.Windows.Forms.DataGridView();
            this.movie_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_row = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.show_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // show_list
            // 
            this.show_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.show_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movie_id,
            this.movie_name,
            this.movie_genre});
            this.show_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_list.Location = new System.Drawing.Point(0, 0);
            this.show_list.Name = "show_list";
            this.show_list.ReadOnly = true;
            this.show_list.Size = new System.Drawing.Size(512, 299);
            this.show_list.TabIndex = 0;
            // 
            // movie_id
            // 
            this.movie_id.HeaderText = "Movie_id";
            this.movie_id.Name = "movie_id";
            this.movie_id.ReadOnly = true;
            this.movie_id.Width = 150;
            // 
            // movie_name
            // 
            this.movie_name.HeaderText = "Movie_title";
            this.movie_name.Name = "movie_name";
            this.movie_name.ReadOnly = true;
            this.movie_name.Width = 160;
            // 
            // movie_genre
            // 
            this.movie_genre.HeaderText = "Movie_genre";
            this.movie_genre.Name = "movie_genre";
            this.movie_genre.ReadOnly = true;
            this.movie_genre.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 64);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "List of favorites";
            // 
            // delete_row
            // 
            this.delete_row.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_row.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_row.Image = ((System.Drawing.Image)(resources.GetObject("delete_row.Image")));
            this.delete_row.Location = new System.Drawing.Point(412, 189);
            this.delete_row.Name = "delete_row";
            this.delete_row.Size = new System.Drawing.Size(97, 40);
            this.delete_row.TabIndex = 2;
            this.toolTip1.SetToolTip(this.delete_row, "Delete row");
            this.delete_row.UseVisualStyleBackColor = true;
            this.delete_row.Click += new System.EventHandler(this.delete_row_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_row);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.show_list);
            this.Name = "List";
            this.Size = new System.Drawing.Size(512, 299);
            ((System.ComponentModel.ISupportInitialize)(this.show_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView show_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_genre;
        private System.Windows.Forms.Button delete_row;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
