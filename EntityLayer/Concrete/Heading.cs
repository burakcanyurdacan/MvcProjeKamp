using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        public int ID { get; set; }
        public string HeadingName { get; set; }
        public DateTime AddingDate { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Content> Contents { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
