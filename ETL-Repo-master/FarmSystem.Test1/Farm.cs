using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    internal class Farm
    {
        public String Cow;

        public String Hen;

        public String Horse;


        Cow cow = new Cow();

        Hen hen = new Hen();

        Horse horse = new Horse();
    }
}

public class Animal
    {
        public Animal()
        {
            this.Fazenda = "";
            
        }
        public Animal(String especie)
        {
            this.Fazenda = especie; 
            
        }
        public String Fazenda { get; set;} 

        public void Exibir()
    {
        Console.WriteLine("Animal " ,this.Fazenda);
    }
        
    }
