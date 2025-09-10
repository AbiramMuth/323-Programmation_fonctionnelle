using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mib_map.Program;

namespace mib_map
{
    internal class Program
    {
        public class Product
        {
            public int Location { get; set; }  // Emplacement du produti
            public string Producer { get; set; }  // Producteur
            public string ProductName { get; set; } // Nom du produti
            public int Quantity { get; set; } // nbr Quantité
            public string Unit { get; set; } // l'unité (kg,pièce)
            public double PricePerUnit { get; set; } // prix par unité
        }
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>
{
    new Product { Location = 1, Producer = "Bornand", ProductName = "Pommes", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Poires", Quantity = 16,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Pastèques", Quantity = 14,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Melons", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Noix", Quantity = 20,Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Raisin", Quantity = 6,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Pruneaux", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Myrtilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            };

            // selectionne les 3 première lettres du producteur + "..." et ajoute la dernière lettre du producteur
            var firstThreeLetter = String.Join("", products.Select(producer => producer.Producer.Substring(0, Math.Min(producer.Producer.Length, 3)) + "..." + producer.Producer.Substring(producer.Producer.Length - 1) + "\n"));
            // Console.Write(firstThreeLetter);


            var i18n = new Dictionary<string, string>()
{
    { "Pommes","Apples"},
    { "Poires","Pears"},
    { "Pastèques","Watermelons"},
    { "Melons","Melons"},
    { "Noix","Nuts"},
    { "Raisin","Grapes"},
    { "Pruneaux","Plums"},
    { "Myrtilles","Blueberries"},
    { "Groseilles","Berries"},
    { "Tomates","Tomatoes"},
    { "Courges","Pumpkins"},
    { "Pêches","Peaches"},
    { "Haricots","Beans"}
};
            // Affiche les fruit en anglais en plus simple
            // .Key (correspond à la première colonne du dictionnaire), .Value (correspond à la deuxième)
            //var englishFruit = String.Join(", ", i18n.Select(fruit => fruit.Value));
            //Console.WriteLine(englishFruit);



            //// Le chiffre d’affaire maximum possible de la journée avec cet aliment (CA = Quantity * PricePerUnit)
            //var ca = String.Join(", ", products.Select(chiffre => chiffre.Quantity * chiffre.PricePerUnit + "CHF"));
            //Console.WriteLine(ca);

            // Tout en 1
            var result = new List<string>();
            result.AddRange(products.Select
            (producer =>
             {
                string producerName = producer.Producer.Substring(0, Math.Min(producer.Producer.Length, 3)) + "..." + producer.Producer.Substring(producer.Producer.Length - 1);
                string englishFruit = i18n.ContainsKey(producer.ProductName) ? i18n[producer.ProductName] : "[Unknown]"; // c'est ca var englishFruit = String.Join(", ", i18n.Select(fruit => fruit.Value));
                double ca = producer.Quantity * producer.PricePerUnit;

                return $"{producerName}\t{englishFruit}\t{ca}";
             }

                    ));
            result.ForEach(line => Console.WriteLine(line));




            // Dashboard
            // Affiche la premiere lettre puis e nombre de caractère puis la derniere lettre du producteur
            var anonymisation = String.Join("", products.Select(producer => producer.Producer.Substring(0, Math.Min(producer.Producer.Length, 1)) + producer.Producer.Length + producer.Producer.Substring(producer.Producer.Length - 1) + "\n"));
            Console.Write(anonymisation);

            // Affichag edes des classemenet des stock
            var classement = String.Join("", products.Select(stock => stock.Quantity < 10 ? "stock faible" : stock.Quantity >= 10 && stock.Quantity <= 15 ? "stock normal" : stock.Quantity > 15 ? "stock élevé" : ""));

            Console.WriteLine(classement);


            // Augmentation du prix selon le classement 
            var price = String.Join(", ", products.Select(stock => stock.Quantity < 10 ?  stock.PricePerUnit * 1.15 : stock.Quantity >= 10 && stock.Quantity <= 15 ? stock.PricePerUnit * 1.05 : stock.PricePerUnit));

            Console.WriteLine(price);


            // INdicatuer de rentabilité
            //double ca = producer.Quantity * producer.PricePerUnit;





            Console.Read();

        }
    }
}
