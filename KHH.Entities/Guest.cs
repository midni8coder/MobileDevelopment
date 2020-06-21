using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHH.Entities
{
    public class Guest
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string AlternateMobile { get; set; }
        public string HomeAddress { get; set; }
        public string HomeCity { get; set; }
        public int HomePinCode { get; set; }
    }
}
