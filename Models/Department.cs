using System.Collections.ObjectModel;

namespace TreeViewTutorial.Models
{
    public class Department
    {
        public string DepartmentName { get; set; }
        
        public ObservableCollection<Person> Roster { get; }

        public Department()
        {
            Roster = new ObservableCollection<Person>();
        }
    }
}