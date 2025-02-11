﻿using ConsoleToDoProject.Models;
namespace ConsoleToDoProject.Models
{
    public class CommandDefinitions
    {
        public Command AddCommand()
        {
            Option priorityOp = new Option(abbreviatedName: "p", fullName: "priority", description:"Task's priority level (1-3)", defaultValue: "1");
            Options ops = new Options() { priorityOp};
            return new Command("add", options: ops);
        }
        public Command RemoveCommand()
        {
            Option descriptionOp = new Option(abbreviatedName: "d", fullName: "description", description:"Remove tasks matching given description", defaultValue: "");
            Option priorityOp = new Option(abbreviatedName: "p", fullName: "priority", description:"Remove tasks with given priority level", defaultValue: "");
            Option completedOp = new Option(abbreviatedName:"c", fullName: "completed",description:"Remove all completed tasks", isFlag: true, defaultValue:"false");
            Option removeAllOp = new Option(abbreviatedName: "a", fullName: "all", description:"Remove all tasks", isFlag:true, defaultValue:"false");

            Options ops = new Options() { descriptionOp,priorityOp, completedOp, removeAllOp};
            return new Command("remove", options: ops);
        }


    }
}
