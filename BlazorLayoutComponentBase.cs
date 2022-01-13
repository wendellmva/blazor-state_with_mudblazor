#nullable enable
using System.Diagnostics.CodeAnalysis;
using BlazorState;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1;

public class BlazorLayoutComponentBase : BlazorStateComponent
{
    internal const string BodyPropertyName = nameof(Body);

    /// <summary>
    /// Gets the content to be rendered inside the layout.
    /// </summary>
    [Parameter]
    public RenderFragment? Body { get; set; }

    /// <inheritdoc />
    // Derived instances of LayoutComponentBase do not appear in any statically analyzable
    // calls of OpenComponent<T> where T is well-known. Consequently we have to explicitly provide a hint to the trimmer to preserve
    // properties.
    [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(LayoutComponentBase))]
    public override Task SetParametersAsync(ParameterView parameters) => base.SetParametersAsync(parameters);
}