using BlazorState;
using MediatR;

namespace BlazorApp1.Features.Apps;

public partial class AppState
{
    public class LoadDrawerComponentHandler : ActionHandler<LoadDrawerComponentAction>
    {
        public AppState AppState => Store.GetState<AppState>();

        public LoadDrawerComponentHandler(IStore store) : base(store)
        {
        }

        public override async Task<Unit> Handle(LoadDrawerComponentAction action, CancellationToken aCancellationToken)
        {
            Console.WriteLine("loaddrawer:component:handler");
            AppState.DrawerComponent = action.Component;
            return await Unit.Task;
        }
    }
}