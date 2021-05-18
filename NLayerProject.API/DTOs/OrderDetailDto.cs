using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.DTOs
{
    public class OrderDetailDto
    {
        public int Id { get; set; }
        public int Sira { get; set; }
        public string Aciklama { get; set; }
        public string Aciklama2 { get; set; }
        public int StokId { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string Birim { get; set; }
        public decimal Miktar { get; set; }
        public string Birim2 { get; set; }
        public decimal Miktar2 { get; set; }
        public string Birim3 { get; set; }
        public decimal Miktar3 { get; set; }
        public decimal BirimKg { get; set; }
        public decimal Kg { get; set; }
        public decimal BirimDesi { get; set; }
        public decimal Desi { get; set; }
        public decimal BirimM3 { get; set; }
        public decimal M3 { get; set; }
        public string HesapBirim { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar { get; set; }
        public decimal Masraf { get; set; }
        public decimal MasrafNakliye { get; set; }
        public decimal BrutTutar { get; set; }
        public decimal KdvOran { get; set; }
        public decimal Kdv { get; set; }
        public decimal Toplam { get; set; }
        public string DagitimIrsNo { get; set; }
        public string MusteriIrsNo { get; set; }
        public int Durum { get; set; }
        public string KayitBy { get; set; }
        public DateTime KayitDate { get; set; }
        public string DegisBy { get; set; }
        public DateTime DegisDate { get; set; }
        public int OrderId { get; set; }
    }
}
