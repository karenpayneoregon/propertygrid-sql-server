using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyGridSqlServer.Classes;

namespace PropertyGridSqlServer
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _productsBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
            _productsBindingSource.PositionChanged += BindingSourceOnPositionChanged;
            
            Shown += OnShown;
        }

        private void BindingSourceOnPositionChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = ProductsListBox.SelectedItem;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _productsBindingSource.DataSource = SqlOperations.Read();
            ProductsListBox.DataSource = _productsBindingSource;
            propertyGrid1.SelectedObject = ProductsListBox.SelectedItem;
        }

        private void SaveCurrentButton_Click(object sender, EventArgs e)
        {
            if (_productsBindingSource.Current != null )
            {
                var success = SqlOperations.SaveProduct((Product) _productsBindingSource.Current);
                if (!success)
                {
                    MessageBox.Show("Your message for failed to update");
                }
            }
        }

        private void SaveAllButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SqlOperations.SaveProduct needs you to finish the code");
        }
    }
}
