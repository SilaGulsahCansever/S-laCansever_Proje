using System;

namespace BerkayÖZTEMEL_Final
{
    internal class Odeme
    {
        public Odeme()
        {
        }

        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public DateTime Tarih { get; set; }
        public double Tutar { get; set; }
        public string Tur { get; set; }
        public string Aciklama { get; set; }
    }
}