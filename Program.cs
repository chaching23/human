using System;

namespace human
{
    class Main{

        // Human v = new Human (bobby, 10)


    }
     class Human
    {f
        // Fields for Human
        public string Name; 
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
             
        // add a public "getter" property to access health



        // public int health { get; set; }
         
        

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public void Human (String Name){
        this.Name= Name;
        Strength=100;
        Intelligence=100;
        Dexterity=3;
        health=100;
        }

        // Add a constructor to assign custom values to all fields
        public void Human (String Name, int Strength, int Intelligence, int Dexterity, int health){
        this.Name= "Bobby";
        this.Strength=100;
        this.Intelligence=100;
        this.Dexterity=100;
        this.health=100;
        }

        // Build Attack method
        public int Attack(Human target)
        {

            target.health = this.target.health = 5*health


        }







    }
    
}
