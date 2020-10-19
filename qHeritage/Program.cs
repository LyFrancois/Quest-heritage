using System;

namespace qHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Human humain = new Human();
            Monkey singe = new Monkey();
            Elefant elefant = new Elefant();
            Turtle turtule = new Turtle();
            Lezard lezard = new Lezard();

            humain.Move();
            singe.Move();
            lezard.Move();
            elefant.Move();
            turtule.Move();


           
        }

        // création d'une classe abstraite 
        public abstract class Animal
        {
            protected int _legs = 4;
            public abstract void Move();

            public Animal (int legs)
            {
                _legs = legs;
            }


        }

         abstract  class Mammal : Animal
        {
            public Mammal(int legs) : base(legs) { }

        } 

         abstract class Reptile: Animal
        {
            public Reptile(int legs) : base(legs) { }
        }

        class Human : Mammal
        {
            public Human():base(2) { }
            public override void Move()
            {
                Console.WriteLine("the humain move with feets");
            }

        }
        class Monkey : Mammal
        {
            public Monkey() : base(2) { }
            public override void Move()
            {
                Console.WriteLine("the   Monkey climb trees ");
            }

        }
        class Elefant : Mammal
        {
            public Elefant() : base(4) { }
            public override void Move()
            {
                Console.WriteLine("the elefant shacking the earth");
            }

        }
        class Turtle : Reptile
        {
            public Turtle() : base(4) { }
            public override void Move()
            {
                Console.WriteLine("the Turtule move slowly");
            }

        }
        class Lezard: Reptile
        {
            public Lezard() : base(4) { }
            public override void Move()
            {
                Console.WriteLine(" the lezard climb walls");
            }

        }


    }
}
