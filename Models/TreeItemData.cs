namespace BlazorApp1.Models;

public class TreeItemData
{
    public string Title { get; set; }

    public string Icon { get; set; }

    public int? Number { get; set; }

    public bool IsExpanded { get; set; }

    public HashSet<TreeItemData> TreeItems { get; set; }

    public TreeItemData(string title, string icon, int? number = null)
    {
        Title = title;
        Icon = icon;
        Number = number;
    }
}