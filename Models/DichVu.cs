using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace qlks.Models
{
    [Table("DichVu")]
    public class DichVu
    {
        [Key]
        public String MaDV { get; set; }
        public String TenDV { get; set; }
        public String DonGiaVN { get; set; }
    }
}