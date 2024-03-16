using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah kodebuah = new KodeBuah();

            Console.WriteLine(kodebuah.getKodeBuah(KodeBuah.daftarBuah.Ceri));
            Console.WriteLine(kodebuah.getKodeBuah(KodeBuah.daftarBuah.Apel));
            Console.WriteLine(kodebuah.getKodeBuah(KodeBuah.daftarBuah.Melon));
        }
    }
}
