using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikaUygulamaSenaryosu
{
    class Fabrika
    {
        public string FabrikaAdi;
        public string FabrikaAdresi;
        public List<Personel> Personeller = new List<Personel>();

        public void PersonelEkle(Personel a)
        {
            Personeller.Add(a);
        }

        public List<string> PersonelListele()
        {
           var temp = new List<string>();
            foreach (var Personeller in Personeller)
            {
                temp.Add("Personel No:" + Personeller.PersonelNO + "    Ad:" + Personeller.kimlik.Ad + "    Soyad:" + Personeller.kimlik.Soyad + "    Tc Kimlik No:" + Personeller.kimlik.TCKimlikNo.ToString() + "   Birim:" + Personeller.Birim );
            }
            return temp;
        }
    }
}
