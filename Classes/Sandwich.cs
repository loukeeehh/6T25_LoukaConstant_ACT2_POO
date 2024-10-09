using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT2_POO.Classes
{
    internal class Sandwich
    {
        private List<string> _pains = new List<string> { "Pain complet", "Pain blanc", "Baguette", "Pain de seigle" };
        private List<string> _garnitures = new List<string> { "Jambon", "Dinde", "Poulet", "Fromage", "Thon" };
        private List<string> _sauces = new List<string> { "Mayo", "Ketchup", "Moutarde", "Sauce barbecue", "Sauce au yaourt" };
        private List<string> _legumes = new List<string> { "Laitue", "Tomates", "Oignons", "Cornichons", "Poivrons" };

        public Sandwich()
        {
            
        }

        public string composeSandwich()
        {
            Random rand = new Random();
            string painChoisi = _pains[rand.Next(_pains.Count)];
            string garnitureChoisie = _garnitures[rand.Next(_garnitures.Count)];
            string sauceChoisie = _sauces[rand.Next(_sauces.Count)];
            string legumeChoisi = _legumes[rand.Next(_legumes.Count)];

            // Création de la chaîne de caractères décrivant le sandwich
            string sandwich = $"Votre sandwich contient : {painChoisi}, {garnitureChoisie}, avec de la {sauceChoisie} et des {legumeChoisi}.";

            return sandwich;
        }
    }
}
