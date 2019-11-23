using DropDownTogleButton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using WpfTestingApp.Infrastucture.DelegateCommand;

namespace DropDownTogleButton.ViewModels
{
    public class ButtonViewModel : ViewModelBase
    {
        public List<CommandModel> Commands { get; private set; }
        private Brush _color;
        public Brush Color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged();
            }
        }

        public ButtonViewModel()
        {
            Commands = new List<CommandModel>
            {
                new CommandModel("Yellow", new DelegateCommand(SetColorYellow)),
                new CommandModel("Green", new DelegateCommand(SetColorGreen)),
                new CommandModel("Red", new DelegateCommand(SetColorRed))
            };
        }

        private void SetColorYellow(object obj)
        {
            Color = new SolidColorBrush(Colors.Yellow);
        }
        private void SetColorGreen(object obj)
        {
            Color = new SolidColorBrush(Colors.Green);
        }
        private void SetColorRed(object obj)
        {
            Color = new SolidColorBrush(Colors.Red);
        }
    }
}
