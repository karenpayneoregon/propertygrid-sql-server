using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace PropertyGridSqlServer.Classes
{
    public class Product
    {
        [Category("Product"), Browsable(false)]
        public int ProductID { get; set; }
        
        [DisplayName("Name"), Category("Product"), Description("")]
        public string ProductName { get; set; }
        
        [DisplayName("Quantity Per Unit"), Category("Product"), Description("")]
        public string QuantityPerUnit { get; set; }
        
        [DisplayName("Unit Price"), Category("Product"), Description("")]
        public decimal? UnitPrice { get; set; }
        
        [DisplayName("Units In Stock"), Category("Product"), Description("")]
        public short? UnitsInStock { get; set; }
        
        [DisplayName("Reorder Level"), Category("Product"), Description("")]
        public short? ReorderLevel { get; set; }
        
        [Category("Product"), Description("")]
        [DisplayName("Discontinued Date"), 
         EditorAttribute(typeof(DateTimePickerEditor), typeof(UITypeEditor))]
        public DateTime? DiscontinuedDate { get; set; }
        public override string ToString() => ProductName;

    }
}
