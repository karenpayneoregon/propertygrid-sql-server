using System.ComponentModel;

namespace PropertyGridSqlServer.Classes
{
    public class AppProperties
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
