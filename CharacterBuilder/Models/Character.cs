using CharacterBuilder.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CharacterBuilder.Character;

namespace CharacterBuilder
{
    public interface ILevelUp
    {
        int Level { get; set; }
        int XP { get; set; }
        void LevelUp();
        void Demote();
        void Load();
        void Save();
        void Print();

    }

    public interface IDemote
    {
        string Name { get; set; }
    }

    public interface ICharacter : ILevelUp, IDemote
    {
        int Age { get; set; }
    
    }

    public class Character : ICharacter
    {
        protected string name;
        protected string type;
        protected int age;
        protected int level;
        protected int xp;
        


        public string Name
        {
            get
            {
                return name;
            }
            set
            {

                this.name = value;

            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {

                this.type = value;

            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                age = value;


            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                level = value;
            }
        }

        public int XP
        {
            get
            {
                return this.xp;
            }
            set
            {
                xp = value;
            }
        }

        



            public Character()
            {
            
            this.Name = "Spim";
            this.type = "Archer";
            this.Age = 1;
            this.Level = 1;
            this.XP = 5;
           
            }

        public void LevelUp()
        {
            for (int i = 0; i < XP; i++)
            {
                this.Level++;
            }
            
        }

        public void Demote()
        {
            this.Level--;
        }

        public void Load()
        {
            CharacterRepo chara = new CharacterRepo();
            chara.Load();
        }
        public void Save()
        {
            CharacterRepo chara = new CharacterRepo();
            chara.Save(this);
        }

        public void Print()
        {
            CharacterRepo chara = new CharacterRepo();
            foreach(Character character in chara.SavedCharacters)
            {
                character.Print();
            }

        }
    }
}
