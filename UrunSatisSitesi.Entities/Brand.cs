using System.ComponentModel.DataAnnotations;

namespace UrunSatisSitesi.Entities
{
    public class Brand: IEntity
    {
        public int Id { get; set; }
        [Display(Name="Marka Ad"), Required(ErrorMessage = "{0} Boş Geçilemez")]
        public string Name { get; set; }
        [Display(Name = "Açıklama"), DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        public string? Logo { get; set; }
        [Display(Name = "Aktif?")]
        public bool IsActive { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public ICollection<Product> Products { get; set; }
        public Brand()
        {
            Products = new List<Product>();
        }

    }
}
