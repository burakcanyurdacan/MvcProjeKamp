using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId{ get; set; }

        [StringLength(500)]
        public string Details1 { get; set; }

        [StringLength(1000)]
        public string Details2 { get; set; }

        [StringLength(100)]
        public string AboutImg1 { get; set; }

        [StringLength(100)]
        public string AboutImg2 { get; set; }
    }
}