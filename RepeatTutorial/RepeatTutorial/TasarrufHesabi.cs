using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatTutorial
{
    abstract class Hesap
    {
        private string hesapNumarasi;
        protected decimal bakiye;
        public string HesapNumarasi
        {
            get { return hesapNumarasi; }
        }
        public decimal Bakiye
        {
            get { return bakiye; }
        }
        public Hesap(string hesapNumarasi, decimal bakiye)
        {
            this.hesapNumarasi = hesapNumarasi;
            this.bakiye = bakiye;
        }
        public abstract void ParaYatir(decimal miktar);
        public abstract void ParaCek(decimal miktar);
        public abstract void HesapBilgileriniGoster();
    }
    internal class TasarrufHesabi : Hesap
    {
        public TasarrufHesabi(string hesapNumarasi, decimal bakiye) : base(hesapNumarasi, bakiye)
        {
        }

        public override void ParaYatir(decimal miktar)
        {
            bakiye += miktar;
        }
        public override void ParaCek(decimal miktar)
        {
            if(bakiye - miktar >= 0)
            {
                bakiye -= miktar;
            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye!");   
            }
        }
        public override void HesapBilgileriniGoster()
        {
            Console.WriteLine($"Tasarruf Hesabı: {HesapNumarasi} - Bakiye: {bakiye}");
        }
    }
}
