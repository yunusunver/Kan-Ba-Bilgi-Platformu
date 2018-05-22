using KanBagisiMVC.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace KanBagisiMVC.Kizilay.Entities.Concrete
{
    public class Bagisci:IEntity
    {
        [Required(ErrorMessage = "Lütfen TC kimlik numaranızı giriniz.")]
        [Key]
        public int TcNo{ get; set; }
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Ad{ get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string Soyad{ get; set; }
        [Required(ErrorMessage = "Lütfen E-posta adresinizi giriniz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Eposta{ get; set; }
        [Required(ErrorMessage = "Lütfen Telefon numaranızı giriniz.")]
        public string Telefon{ get; set; }
        
        public string KanGrubu{ get; set; }
        [Required(ErrorMessage = "Lütfen bulunduğunuz şehiri giriniz.")]
        public string Sehir{ get; set; }
        
        public DateTime Tarih { get; set; }
    
    }
}
