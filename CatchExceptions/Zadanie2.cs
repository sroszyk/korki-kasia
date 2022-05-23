using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    /// <summary>
    /// Zmodyfikuj kod w taki sposób aby program nie zakończył swojego działania z błędem - trzeba złapać wyjątek oraz żeby w FinalFunkcja dostępny był obiekt wyjątku z poprawnym StackTracem - właściwość ex.StackTrace
    /// </summary>
    public class Zadanie2
    {
        public void Funckja1()
        {
            throw new NotImplementedException("Funckja1");
        }

        public void Funkcj2()
        {
            Funckja1();
        }

        public void Funkcj3()
        {
            Funkcj2();
        }

        public void Funkcj4()
        {
            Funkcj3();
        }

        public void FinalFunkcja()
        {
            Funkcj4();
        }

    }
}
