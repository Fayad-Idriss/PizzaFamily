using System;

namespace Hello
{
    /// <summary>
    /// Ceci est une implémentation du message traditionnel « Hello world! »
    /// </summary>
    /// <remarks>Créée par l'équipe éducative d'OpenClassrooms</remarks>
    public class HelloWorld
    {
        /// <summary>
        /// Le programme commence ici
        /// </summary>
        public static void Main(string[] args)
        {
            List<Pizza> pizzaVente = new()
            {
                // Ajouter des objets Personne à la liste
                new Pizza("Margarita", 8, true),
                new Pizza("Végétarienne", 10, true),
                new Pizza("Boisé ", 10, false),
                new Pizza("Cannibale ", 12, false),
                new Pizza("Rêine ", 12, false)
            };


            // Affichage des pizzas avec foreach
            foreach (Pizza pizza in pizzaVente)
            {
                pizza.Afficher();
            }
        }
    }
}
