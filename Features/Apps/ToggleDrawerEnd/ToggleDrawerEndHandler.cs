using BlazorState;
using MediatR;

namespace BlazorApp1.Features.Apps;

public partial class AppState
{
    public class ToggleDrawerEndHandler : ActionHandler<ToggleDrawerEndAction>
    {
        public AppState AppState => Store.GetState<AppState>();

        public ToggleDrawerEndHandler(IStore store) : base(store) {}

        public override async Task<Unit> Handle(ToggleDrawerEndAction action, CancellationToken token)
        {
            Console.WriteLine("toggledrawer:end:handler");
            if (AppState.DrawerEnd != action.DrawerEnd)
                AppState.DrawerEnd = action.DrawerEnd;

            return await Unit.Task;
        }
    }
}