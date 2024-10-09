using _6T25_LoukaConstant_ACT2_POO.Classes;

namespace _6T25_LoukaConstant_ACT2_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce programme !");
            
            double rayon;
            double reel;
            double imaginaire;
            string nUser;
            string repeatProg;

            Console.WriteLine("Veuillez choisir quel méthode vous voulez : \n 1. Le cercle \n 2. Nombre complexe \n 3. Sandwich aléatoire \n 4.Persone");
            nUser = Console.ReadLine();


            if (nUser == "1")
            {
                do
                {
                    Console.WriteLine("Le cercle \n");
                    Console.WriteLine("Tapez un rayon pour votre cercle");
                    rayon = double.Parse(Console.ReadLine());
                    Cercle cercle = new Cercle(rayon);

                    Console.WriteLine(cercle.infosCercle());

                    cercle.Rayon = cercle.Rayon / 2;
                    Console.WriteLine("Avec un cercle diminué de moitié : " + cercle.Rayon);

                    Console.WriteLine("Un autre cercle ?");
                    repeatProg = Console.ReadLine();

                } while (repeatProg == "o");
            }

            if (nUser == "2")
            {
                do
                {
                    Console.WriteLine("Programme Nombre Complexe \n");
                    Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
                    reel = double.Parse(Console.ReadLine());

                    Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
                    imaginaire = double.Parse(Console.ReadLine());

                    Complexe complexe = new Complexe(reel, imaginaire);

                    Console.WriteLine($"Le premier complexe : " + complexe.AfficheComplexe() + " a pour module : " + complexe.CalculModule());

                    Console.WriteLine("Que vaut la partie réelle du second complexe ?");
                    reel = double.Parse(Console.ReadLine());

                    Console.WriteLine("Que vaut la partie imaginaire du second complexe ?");
                    imaginaire = double.Parse(Console.ReadLine());

                    Complexe complexe2 = new Complexe(reel, imaginaire);

                    Console.WriteLine($"Le second complexe : " + complexe2.AfficheComplexe());
                    complexe.Ajoute(complexe2);
                    Console.WriteLine($"Le premier complexe devient : " + complexe.AfficheComplexe() + " après ajout du second");

                    Console.WriteLine("Recommencer ?");
                    repeatProg = Console.ReadLine();

                } while (repeatProg == "o");

            }

            if (nUser == "3")
            {
                Console.WriteLine("Bienvenue dans notre concepteur de sandwich !");
                Console.WriteLine("Tapez sur espace pour générer un sandwich !");
                nUser = Console.ReadLine();

                if (nUser == " ")
                {
                    Sandwich sandwich = new Sandwich();
                    Console.WriteLine(sandwich.composeSandwich());
                }

                
            }

            if (nUser == "4")
            {

                Console.WriteLine("Bienvenue dans notre gestionnaire de porte monnaie !");

               
            }

        } 
    }
}