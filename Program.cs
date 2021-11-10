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
            bil BMW = new bil("M4", "Flaske Grøn", 2021);
            bil Ford1 = new bil("Mustang", "den er blå igen.....", 1984); ;
            Axel Lund = new Axel("Høj", "Medium hvid", "2000");
            Dissing Mathias = new Dissing("God", "hvid", "1991");
        }
    }
}
