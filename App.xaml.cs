using Avalonia;
using Avalonia.Markup.Xaml;

namespace TreeViewTutorial
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}