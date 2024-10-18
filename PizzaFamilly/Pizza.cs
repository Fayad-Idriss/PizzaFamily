using System;
using System.Collections.Generic;


public class Pizza
	{
		public string nom;
		public int prix;
	    public bool vegetarien;
        public List<string> ingredients;



    public Pizza(string nom, int prix, bool vegetarien, List<string> ingredients)
		{
			this.nom = nom;
			this.prix = prix;
			this.vegetarien = vegetarien;
            this.ingredients = ingredients;
    }


		public void Afficher()
		{
			if (vegetarien == false)
			{
				Console.WriteLine("Pizza " + nom + prix + " euro");
                Console.WriteLine(string.Join(", ", ingredients));
                Console.WriteLine();
        }
        else
			{
				Console.WriteLine("Pizza " + nom + " (V) " + prix + " euro");
			    Console.WriteLine(string.Join(", ", ingredients));
                Console.WriteLine();
        };
		}
	}


