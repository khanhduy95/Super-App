using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperApp.Core
{
    public class BaseEntiy : Base
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedUtc { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LasteModifiedUtc { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedUtc { get; set; }
    }
}
