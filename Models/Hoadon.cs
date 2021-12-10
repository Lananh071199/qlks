using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace qlks.Models
{

    [Table("Hoadon")]
    public class Hoadon
    {
        [Key]
        public String MaHD { get; set; }
        public String MaKH { get; set; }
        public float SoTien { get; set; }
        public string NgayTT { get; set; }
        public String HinhThucTT { get; set; }
    }
}