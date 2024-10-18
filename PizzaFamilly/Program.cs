using System;
using PizzaFamilly;

namespace Hello
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            List<Pizza> pizzaVente = new()
            {
                // Ajouter des objets Personne à la liste
                new Pizza("Margarita", 14, true, new List<string> {"Tomate", "Fromage", "Basilic"}),
                new Pizza("Végétarienne ", 11, true, new List<string> {"steack végétale", "Fromage", "Tomate"}),
                new Pizza("Boisé ", 10, false, new List<string> {"steack végétale", "Fromage", "Tomate"}),
                new Pizza("Cannibale ", 12, false, new List<string> {"steack","Escalope","Cordon Bleu", "Fromage", "Tomate"}),
                new Pizza("Rêine ", 12, false, new List<string> {"Jambon","Chorizo", "Fromage", "Tomate"}),
            };

            // Ajouter une pizza personnalisée à la liste
            var pizzaPersonnalisee = new Personnalise(); // Création de l'instance Personnalise
            pizzaVente.Add(pizzaPersonnalisee);

            //Code permettant de pouvoir trier les prix du moin chère au plus chère.
            pizzaVente.Sort((p1, p2) => p1.prix.CompareTo(p2.prix));

            // Affichage des pizzas avec foreach
            foreach (Pizza pizza in pizzaVente)
            {
                pizza.Afficher();
            }
        }
    }
}
