using System;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //TEST 1
        public void Enter(object animal)
        {
           // public class : Cow:Hen:Horse 
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
             
           // Console.WriteLine("The Cow entered the farm"); 
            //Console.WriteLine("The horse entered the farm");
            //Console.WriteLine("The Hen entered the farm");
            

            Console.WriteLine("Animal has entered the Emydex farm");

        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            


            Console.WriteLine("A galinha diz CLUCKAAAAAWWWWK!");
         Console.WriteLine("Cavalo diz relincho!");
         Console.WriteLine("A ovelha diz baa!");

           // Console.WriteLine("There are no animals in the farm");
        }

        //TEST 3
        public void MilkAnimals()
        {
            Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            

            Console.WriteLine("A galinha deixou a fazenda");

                Console.WriteLine("A vaca deixou a fazenda");
            Console.WriteLine("Cavalo saiu da fazenda");
            Console.WriteLine("A ovelha deixou a fazenda");
            
                 Console.WriteLine("Não tem animais na fazenda");

           //Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}