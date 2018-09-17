using System;

namespace Projet
{
    class Program
    {
        static void Scenario1()
        {
            Console.Clear();
            int reponse = 0;
            Console.WriteLine("Tu t approche du trader qui est sur son pc et le questionne mais par quel methode vas tu y aller \n 1.Etre direct et lui demander son nom prenom et pourquoi il va jusqu au terminus \n 2. Lui parler du trading essayer de sympatiser pour avoir des info plus en profondeur et peut etre t en faire un allier ");
            reponse = Convert.ToInt32(Console.ReadLine());
            if (reponse == 1)
            {
                Console.WriteLine("Oh de 1 qu est ce qui te fais croire aue je vais au terminus de 2 tu te prend pour qui salle pauvre aller part  de la et de 3 goldenMan a un appel a passer ");
                Console.WriteLine("Bravo Capitaine bourrin tu en a fait ton ennemie maintenant ! tu a interet de gerer avec les autres ou je fais du mal a ta famille ");
            }
            else
            {
                Console.WriteLine("Tu veux quoi toi je bosse pour une grande banque je traite pas avec les gens de ton genre maintenant laisse moi tranquille goldenMan a un appelle a passer et qui ta dit aue j allais au terminus ");
                Console.WriteLine("Bon il est pqs gentil gentil lui... mais il ta donner une ou deux info quand meme ");
            }
            Console.WriteLine("Quel personnage voulez vous choisir pour interroger maintenant?\n 1.Trader \n 2.Infirmiere \n 3.Gothique \n 4.Musicien \n 5.Mysterieux \n 6.Bucheron ");
            reponse = Convert.ToInt32(Console.ReadLine());
            Repartiton(reponse);
        }
        static void Scenario2()
        {
            Console.Clear();
            int reponse = 0;
            Console.WriteLine("Bon elle est vraiment attacher a son sac va falloir adopter une methode specifique je pense  \n 1.Essayer de voler son sac de force attention tu peux attirer la police si on te repere  \n 2.Essayer une methode maline en racontant un mensonge pour aue le controleur fouille son sac et prends son nom ");
            reponse = Convert.ToInt32(Console.ReadLine());
            if (reponse == 1)
            {
                Console.WriteLine("Elle t apercois tourner autour de son sac et previensles controleur cache toi vite ! \n 1. Sous les sieges \n 2. au toilette  ");
                reponse = Convert.ToInt32(Console.ReadLine());
                if (reponse == 1)
                {
                    Console.WriteLine("tu es trop gros pour passer sous les siege imbecile ! On va dire que tu a fait le choix numero deux car je ne pensais pas que tu etais si long a la detente ! bien jouer tu tes cacher dans les toilettes et tu as esquiver le controleur ");
                }
                else
                {
                    Console.WriteLine("Bien jouer tu tes cacher dans les toilettes et tu as esquiver le controleur, tu es plus malin que ce que je pensais.");

                }
            }
            else
            {
                Console.WriteLine("Le controleur accepte de la controler grace a tes beau yeux doux mais l infirmiere connais ses droits et dit d aller se faire un cafer au controleur dommage bien tenter mais ca t apprends quel y tien beaucoup a son sac ");

            }
            Console.WriteLine("Quel personnage voulez vous choisir pour interroger maintenant?\n 1.Trader \n 2.Infirmiere \n 3.Gothique \n 4.Musicien \n 5.Mysterieux \n 6.Bucheron ");
            reponse = Convert.ToInt32(Console.ReadLine());
            Repartiton(reponse);
        }
        static void Scenario3()
        {
            Console.Clear();
            int reponse = 0;
            Console.WriteLine("Tu t assoie a coter d elle et tu hesite a l approcher grace au etude de ton fils ou alors avec la photographie pour son sac /n 1.Fils /n 2.Photographie ");
            reponse = Convert.ToInt32(Console.ReadLine());
            if (reponse == 1)
            {
                Console.WriteLine("Tu lui fait croire qu elle est l ex de ton fils mais elle te dit qu elle est lesbienne et te prend pour un pedophile, elle part tu la suit et quand vous etes seul tu lui enleves... son sac il tombe mais tu vois que c est juste des faux permis et tu la laisse partir ");
            }
            else
            {
                Console.WriteLine("Tu lui fait croire que tu es un photographe mais elle a peur et  part tu la suit et quand vous etes seul tu lui enleves... son sac il tombe mais tu vois que c est juste des faux permis et tu la laisse partir ");
            }
            Console.WriteLine("Quel personnage voulez vous choisir pour interroger maintenant?\n 1.Trader \n 2.Infirmiere \n 3.Gothique \n 4.Musicien \n 5.Mysterieux \n 6.Bucheron ");
            reponse = Convert.ToInt32(Console.ReadLine());
            Repartiton(reponse);
        }
        static void Scenario4()
        {
            Console.Clear();
            int reponse = 0;
            Console.WriteLine("Tu t avance dans le wagon mais entre 2 wagon on t agresse c est l homme Mysterieux il en a apres toi, tu te defend tant bien aue mal mais tu arrives le faire tombee dans le wagon suivant et donc il tel ache , le Musicien viens t aider a te relever et vous discuter un peu de l agression et vous sympatiser bien sa sera surment un grand allier pour plus tard  ");
            Console.WriteLine("Quel personnage voulez vous choisir pour interroger maintenant?\n 1.Trader \n 2.Infirmiere \n 3.Gothique \n 4.Musicien \n 5.Mysterieux \n 6.Bucheron ");
            reponse = Convert.ToInt32(Console.ReadLine());
            Repartiton(reponse);
        }
        static void Scenario5()
        {
            Console.Clear();
            int reponse = 0;
            Console.WriteLine("Tu le suit dans les wagons mais il te remarque et te prend a parti, tu hesite a lui dire Jail pour le faire tilter\n 1.Dire Jail \n 2.Ne rien dire et repartir ");
            reponse = Convert.ToInt32(Console.ReadLine());
            if (reponse == 1)
            {
                Console.WriteLine("Vous vous tappez mais les controleurs arrive vous separer, heureusement pour vous d ailleurs");
            }
            else
            {
                Console.WriteLine(" Vous partez et retrouver son sac seul dans le wagon et le fouiller ... Vous trouver des chemise calecon god et une plaque du FBI et un gun. ET vous trouvez son cadavre cacher sous le wagon ");
            }
            Console.WriteLine("Quel personnage voulez vous choisir pour interroger maintenant?\n 1.Trader \n 2.Infirmiere \n 3.Gothique \n 4.Musicien \n 5.Mysterieux \n 6.Bucheron ");
            reponse = Convert.ToInt32(Console.ReadLine());
            Repartiton(reponse);
        }
        static void Scenario6()
        {
            Console.Clear();
            int reponse = 0;
            Random rnd = new Random();
            int poker = rnd.Next(1, 3);
            Console.WriteLine("Tu le vois jouer au poker avec un ami a toi, tu decide de rejoindre le jeu pour lui soutirer son nom etc que demander en premier ? \n1.Sa destination que tu connais deja \n 2.Son prenom  ");
            reponse = Convert.ToInt32(Console.ReadLine());
            if (reponse == 1)
            {
                Console.WriteLine("Il vous dit qu il va comme d habitude au terminus et cela te choque car tu ne pensais pas que c etait un client regulier donc cela l elimine de la liste");
            }
            else
            {
                Console.WriteLine(" Il dit que tu saura son prenom si tu gagne la parti Bonne chance tu as une chance sur trois");
                if (poker == 2)
                {
                    Console.WriteLine(" Bien jouer tu as gagner il s appelle nounours et il prend se train toute les semaine avec ca carte d habituer qui te montre pour prouver son identiter");
                }
                else
                {
                    Console.WriteLine(" Perdu reviens une prochaine fois");
                }


            }
            Console.WriteLine("Quel personnage voulez vous choisir pour interroger maintenant?\n 1.Trader \n 2.Infirmiere \n 3.Gothique \n 4.Musicien \n 5.Mysterieux \n 6.Bucheron ");
            reponse = Convert.ToInt32(Console.ReadLine());
            Repartiton(reponse);
        }
        static void Repartiton(int reponse)
        {
            if (reponse == 1)
            {
                Scenario1();
            }
            else if (reponse == 2)
            {
                Scenario2();
            }
            else if (reponse == 3)
            {
                Scenario3();
            }
            else if (reponse == 4)
            {
                Scenario4();
            }
            else if (reponse == 5)
            {
                Scenario5();
            }
            else if (reponse == 6)
            {
                Scenario6();
            }

        }
        static void Main(string[] args)

