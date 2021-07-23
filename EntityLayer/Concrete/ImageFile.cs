using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ImageFile
    {
        [Key]
        public int ImgId { get; set; }
        [StringLength(100)]
        public string ImgName { get; set; }
        [StringLength(250)]
        public string ImgPath { get; set; }
    }
}
