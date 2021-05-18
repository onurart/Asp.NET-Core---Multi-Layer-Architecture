using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.Model
{
    public class Customer : BaseModel
    {
        public int Id { get; set; }
        public string HesapKodu { get; set; }
        public string Unvan { get; set; }
        public int Firma { get; set; }
        public int Sirket { get; set; }
        public int HesapTuru { get; set; }
        public int HesapTipi { get; set; }
        public string SubeKodu { get; set; }
        public string SubeAdi { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int FaturaCariId { get; set; }
        public string FaturaCariHesapKodu { get; set; }
        public string FaturaCariUnvan { get; set; }
        public string Adres { get; set; }
        public string Adres2 { get; set; }
        public string Sehir { get; set; }
        public string SehirAdi { get; set; }
        public string Ulke { get; set; }
        public string Bolge { get; set; }
        public string Semt { get; set; }
        public string PostaKodu { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string TCNo { get; set; }
        public string Yetkili { get; set; }
        public string YetkiliTel1 { get; set; }
        public string YetkiliTel2 { get; set; }
        public string YetkiliEmail { get; set; }
        public int VadeGun { get; set; }
        public int OdemeGun { get; set; }
        public bool IsPasif { get; set; }
    }
}
