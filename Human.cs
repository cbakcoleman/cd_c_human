using System;

namespace cd_c_human
{


    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligience;
        public int Dexterity;
        private int health;

        // Add a public "getter" property to access health
        public int Health
        {
            get
            {
                return health;
            }
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string Name)
        {
            Strength = 3;
            Intelligience = 3;
            Dexterity = 3;
            health = 100;
            this.Name = Name;
        }

        // Add a constructor to assign custom vaues to all fields
        public Human(string Name, int Strength, int Intelligience, int Dexterity, int health)
        {
            this.Strength = Strength;
            this.Intelligience = Intelligience;
            this.Dexterity = Dexterity;
            this.Strength = Strength;
            this.Strength = Strength;
        }

        // Build Attack method
        public int Attack(human target)
        {
            target.Health = target.Health - (5*Strength);
            return target.Health;
        }

    } // END HUMAN CLASS


}