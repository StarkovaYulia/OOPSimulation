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

namespace Panthers
{
    class Panther : Predator
    {
        public Panther(Map map, GenerateAndDraw locality)
            : base(map, locality)
        {

        }
        public void CreateKind()
        {
            IsHibernation = false;
            IsTamed = false;
            CanBeTamed = true;
            thingForTaming = "bear meat";
            color = Color.FromArgb(31, 14, 17);
            health = 40;
            constHealth = health;
            satietyLevel = 15;
            age = 5;
            animalName = "panther";
            locality.descriptionSquares[coordAnimalX, coordAnimalY].predator.Add(this);
            locality.animalsObjects.Add(this);
        }

        public override string GoodJobFromAnimal()
        {
            return "panther meat";
        }
    }
}
