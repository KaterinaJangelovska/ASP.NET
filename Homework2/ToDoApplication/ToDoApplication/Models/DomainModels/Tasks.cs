using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApplication.Models.DomainModels
{
    public class Tasks
    {
        public string Title { get; set; }
        public string Descripton { get; set; }
        //Dictionary<int, string> Importance = new Dictionary<int, string>();
        public Status Status { get; set; }
        public Type Type { get; set; }
        public List<SubTasks> SubTasks { get; set; }
        public Importance Importance { get; set; }
    }

    public enum Status
    {
        NotDone,
        InProgress,
        Done
    }

    public enum Type
    {
        Work,
        Personal,
        Hobby
    }

    public enum Importance
    {
        Important = 1,
        mediumImportance = 2,
        notImportant = 3
    }


}
