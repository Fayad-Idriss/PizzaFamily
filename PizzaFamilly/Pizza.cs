using System;





namespace PizzaFamilly
{

	public class Pizza
	{
		public string nom;
		public int prix;
		public bool vegetarien;


		public Pizza(string nom, int prix, bool vegetarien)
		{
			this.nom = nom;
			this.prix = prix;
			this.vegetarien = vegetarien;
		}


		public void Afficher()
		{
			if (vegetarien == false)
			{
				Console.WriteLine("Pizza " + nom + prix + " euro"); ;
			}else
			{
				Console.WriteLine("Pizza " + nom + " (V) " + prix + " euro");
			};
		}
	}
}

