namespace _17621834_Daniela_3b
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.panel_movies = new System.Windows.Forms.Panel();
            this.panel_tv = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_movies = new System.Windows.Forms.Button();
            this.btn_shows = new System.Windows.Forms.Button();
            this.panel_movies.SuspendLayout();
            this.panel_tv.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_movies
            // 
            this.panel_movies.Controls.Add(this.btn_movies);
            this.panel_movies.Controls.Add(this.label1);
            this.panel_movies.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_movies.Location = new System.Drawing.Point(0, 0);
            this.panel_movies.Name = "panel_movies";
            this.panel_movies.Size = new System.Drawing.Size(249, 299);
            this.panel_movies.TabIndex = 0;
            // 
            // panel_tv
            // 
            this.panel_tv.Controls.Add(this.btn_shows);
            this.panel_tv.Controls.Add(this.label2);
            this.panel_tv.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_tv.Location = new System.Drawing.Point(255, 0);
            this.panel_tv.Name = "panel_tv";
            this.panel_tv.Size = new System.Drawing.Size(257, 299);
            this.panel_tv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "TV Shows";
            // 
            // btn_movies
            // 
            this.btn_movies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_movies.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_movies.Image = ((System.Drawing.Image)(resources.GetObject("btn_movies.Image")));
            this.btn_movies.Location = new System.Drawing.Point(37, 28);
            this.btn_movies.Name = "btn_movies";
            this.btn_movies.Size = new System.Drawing.Size(194, 150);
            this.btn_movies.TabIndex = 2;
            this.btn_movies.UseVisualStyleBackColor = true;
            this.btn_movies.Click += new System.EventHandler(this.btn_movies_Click);
            // 
            // btn_shows
            // 
            this.btn_shows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shows.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_shows.Image = ((System.Drawing.Image)(resources.GetObject("btn_shows.Image")));
            this.btn_shows.Location = new System.Drawing.Point(37, 28);
            this.btn_shows.Name = "btn_shows";
            this.btn_shows.Size = new System.Drawing.Size(194, 150);
            this.btn_shows.TabIndex = 3;
            this.btn_shows.UseVisualStyleBackColor = true;
            this.btn_shows.Click += new System.EventHandler(this.btn_shows_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_tv);
            this.Controls.Add(this.panel_movies);
            this.Name = "menu";
            this.Size = new System.Drawing.Size(512, 299);
            //this.Load += new System.EventHandler(this.menu_Load);
            this.panel_movies.ResumeLayout(false);
            this.panel_movies.PerformLayout();
            this.panel_tv.ResumeLayout(false);
            this.panel_tv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_movies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_tv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_movies;
        private System.Windows.Forms.Button btn_shows;
    }
}
