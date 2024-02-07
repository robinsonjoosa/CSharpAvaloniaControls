using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaTreeView
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}