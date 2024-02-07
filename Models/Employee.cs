using System.Collections.ObjectModel;

namespace AvaloniaTreeView.Models
{
    public class Employee : Person
    {
        public ObservableCollection<string> Designations { get; }

        public Employee()
        {
            Designations = new ObservableCollection<string>();
        }
    }
}