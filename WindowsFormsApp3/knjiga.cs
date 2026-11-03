using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class knjiga
    {
        public string Naslov;
        public string autor;
        public int godina;

        public knjiga(string naslov, string autor, int godina)
        {
            Naslov = naslov;
            this.autor = autor;
            this.godina = godina;
        }
    }
}
