using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyGridConverterExample1.Classes;
using PropertyGridConverterExample1.Containers;

namespace PropertyGridConverterExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid.PropertyValueChanged += PropertyGridOnPropertyValueChanged;
        }

        private void PropertyGridOnPropertyValueChanged(object s, PropertyValueChangedEventArgs args)
        {
            switch (args.ChangedItem.Label)
            {
                case "Address" when !WebAddressHelper.UrlChecker3(args.ChangedItem.Value.ToString()):
                case "Name" when string.IsNullOrWhiteSpace(args.ChangedItem.Value.ToString()):
                    InvalidMessageAndResetToLastValue(args);
                    break;
            }
        }

        private void InvalidMessageAndResetToLastValue(PropertyValueChangedEventArgs e)
        {
            e.ChangedItem.PropertyDescriptor.SetValue(propertyGrid.SelectedObject, e.OldValue);
            MessageBox.Show(@"Wrong Data", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void AssignGoodButton_Click(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = null;
            
            var item = new Item()
            {
                FirstName = "Karen",
                LastName = "Payne",
                Name = "ABC", 
                Address = "https://stackoverflow.com/questions/"
            };
            
            if (WebAddressHelper.UrlChecker3(item.Address))
            {
                propertyGrid.SelectedObject = item;
            }
            else
            {
                MessageBox.Show(@"Invalid address");
            }
        }

        private void AssignBadButton_Click(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = null;
            
            var item = new Item()
            {
                FirstName = "Karen", 
                LastName = "Payne",
                Name = "ABC", 
                Address = "http://foo.bar?q=Spaces should be encoded"
            };
            
            if (WebAddressHelper.UrlChecker3(item.Address))
            {
                propertyGrid.SelectedObject = item;
            }
            else
            {
                MessageBox.Show(@"Invalid address");
            }
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            var current = (Item) propertyGrid.SelectedObject;
            Console.WriteLine();
        }
    }
}
