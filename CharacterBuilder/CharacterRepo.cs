using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder
{
    [Serializable]
    public class CharacterRepo
    {
        protected List<Character> savedCharacters;

        public List<Character> SavedCharacters
        {
            get
            {
                return this.savedCharacters;
            }
            set
            {
                savedCharacters = value;
            }
        }

        public CharacterRepo() 
        {
        
        this.savedCharacters= new List<Character>(); 
        }

        public void LoadCharacters()
        {
            if (SavedCharacters == null)
            {
                SavedCharacters = new List<Character>();
            }
        }


        public void Load()
        {
            foreach (Character chara in SavedCharacters)
            {


                string path = ($"{Directory.GetCurrentDirectory()}\\{chara.Name}.txt");
                string json;
                using (StreamReader sr = new StreamReader(path))
                {
                    json = sr.ReadLine();
                    JsonConvert.DeserializeObject(json);
                }
            }
        }

        public void Save(Character chara)
        {
            if (this == null)
            { return; }
            else
            {
                string path = ($"{Directory.GetCurrentDirectory()}\\{chara.Name}.txt");
                string json;

                json = JsonConvert.SerializeObject(this, Formatting.Indented);
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(json);
                }
                SavedCharacters.Add(chara);
            }
        } 
    }
}
