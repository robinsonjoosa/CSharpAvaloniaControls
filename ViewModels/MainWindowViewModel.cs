using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvaloniaTreeView.Models;

namespace AvaloniaTreeView.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Meeting> ScheduledMeetings { get; }

        public MainWindowViewModel()
        {
            ScheduledMeetings = new ObservableCollection<Meeting>(FillLeague());
        }

        private List<Meeting> FillLeague()
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
                            DepartmentName = "Production"
                        },
                        new Department()
                        {
                            DepartmentName = "Sales",
                            Eployees =
                            {
                                new Employee() { Name = "Patrick Cassidy", Designations = { "Account Executive", "Business Development Representative"}},
                                new Employee() { Name = " M. Jonathan", Designations = { "Sales Executive", "Sales Development Representative"}},
                                new Employee() { Name = "Alexander"},
                                new Manager() {Title = "Sales Manager", Name = "Annabelle Rose"},
                                new Manager() {Title= "Sales Operation Manager", Name = "David Dahl"}
                            }
                        },
                        new Department()
                        {
                            DepartmentName = "Marketing"
                        }
                    }
                },
                new Meeting()
                {
                    MeetingName = "Problem-Solving",
                    Departments =
                    {
                        new Department()
                        {
                            DepartmentName = "Finance"
                        },
                        new Department()
                        {
                            DepartmentName = "Production Planning"
                        },
                        new Department()
                        {
                            DepartmentName = "Procurement"
                        }
                    }
                }
            };
        }
    }
}
