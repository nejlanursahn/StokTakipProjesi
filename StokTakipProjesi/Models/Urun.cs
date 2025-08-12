using System.ComponentModel.DataAnnotations;

namespace StokTakipProjesi.Models
{
    public class Urun
    {
   
        [Key]
        public int Id { get; set; }

        [Required]
        public string Ad { get; set; }

        public int Stok { get; set; }

        public decimal Fiyat { get; set; } // isteğe bağlı
    }
}
