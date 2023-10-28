using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatTutorial
{
    internal class VadesizHesap : Hesap
    {
        public VadesizHesap(string hesapNumarasi, decimal bakiye) : base(hesapNumarasi, bakiye) { }
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
            Console.WriteLine   ($"Vadesiz Hesap: {HesapNumarasi} - Bakiye: {bakiye}");
        }

    }
}
