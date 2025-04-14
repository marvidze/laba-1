using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal class LibraryManager
    {
        private Stack<ICommand> executedCommands = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            executedCommands.Push(command);
        }

        public bool UndoLastCommand()
        {
            if (executedCommands.Count > 0)
            {
                var lastCommand = executedCommands.Pop();
                lastCommand.Undo();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
