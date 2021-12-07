using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_GenericOncesiIslemler
{
    public class SanalDatabase
    {
        private ArrayList Listem;

        public SanalDatabase()
        {
            Listem = new ArrayList();
        }

        public void yeniKayit(int data)
        {
            Listem.Add(data);
        }
    }
}
