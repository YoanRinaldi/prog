using System;

namespace Defi
{
    class Program
    {
        static void Main(string[] args)
        {
            string texte = "Mb`qsph`d`ftu`m(gvo";
            int cara = 0;
            string texte2 = "";


            for (int i = 0; i < texte.Length; i++)
            {


                cara = Convert.ToInt32(texte[i]);


                cara = cara - 1;
                texte2 = texte2 + Convert.ToChar(cara);

            }
            Console.WriteLine(texte2);
            // c est dur olala
        }
    }
}
