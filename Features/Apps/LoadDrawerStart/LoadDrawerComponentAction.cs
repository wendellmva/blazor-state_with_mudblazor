using BlazorState;

namespace BlazorApp1.Features.Apps;

public partial class AppState
{    
    public class LoadDrawerComponentAction : IAction
    {
        public LoadDrawerComponentAction(Type component)
        {
            Component = component;
        }

        public Type Component { get; set; }
    }
}