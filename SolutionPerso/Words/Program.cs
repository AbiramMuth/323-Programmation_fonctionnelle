using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

///Abiram Muthulingam
/// 03.09.2025
/// Filtrage des mots
namespace Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liste de mots
            string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune", "exemple", "ab" };

            // enleve les mots qui contienne x et qui ont 4 caractère ou plus
            var selectWords = words.Where(letterX => !letterX.Contains('x'))
                .Where(moreLetter => moreLetter.Length >= 4);
            
            // affiche les mots
            foreach (var word in selectWords)
            {
                Console.WriteLine(word);
            }

            // autant de caractère que la moyenne du nombre de caractère de la liste 
            var listWords = words.Where(averageWord => averageWord.Length == words.Average(w => w.Length));

            // inverse le résultat de base de la liste
            var inverseList = selectWords.Reverse();

            foreach (var word in inverseList)
            {
                Console.WriteLine(word);
            }

            // Trier par ordre alphabetique
            var alphabeticList = selectWords.OrderBy(word => word);

            foreach (var word in alphabeticList)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(word);
            }
            Console.ResetColor();
            // Trier par ordre alphabetique décroissant
            selectWords.OrderByDescending(word => word).ToList().ForEach(w => Console.WriteLine(w));  // .Foreach



            // B.
            string[] words2 = { "whatThe!!!", "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune", "My kingdom for a horse !", "Ooops I did it again" };

            // ordonne par les plus longues phrases et enleve les 3 plus longues
            words2.OrderByDescending(first => first.Length)
                .Skip(3).ToList().ForEach(w => Console.WriteLine(w));

            // C
            string[] words3 = { "+++++", "<<<<<", ">>>>>", "bonjour", "hello", "@@@@", "vert", "rouge", "bleu", "jaune", "#####", "%%%%%%%" };

            // SkipWhile, prends en compte que le début puis, des que la condition est bonne, il s'arrete et ne fais pas la suite.
            // donc la en ordonne pour que tous les caractère spéciaux soient au début puis, !Regex.. permet d'enlever les caractère spéciaux
            Console.ForegroundColor = ConsoleColor.Blue;
            words3.OrderBy(specialCaracter => specialCaracter).SkipWhile(c => !Regex.IsMatch(c, "^[a-zA-Z]")).ToList().ForEach(w => Console.WriteLine(w));

            // D.
            string[] words4 = { "i am the winner", "hello", "monde", "vert", "rouge", "bleu", "i am the looser" };

            // prends le pr
            words4.Take(1).ToList().ForEach(w => Console.Write("The winner is : "+w));
            Console.WriteLine();

            Console.WriteLine("The looser is : " + words4.Last());


            // Partie 2, Epsilon
            double Epsilon (string word)
            {
                // vérifie que la lettre du mot est dans le dictionnaire, regroupe les lettre et calcule, le pourcentage des lettre / par le nombre de fois qu'il y est la lettre
                return word.Where(c => frequences.ContainsKey(c)).GroupBy(c => c).Sum(c => frequences[c.Key] / c.Count());
            }
            Console.WriteLine(Epsilon("HELLO"));



            // Partie 3
            // Comparaison mot anglais et francais
            List<string> frenchWords = new List<string>() {
            "Merci","Hotdog","Oui","Non","Désolé","Réunion","Manger","Boire","Téléphone","Ordinateur","Internet","Email","Sandwich","Hello","Taxi","Hotel","droite","Continuer","Sandwich","Kayak","Paddle"};

            List<string> englishWords = new List<string>()
            {
                "Hotdog", "Internet", "Email", "Sandwich", "Hello", "Taxi", "Hotel",
                "Bus", "Football", "Parking", "Surf", "Plage", "Volleyball"
            };
            // 
            var IdentiqueWord = frenchWords.Where(sameWord => englishWords.Contains(sameWord));
            foreach(var v in IdentiqueWord)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(v);
            }




            Console.Read();
        }
        /// <summary>
        /// Dictionnaire pour la partie 2
        /// </summary>
        static Dictionary<char, double> frequences = new Dictionary<char, double>()
        {
            {'A', 8.15}, {'B', 0.97}, {'C', 3.15}, {'D', 3.73}, {'E', 17.39},
            {'F', 1.12}, {'G', 0.97}, {'H', 0.85}, {'I', 7.31}, {'J', 0.45},
            {'K', 0.02}, {'L', 5.69}, {'M', 2.87}, {'N', 7.12}, {'O', 5.28},
            {'P', 2.80}, {'Q', 1.21}, {'R', 6.64}, {'S', 8.14}, {'T', 7.22},
            {'U', 6.38}, {'V', 1.64}, {'W', 0.03}, {'X', 0.41}, {'Y', 0.28},
            {'Z', 0.15}
        };
    }
}