        {
            int reponse;

            bool sorti = false;
            Console.WriteLine("Vous prenez votre train de banlieu comme tous les matin, vous arrivez au  boulot vous travaillez comme d habitude, en utilisant encore et encore le meme speach sur votre famille pour toucher le client pour arriver a votre fin, lui faire prendre une assurance.Mais aujourd hui juste apres la pause du midi votre patron veux vous voir, il vous annonce que vous ne rapporter plus aasez a l entreprise et vous vire. Depiter vous n avez pas le courage de l annoncer a votre femme et votre fils aui en plus doit partir a l universite...Vous en parlez devant un verre a votre ex coequipiee qui vous rappel vos heur de gloire dans la police.Vous reprenez votre train de banlieu mais ce coup si quelau un s assois a coter de vous et vous dit : ");
            while (sorti == false)
            {
                Console.WriteLine("Hey mon chere ami, on va jouer a un petit jeu hypothetique toi et moi ");
                Console.WriteLine("Tu a relever le defi,la mission est simple,un passager de ce train est un intru trouve le, 3 indice sont a ta disposition, il ou elle va jusqu au terminus , il ou elle a un sac et repond sous le nom de Jail.Trouve ta premiere recompense au toilette. ");
                Console.WriteLine("1. Fuir // 2. Aller chercher l argent");
                reponse = Convert.ToInt32(Console.ReadLine());
                if (reponse == 1)
                {
                    sorti = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Tu te retrouve dans les toilettes et cherche la recompense.Par ou commencer : \n 1.Cuvette // 2.Poubelle // 3.Grille d aeration // 4.Evier // 5.Seche main ");
                    reponse = Convert.ToInt32(Console.ReadLine());
                    if (reponse != 3)
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Louper recommence: \n 1.Cuvette // 2.Poubelle // 3.Grille d aeration // 4.Evier // 5.Seche main ");
                            reponse = Convert.ToInt32(Console.ReadLine());
                        } while (reponse != 3);
                    }
                    Console.Clear();
                    Console.WriteLine("Bien jouer tu as trouver la recompense et c eest 25 000 dollar et tu peux te faire jusqu a 100 000 en trouvant la personne. Maintenant tu passes dans tous les wagons et repere les non habituer aui vont au termimus grace au billet eticter sur les sieges . ");
                    Console.WriteLine("Tu en a trouver 6 :\n 1.Trader qui genait tellement la fille sur la place qu elle est parti et llui a laisser la place on va l appeler le trader \n 2.Une infirmiere qui est scotcher a son portable et son sac on va l appeler l infirmiere \n 3.une jeune fille qui c est engueuler avec son copain et possede un sac pour appareil photo on va l appeler la gothique \n 4. un afro americain qui a un etuie a guitard on va l appeler le musicien \n 5. Un homme rentrer precipitament dans le train tous en noir avec un gros sac noir egalement on va l appeler le mysterieux \n 6. un homme avec des tatouage un sac normal mais il est assez baraquer on l appelera le bucheron ");
                    Console.WriteLine("Quel personnage voulez vous choisir pour interroger en premier?\n 1.Trader \n 2.Infirmiere \n 3.Gothique \n 4.Musicien \n 5.Mysterieux \n 6.Bucheron ");
                    reponse = Convert.ToInt32(Console.ReadLine());
                    Repartiton(reponse);
                }
            }
        }

    }
}
