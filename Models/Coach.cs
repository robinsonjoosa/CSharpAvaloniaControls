namespace TreeViewTutorial.Models
{
    public class Manager : Person
    {
        public string Title { get; set; }

        public string ProperName => $"{Title}: {Name}";
    }
}