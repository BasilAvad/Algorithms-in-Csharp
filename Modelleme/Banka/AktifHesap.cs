using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Banka
{
    public class AktifHesap : ITransfer
    {
        private decimal _bakiye;
        public decimal Bakiye =>_bakiye;

        public bool Cek(decimal miktar)
        {
            if (_bakiye>=miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\a Bakiye yetersiz!");
            return false;
        }

        public bool TransferYap(IBankaHesap aliciHesap, decimal miktar)
        {
            bool sonuc = Cek(miktar);
            if (sonuc)
            {
                aliciHesap.Yatir(miktar);
            }
            return sonuc;
        }

        public void Yatir(decimal miktar) =>
            _bakiye += miktar;

        public override string ToString()=>
            $"Aktif hesabi bakiye bilgisi{_bakiye,6:C}";
    }
}
