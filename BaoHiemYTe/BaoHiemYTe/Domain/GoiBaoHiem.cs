using System.ComponentModel.DataAnnotations;

namespace BaoHiemYTe.Domain
{
    public class GoiBaoHiem
    {
        [Key]
        public int MaGoiBH { get; set; }
        public string TenGoiBH { get; set; }
        public int Gia { get; set; }
        public int TiLeHoanTien { get; set; }
    }
}
