using System;
using System.Collections.Generic;

namespace EasyBrew
{
    public class Recipe
    {
        public string Name { get; set; } = "Fiskøl";
        public string Producer { get; set; } = "The Drunk Developer";
        public string Description { get; set; } = "Quite punchy, easy to consume a lot each day. 8.9% ABV.";
        public string Procedure { get; set; } = 
            "0. Calculate mash and sparge water based on 6.5 Kilograms grain, 90 min boiltime, 23 liter in fermenter for your setup." + Environment.NewLine +
            "1. Heat mash water to 65&deg;C." + Environment.NewLine +
            "2. Add grain and mash for 60 minutes, mash out at 77&deg;C for 15 minutes." + Environment.NewLine +
            "3. Sparge with water at 78&deg;C." + Environment.NewLine +
            "4. Boiltime 90 minutes." + Environment.NewLine + 
            "5. Boil additions:" + Environment.NewLine + Environment.NewLine +
            "| Addition | MinLeft     |" + Environment.NewLine +
            "|---       |---          |" + Environment.NewLine +
            "| Bag#1    | 60          |" + Environment.NewLine + 
            "| Bag#2    | 15          |" + Environment.NewLine + Environment.NewLine +
            "5. Chill to 24&deg;C and transfer to fermenter." + Environment.NewLine +
            "6. Ferment for 14 days at 18-22&deg;C";
        
        // todo: public Procedure Procedure { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}