using System.Collections.ObjectModel;

namespace TreeViewTutorial.Models
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