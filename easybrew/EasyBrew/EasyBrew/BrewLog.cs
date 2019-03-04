using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBrew.Recipe;

namespace EasyBrew
{
    public class BrewLog
    {
        public EasyBrew.Recipe.Recipe Recipe { get; set; }
        public DateTime StartedBrewing { get; set; }
        public DateTime FinishedBrewing { get; set; }
        public DateTime StartedFermenting { get; set; }
        public DateTime Kegged { get; set; }
        public int SG { get; set; }
        public int OG { get; set; }
        public int FG { get; set; }

        public BrewLog(EasyBrew.Recipe.Recipe recipe) => Recipe = recipe ?? throw new ArgumentNullException(nameof(recipe));
    }
}
