using System;
namespace PizzaFamilly
{
	public class Personnalise : Pizza
	{
		public Personnalise() : base("Personnalisé", 5, false, null)
		{
			this.ingredients = new List<string>();

			while (true)
			{

				Console.WriteLine("Veuiller renseigner les ingredients de votre pizza personnalisé : ");
				var ingredient = Console.ReadLine();

				if (string.IsNullOrWhiteSpace(ingredient))
				{
					break;
				}

				ingredients.Add(ingredient);
			}
		}
	}
}

