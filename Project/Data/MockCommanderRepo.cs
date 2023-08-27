using Project.Models;
using System.Collections.Generic;

namespace Project.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil Water", Line = "Boil water", Platform = "Kettle" },
                new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a Knife", Platform = "knife" },
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Get tea bag", Platform = "Cup" }
        };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil Water", Line = "Boil water", Platform = "Kettle" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
