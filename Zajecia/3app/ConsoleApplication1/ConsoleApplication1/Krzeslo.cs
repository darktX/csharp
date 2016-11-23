using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Krzeslo
    {
        private int iloscNog;
        public int getIloscNog()
        {
            return this.iloscNog;



        }
        public void setIloscNog(int iloscNog)
        {
            this.iloscNog = iloscNog;
        }

        public int mojaMetoda()
        {
            this.innaMetoda();
            return 1;

        }
        private void innaMetoda()
        {
            Console.WriteLine($"COS{this.iloscNog()}");


        }
    }
}
