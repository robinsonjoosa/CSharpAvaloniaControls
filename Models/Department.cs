using System.Collections.ObjectModel;

namespace AvaloniaTreeView.Models
{
    public class Department
    {
        public string DepartmentName { get; set; }
        
        public ObservableCollection<Person> Eployees { get; }

        public Department()
        {
            Eployees = new ObservableCollection<Person>();
        }
    }
}