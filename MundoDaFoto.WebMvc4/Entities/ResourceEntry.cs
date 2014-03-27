using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.Entities
{
    
    public class ResourceEntry
    {
        public int IdGlobalization { get; set; }
        public string Lang { get; set; }
        public string label { get; set; }
        public string OriginalText { get; set; }
        public string TranslateText { get; set; }


        public ResourceEntry() {
              
        }
    }
}
