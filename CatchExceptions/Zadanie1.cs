using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    /// <summary>
    /// Bez uruchamiania programu zastanów się jaki wynik będzie wyświetlony na konsoli
    /// </summary>
    public class Zadanie1
    {
        public static void Test()
        {
            try
            {
                throw new ArgumentNullException();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("ArgumentException");
                throw ex;
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("NotImplementedException");
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Koniec");
            }

            Console.WriteLine("Tutaj też koniec");
        }
    }
}
