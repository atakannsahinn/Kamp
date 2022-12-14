using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
		public void BasvuruYap(IKrediManager krediManager) 
        {
            krediManager.Hesapla();
        }

        public void BasvuruYapListe(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        public void BasvuruYapListe(params IKrediManager[] krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
