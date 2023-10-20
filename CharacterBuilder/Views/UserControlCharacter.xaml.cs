using CharacterBuilder.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CharacterBuilder.Views
{
    /// <summary>
    /// Interaction logic for UserControlCharacter.xaml
    /// </summary>
    public partial class UserControlCharacter : UserControl
    {
        CharacterViewModel vm;

        public UserControlCharacter()
        {
            InitializeComponent();
            vm = new CharacterViewModel(new Character() { Name = "Spim" });
            this.DataContext = vm;
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveButton.IsEnabled = false;   
        }
    }
}
