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
<<<<<<< HEAD
            bil Ford = new bil("Mustang", "røøød", 1984); ;

            
=======
            bil Ford = new bil("Mustang", "den er blå igen", 1984); ;
>>>>>>> 6f4a6100c4f058a47561f93f07f65f8a8cacc156
            Dissing Mathias = new Dissing("God", "hvid", "1991");
        }
    }
}
