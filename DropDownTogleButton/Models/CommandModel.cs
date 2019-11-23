using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DropDownTogleButton.Models
{
    public class CommandModel
    {
        public string Name { get; set; }
        public ICommand Command { get; set; }
        public object CommandParameter { get; set; }

        public CommandModel(string name, ICommand command, object commandParameter = null)
        {
            Name = name;
            Command = command;
            CommandParameter = commandParameter;
        }
    }
}
