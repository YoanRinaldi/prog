using System;

namespace BlackJack
{
    class Program
    {
        static int Carte(int score)
        {
            int carte = 0;
            
            Random rnd = new Random();
            carte= rnd.Next(2, 12);

            score = carte + score;
            return score;
        }
        static bool BJ(bool test,int score)
        {
            if(score>21)
            {
                test = true;

            }
            return test;
        }
        static void Main(string[] args)
        {
            int valeurJ = 100;
            int scoreJ = 0;
            int scoreI = 0;
            int valeurM = 0;
            int choix = 0;
            
            bool test = false;
            while(valeurJ>0){


                Console.WriteLine("Hello tu mises combien");
                valeurM = Convert.ToInt32(Console.ReadLine());
                valeurJ = valeurJ - valeurM;
                if (valeurJ < 0)
                {
                    Console.WriteLine("Tu as pas assez desole");

                }
                scoreJ = Carte(scoreJ);
                scoreJ = Carte(scoreJ);
                scoreI = Carte(scoreI);
                scoreI = Carte(scoreI);
                //Tour Joueur
                Console.WriteLine("tu as un score de " + scoreJ + " et la bank a " + scoreI);
                Console.WriteLine("Tu t arretes (1) ou tu relance (2)");
                choix = Convert.ToInt32(Console.ReadLine());
                if (choix == 2)
                {
                    scoreJ = Carte(scoreJ);
                    Console.WriteLine("tu as un score de " + scoreJ + " et la bank a " + scoreI);


                }

                //Tour IA lol mdr xd

                test = BJ(test, scoreJ);
                if (test)
                {
                    Console.WriteLine("Tu as depasser 21 perdu");
                }
                else
                {
                    Console.WriteLine("C est le tour de la bank");
                    if (scoreI >= scoreJ)
                    {
                        Console.WriteLine("Tu n as pas plus que la bank perdu");
                    }
                    else
                    {
                        do
                        {
                            scoreI = Carte(scoreI);
                            Console.WriteLine("tu as un score de " + scoreJ + " et la bank a " + scoreI);

                        } while (scoreI < scoreJ);

                    }
                }

                if(scoreI>21)
                {
                    valeurJ = valeurJ + valeurM * 2;
                    Console.WriteLine("Tu as gagner car tu as " + scoreJ + " et la bank a " + scoreI + " donc ta mise est de " + valeurJ);
                }

                else if (scoreJ > scoreI && scoreJ <= 21)
                    {
                        valeurJ = valeurJ + valeurM * 2;
                        Console.WriteLine("Tu as gagner car tu as " + scoreJ + " et la bank a " + scoreI+" donc ta mise est de "+valeurJ);
                    }
                    else
                    {
                        Console.WriteLine("Tu as perdu car tu as " + scoreJ + " et la bank a " + scoreI + " donc ta mise est de " + valeurJ);

                    }

                scoreJ = 0;
                scoreI = 0;
            }
            

            


        }
    }
}
