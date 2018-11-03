using System;
using Monkeys2.Models;

namespace Monkeys2.ViewModels
{
    public class DetailsViewModel
    {
        public Monkey Monkey { get; set; }
        public DetailsViewModel(Monkey monkey)
        {
            Monkey = monkey;
        }
    }
}

