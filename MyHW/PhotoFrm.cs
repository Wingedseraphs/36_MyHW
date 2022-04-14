﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class PhotoFrm : Form
    {
        public PhotoFrm()
        {
            InitializeComponent();
        }

        private void albumTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.albumTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDatabaseDataSet);

        }

        private void PhotoFrm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myAlbumDatabaseDataSet.AlbumTable' 資料表。您可以視需要進行移動或移除。
            this.albumTableTableAdapter.Fill(this.myAlbumDatabaseDataSet.AlbumTable);

        }
    }
}
