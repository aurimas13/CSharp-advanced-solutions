using System;

namespace OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Human auris = new Human("Aurimas", "Nausedas", "Blue", 31);

            //auris.firstName = "Aurimas";
            //auris.lastName = "Nausedas";
            auris.InroduceMyslef();

            Human mike = new Human("Mike", "Speedy", "Blue", 100);
            //mike.firstName = "Mikael";
            //mike.lastName = "Gozalez";
            mike.InroduceMyslef();

            Human basicHuman = new Human();
            basicHuman.InroduceMyslef();

            Human john = new Human("John", "Crazy", "Blue");
            john.InroduceMyslef();

            Human what = new Human("Ona");
            what.InroduceMyslef();

            Human manuel = new Human("Manuel", "Ocotober")
            manuel.InroduceMyslef();

            Human anna = new Human("Anna", "Timid", 28);
            anna.InroduceMyslef();
        }
    }
}
