using System.Linq;


// See https://aka.ms/new-console-template for more information

// un Produit avec ses propriétés
public class Product
{
    public int Location { get; set; }  // Emplacement du produti
    public string Producer { get; set; }  // Producteur
    public string ProductName { get; set; } // Nom du produti
    public int Quantity { get; set; } // nbr Quantité
    public string Unit { get; set; } // l'unité (kg,pièce)
    public double PricePerUnit { get; set; } // prix par unité
}

class Program {
   static void Main()
    {

        List<Product> products = new List<Product>() // Créer la Liste du produit
        {
    new Product { Location = 1, Producer = "Bornand", ProductName = "Pommes", Quantity = 20, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Poires", Quantity = 16, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Pastèques", Quantity = 14, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Melons", Quantity = 5, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Noix", Quantity = 20, Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Raisin", Quantity = 6, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Pruneaux", Quantity = 13, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Myrtilles", Quantity = 12, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Groseilles", Quantity = 12, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Pêches", Quantity = 8, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Haricots", Quantity = 6, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Courges", Quantity = 18, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Tomates", Quantity = 12, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Pommes", Quantity = 20, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Poires", Quantity = 5, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Pastèques", Quantity = 6, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Melons", Quantity = 14, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Noix", Quantity = 20, Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Raisin", Quantity = 15, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Pruneaux", Quantity = 5, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Myrtilles", Quantity = 18, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Groseilles", Quantity = 10, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Pêches", Quantity = 20, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Haricots", Quantity = 9, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Courges", Quantity = 12, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Tomates", Quantity = 12, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Pommes", Quantity = 15, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Poires", Quantity = 18, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Pastèques", Quantity = 7, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Pêches", Quantity = 10, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Haricots", Quantity = 11, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Courges", Quantity = 10, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Tomates", Quantity = 13, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Pommes", Quantity = 14, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Poires", Quantity = 5, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Pastèques", Quantity = 5, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Haricots", Quantity = 5, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Courges", Quantity = 17, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Tomates", Quantity = 9, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Pommes", Quantity = 13, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Poires", Quantity = 5, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Pastèques", Quantity = 20, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Melons", Quantity = 20, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Noix", Quantity = 13, Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Raisin", Quantity = 8, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Pruneaux", Quantity = 19, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Myrtilles", Quantity = 9, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Groseilles", Quantity = 10, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Pêches", Quantity = 9, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Haricots", Quantity = 19, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Courges", Quantity = 16, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Tomates", Quantity = 18, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Pommes", Quantity = 8, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Poires", Quantity = 13, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Pastèques", Quantity = 15, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Melons", Quantity = 12, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Noix", Quantity = 11, Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Raisin", Quantity = 16, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Pruneaux", Quantity = 20, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Myrtilles", Quantity = 18, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Groseilles", Quantity = 19, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Pêches", Quantity = 12, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Haricots", Quantity = 13, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Courges", Quantity = 7, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Tomates", Quantity = 12, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Pommes", Quantity = 17, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Poires", Quantity = 7, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Pastèques", Quantity = 11, Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Melons", Quantity = 7, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Noix", Quantity = 10, Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Raisin", Quantity = 17, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Pruneaux", Quantity = 18, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Myrtilles", Quantity = 12, Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Groseilles", Quantity = 12, Unit = "kg", PricePerUnit = 5.50 }
        };


        ///////// Sans LinQ
        ///
        
        int counterPeach = 0; // compteur de pêche
       foreach (var product in products) // parcours chaque produit de la liste
        {
            // si le nom du produit est Pêches, le compteur s'incremente
            if (product.ProductName == "Pêches")
            {
                counterPeach++;
            }
        }

        // Question
        Console.WriteLine("Combien y a t'il de vendeurs de pêche dans ce marché ?");
        Console.ForegroundColor = ConsoleColor.Yellow;
        //Réponse
        Console.WriteLine("il y a " + counterPeach + " vendeurs de pêches !"); // affiche le nbr de vendeur de peche



        int quantityMax = 0; // stocke la plus grande quantité trouvée
        string bestVendeur = "";
        int locationBestVendeur = 0;
        foreach (var product in products)
        {
            // vérifie si le produit est pastèques
            if( product.ProductName == "Pastèques")
            {
                // si la quantité du produit est plus grande que la quantité max actuel
                if (product.Quantity > quantityMax)
                {
                    // met à jour quantityMax avec cette nouvelle valeur plus grande
                    quantityMax = product.Quantity;
                    bestVendeur = product.Producer;
                    locationBestVendeur = product.Location;
                }
            }
        }

        Console.ResetColor();
        // Question
        Console.WriteLine("Quel producteur a le plus de pastèques à vendre ? Ou est-il = Combien en a t'il ?");
        Console.ForegroundColor = ConsoleColor.Yellow;
        // Réponse
        Console.WriteLine($"C'est {bestVendeur} qui a le plus de pastèques (stand {locationBestVendeur}, {quantityMax} pièces)");


        ///////// A l'aide de LinQ
        Console.ForegroundColor = ConsoleColor.Blue;

        // Le résultat est stocker dans productPeach
        List<Product> productPeach = products  //products et la liste des produits
            .Where(p => p.ProductName == "Pêches") // filtre la liste selon Pêches
            .ToList(); // convertit tableau en liste
        
        Console.ResetColor();
        // Question
        Console.WriteLine("Combien y a t'il de vendeurs de pêche dans ce marché ?");

        Console.ForegroundColor = ConsoleColor.Blue;
        //Réponse
        Console.WriteLine("il y a " + productPeach.Count + " vendeurs de pêches !");


      Product bestSeller  = products // products est la liste
     .Where(p => p.ProductName == "Pastèques") // trie par pasteque
     .OrderBy(p => p.Quantity).LastOrDefault(); // ordonne dans l'ordre croissant par quantité et selectionne le dernier (donc la plus grande quantité)


        Console.ResetColor();
        // Question
        Console.WriteLine("Quel producteur a le plus de pastèques à vendre ? Ou est-il = Combien en a t'il ?");
        Console.ForegroundColor = ConsoleColor.Blue;
        
        // Reponse
        Console.WriteLine($"C'est {bestSeller.Producer} qui a le plus de pastèques (stand {bestSeller.Location}, {bestSeller.Quantity} pièces)");

        Console.ResetColor();

    }
}