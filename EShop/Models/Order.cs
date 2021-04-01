using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage ="Lütfen Adınızı Giriniz")]
        [Display(Name = "Ad")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        [Display(Name = "Soyad")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Lütfen Adresinizi Giriniz")]
        [Display(Name = "Adres")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Lütfen Şehir Bilgisi Giriniz")]
        [Display(Name = "Şehir")]
        public string City { get; set; }

        [Required(ErrorMessage = "Lütfen Posta Kodu Giriniz")]
        [Display(Name = "Posta Kodu")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz")]
        [Display(Name = "Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }

    }
}
