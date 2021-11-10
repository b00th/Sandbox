using System;

namespace Sandbox
{
    class bil
    {
        
       public string farve;
       public string model;
       public int årgang;

        public bil(string modelNavn, string modelFarve, int modelÅrgang)
        {
            model = modelNavn;
            farve = modelFarve;
            årgang = modelÅrgang;

        }
        static void Main(string[] args)
        {
            bil Ford = new bil("Mustang", "røøød", 1984); ;

            Dissing Mathias = new Dissing("God", "hvid", "1991");
            
        }
    }
}
