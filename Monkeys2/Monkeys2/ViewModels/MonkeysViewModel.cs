using Monkeys2.Helpers;
using Monkeys2.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace Monkeys2.ViewModels
{
    public class MonkeysViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }
        public ObservableCollection<Grouping<string, Monkey>> MonkeysGrouped { get; set; }

        public MonkeysViewModel()
        {

            Monkeys = MonkeyHelper.Monkeys;
            MonkeysGrouped = MonkeyHelper.MonkeysGrouped;
        }

        public int MonkeyCount => Monkeys.Count;
    }
}
