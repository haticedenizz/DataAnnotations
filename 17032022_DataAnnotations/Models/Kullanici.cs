using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17032022_DataAnnotations.Models
{
    public class Kullanici
    {
        [DisplayName("Adınız")]
        public string Ad { get; set; }

        [DisplayName("Soyadınız")]
        public string Soyad { get; set; }

        [DisplayName("Yaşınız"),
         Required(ErrorMessage ="Lütfen {0} değerini giriniz."),
         Range(10,90,ErrorMessage ="{0} değeri {1} ile {2} arasında olmalıdır.")]
        public int Yas { get; set; }

        [DisplayName("Kullanıcı Adı"),
         Required(ErrorMessage ="Lütfen bir {0} giriniz."),
         MinLength(5,ErrorMessage ="{0} en az {1} karakter olmalıdır."),
         MaxLength(15,ErrorMessage ="{0} en fazla {1} karakter olmalıdır.")]
        public string KullaniciAdi { get; set; }

        [DisplayName("Şifre"),
            Required(ErrorMessage = "Lütfen {0} giriniz"),
            MinLength(6, ErrorMessage = "{0} en az {1} karakter olmalıdır."),
            MaxLength(10, ErrorMessage = "{0} adı en fazla {1} karakter olmalıdır."),DataType(DataType.Password)]
        public string Sifre { get; set; }

        [DisplayName("Şifre(Tekrar)"), Required(ErrorMessage = "Lütfen {0} giriniz"),
            MinLength(6, ErrorMessage = "{0} en az {1} karakter olmalıdır."),
            MaxLength(10, ErrorMessage = "{0} adı en fazla {1} karakter olmalıdır."), DataType(DataType.Password),Compare(nameof(Sifre))]
        public string Sifre2 { get; set; }

        [DisplayName("E-posta"),
            Required(ErrorMessage ="Lütfen {0} giriniz"),
            MaxLength(60),EmailAddress()]
        
        //        RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]")
        public string Email { get; set; }

        [DisplayName("E-posta(Tekrar)"), Required(ErrorMessage = "Lütfen {0} giriniz"), MaxLength(60), EmailAddress(), Compare(nameof(Email))]
        public string Email2 { get; set; }

        [DisplayName("Takımınız"),MaxLength(20)]
        public string Takiminiz { get; set; }




    }
}