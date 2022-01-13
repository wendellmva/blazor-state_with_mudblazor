using BlazorApp1.Models;
using BlazorState;

namespace BlazorApp1.Features.Apps;

public partial class AppState
{    
    public class SelectedValuesChangedAction : IAction
    {
        public SelectedValuesChangedAction(HashSet<TreeItemData> selectedValues)
        {
            SelectedValues = selectedValues;
        }

        public HashSet<TreeItemData> SelectedValues { get; set; }
    }
}