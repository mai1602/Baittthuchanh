using System.ComponentModel.DataAnnotations;

namespace baithuchanh.Models
{
    public class LopHoc{
        [Key]
        public string MaLop { get; set; }
        
        public string TenLop { get; set; }
        
    }
}