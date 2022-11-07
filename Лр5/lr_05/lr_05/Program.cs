﻿using System;

namespace lr_05
{
    public abstract class Fighter : IFighters
    {
        public string weapon;
        public string skill;
        public int average_damage;
        public int IDFighter;

        public Fighter(string weapon1, string skill1, int ID, int damage)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
        }

        public virtual void Actions()
        {
            Console.WriteLine("Weapon of {0} - {1}, skill - {2}, average damage - {3}", IDFighter, weapon, skill, average_damage);
        }
    }
    sealed class Hunter : Fighter
    {
        public string Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
        public Hunter(string weapon, string skill1, int ID, int damage) : base(weapon, skill1, ID, damage)
        {
            this.Weapon = weapon;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
        }

        public override void Actions()
        {
            Console.WriteLine("Hunters ID - {0}, weapon - {1}, skill - {2}, avarage damage - {3}", IDFighter, weapon, skill, average_damage);
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }
    }

    class Shaman : Fighter
    {
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
                return true;
        }

        public override int GetHashCode()
        {
            return IDFighter * 111;
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }

        public Shaman(string weapon1, string skill1, int ID, int damage) : base(weapon1, skill1, ID, damage)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
        }
    }

    public partial class Archer : Fighter
    {
        public Archer(string weapon1, string skill1, int ID, int damage) : base(weapon1, skill1, ID, damage)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }

    }

    class Psychic : Fighter
    {
        public Psychic(string weapon1, string skill1, int ID, int damage) : base(weapon1, skill1, ID, damage)
        {
            weapon = weapon1;
            skill = skill1;
            IDFighter = ID;
            average_damage = damage;
        }

        public override string ToString()
        {
            return weapon + " " + skill;
        }
    }
    enum Skill
    {
        skill1,
        skill2,
        skill3,
        skill4
    }

    struct Options
    {
        public string action;
        public int skill;

        public void Actions()
        {
            Console.WriteLine($"Action {action} on skill {skill}");
        }
    }

    // eponymous methods
    abstract class BaseClone
    {
        public abstract bool DoClone();
    }

    class UserClass : BaseClone, ICloneable
    {

        public override bool DoClone()
        {
            Console.WriteLine("Method from abstract class");
            return true;
        }
    }

    class Printer
    {
        public void IAmPrinting(Fighter obj)
        {
            Console.WriteLine(obj.GetType().Name + " " + obj.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hunter hunter = new Hunter("gun", "shot", 1, 107);
            Shaman shaman = new Shaman("book of curses", "curse", 2, 94);
            Archer archer = new Archer("bow", "firebolt", 3, 123);
            Psychic psychic = new Psychic("tarot", "mind capture", 4, 77);

            /*hunter.Actions();
            shaman.Actions();
            archer.Actions();
            psychic.Actions();*/
            archer.Fighter_Skill();

            UserClass userClass = new UserClass();

            //userClass.DoClone();

            object obj1 = new Hunter("gun", "shot", 1, 107);
            object obj2 = new Archer("bow", "firebolt", 3, 123);
            object obj3 = new Shaman("book of curses", "curse", 2, 94);

            /*Console.WriteLine(obj1 is Hunter);
            Console.WriteLine(obj2 is Hunter);
            Console.WriteLine(obj3 is Shaman);*/

            IEnumerable<string> list1 = new[] { "hunter", "shaman", "archer", "psychic" };
            IList<string> list2 = list1 as IList<string>;

            if (list2 != null)
            {
                //Console.WriteLine(list2[0] + " " + list2[list2.Count - 2]);
            }
            /*Console.WriteLine(hunter.GetType() + " " + hunter.ToString());
            Console.WriteLine(shaman.GetType() + " " + shaman.ToString());
            Console.WriteLine(archer.GetType() + " " + archer.ToString());
            Console.WriteLine(psychic.GetType() + " " + psychic.ToString());*/

            Console.WriteLine();
            Console.WriteLine();
            Printer printer = new Printer();
            Fighter[] array = { hunter, shaman, archer, psychic };

            for (int i = 0; i < array.Length; i++)
            {
                printer.IAmPrinting(array[i]);
            }

            // 5 lr

            Army army = new Army();
            army.Add(hunter);
            army.Add(shaman);
            army.Add(archer);
            army.Add(psychic);

            army.Show();
        }
    }
}