using System;
namespace Bellator.Models
{
    public class ProblematicItem
    {
        public string OriginalName { get; set; }
        public string ConvertTo { get; set; }

        public ProblematicItem(string name, string convertTo)
        {
            this.OriginalName = name;
            this.ConvertTo = convertTo;
        }
    }
}
