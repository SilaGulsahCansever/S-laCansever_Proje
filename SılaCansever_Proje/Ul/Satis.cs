using System;

namespace BerkayÖZTEMEL_Final
{
    internal class Satis
    {
        public Satis()
        {
        }

        public Guid ID { get; set; }
        public Guid MusteriID { get; internal set; }
        public Guid UrunID { get; internal set; }
        public double Fiyat { get; internal set; }
        public DateTime Tarih { get; internal set; }
    }
}