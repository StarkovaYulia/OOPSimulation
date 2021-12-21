using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Predators;
using System.Drawing;
using Animals;
using GeneratingAndDrawing;
using ClassMap;

namespace Lions
{
    class Lion : Predator
    {
        public Lion(Map map, GenerateAndDraw locality)
            : base(map, locality)
        {

        }
        public void CreateKind()
        {
            IsHibernation = false;
            IsTamed = false;
            CanBeTamed = false;
            color = Color.FromArgb(21, 23, 25);
            health = 45;
            constHealth = health;
            satietyLevel = 20;
            age = 7;
            animalName = "lion";
            locality.descriptionSquares[coordAnimalX, coordAnimalY].predator.Add(this);
            locality.animalsObjects.Add(this);
        }
        public override string GoodJobFromAnimal() { return "none"; }
    }
}
