using System.ComponentModel.DataAnnotations;

namespace UrunSatisSitesi.Entities
{
    public class News : IEntity
    {
        public int Id { get ; set ; }
        [Display(Name = "Kategori Ad"), Required(ErrorMessage = "{0} Boş Geçilemez")]
        public string Name { get; set; }
        [Display(Name = "Açıklama"), DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        [Display(Name = "Aktif?")]
        public bool IsActive { get; set; }

       
    }
}
