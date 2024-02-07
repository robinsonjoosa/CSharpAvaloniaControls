using System.Collections.ObjectModel;

namespace AvaloniaTreeView.Models
{
    public class Meeting
    {
        public string MeetingName { get; set; }

        public ObservableCollection<Department> Departments { get; }

        public Meeting()
        {
            Departments = new ObservableCollection<Department>();
        }
        
    }
}