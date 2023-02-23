using System;
using ToDooAPI.Domain.Commands.Contracts;

namespace ToDooAPI.Domain.Commands
{
    public class CreateTodoCommand : ICommand
    {
        public CreateTodoCommand() 
        {
        }

        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }
        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
