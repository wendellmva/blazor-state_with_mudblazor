using BlazorApp1.Models;
using BlazorState;

namespace BlazorApp1.Features.Apps
{
    public partial class AppState : State<AppState>
    {
        private Type? _drawerComponent;
        private bool _drawerEnd;

        public Type? DrawerComponent
        {
            get => _drawerComponent;
            set
            {
                _drawerComponent = value;
                Console.WriteLine("appstate:drawercomponent:set");
            }
        }

        public bool DrawerEnd
        {
            get => _drawerEnd;
            set
            {
                _drawerEnd = value;
                Console.WriteLine("appstate:drawercomponent:set=>" + (_drawerEnd ? "Drawer should be open" : "Drawer should closed"));
            }
        }

        public TreeItemData ActivatedValue { get; set; }
        public HashSet<TreeItemData> SelectedValues { get; set; }

        public override void Initialize()
        {

        }
    }
}
