using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CharacterBuilder.ViewModels
{
    public class CharacterViewModel : BaseViewModel
    {
        public ICharacter character;
        public ICommand LevelUpCommand { get; set; }
        public ICommand DemoteCommand { get; set; }

        public ICommand LoadCommand { get; set; }
        public ICommand SaveCommand { get; set; }
       

        public string Name
        {
            get
            {
                return character.Name;
            }
            set
            {
                character.Name = value;
                RaisePropertyChangedEvent();
            }
        }

        public int Age
        {
            get
            {
                return character.Age;
            }
            set
            {
                character.Age = value;
                RaisePropertyChangedEvent();
            }
        }

        public int Level
        {
            get
            {
                return character.Level;
            }
            set
            {
                character.Level = value;
                RaisePropertyChangedEvent();
            }
        }


        public int XP
        {
            get
            {
                return character.XP;
            }
            set
            {
                character.XP = value;
                RaisePropertyChangedEvent();
            }
        }


        public CharacterViewModel(ICharacter character)
        {
            this.character = character;
            LevelUpCommand = new BasicCommand(OnLevelUpCommand, LevelUpCommandCanExecute);
            DemoteCommand = new BasicCommand(OnDemoteCommand, DemoteCommandCanExecute);
            LoadCommand = new BasicCommand(OnLoadCommand, LoadCommandCanExecute);
            SaveCommand = new BasicCommand(OnSaveCommand, SaveCommandCanExecute);
        }

        private bool PrintCommandCanExecute(object parameter)
        {
            return true;
        }


        private void OnPrintCommand(object parameter)
        {
            this.character.Print();
        }


        private bool LoadCommandCanExecute(object parameter)
        {
            return true;
        }


        private void OnLoadCommand(object parameter)
        {
            this.character.Load();
        }

        internal void Load()
        {
            this.character.Load();
        }

        private bool SaveCommandCanExecute(object parameter)
        {
            return true;
        }


        private void OnSaveCommand(object parameter)
        {
            this.character.Save();
        }

        internal void Save()
        {
            this.character.Save();
        }


        private bool LevelUpCommandCanExecute(object parameter)
        {
            return true;
        }

        private void OnLevelUpCommand(object parameter)
        {
            this.character.LevelUp();
            RaisePropertyChangedEvent("Level");
        }

        private bool DemoteCommandCanExecute(object parameter)
        {
            return true;
        }

        private void OnDemoteCommand(object parameter)
        {
            this.character.Demote();
            RaisePropertyChangedEvent("Level");
        }

        internal void LevelUp()
        {
            this.character.LevelUp();
            RaisePropertyChangedEvent("Level");
        }

        internal void Demote()
        {
            this.character.Demote();
            RaisePropertyChangedEvent("Level");
        }

    }
}
