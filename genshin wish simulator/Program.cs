using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genshin_wish_simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int sans;
            int welcome_home;

            int home_wish = 0;      
            int min_top = 10000, max_top = 0;

            //int hedef_karakter = 0;
            int sıradan_karakter = 0;
            for(int i = 1; i <21; i++)
            {

                int c = 0;
                Boolean muhafaza = false;
                int ara_wish = 0;
                int top_wish = 0;
                int rate_up = 0;
                Console.WriteLine("*---------------------------------------------------------------------*");

                while (c < 7)
                {
                    sans = rnd.Next(1, 1000);
                    if (muhafaza == false)
                    {
                        ara_wish++;
                        if (ara_wish <= 75)
                        {
                            if (sans <= 6)
                            {
                                welcome_home = rnd.Next(1, 100);
                                if (welcome_home <= 50)
                                {
                                    c++;
                                    top_wish = top_wish + ara_wish;
                                    Console.WriteLine("Dongu {0} // C{1} // Mevcut toplam wish = {2} // Ara wish = {3}", i, c, top_wish, ara_wish);
                                    ara_wish = 0;                                    
                                }
                                else
                                {
                                    sıradan_karakter++;
                                    muhafaza = true;
                                    Console.WriteLine("rate up");
                                    rate_up = ara_wish;
                                    
                                }
                            }
                        }
                        else
                        {
                            if (sans <= 324)
                            {
                                welcome_home = rnd.Next(1, 100);
                                if (welcome_home <= 50)
                                {
                                    c++;
                                    top_wish = top_wish + ara_wish;
                                    Console.WriteLine("Dongu {0} // C{1} // Mevcut toplam wish = {2} // Ara wish = {3}", i, c, top_wish, ara_wish);
                                    ara_wish = 0;
                                }
                                else
                                {
                                    sıradan_karakter++;
                                    muhafaza = true;
                                    top_wish = top_wish + ara_wish;
                                    ara_wish = 0;
                                }
                            }
                        }
                    }
                    else
                    {
                        ara_wish++;
                        if (ara_wish-rate_up <= 75)
                        {
                            if (sans <= 6)
                            {
                                c++;
                                top_wish = top_wish + ara_wish;
                                Console.WriteLine("Dongu {0} // C{1} // Mevcut toplam wish = {2} // Ara wish = {3}", i, c, top_wish, ara_wish);
                                ara_wish = 0;
                                muhafaza = false;
                            }
                        }
                        else
                        {
                            if (sans <= 324)
                            {
                                c++;
                                top_wish = top_wish + ara_wish;
                                Console.WriteLine("Dongu {0} // C{1} // Mevcut toplam wish = {2} // Ara wish = {3}", i, c, top_wish, ara_wish);
                                ara_wish = 0;
                                muhafaza = false;
                            }
                        }
                    }

                }

                
                if(top_wish < min_top)
                {
                    min_top = top_wish;
                }
                if(top_wish > max_top)
                {
                    max_top = top_wish;
                }


                home_wish = home_wish + top_wish;

            }
            Console.WriteLine("Ortalama wish = {0} // Max wish {1} // Min wish {2}", home_wish/20, max_top, min_top);
        }
    }
}
