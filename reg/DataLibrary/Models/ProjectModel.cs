using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ProjectModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortdescription { get; set; }
        public string fulldescription { get; set; }
        public string owner { get; set; }
    }
}
