using System.Collections.Generic;

namespace EasyBrew
{
    public class Procedure
    {
        public LinkedList<MashStep> MashSteps { get; set; }
        public Boil Boil { get; set; }
    }
}