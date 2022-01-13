using BlazorState;

namespace BlazorApp1.Features.Apps;

public partial class AppState
{    
    public class ToggleDrawerEndAction : IAction
    {
        public bool DrawerEnd { get; set; }
    }
}