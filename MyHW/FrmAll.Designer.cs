
namespace MyHW
{
    partial class FrmAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAll));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNorthwind = new System.Windows.Forms.Button();
            this.btnDataSet = new System.Windows.Forms.Button();
            this.btnAdventureWorks = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 589);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.splitContainer2.Panel1.Controls.Add(this.btnPicture);
            this.splitContainer2.Panel1.Controls.Add(this.btnListView);
            this.splitContainer2.Panel1.Controls.Add(this.btnAdventureWorks);
            this.splitContainer2.Panel1.Controls.Add(this.btnDataSet);
            this.splitContainer2.Panel1.Controls.Add(this.btnNorthwind);
            this.splitContainer2.Size = new System.Drawing.Size(1028, 442);
            this.splitContainer2.SplitterDistance = 149;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(317, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSIT ADO.NET 作業";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnNorthwind
            // 
            this.btnNorthwind.BackColor = System.Drawing.Color.Black;
            this.btnNorthwind.ForeColor = System.Drawing.Color.White;
            this.btnNorthwind.Location = new System.Drawing.Point(12, 24);
            this.btnNorthwind.Name = "btnNorthwind";
            this.btnNorthwind.Size = new System.Drawing.Size(121, 28);
            this.btnNorthwind.TabIndex = 0;
            this.btnNorthwind.Text = "Northwind";
            this.btnNorthwind.UseVisualStyleBackColor = false;
            this.btnNorthwind.Click += new System.EventHandler(this.btnNorthwind_Click);
            // 
            // btnDataSet
            // 
            this.btnDataSet.BackColor = System.Drawing.Color.Black;
            this.btnDataSet.ForeColor = System.Drawing.Color.White;
            this.btnDataSet.Location = new System.Drawing.Point(12, 92);
            this.btnDataSet.Name = "btnDataSet";
            this.btnDataSet.Size = new System.Drawing.Size(121, 28);
            this.btnDataSet.TabIndex = 1;
            this.btnDataSet.Text = "DataSet 結構";
            this.btnDataSet.UseVisualStyleBackColor = false;
            this.btnDataSet.Click += new System.EventHandler(this.btnDataSet_Click);
            // 
            // btnAdventureWorks
            // 
            this.btnAdventureWorks.BackColor = System.Drawing.Color.Black;
            this.btnAdventureWorks.ForeColor = System.Drawing.Color.White;
            this.btnAdventureWorks.Location = new System.Drawing.Point(12, 58);
            this.btnAdventureWorks.Name = "btnAdventureWorks";
            this.btnAdventureWorks.Size = new System.Drawing.Size(121, 28);
            this.btnAdventureWorks.TabIndex = 2;
            this.btnAdventureWorks.Text = "AdventureWorks";
            this.btnAdventureWorks.UseVisualStyleBackColor = false;
            this.btnAdventureWorks.Click += new System.EventHandler(this.btnAdventureWorks_Click);
            // 
            // btnListView
            // 
            this.btnListView.BackColor = System.Drawing.Color.Black;
            this.btnListView.ForeColor = System.Drawing.Color.White;
            this.btnListView.Location = new System.Drawing.Point(12, 126);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(121, 28);
            this.btnListView.TabIndex = 3;
            this.btnListView.Text = "ListView";
            this.btnListView.UseVisualStyleBackColor = false;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Black;
            this.btnPicture.ForeColor = System.Drawing.Color.White;
            this.btnPicture.Location = new System.Drawing.Point(12, 160);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(121, 28);
            this.btnPicture.TabIndex = 4;
            this.btnPicture.Text = "相片管理";
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // FrmAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 589);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmAll";
            this.Text = "FrmAll";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnNorthwind;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.Button btnAdventureWorks;
        private System.Windows.Forms.Button btnDataSet;
    }
}