using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NLayerProject.Core.Model
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new Collection<OrderDetail>();
        }

        public int Id { get; set; }
        public int SiparisBagId { get; set; }
        public int Firma { get; set; }
        public int Sirket { get; set; }
        public int KayitTipi { get; set; }
        public int EvrakTipi { get; set; }
        public int Tip { get; set; }
        public int Tur { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
        public DateTime Termin { get; set; }
        public string Seri { get; set; }
        public string SeriNo { get; set; }
        public int GonderenId { get; set; }
        public string GonderenUnvan { get; set; }
        public int GonderenFaturaAdresId { get; set; }
        public string GonderenFaturaAdresUnvan { get; set; }
        public int YuklemeHesapId { get; set; }
        public string YuklemeHesapUnvan { get; set; }
        public int YuklemeAdresId { get; set; }
        public string YuklemeAdresFaturaUnvan { get; set; }
        public string YuklemeSehir { get; set; }
        public string YuklemeSehirAdi { get; set; }
        public string YuklemeSube { get; set; }
        public string YuklemeSubeAdi { get; set; }
        public int AliciId { get; set; }
        public string AliciUnvan { get; set; }
        public int AliciFaturaAdresId { get; set; }
        public string AliciFaturaAdresUnvan { get; set; }
        public int AliciTeslimAdresId { get; set; }
        public string AliciTeslimAdresUnvan { get; set; }
        public string AliciTeslimSehir { get; set; }
        public string AliciTeslimSehirAdi { get; set; }
        public string AliciTeslimSube { get; set; }
        public string AliciTeslimSubeAdi { get; set; }
        public int NakliyeHesapId { get; set; }
        public string NakliyeHesapUnvan { get; set; }
        public int NakliyeHesapFaturaId { get; set; }
        public string NakliyeHesapFaturaUnvan { get; set; }
        public int FiyatTipi { get; set; }
        public int OdemeSekli { get; set; }
        public int OdmeTuru { get; set; }
        public int TeslimTipi { get; set; }
        public int FaturaTip { get; set; }
        public string Aciklama { get; set; }
        public string Aciklama2 { get; set; }
        public string Aciklama3 { get; set; }
        public int ProjeId { get; set; }
        public int AltProjeId { get; set; }
        public bool Iptal { get; set; }
        public bool Silindi { get; set; }
        public string SilmeNedeni { get; set; }
        public string KayitBy { get; set; }
        public DateTime KayitDate { get; set; }
        public string DegisBy { get; set; }
        public DateTime DegisDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
