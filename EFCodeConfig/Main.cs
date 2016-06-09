using EFCodeConfig.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeConfig
{
    public partial class Main : Form
    {
        Model model = new Model();

        public Main()
        {
            InitializeComponent();

            model.Categories.Load();
            categoryBindingSource.DataSource = model.Categories.Local.ToBindingList();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            model.SaveChanges();
            categoryDataGridView.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            model.Dispose();
        }
    }
}
