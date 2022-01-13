using BlazorState;
using MediatR;

namespace BlazorApp1.Features.Apps;

public partial class AppState
{
    public class SelectedValuesChangedHandler : ActionHandler<SelectedValuesChangedAction>
    {
        public AppState AppState => Store.GetState<AppState>();

        public SelectedValuesChangedHandler(IStore store) : base(store) { }

        public override async Task<Unit> Handle(SelectedValuesChangedAction action, CancellationToken token)
        {
            Console.WriteLine("selectedvalues:changed:handler");
            AppState.SelectedValues = action.SelectedValues;
            return await Unit.Task;
        }
    }
}