using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012
{
    public class Versenyző
    {

        float[] dobasok=new float[4];

        public Versenyző(String csvsor)
        {
            var mezok = csvsor.Split(";");
            Nev = mezok[0];
            Csoport = mezok[1][0];
            Nemzet_es_Kod = mezok[2];
            for (int i = 0; i <3; i++)
            {
                if (mezok[3+i][0] == 'X')
                {
                    dobasok[i] = -1;
                }
                else if (mezok[3+i][0] == '-')
                {
                    dobasok[i] = -2;
                }
                else
                {
                    dobasok[i] = float.Parse(mezok[3]);
                }
                

            }

           
        }

      

        public String Nev { get; set; }
        public char Csoport { get; set; }
        public String Nemzet_es_Kod { get; set; }
        public float D1 { get =>this.dobasok[1]; }
        public float D2 { get => this.dobasok[2]; }
        public float D3 { get => this.dobasok[3]; }

        //7.
        public float Eredmeny()
        {
            return dobasok.Max();
        }

        public String Nemzet => this.Nemzet_es_Kod.Substring(0,this.Nemzet_es_Kod.IndexOf('(')-1);
        public String Kod => this.Nemzet_es_Kod.Substring(this.Nemzet_es_Kod.IndexOf('(') + 1,3);
    }
}
