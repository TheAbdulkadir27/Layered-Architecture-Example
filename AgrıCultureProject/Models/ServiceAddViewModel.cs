using System.ComponentModel.DataAnnotations;

namespace AgrıCultureProject.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık Alanı Boş Geçilemez")]
        public string title { get; set; }
        [Display(Name ="Açıklama")]
        [Required(ErrorMessage ="Açıklama Alanı Boş Geçilemez!")]
        public string Description { get; set; }

        [Display(Name ="Görsel Alanı")]
        [Required(ErrorMessage ="Lütfen Görsel Alanına Yazı Giriniz!")]
        public string İmage { get; set; }
    }
}
