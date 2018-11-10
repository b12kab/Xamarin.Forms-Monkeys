using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Monkeys2.Models
{
    public class GroupedMonkeys : ObservableCollection<Monkey>
    {
        public string Heading { get; set; }

        public GroupedMonkeys(string title)
        {
            Heading = title;
        }
    }
}
