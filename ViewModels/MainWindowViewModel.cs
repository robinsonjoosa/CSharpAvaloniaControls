using System.Collections.Generic;
using System.Collections.ObjectModel;
using TreeViewTutorial.Models;

namespace TreeViewTutorial.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Meeting> MeetingScheduled { get; }

        public MainWindowViewModel()
        {
            MeetingScheduled = new ObservableCollection<Meeting>(ScheduleMeeting());
        }

        private List<Meeting> ScheduleMeeting()
        {
            return new List<Meeting>()
            {
                new Meeting()
                {
                    MeetingName = "Decision-Making",
                    Departments =
                    {
                        new Department()
                        {
                           DepartmentName = "Quality department"
                        },
                        new Department()
                        {
                            DepartmentName = "Maintenance",
                            Roster =
                            {
                                new Employee() { Name = "Nick Cannon", Designations = { "Inspection Coordinator", "Inspection Supervisor"}},
                                new Employee() { Name = "Bob Bryan", Designations = { "Lifting Inspection", "Integrity Inspection"}},
                                new Employee() { Name = "Evan-John"},
                                new Manager() {Title = "Maintenance Manager", Name = "Patrick Duffy"},
                                new Manager() {Title= "Assistant Manager", Name = "Alan Williams"}
                            }
                        },
                        new Department()
                        {
                            DepartmentName = "Planning"
                        }
                    }
                },
                new Meeting()
                {
                    MeetingName = "Idea-Sharing",
                    Departments =
                    {
                        new Department()
                        {
                            DepartmentName = "Marketing"
                        },
                        new Department()
                        {
                            DepartmentName = "Manufacturing"
                        },
                        new Department()
                        {
                            DepartmentName = "Engineering"
                        }
                    }
                }
            };
        }
    }
}
