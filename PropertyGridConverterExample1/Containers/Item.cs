using System.ComponentModel;

namespace PropertyGridConverterExample1.Containers
{
    public class Item
    {
        [Category("Web site"), Description("Your web site")]
        public string Name { get; set; }
        [Category("Web site"), Description("Your web site")]
        public string Address { get; set; }

        [Category("Personal details"), Description("Your first name")]
        public string FirstName { get; set; }
        [Category("Personal details"), Description("Your last name")]
        public string LastName { get; set; }
    }
}