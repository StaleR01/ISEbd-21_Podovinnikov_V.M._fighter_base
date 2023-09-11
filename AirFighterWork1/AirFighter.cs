using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFighterWork1
{
    public class AirFighter
    {
        public int speed {  get; private set; }

        public double weight { get; private set; }

        public Color bodyColor { get; private set; }

        public Color addictionalColor {  get; private set; }

        public bool rocket { get;  set; }

        public bool additionalWings {  get;  set; }

        public int additionalEngine {  get; set; }

        public double step => (double)speed * 100 / weight;

        public void init(int Speed, double Weight, Color BodyColor, Color AddictionalColor, bool Rocket = true, bool AdditionalWings = true, int AdditionalEngine = 2)
        {
            this.speed = Speed;
            this.weight = Weight;
            this.bodyColor = BodyColor;
            this.addictionalColor = AddictionalColor;
            this.rocket = Rocket;
            this.additionalWings = AdditionalWings;
            this.additionalEngine = AdditionalEngine;
        }


    }
}
