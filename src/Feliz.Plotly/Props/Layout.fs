namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type layout =
    static member inline font (properties: #ILayoutFontProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
    static member inline title (properties: #ILayoutTitleProperty list) = Interop.mkLayoutAttr "title" (createObj !!properties)
    static member inline margin (properties: #ILayoutMarginProperty list) = Interop.mkLayoutAttr "margin" (createObj !!properties)
    static member inline modebar (properties: #ILayoutModebarProperty list) = Interop.mkLayoutAttr "modebar" (createObj !!properties)
    static member inline transition (properties: #ILayoutTransitionProperty list) = Interop.mkLayoutAttr "transition" (createObj !!properties)
    static member inline hoverlabel (properties: #ILayoutHoverlabelProperty list) = Interop.mkLayoutAttr "hoverlabel" (createObj !!properties)
    static member inline grid (properties: #ILayoutGridProperty list) = Interop.mkLayoutAttr "grid" (createObj !!properties)
    static member inline xaxis (properties: #ILayoutXaxisProperty list) = Interop.mkLayoutAttr "xaxis" (createObj !!properties)
    static member inline yaxis (properties: #ILayoutYaxisProperty list) = Interop.mkLayoutAttr "yaxis" (createObj !!properties)
    static member inline ternary (properties: #ILayoutTernaryProperty list) = Interop.mkLayoutAttr "ternary" (createObj !!properties)
    static member inline scene (properties: #ILayoutSceneProperty list) = Interop.mkLayoutAttr "scene" (createObj !!properties)
    static member inline geo (properties: #ILayoutGeoProperty list) = Interop.mkLayoutAttr "geo" (createObj !!properties)
    static member inline mapbox (properties: #ILayoutMapboxProperty list) = Interop.mkLayoutAttr "mapbox" (createObj !!properties)
    static member inline polar (properties: #ILayoutPolarProperty list) = Interop.mkLayoutAttr "polar" (createObj !!properties)
    static member inline radialaxis (properties: #ILayoutRadialaxisProperty list) = Interop.mkLayoutAttr "radialaxis" (createObj !!properties)
    static member inline angularaxis (properties: #ILayoutAngularaxisProperty list) = Interop.mkLayoutAttr "angularaxis" (createObj !!properties)
    static member inline legend (properties: #ILayoutLegendProperty list) = Interop.mkLayoutAttr "legend" (createObj !!properties)
    static member inline annotations (properties: #ILayoutAnnotationsProperty list) = Interop.mkLayoutAttr "annotations" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    static member inline shapes (properties: #ILayoutShapesProperty list) = Interop.mkLayoutAttr "shapes" (createObj !!properties)
    static member inline images (properties: #ILayoutImagesProperty list) = Interop.mkLayoutAttr "images" (createObj !!properties)
    static member inline updatemenus (properties: #ILayoutUpdatemenusProperty list) = Interop.mkLayoutAttr "updatemenus" (createObj !!properties)
    static member inline sliders (properties: #ILayoutSlidersProperty list) = Interop.mkLayoutAttr "sliders" (createObj !!properties)
    static member inline colorscale (properties: #ILayoutColorscaleProperty list) = Interop.mkLayoutAttr "colorscale" (createObj !!properties)
    static member inline coloraxis (properties: #ILayoutColoraxisProperty list) = Interop.mkLayoutAttr "coloraxis" (createObj !!properties)
    static member inline bar (properties: #ILayoutBarProperty list) = Interop.mkLayoutAttr "bar" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline box (properties: #ILayoutBoxProperty list) = Interop.mkLayoutAttr "box" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline histogram (properties: #ILayoutHistogramProperty list) = Interop.mkLayoutAttr "histogram" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline violin (properties: #ILayoutViolinProperty list) = Interop.mkLayoutAttr "violin" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline funnel (properties: #ILayoutFunnelProperty list) = Interop.mkLayoutAttr "funnel" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline waterfall (properties: #ILayoutWaterfallProperty list) = Interop.mkLayoutAttr "waterfall" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline pie (properties: #ILayoutPieProperty list) = Interop.mkLayoutAttr "pie" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline sunburst (properties: #ILayoutSunburstProperty list) = Interop.mkLayoutAttr "sunburst" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline treemap (properties: #ILayoutTreemapProperty list) = Interop.mkLayoutAttr "treemap" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline funnelarea (properties: #ILayoutFunnelareaProperty list) = Interop.mkLayoutAttr "funnelarea" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline candlestick (properties: #ILayoutCandlestickProperty list) = Interop.mkLayoutAttr "candlestick" (createObj !!(properties |> List.map (Bindings.getKV)))
    static member inline barpolar (properties: #ILayoutBarpolarProperty list) = Interop.mkLayoutAttr "barpolar" (createObj !!(properties |> List.map (Bindings.getKV)))
    /// Determines whether or not a layout width or height that has been left undefined by the user is initialized on each relayout. Note that, regardless of this attribute, an undefined layout width or height is always initialized on the first call to plot.
    static member inline autosize (value: bool) = Interop.mkLayoutAttr "autosize" value
    /// Sets the plot's width (in px).
    static member inline width (value: int) = Interop.mkLayoutAttr "width" value
    /// Sets the plot's width (in px).
    static member inline width (value: float) = Interop.mkLayoutAttr "width" value
    /// Sets the plot's height (in px).
    static member inline height (value: int) = Interop.mkLayoutAttr "height" value
    /// Sets the plot's height (in px).
    static member inline height (value: float) = Interop.mkLayoutAttr "height" value
    /// Sets the color of paper where the graph is drawn.
    static member inline paperBgcolor (value: string) = Interop.mkLayoutAttr "paper_bgcolor" value
    /// Sets the color of plotting area in-between x and y axes.
    static member inline plotBgcolor (value: string) = Interop.mkLayoutAttr "plot_bgcolor" value
    /// Sets the decimal and thousand separators. For example, *. * puts a '.' before decimals and a space between thousands. In English locales, dflt is *.,* but other locales may alter this default.
    static member inline separators (value: string) = Interop.mkLayoutAttr "separators" value
    /// Determines whether or not a text link citing the data source is placed at the bottom-right cored of the figure. Has only an effect only on graphs that have been generated via forked graphs from the plotly service (at https://plot.ly or on-premise).
    static member inline hidesources (value: bool) = Interop.mkLayoutAttr "hidesources" value
    /// Determines whether or not a legend is drawn. Default is `true` if there is a trace to show and any of these: a) Two or more traces would by default be shown in the legend. b) One pie trace is shown in the legend. c) One trace is explicitly given with `showlegend: true`.
    static member inline showlegend (value: bool) = Interop.mkLayoutAttr "showlegend" value
    /// Sets the default trace colors.
    static member inline colorway (values: seq<string>) = Interop.mkLayoutAttr "colorway" (values |> Array.ofSeq)
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: bool) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<bool>) = Interop.mkLayoutAttr "datarevision" (values |> Array.ofSeq)
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: string) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<string>) = Interop.mkLayoutAttr "datarevision" (values |> Array.ofSeq)
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: int) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<int>) = Interop.mkLayoutAttr "datarevision" (values |> Array.ofSeq)
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: float) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<float>) = Interop.mkLayoutAttr "datarevision" (values |> Array.ofSeq)
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: bool) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<bool>) = Interop.mkLayoutAttr "uirevision" (values |> Array.ofSeq)
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: string) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<string>) = Interop.mkLayoutAttr "uirevision" (values |> Array.ofSeq)
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: int) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<int>) = Interop.mkLayoutAttr "uirevision" (values |> Array.ofSeq)
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: float) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<float>) = Interop.mkLayoutAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: bool) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<bool>) = Interop.mkLayoutAttr "editrevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: string) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<string>) = Interop.mkLayoutAttr "editrevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: int) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<int>) = Interop.mkLayoutAttr "editrevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: float) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<float>) = Interop.mkLayoutAttr "editrevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: bool) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<bool>) = Interop.mkLayoutAttr "selectionrevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: string) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<string>) = Interop.mkLayoutAttr "selectionrevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: int) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<int>) = Interop.mkLayoutAttr "selectionrevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: float) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<float>) = Interop.mkLayoutAttr "selectionrevision" (values |> Array.ofSeq)
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: bool) = Interop.mkLayoutAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<bool>) = Interop.mkLayoutAttr "template" (values |> Array.ofSeq)
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: string) = Interop.mkLayoutAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<string>) = Interop.mkLayoutAttr "template" (values |> Array.ofSeq)
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: int) = Interop.mkLayoutAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<int>) = Interop.mkLayoutAttr "template" (values |> Array.ofSeq)
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: float) = Interop.mkLayoutAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<float>) = Interop.mkLayoutAttr "template" (values |> Array.ofSeq)
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: bool) = Interop.mkLayoutAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<bool>) = Interop.mkLayoutAttr "meta" (values |> Array.ofSeq)
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: string) = Interop.mkLayoutAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<string>) = Interop.mkLayoutAttr "meta" (values |> Array.ofSeq)
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: int) = Interop.mkLayoutAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<int>) = Interop.mkLayoutAttr "meta" (values |> Array.ofSeq)
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: float) = Interop.mkLayoutAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<float>) = Interop.mkLayoutAttr "meta" (values |> Array.ofSeq)
    /// Sets the default distance (in pixels) to look for data to add hover labels (-1 means no cutoff, 0 means no looking for data). This is only a real distance for hovering on point-like objects, like scatter points. For area-like objects (bars, scatter fills, etc) hovering is on inside the area and off outside, but these objects will not supersede hover on point-like objects in case of conflict.
    static member inline hoverdistance (value: int) = Interop.mkLayoutAttr "hoverdistance" value
    /// Sets the default distance (in pixels) to look for data to draw spikelines to (-1 means no cutoff, 0 means no looking for data). As with hoverdistance, distance does not apply to area-like objects. In addition, some objects can be hovered on but will not generate spikelines, such as scatter fills.
    static member inline spikedistance (value: int) = Interop.mkLayoutAttr "spikedistance" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Rotates the entire polar by the given angle in legacy polar charts.
    static member inline orientation (value: int) = Interop.mkLayoutAttr "orientation" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Rotates the entire polar by the given angle in legacy polar charts.
    static member inline orientation (value: float) = Interop.mkLayoutAttr "orientation" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkLayoutAttr "metasrc" value

[<AutoOpen>]
module layout =
    /// Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
    [<Erase>]
    type clickmode =
        static member inline none = Interop.mkLayoutAttr "clickmode" "none"
        static member inline event = Interop.mkLayoutAttr "clickmode" "event"
        static member inline select = Interop.mkLayoutAttr "clickmode" "select"
        static member inline selectAndEvent = Interop.mkLayoutAttr "clickmode" "select+event"

    /// Determines the mode of drag interactions. *select* and *lasso* apply only to scatter traces with markers or text. *orbit* and *turntable* apply only to 3D scenes.
    [<Erase>]
    type dragmode =
        static member inline lasso = Interop.mkLayoutAttr "dragmode" "lasso"
        static member inline orbit = Interop.mkLayoutAttr "dragmode" "orbit"
        static member inline pan = Interop.mkLayoutAttr "dragmode" "pan"
        static member inline select = Interop.mkLayoutAttr "dragmode" "select"
        static member inline turntable = Interop.mkLayoutAttr "dragmode" "turntable"
        static member inline zoom = Interop.mkLayoutAttr "dragmode" "zoom"
        static member inline false' = Interop.mkLayoutAttr "dragmode" "false"

    /// Determines the mode of hover interactions. If `clickmode` includes the *select* flag, `hovermode` defaults to *closest*. If `clickmode` lacks the *select* flag, it defaults to *x* or *y* (depending on the trace's `orientation` value) for plots based on cartesian coordinates. For anything else the default value is *closest*.
    [<Erase>]
    type hovermode =
        static member inline closest = Interop.mkLayoutAttr "hovermode" "closest"
        static member inline x = Interop.mkLayoutAttr "hovermode" "x"
        static member inline y = Interop.mkLayoutAttr "hovermode" "y"
        static member inline false' = Interop.mkLayoutAttr "hovermode" "false"

    /// When \"dragmode\" is set to \"select\", this limits the selection of the drag to horizontal, vertical or diagonal. \"h\" only allows horizontal selection, \"v\" only vertical, \"d\" only diagonal and \"any\" sets no limit.
    [<Erase>]
    type selectdirection =
        static member inline any = Interop.mkLayoutAttr "selectdirection" "any"
        static member inline d = Interop.mkLayoutAttr "selectdirection" "d"
        static member inline h = Interop.mkLayoutAttr "selectdirection" "h"
        static member inline v = Interop.mkLayoutAttr "selectdirection" "v"

    /// Sets the default calendar system to use for interpreting and displaying dates throughout the plot.
    [<Erase>]
    type calendar =
        static member inline chinese = Interop.mkLayoutAttr "calendar" "chinese"
        static member inline coptic = Interop.mkLayoutAttr "calendar" "coptic"
        static member inline discworld = Interop.mkLayoutAttr "calendar" "discworld"
        static member inline ethiopian = Interop.mkLayoutAttr "calendar" "ethiopian"
        static member inline gregorian = Interop.mkLayoutAttr "calendar" "gregorian"
        static member inline hebrew = Interop.mkLayoutAttr "calendar" "hebrew"
        static member inline islamic = Interop.mkLayoutAttr "calendar" "islamic"
        static member inline jalali = Interop.mkLayoutAttr "calendar" "jalali"
        static member inline julian = Interop.mkLayoutAttr "calendar" "julian"
        static member inline mayan = Interop.mkLayoutAttr "calendar" "mayan"
        static member inline nanakshahi = Interop.mkLayoutAttr "calendar" "nanakshahi"
        static member inline nepali = Interop.mkLayoutAttr "calendar" "nepali"
        static member inline persian = Interop.mkLayoutAttr "calendar" "persian"
        static member inline taiwan = Interop.mkLayoutAttr "calendar" "taiwan"
        static member inline thai = Interop.mkLayoutAttr "calendar" "thai"
        static member inline ummalqura = Interop.mkLayoutAttr "calendar" "ummalqura"

    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the direction corresponding to positive angles in legacy polar charts.
    [<Erase>]
    type direction =
        static member inline clockwise = Interop.mkLayoutAttr "direction" "clockwise"
        static member inline counterclockwise = Interop.mkLayoutAttr "direction" "counterclockwise"

    [<Erase>]
    type font =
        static member inline description (properties: #ILayoutFontDescriptionProperty list) = Interop.mkLayoutFontAttr "description" (createObj !!properties)
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        static member inline family (value: string) = Interop.mkLayoutFontAttr "family" value
        static member inline size (value: int) = Interop.mkLayoutFontAttr "size" value
        static member inline size (value: float) = Interop.mkLayoutFontAttr "size" value
        static member inline color (value: string) = Interop.mkLayoutFontAttr "color" value

    [<Erase>]
    type title =
        static member inline font (properties: #ILayoutTitleFontProperty list) = Interop.mkLayoutTitleAttr "font" (createObj !!properties)
        static member inline pad (properties: #ILayoutTitlePadProperty list) = Interop.mkLayoutTitleAttr "pad" (createObj !!properties)
        /// Sets the plot's title. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
        static member inline text (value: string) = Interop.mkLayoutTitleAttr "text" value
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        static member inline x (value: int) = Interop.mkLayoutTitleAttr "x" value
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        static member inline x (value: float) = Interop.mkLayoutTitleAttr "x" value
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        static member inline y (value: int) = Interop.mkLayoutTitleAttr "y" value
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        static member inline y (value: float) = Interop.mkLayoutTitleAttr "y" value

    [<AutoOpen>]
    module title =
        /// Sets the container `x` refers to. *container* spans the entire `width` of the plot. *paper* refers to the width of the plotting area only.
        [<Erase>]
        type xref =
            static member inline container = Interop.mkLayoutTitleAttr "xref" "container"
            static member inline paper = Interop.mkLayoutTitleAttr "xref" "paper"

        /// Sets the container `y` refers to. *container* spans the entire `height` of the plot. *paper* refers to the height of the plotting area only.
        [<Erase>]
        type yref =
            static member inline container = Interop.mkLayoutTitleAttr "yref" "container"
            static member inline paper = Interop.mkLayoutTitleAttr "yref" "paper"

        /// Sets the title's horizontal alignment with respect to its x position. *left* means that the title starts at x, *right* means that the title ends at x and *center* means that the title's center is at x. *auto* divides `xref` by three and calculates the `xanchor` value automatically based on the value of `x`.
        [<Erase>]
        type xanchor =
            static member inline auto = Interop.mkLayoutTitleAttr "xanchor" "auto"
            static member inline center = Interop.mkLayoutTitleAttr "xanchor" "center"
            static member inline left = Interop.mkLayoutTitleAttr "xanchor" "left"
            static member inline right = Interop.mkLayoutTitleAttr "xanchor" "right"

        /// Sets the title's vertical alignment with respect to its y position. *top* means that the title's cap line is at y, *bottom* means that the title's baseline is at y and *middle* means that the title's midline is at y. *auto* divides `yref` by three and calculates the `yanchor` value automatically based on the value of `y`.
        [<Erase>]
        type yanchor =
            static member inline auto = Interop.mkLayoutTitleAttr "yanchor" "auto"
            static member inline bottom = Interop.mkLayoutTitleAttr "yanchor" "bottom"
            static member inline middle = Interop.mkLayoutTitleAttr "yanchor" "middle"
            static member inline top = Interop.mkLayoutTitleAttr "yanchor" "top"

        [<Erase>]
        type font =
            static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutTitleFontAttr "description" (createObj !!properties)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutTitleFontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutTitleFontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutTitleFontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutTitleFontAttr "color" value

        [<Erase>]
        type pad =
            static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutTitlePadAttr "description" (createObj !!properties)
            /// The amount of padding (in px) along the top of the component.
            static member inline t (value: int) = Interop.mkLayoutTitlePadAttr "t" value
            /// The amount of padding (in px) along the top of the component.
            static member inline t (value: float) = Interop.mkLayoutTitlePadAttr "t" value
            /// The amount of padding (in px) on the right side of the component.
            static member inline r (value: int) = Interop.mkLayoutTitlePadAttr "r" value
            /// The amount of padding (in px) on the right side of the component.
            static member inline r (value: float) = Interop.mkLayoutTitlePadAttr "r" value
            /// The amount of padding (in px) along the bottom of the component.
            static member inline b (value: int) = Interop.mkLayoutTitlePadAttr "b" value
            /// The amount of padding (in px) along the bottom of the component.
            static member inline b (value: float) = Interop.mkLayoutTitlePadAttr "b" value
            /// The amount of padding (in px) on the left side of the component.
            static member inline l (value: int) = Interop.mkLayoutTitlePadAttr "l" value
            /// The amount of padding (in px) on the left side of the component.
            static member inline l (value: float) = Interop.mkLayoutTitlePadAttr "l" value

    [<Erase>]
    type margin =
        /// Sets the left margin (in px).
        static member inline l (value: int) = Interop.mkLayoutMarginAttr "l" value
        /// Sets the left margin (in px).
        static member inline l (value: float) = Interop.mkLayoutMarginAttr "l" value
        /// Sets the right margin (in px).
        static member inline r (value: int) = Interop.mkLayoutMarginAttr "r" value
        /// Sets the right margin (in px).
        static member inline r (value: float) = Interop.mkLayoutMarginAttr "r" value
        /// Sets the top margin (in px).
        static member inline t (value: int) = Interop.mkLayoutMarginAttr "t" value
        /// Sets the top margin (in px).
        static member inline t (value: float) = Interop.mkLayoutMarginAttr "t" value
        /// Sets the bottom margin (in px).
        static member inline b (value: int) = Interop.mkLayoutMarginAttr "b" value
        /// Sets the bottom margin (in px).
        static member inline b (value: float) = Interop.mkLayoutMarginAttr "b" value
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        static member inline pad (value: int) = Interop.mkLayoutMarginAttr "pad" value
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        static member inline pad (value: float) = Interop.mkLayoutMarginAttr "pad" value
        /// Turns on/off margin expansion computations. Legends, colorbars, updatemenus, sliders, axis rangeselector and rangeslider are allowed to push the margins by defaults.
        static member inline autoexpand (value: bool) = Interop.mkLayoutMarginAttr "autoexpand" value

    [<Erase>]
    type modebar =
        /// Sets the background color of the modebar.
        static member inline bgcolor (value: string) = Interop.mkLayoutModebarAttr "bgcolor" value
        /// Sets the color of the icons in the modebar.
        static member inline color (value: string) = Interop.mkLayoutModebarAttr "color" value
        /// Sets the color of the active or hovered on icons in the modebar.
        static member inline activecolor (value: string) = Interop.mkLayoutModebarAttr "activecolor" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutModebarAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutModebarAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutModebarAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutModebarAttr "uirevision" (values |> Array.ofSeq)

    [<AutoOpen>]
    module modebar =
        /// Sets the orientation of the modebar.
        [<Erase>]
        type orientation =
            static member inline h = Interop.mkLayoutModebarAttr "orientation" "h"
            static member inline v = Interop.mkLayoutModebarAttr "orientation" "v"

    [<Erase>]
    type transition =
        static member inline description (properties: #ILayoutTransitionDescriptionProperty list) = Interop.mkLayoutTransitionAttr "description" (createObj !!properties)
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        static member inline duration (value: int) = Interop.mkLayoutTransitionAttr "duration" value
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        static member inline duration (value: float) = Interop.mkLayoutTransitionAttr "duration" value

    [<AutoOpen>]
    module transition =
        /// The easing function used for the transition
        [<Erase>]
        type easing =
            static member inline back = Interop.mkLayoutTransitionAttr "easing" "back"
            static member inline backIn = Interop.mkLayoutTransitionAttr "easing" "back-in"
            static member inline backInOut = Interop.mkLayoutTransitionAttr "easing" "back-in-out"
            static member inline backOut = Interop.mkLayoutTransitionAttr "easing" "back-out"
            static member inline bounce = Interop.mkLayoutTransitionAttr "easing" "bounce"
            static member inline bounceIn = Interop.mkLayoutTransitionAttr "easing" "bounce-in"
            static member inline bounceInOut = Interop.mkLayoutTransitionAttr "easing" "bounce-in-out"
            static member inline bounceOut = Interop.mkLayoutTransitionAttr "easing" "bounce-out"
            static member inline circle = Interop.mkLayoutTransitionAttr "easing" "circle"
            static member inline circleIn = Interop.mkLayoutTransitionAttr "easing" "circle-in"
            static member inline circleInOut = Interop.mkLayoutTransitionAttr "easing" "circle-in-out"
            static member inline circleOut = Interop.mkLayoutTransitionAttr "easing" "circle-out"
            static member inline cubic = Interop.mkLayoutTransitionAttr "easing" "cubic"
            static member inline cubicIn = Interop.mkLayoutTransitionAttr "easing" "cubic-in"
            static member inline cubicInOut = Interop.mkLayoutTransitionAttr "easing" "cubic-in-out"
            static member inline cubicOut = Interop.mkLayoutTransitionAttr "easing" "cubic-out"
            static member inline elastic = Interop.mkLayoutTransitionAttr "easing" "elastic"
            static member inline elasticIn = Interop.mkLayoutTransitionAttr "easing" "elastic-in"
            static member inline elasticInOut = Interop.mkLayoutTransitionAttr "easing" "elastic-in-out"
            static member inline elasticOut = Interop.mkLayoutTransitionAttr "easing" "elastic-out"
            static member inline exp = Interop.mkLayoutTransitionAttr "easing" "exp"
            static member inline expIn = Interop.mkLayoutTransitionAttr "easing" "exp-in"
            static member inline expInOut = Interop.mkLayoutTransitionAttr "easing" "exp-in-out"
            static member inline expOut = Interop.mkLayoutTransitionAttr "easing" "exp-out"
            static member inline linear = Interop.mkLayoutTransitionAttr "easing" "linear"
            static member inline linearIn = Interop.mkLayoutTransitionAttr "easing" "linear-in"
            static member inline linearInOut = Interop.mkLayoutTransitionAttr "easing" "linear-in-out"
            static member inline linearOut = Interop.mkLayoutTransitionAttr "easing" "linear-out"
            static member inline quad = Interop.mkLayoutTransitionAttr "easing" "quad"
            static member inline quadIn = Interop.mkLayoutTransitionAttr "easing" "quad-in"
            static member inline quadInOut = Interop.mkLayoutTransitionAttr "easing" "quad-in-out"
            static member inline quadOut = Interop.mkLayoutTransitionAttr "easing" "quad-out"
            static member inline sin = Interop.mkLayoutTransitionAttr "easing" "sin"
            static member inline sinIn = Interop.mkLayoutTransitionAttr "easing" "sin-in"
            static member inline sinInOut = Interop.mkLayoutTransitionAttr "easing" "sin-in-out"
            static member inline sinOut = Interop.mkLayoutTransitionAttr "easing" "sin-out"

        /// Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change.
        [<Erase>]
        type ordering =
            static member inline layoutFirst = Interop.mkLayoutTransitionAttr "ordering" "layout first"
            static member inline tracesFirst = Interop.mkLayoutTransitionAttr "ordering" "traces first"

    [<Erase>]
    type hoverlabel =
        static member inline font (properties: #ILayoutHoverlabelFontProperty list) = Interop.mkLayoutHoverlabelAttr "font" (createObj !!properties)
        /// Sets the background color of all hover labels on graph
        static member inline bgcolor (value: string) = Interop.mkLayoutHoverlabelAttr "bgcolor" value
        /// Sets the border color of all hover labels on graph.
        static member inline bordercolor (value: string) = Interop.mkLayoutHoverlabelAttr "bordercolor" value
        /// Sets the default length (in number of characters) of the trace name in the hover labels for all traces. -1 shows the whole name regardless of length. 0-3 shows the first 0-3 characters, and an integer >3 will show the whole name if it is less than that many characters, but if it is longer, will truncate to `namelength - 3` characters and add an ellipsis.
        static member inline namelength (value: int) = Interop.mkLayoutHoverlabelAttr "namelength" value

    [<AutoOpen>]
    module hoverlabel =
        /// Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
        [<Erase>]
        type align =
            static member inline auto = Interop.mkLayoutHoverlabelAttr "align" "auto"
            static member inline left = Interop.mkLayoutHoverlabelAttr "align" "left"
            static member inline right = Interop.mkLayoutHoverlabelAttr "align" "right"

        [<Erase>]
        type font =
            static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutHoverlabelFontAttr "description" (createObj !!properties)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutHoverlabelFontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutHoverlabelFontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutHoverlabelFontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutHoverlabelFontAttr "color" value

    [<Erase>]
    type grid =
        static member inline domain (properties: #ILayoutGridDomainProperty list) = Interop.mkLayoutGridAttr "domain" (createObj !!properties)
        /// The number of rows in the grid. If you provide a 2D `subplots` array or a `yaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        static member inline rows (value: int) = Interop.mkLayoutGridAttr "rows" value
        /// The number of columns in the grid. If you provide a 2D `subplots` array, the length of its longest row is used as the default. If you give an `xaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        static member inline columns (value: int) = Interop.mkLayoutGridAttr "columns" value
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        static member inline xgap (value: int) = Interop.mkLayoutGridAttr "xgap" value
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        static member inline xgap (value: float) = Interop.mkLayoutGridAttr "xgap" value
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        static member inline ygap (value: int) = Interop.mkLayoutGridAttr "ygap" value
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        static member inline ygap (value: float) = Interop.mkLayoutGridAttr "ygap" value

    [<AutoOpen>]
    module grid =
        /// Is the first row the top or the bottom? Note that columns are always enumerated from left to right.
        [<Erase>]
        type roworder =
            static member inline bottomToTop = Interop.mkLayoutGridAttr "roworder" "bottom to top"
            static member inline topToBottom = Interop.mkLayoutGridAttr "roworder" "top to bottom"

        /// If no `subplots`, `xaxes`, or `yaxes` are given but we do have `rows` and `columns`, we can generate defaults using consecutive axis IDs, in two ways: *coupled* gives one x axis per column and one y axis per row. *independent* uses a new xy pair for each cell, left-to-right across each row then iterating rows according to `roworder`.
        [<Erase>]
        type pattern =
            static member inline coupled = Interop.mkLayoutGridAttr "pattern" "coupled"
            static member inline independent = Interop.mkLayoutGridAttr "pattern" "independent"

        /// Sets where the x axis labels and titles go. *bottom* means the very bottom of the grid. *bottom plot* is the lowest plot that each x axis is used in. *top* and *top plot* are similar.
        [<Erase>]
        type xside =
            static member inline bottomPlot = Interop.mkLayoutGridAttr "xside" "bottom plot"
            static member inline bottom = Interop.mkLayoutGridAttr "xside" "bottom"
            static member inline topPlot = Interop.mkLayoutGridAttr "xside" "top plot"
            static member inline top = Interop.mkLayoutGridAttr "xside" "top"

        /// Sets where the y axis labels and titles go. *left* means the very left edge of the grid. *left plot* is the leftmost plot that each y axis is used in. *right* and *right plot* are similar.
        [<Erase>]
        type yside =
            static member inline leftPlot = Interop.mkLayoutGridAttr "yside" "left plot"
            static member inline left = Interop.mkLayoutGridAttr "yside" "left"
            static member inline rightPlot = Interop.mkLayoutGridAttr "yside" "right plot"
            static member inline right = Interop.mkLayoutGridAttr "yside" "right"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline x (values: seq<int>) = Interop.mkLayoutGridDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the horizontal domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline x (values: seq<float>) = Interop.mkLayoutGridDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the vertical domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline y (values: seq<int>) = Interop.mkLayoutGridDomainAttr "y" (values |> Array.ofSeq)
            /// Sets the vertical domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline y (values: seq<float>) = Interop.mkLayoutGridDomainAttr "y" (values |> Array.ofSeq)

    [<Erase>]
    type xaxis =
        static member inline title (properties: #ILayoutXaxisTitleProperty list) = Interop.mkLayoutXaxisAttr "title" (createObj !!properties)
        static member inline tickfont (properties: #ILayoutXaxisTickfontProperty list) = Interop.mkLayoutXaxisAttr "tickfont" (createObj !!properties)
        static member inline tickformatstops (properties: #ILayoutXaxisTickformatstopsProperty list) = Interop.mkLayoutXaxisAttr "tickformatstops" (createObj !!properties)
        static member inline rangeslider (properties: #ILayoutXaxisRangesliderProperty list) = Interop.mkLayoutXaxisAttr "rangeslider" (createObj !!properties)
        static member inline rangeselector (properties: #ILayoutXaxisRangeselectorProperty list) = Interop.mkLayoutXaxisAttr "rangeselector" (createObj !!properties)
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        static member inline visible (value: bool) = Interop.mkLayoutXaxisAttr "visible" value
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline color (value: string) = Interop.mkLayoutXaxisAttr "color" value
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<bool>) = Interop.mkLayoutXaxisAttr "range" (values |> Array.ofSeq)
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<int>) = Interop.mkLayoutXaxisAttr "range" (values |> Array.ofSeq)
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<float>) = Interop.mkLayoutXaxisAttr "range" (values |> Array.ofSeq)
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<string>) = Interop.mkLayoutXaxisAttr "range" (values |> Array.ofSeq)
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        static member inline fixedrange (value: bool) = Interop.mkLayoutXaxisAttr "fixedrange" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        static member inline scaleanchor (value: string) = Interop.mkLayoutXaxisAttr "scaleanchor" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: int) = Interop.mkLayoutXaxisAttr "scaleratio" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: float) = Interop.mkLayoutXaxisAttr "scaleratio" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        static member inline matches (value: string) = Interop.mkLayoutXaxisAttr "matches" value
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        static member inline nticks (value: int) = Interop.mkLayoutXaxisAttr "nticks" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: bool) = Interop.mkLayoutXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<bool>) = Interop.mkLayoutXaxisAttr "tick0" (values |> Array.ofSeq)
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: string) = Interop.mkLayoutXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<string>) = Interop.mkLayoutXaxisAttr "tick0" (values |> Array.ofSeq)
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: int) = Interop.mkLayoutXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<int>) = Interop.mkLayoutXaxisAttr "tick0" (values |> Array.ofSeq)
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: float) = Interop.mkLayoutXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<float>) = Interop.mkLayoutXaxisAttr "tick0" (values |> Array.ofSeq)
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: bool) = Interop.mkLayoutXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<bool>) = Interop.mkLayoutXaxisAttr "dtick" (values |> Array.ofSeq)
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: string) = Interop.mkLayoutXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<string>) = Interop.mkLayoutXaxisAttr "dtick" (values |> Array.ofSeq)
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: int) = Interop.mkLayoutXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<int>) = Interop.mkLayoutXaxisAttr "dtick" (values |> Array.ofSeq)
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: float) = Interop.mkLayoutXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<float>) = Interop.mkLayoutXaxisAttr "dtick" (values |> Array.ofSeq)
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<bool>) = Interop.mkLayoutXaxisAttr "tickvals" (values |> Array.ofSeq)
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<string>) = Interop.mkLayoutXaxisAttr "tickvals" (values |> Array.ofSeq)
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<int>) = Interop.mkLayoutXaxisAttr "tickvals" (values |> Array.ofSeq)
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<float>) = Interop.mkLayoutXaxisAttr "tickvals" (values |> Array.ofSeq)
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<bool>) = Interop.mkLayoutXaxisAttr "ticktext" (values |> Array.ofSeq)
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<string>) = Interop.mkLayoutXaxisAttr "ticktext" (values |> Array.ofSeq)
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<int>) = Interop.mkLayoutXaxisAttr "ticktext" (values |> Array.ofSeq)
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<float>) = Interop.mkLayoutXaxisAttr "ticktext" (values |> Array.ofSeq)
        /// Sets the tick length (in px).
        static member inline ticklen (value: int) = Interop.mkLayoutXaxisAttr "ticklen" value
        /// Sets the tick length (in px).
        static member inline ticklen (value: float) = Interop.mkLayoutXaxisAttr "ticklen" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: int) = Interop.mkLayoutXaxisAttr "tickwidth" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: float) = Interop.mkLayoutXaxisAttr "tickwidth" value
        /// Sets the tick color.
        static member inline tickcolor (value: string) = Interop.mkLayoutXaxisAttr "tickcolor" value
        /// Determines whether or not the tick labels are drawn.
        static member inline showticklabels (value: bool) = Interop.mkLayoutXaxisAttr "showticklabels" value
        /// Determines whether long tick labels automatically grow the figure margins.
        static member inline automargin (value: bool) = Interop.mkLayoutXaxisAttr "automargin" value
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        static member inline showspikes (value: bool) = Interop.mkLayoutXaxisAttr "showspikes" value
        /// Sets the spike color. If undefined, will use the series color
        static member inline spikecolor (value: string) = Interop.mkLayoutXaxisAttr "spikecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: int) = Interop.mkLayoutXaxisAttr "spikethickness" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: float) = Interop.mkLayoutXaxisAttr "spikethickness" value
        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        static member inline spikedash (value: string) = Interop.mkLayoutXaxisAttr "spikedash" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: int) = Interop.mkLayoutXaxisAttr "tickangle" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: float) = Interop.mkLayoutXaxisAttr "tickangle" value
        /// Sets a tick label prefix.
        static member inline tickprefix (value: string) = Interop.mkLayoutXaxisAttr "tickprefix" value
        /// Sets a tick label suffix.
        static member inline ticksuffix (value: string) = Interop.mkLayoutXaxisAttr "ticksuffix" value
        /// If \"true\", even 4-digit integers are separated
        static member inline separatethousands (value: bool) = Interop.mkLayoutXaxisAttr "separatethousands" value
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline tickformat (value: string) = Interop.mkLayoutXaxisAttr "tickformat" value
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline hoverformat (value: string) = Interop.mkLayoutXaxisAttr "hoverformat" value
        /// Determines whether or not a line bounding this axis is drawn.
        static member inline showline (value: bool) = Interop.mkLayoutXaxisAttr "showline" value
        /// Sets the axis line color.
        static member inline linecolor (value: string) = Interop.mkLayoutXaxisAttr "linecolor" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: int) = Interop.mkLayoutXaxisAttr "linewidth" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: float) = Interop.mkLayoutXaxisAttr "linewidth" value
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        static member inline showgrid (value: bool) = Interop.mkLayoutXaxisAttr "showgrid" value
        /// Sets the color of the grid lines.
        static member inline gridcolor (value: string) = Interop.mkLayoutXaxisAttr "gridcolor" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: int) = Interop.mkLayoutXaxisAttr "gridwidth" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: float) = Interop.mkLayoutXaxisAttr "gridwidth" value
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        static member inline zeroline (value: bool) = Interop.mkLayoutXaxisAttr "zeroline" value
        /// Sets the line color of the zero line.
        static member inline zerolinecolor (value: string) = Interop.mkLayoutXaxisAttr "zerolinecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: int) = Interop.mkLayoutXaxisAttr "zerolinewidth" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: float) = Interop.mkLayoutXaxisAttr "zerolinewidth" value
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        static member inline showdividers (value: bool) = Interop.mkLayoutXaxisAttr "showdividers" value
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        static member inline dividercolor (value: string) = Interop.mkLayoutXaxisAttr "dividercolor" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: int) = Interop.mkLayoutXaxisAttr "dividerwidth" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: float) = Interop.mkLayoutXaxisAttr "dividerwidth" value
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<int>) = Interop.mkLayoutXaxisAttr "domain" (values |> Array.ofSeq)
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<float>) = Interop.mkLayoutXaxisAttr "domain" (values |> Array.ofSeq)
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: int) = Interop.mkLayoutXaxisAttr "position" value
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: float) = Interop.mkLayoutXaxisAttr "position" value
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutXaxisAttr "categoryarray" (values |> Array.ofSeq)
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<string>) = Interop.mkLayoutXaxisAttr "categoryarray" (values |> Array.ofSeq)
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<int>) = Interop.mkLayoutXaxisAttr "categoryarray" (values |> Array.ofSeq)
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<float>) = Interop.mkLayoutXaxisAttr "categoryarray" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutXaxisAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutXaxisAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutXaxisAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutXaxisAttr "uirevision" (values |> Array.ofSeq)
        /// Sets the source reference on plot.ly for  tickvals .
        static member inline tickvalssrc (value: string) = Interop.mkLayoutXaxisAttr "tickvalssrc" value
        /// Sets the source reference on plot.ly for  ticktext .
        static member inline ticktextsrc (value: string) = Interop.mkLayoutXaxisAttr "ticktextsrc" value
        /// Sets the source reference on plot.ly for  categoryarray .
        static member inline categoryarraysrc (value: string) = Interop.mkLayoutXaxisAttr "categoryarraysrc" value

    [<AutoOpen>]
    module xaxis =
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        [<Erase>]
        type type' =
            static member inline dash = Interop.mkLayoutXaxisAttr "type" "-"
            static member inline category = Interop.mkLayoutXaxisAttr "type" "category"
            static member inline date = Interop.mkLayoutXaxisAttr "type" "date"
            static member inline linear = Interop.mkLayoutXaxisAttr "type" "linear"
            static member inline log = Interop.mkLayoutXaxisAttr "type" "log"
            static member inline multicategory = Interop.mkLayoutXaxisAttr "type" "multicategory"

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        [<Erase>]
        type autorange =
            static member inline reversed = Interop.mkLayoutXaxisAttr "autorange" "reversed"
            static member inline false' = Interop.mkLayoutXaxisAttr "autorange" "false"
            static member inline true' = Interop.mkLayoutXaxisAttr "autorange" "true"

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        [<Erase>]
        type rangemode =
            static member inline nonnegative = Interop.mkLayoutXaxisAttr "rangemode" "nonnegative"
            static member inline normal = Interop.mkLayoutXaxisAttr "rangemode" "normal"
            static member inline tozero = Interop.mkLayoutXaxisAttr "rangemode" "tozero"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        [<Erase>]
        type constrain =
            static member inline domain = Interop.mkLayoutXaxisAttr "constrain" "domain"
            static member inline range = Interop.mkLayoutXaxisAttr "constrain" "range"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        [<Erase>]
        type constraintoward =
            static member inline bottom = Interop.mkLayoutXaxisAttr "constraintoward" "bottom"
            static member inline center = Interop.mkLayoutXaxisAttr "constraintoward" "center"
            static member inline left = Interop.mkLayoutXaxisAttr "constraintoward" "left"
            static member inline middle = Interop.mkLayoutXaxisAttr "constraintoward" "middle"
            static member inline right = Interop.mkLayoutXaxisAttr "constraintoward" "right"
            static member inline top = Interop.mkLayoutXaxisAttr "constraintoward" "top"

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        [<Erase>]
        type tickmode =
            static member inline array = Interop.mkLayoutXaxisAttr "tickmode" "array"
            static member inline auto = Interop.mkLayoutXaxisAttr "tickmode" "auto"
            static member inline linear = Interop.mkLayoutXaxisAttr "tickmode" "linear"

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        [<Erase>]
        type ticks =
            static member inline none = Interop.mkLayoutXaxisAttr "ticks" ""
            static member inline inside = Interop.mkLayoutXaxisAttr "ticks" "inside"
            static member inline outside = Interop.mkLayoutXaxisAttr "ticks" "outside"

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        [<Erase>]
        type tickson =
            static member inline boundaries = Interop.mkLayoutXaxisAttr "tickson" "boundaries"
            static member inline labels = Interop.mkLayoutXaxisAttr "tickson" "labels"

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        [<Erase>]
        type mirror =
            static member inline all = Interop.mkLayoutXaxisAttr "mirror" "all"
            static member inline allticks = Interop.mkLayoutXaxisAttr "mirror" "allticks"
            static member inline ticks = Interop.mkLayoutXaxisAttr "mirror" "ticks"
            static member inline false' = Interop.mkLayoutXaxisAttr "mirror" "false"
            static member inline true' = Interop.mkLayoutXaxisAttr "mirror" "true"

        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        [<Erase>]
        type spikemode =
            static member inline across = Interop.mkLayoutXaxisAttr "spikemode" "across"
            static member inline acrossAndToaxis = Interop.mkLayoutXaxisAttr "spikemode" "across+toaxis"
            static member inline marker = Interop.mkLayoutXaxisAttr "spikemode" "marker"
            static member inline markerAndAcross = Interop.mkLayoutXaxisAttr "spikemode" "marker+across"
            static member inline markerAndAcrossToaxis = Interop.mkLayoutXaxisAttr "spikemode" "marker+across+toaxis"
            static member inline markerAndToaxis = Interop.mkLayoutXaxisAttr "spikemode" "marker+toaxis"
            static member inline toaxis = Interop.mkLayoutXaxisAttr "spikemode" "toaxis"

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        [<Erase>]
        type spikesnap =
            static member inline cursor = Interop.mkLayoutXaxisAttr "spikesnap" "cursor"
            static member inline data = Interop.mkLayoutXaxisAttr "spikesnap" "data"

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        [<Erase>]
        type showtickprefix =
            static member inline all = Interop.mkLayoutXaxisAttr "showtickprefix" "all"
            static member inline first = Interop.mkLayoutXaxisAttr "showtickprefix" "first"
            static member inline last = Interop.mkLayoutXaxisAttr "showtickprefix" "last"
            static member inline none = Interop.mkLayoutXaxisAttr "showtickprefix" "none"

        /// Same as `showtickprefix` but for tick suffixes.
        [<Erase>]
        type showticksuffix =
            static member inline all = Interop.mkLayoutXaxisAttr "showticksuffix" "all"
            static member inline first = Interop.mkLayoutXaxisAttr "showticksuffix" "first"
            static member inline last = Interop.mkLayoutXaxisAttr "showticksuffix" "last"
            static member inline none = Interop.mkLayoutXaxisAttr "showticksuffix" "none"

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        [<Erase>]
        type showexponent =
            static member inline all = Interop.mkLayoutXaxisAttr "showexponent" "all"
            static member inline first = Interop.mkLayoutXaxisAttr "showexponent" "first"
            static member inline last = Interop.mkLayoutXaxisAttr "showexponent" "last"
            static member inline none = Interop.mkLayoutXaxisAttr "showexponent" "none"

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        [<Erase>]
        type exponentformat =
            static member inline B = Interop.mkLayoutXaxisAttr "exponentformat" "B"
            static member inline E = Interop.mkLayoutXaxisAttr "exponentformat" "E"
            static member inline SI = Interop.mkLayoutXaxisAttr "exponentformat" "SI"
            static member inline e = Interop.mkLayoutXaxisAttr "exponentformat" "e"
            static member inline none = Interop.mkLayoutXaxisAttr "exponentformat" "none"
            static member inline power = Interop.mkLayoutXaxisAttr "exponentformat" "power"

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        [<Erase>]
        type anchor =
            static member inline free = Interop.mkLayoutXaxisAttr "anchor" "free"
            static member inline custom (value: string) = Interop.mkLayoutXaxisAttr "anchor" value

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        [<Erase>]
        type side =
            static member inline bottom = Interop.mkLayoutXaxisAttr "side" "bottom"
            static member inline left = Interop.mkLayoutXaxisAttr "side" "left"
            static member inline right = Interop.mkLayoutXaxisAttr "side" "right"
            static member inline top = Interop.mkLayoutXaxisAttr "side" "top"

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        [<Erase>]
        type overlaying =
            static member inline free = Interop.mkLayoutXaxisAttr "overlaying" "free"
            static member inline custom (value: string) = Interop.mkLayoutXaxisAttr "overlaying" value

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        [<Erase>]
        type layer =
            static member inline aboveTraces = Interop.mkLayoutXaxisAttr "layer" "above traces"
            static member inline belowTraces = Interop.mkLayoutXaxisAttr "layer" "below traces"

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        [<Erase>]
        type categoryorder =
            static member inline array = Interop.mkLayoutXaxisAttr "categoryorder" "array"
            static member inline categoryAscending = Interop.mkLayoutXaxisAttr "categoryorder" "category ascending"
            static member inline categoryDescending = Interop.mkLayoutXaxisAttr "categoryorder" "category descending"
            static member inline maxAscending = Interop.mkLayoutXaxisAttr "categoryorder" "max ascending"
            static member inline maxDescending = Interop.mkLayoutXaxisAttr "categoryorder" "max descending"
            static member inline meanAscending = Interop.mkLayoutXaxisAttr "categoryorder" "mean ascending"
            static member inline meanDescending = Interop.mkLayoutXaxisAttr "categoryorder" "mean descending"
            static member inline medianAscending = Interop.mkLayoutXaxisAttr "categoryorder" "median ascending"
            static member inline medianDescending = Interop.mkLayoutXaxisAttr "categoryorder" "median descending"
            static member inline minAscending = Interop.mkLayoutXaxisAttr "categoryorder" "min ascending"
            static member inline minDescending = Interop.mkLayoutXaxisAttr "categoryorder" "min descending"
            static member inline sumAscending = Interop.mkLayoutXaxisAttr "categoryorder" "sum ascending"
            static member inline sumDescending = Interop.mkLayoutXaxisAttr "categoryorder" "sum descending"
            static member inline totalAscending = Interop.mkLayoutXaxisAttr "categoryorder" "total ascending"
            static member inline totalDescending = Interop.mkLayoutXaxisAttr "categoryorder" "total descending"
            static member inline trace = Interop.mkLayoutXaxisAttr "categoryorder" "trace"

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        [<Erase>]
        type calendar =
            static member inline chinese = Interop.mkLayoutXaxisAttr "calendar" "chinese"
            static member inline coptic = Interop.mkLayoutXaxisAttr "calendar" "coptic"
            static member inline discworld = Interop.mkLayoutXaxisAttr "calendar" "discworld"
            static member inline ethiopian = Interop.mkLayoutXaxisAttr "calendar" "ethiopian"
            static member inline gregorian = Interop.mkLayoutXaxisAttr "calendar" "gregorian"
            static member inline hebrew = Interop.mkLayoutXaxisAttr "calendar" "hebrew"
            static member inline islamic = Interop.mkLayoutXaxisAttr "calendar" "islamic"
            static member inline jalali = Interop.mkLayoutXaxisAttr "calendar" "jalali"
            static member inline julian = Interop.mkLayoutXaxisAttr "calendar" "julian"
            static member inline mayan = Interop.mkLayoutXaxisAttr "calendar" "mayan"
            static member inline nanakshahi = Interop.mkLayoutXaxisAttr "calendar" "nanakshahi"
            static member inline nepali = Interop.mkLayoutXaxisAttr "calendar" "nepali"
            static member inline persian = Interop.mkLayoutXaxisAttr "calendar" "persian"
            static member inline taiwan = Interop.mkLayoutXaxisAttr "calendar" "taiwan"
            static member inline thai = Interop.mkLayoutXaxisAttr "calendar" "thai"
            static member inline ummalqura = Interop.mkLayoutXaxisAttr "calendar" "ummalqura"

        [<Erase>]
        type title =
            static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutXaxisTitleAttr "font" (createObj !!properties)
            /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
            static member inline text (value: string) = Interop.mkLayoutXaxisTitleAttr "text" value

        [<AutoOpen>]
        module title =
            [<Erase>]
            type font =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

        [<Erase>]
        type tickfont =
            static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutXaxisTickfontAttr "description" (createObj !!properties)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutXaxisTickfontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutXaxisTickfontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutXaxisTickfontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutXaxisTickfontAttr "color" value

        [<Erase>]
        type tickformatstops = 
            static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutXaxisTickformatstopsAttr "tickformatstop" (createObj !!properties)

        [<AutoOpen>]
        module tickformatstops =
            [<Erase>]
            type tickformatstop =
                /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                /// string - dtickformat for described zoom level, the same as *tickformat*
                static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

        [<Erase>]
        type rangeslider =
            static member inline yaxis (properties: #ILayoutProperty list) = Interop.mkLayoutXaxisRangesliderAttr "yaxis" (createObj !!properties)
            /// Sets the background color of the range slider.
            static member inline bgcolor (value: string) = Interop.mkLayoutXaxisRangesliderAttr "bgcolor" value
            /// Sets the border color of the range slider.
            static member inline bordercolor (value: string) = Interop.mkLayoutXaxisRangesliderAttr "bordercolor" value
            /// Sets the border width of the range slider.
            static member inline borderwidth (value: int) = Interop.mkLayoutXaxisRangesliderAttr "borderwidth" value
            /// Determines whether or not the range slider range is computed in relation to the input data. If `range` is provided, then `autorange` is set to *false*.
            static member inline autorange (value: bool) = Interop.mkLayoutXaxisRangesliderAttr "autorange" value
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutXaxisRangesliderAttr "range" (values |> Array.ofSeq)
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutXaxisRangesliderAttr "range" (values |> Array.ofSeq)
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutXaxisRangesliderAttr "range" (values |> Array.ofSeq)
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutXaxisRangesliderAttr "range" (values |> Array.ofSeq)
            /// The height of the range slider as a fraction of the total plot area height.
            static member inline thickness (value: int) = Interop.mkLayoutXaxisRangesliderAttr "thickness" value
            /// The height of the range slider as a fraction of the total plot area height.
            static member inline thickness (value: float) = Interop.mkLayoutXaxisRangesliderAttr "thickness" value
            /// Determines whether or not the range slider will be visible. If visible, perpendicular axes will be set to `fixedrange`
            static member inline visible (value: bool) = Interop.mkLayoutXaxisRangesliderAttr "visible" value

        [<AutoOpen>]
        module rangeslider =
            [<Erase>]
            type yaxis =
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<bool>) = Interop.mkLayoutAttr "range" (values |> Array.ofSeq)
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<int>) = Interop.mkLayoutAttr "range" (values |> Array.ofSeq)
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<float>) = Interop.mkLayoutAttr "range" (values |> Array.ofSeq)
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<string>) = Interop.mkLayoutAttr "range" (values |> Array.ofSeq)

            [<AutoOpen>]
            module yaxis =
                /// Determines whether or not the range of this axis in the rangeslider use the same value than in the main plot when zooming in/out. If *auto*, the autorange will be used. If *fixed*, the `range` is used. If *match*, the current range of the corresponding y-axis on the main subplot is used.
                [<Erase>]
                type rangemode =
                    static member inline auto = Interop.mkLayoutAttr "rangemode" "auto"
                    static member inline fixed' = Interop.mkLayoutAttr "rangemode" "fixed"
                    static member inline match' = Interop.mkLayoutAttr "rangemode" "match"

        [<Erase>]
        type rangeselector =
            static member inline buttons (properties: #ILayoutProperty list) = Interop.mkLayoutXaxisRangeselectorAttr "buttons" (createObj !!properties)
            static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutXaxisRangeselectorAttr "font" (createObj !!properties)
            /// Determines whether or not this range selector is visible. Note that range selectors are only available for x axes of `type` set to or auto-typed to *date*.
            static member inline visible (value: bool) = Interop.mkLayoutXaxisRangeselectorAttr "visible" value
            /// Sets the x position (in normalized coordinates) of the range selector.
            static member inline x (value: int) = Interop.mkLayoutXaxisRangeselectorAttr "x" value
            /// Sets the x position (in normalized coordinates) of the range selector.
            static member inline x (value: float) = Interop.mkLayoutXaxisRangeselectorAttr "x" value
            /// Sets the y position (in normalized coordinates) of the range selector.
            static member inline y (value: int) = Interop.mkLayoutXaxisRangeselectorAttr "y" value
            /// Sets the y position (in normalized coordinates) of the range selector.
            static member inline y (value: float) = Interop.mkLayoutXaxisRangeselectorAttr "y" value
            /// Sets the background color of the range selector buttons.
            static member inline bgcolor (value: string) = Interop.mkLayoutXaxisRangeselectorAttr "bgcolor" value
            /// Sets the background color of the active range selector button.
            static member inline activecolor (value: string) = Interop.mkLayoutXaxisRangeselectorAttr "activecolor" value
            /// Sets the color of the border enclosing the range selector.
            static member inline bordercolor (value: string) = Interop.mkLayoutXaxisRangeselectorAttr "bordercolor" value
            /// Sets the width (in px) of the border enclosing the range selector.
            static member inline borderwidth (value: int) = Interop.mkLayoutXaxisRangeselectorAttr "borderwidth" value
            /// Sets the width (in px) of the border enclosing the range selector.
            static member inline borderwidth (value: float) = Interop.mkLayoutXaxisRangeselectorAttr "borderwidth" value

        [<AutoOpen>]
        module rangeselector =
            /// Sets the range selector's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
            [<Erase>]
            type xanchor =
                static member inline auto = Interop.mkLayoutXaxisRangeselectorAttr "xanchor" "auto"
                static member inline center = Interop.mkLayoutXaxisRangeselectorAttr "xanchor" "center"
                static member inline left = Interop.mkLayoutXaxisRangeselectorAttr "xanchor" "left"
                static member inline right = Interop.mkLayoutXaxisRangeselectorAttr "xanchor" "right"

            /// Sets the range selector's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
            [<Erase>]
            type yanchor =
                static member inline auto = Interop.mkLayoutXaxisRangeselectorAttr "yanchor" "auto"
                static member inline bottom = Interop.mkLayoutXaxisRangeselectorAttr "yanchor" "bottom"
                static member inline middle = Interop.mkLayoutXaxisRangeselectorAttr "yanchor" "middle"
                static member inline top = Interop.mkLayoutXaxisRangeselectorAttr "yanchor" "top"

            [<Erase>]
            type buttons = 
                static member inline button (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "button" (createObj !!properties)

            [<AutoOpen>]
            module buttons =
                [<Erase>]
                type button =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// Determines whether or not this button is visible.
                    static member inline visible (value: bool) = Interop.mkLayoutAttr "visible" value
                    /// Sets the number of steps to take to update the range. Use with `step` to specify the update interval.
                    static member inline count (value: int) = Interop.mkLayoutAttr "count" value
                    /// Sets the number of steps to take to update the range. Use with `step` to specify the update interval.
                    static member inline count (value: float) = Interop.mkLayoutAttr "count" value
                    /// Sets the text label to appear on the button.
                    static member inline label (value: string) = Interop.mkLayoutAttr "label" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

                [<AutoOpen>]
                module button =
                    /// The unit of measurement that the `count` value will set the range by.
                    [<Erase>]
                    type step =
                        static member inline all = Interop.mkLayoutAttr "step" "all"
                        static member inline day = Interop.mkLayoutAttr "step" "day"
                        static member inline hour = Interop.mkLayoutAttr "step" "hour"
                        static member inline minute = Interop.mkLayoutAttr "step" "minute"
                        static member inline month = Interop.mkLayoutAttr "step" "month"
                        static member inline second = Interop.mkLayoutAttr "step" "second"
                        static member inline year = Interop.mkLayoutAttr "step" "year"

                    /// Sets the range update mode. If *backward*, the range update shifts the start of range back *count* times *step* milliseconds. If *todate*, the range update shifts the start of range back to the first timestamp from *count* times *step* milliseconds back. For example, with `step` set to *year* and `count` set to *1* the range update shifts the start of the range back to January 01 of the current year. Month and year *todate* are currently available only for the built-in (Gregorian) calendar.
                    [<Erase>]
                    type stepmode =
                        static member inline backward = Interop.mkLayoutAttr "stepmode" "backward"
                        static member inline todate = Interop.mkLayoutAttr "stepmode" "todate"

            [<Erase>]
            type font =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

    [<Erase>]
    type yaxis =
        static member inline title (properties: #ILayoutYaxisTitleProperty list) = Interop.mkLayoutYaxisAttr "title" (createObj !!properties)
        static member inline tickfont (properties: #ILayoutYaxisTickfontProperty list) = Interop.mkLayoutYaxisAttr "tickfont" (createObj !!properties)
        static member inline tickformatstops (properties: #ILayoutYaxisTickformatstopsProperty list) = Interop.mkLayoutYaxisAttr "tickformatstops" (createObj !!properties)
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        static member inline visible (value: bool) = Interop.mkLayoutYaxisAttr "visible" value
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline color (value: string) = Interop.mkLayoutYaxisAttr "color" value
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<bool>) = Interop.mkLayoutYaxisAttr "range" (values |> Array.ofSeq)
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<int>) = Interop.mkLayoutYaxisAttr "range" (values |> Array.ofSeq)
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<float>) = Interop.mkLayoutYaxisAttr "range" (values |> Array.ofSeq)
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<string>) = Interop.mkLayoutYaxisAttr "range" (values |> Array.ofSeq)
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        static member inline fixedrange (value: bool) = Interop.mkLayoutYaxisAttr "fixedrange" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        static member inline scaleanchor (value: string) = Interop.mkLayoutYaxisAttr "scaleanchor" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: int) = Interop.mkLayoutYaxisAttr "scaleratio" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: float) = Interop.mkLayoutYaxisAttr "scaleratio" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        static member inline matches (value: string) = Interop.mkLayoutYaxisAttr "matches" value
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        static member inline nticks (value: int) = Interop.mkLayoutYaxisAttr "nticks" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: bool) = Interop.mkLayoutYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<bool>) = Interop.mkLayoutYaxisAttr "tick0" (values |> Array.ofSeq)
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: string) = Interop.mkLayoutYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<string>) = Interop.mkLayoutYaxisAttr "tick0" (values |> Array.ofSeq)
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: int) = Interop.mkLayoutYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<int>) = Interop.mkLayoutYaxisAttr "tick0" (values |> Array.ofSeq)
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: float) = Interop.mkLayoutYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<float>) = Interop.mkLayoutYaxisAttr "tick0" (values |> Array.ofSeq)
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: bool) = Interop.mkLayoutYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<bool>) = Interop.mkLayoutYaxisAttr "dtick" (values |> Array.ofSeq)
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: string) = Interop.mkLayoutYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<string>) = Interop.mkLayoutYaxisAttr "dtick" (values |> Array.ofSeq)
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: int) = Interop.mkLayoutYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<int>) = Interop.mkLayoutYaxisAttr "dtick" (values |> Array.ofSeq)
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: float) = Interop.mkLayoutYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<float>) = Interop.mkLayoutYaxisAttr "dtick" (values |> Array.ofSeq)
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<bool>) = Interop.mkLayoutYaxisAttr "tickvals" (values |> Array.ofSeq)
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<string>) = Interop.mkLayoutYaxisAttr "tickvals" (values |> Array.ofSeq)
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<int>) = Interop.mkLayoutYaxisAttr "tickvals" (values |> Array.ofSeq)
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<float>) = Interop.mkLayoutYaxisAttr "tickvals" (values |> Array.ofSeq)
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<bool>) = Interop.mkLayoutYaxisAttr "ticktext" (values |> Array.ofSeq)
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<string>) = Interop.mkLayoutYaxisAttr "ticktext" (values |> Array.ofSeq)
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<int>) = Interop.mkLayoutYaxisAttr "ticktext" (values |> Array.ofSeq)
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<float>) = Interop.mkLayoutYaxisAttr "ticktext" (values |> Array.ofSeq)
        /// Sets the tick length (in px).
        static member inline ticklen (value: int) = Interop.mkLayoutYaxisAttr "ticklen" value
        /// Sets the tick length (in px).
        static member inline ticklen (value: float) = Interop.mkLayoutYaxisAttr "ticklen" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: int) = Interop.mkLayoutYaxisAttr "tickwidth" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: float) = Interop.mkLayoutYaxisAttr "tickwidth" value
        /// Sets the tick color.
        static member inline tickcolor (value: string) = Interop.mkLayoutYaxisAttr "tickcolor" value
        /// Determines whether or not the tick labels are drawn.
        static member inline showticklabels (value: bool) = Interop.mkLayoutYaxisAttr "showticklabels" value
        /// Determines whether long tick labels automatically grow the figure margins.
        static member inline automargin (value: bool) = Interop.mkLayoutYaxisAttr "automargin" value
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        static member inline showspikes (value: bool) = Interop.mkLayoutYaxisAttr "showspikes" value
        /// Sets the spike color. If undefined, will use the series color
        static member inline spikecolor (value: string) = Interop.mkLayoutYaxisAttr "spikecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: int) = Interop.mkLayoutYaxisAttr "spikethickness" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: float) = Interop.mkLayoutYaxisAttr "spikethickness" value
        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        static member inline spikedash (value: string) = Interop.mkLayoutYaxisAttr "spikedash" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: int) = Interop.mkLayoutYaxisAttr "tickangle" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: float) = Interop.mkLayoutYaxisAttr "tickangle" value
        /// Sets a tick label prefix.
        static member inline tickprefix (value: string) = Interop.mkLayoutYaxisAttr "tickprefix" value
        /// Sets a tick label suffix.
        static member inline ticksuffix (value: string) = Interop.mkLayoutYaxisAttr "ticksuffix" value
        /// If \"true\", even 4-digit integers are separated
        static member inline separatethousands (value: bool) = Interop.mkLayoutYaxisAttr "separatethousands" value
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline tickformat (value: string) = Interop.mkLayoutYaxisAttr "tickformat" value
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline hoverformat (value: string) = Interop.mkLayoutYaxisAttr "hoverformat" value
        /// Determines whether or not a line bounding this axis is drawn.
        static member inline showline (value: bool) = Interop.mkLayoutYaxisAttr "showline" value
        /// Sets the axis line color.
        static member inline linecolor (value: string) = Interop.mkLayoutYaxisAttr "linecolor" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: int) = Interop.mkLayoutYaxisAttr "linewidth" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: float) = Interop.mkLayoutYaxisAttr "linewidth" value
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        static member inline showgrid (value: bool) = Interop.mkLayoutYaxisAttr "showgrid" value
        /// Sets the color of the grid lines.
        static member inline gridcolor (value: string) = Interop.mkLayoutYaxisAttr "gridcolor" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: int) = Interop.mkLayoutYaxisAttr "gridwidth" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: float) = Interop.mkLayoutYaxisAttr "gridwidth" value
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        static member inline zeroline (value: bool) = Interop.mkLayoutYaxisAttr "zeroline" value
        /// Sets the line color of the zero line.
        static member inline zerolinecolor (value: string) = Interop.mkLayoutYaxisAttr "zerolinecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: int) = Interop.mkLayoutYaxisAttr "zerolinewidth" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: float) = Interop.mkLayoutYaxisAttr "zerolinewidth" value
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        static member inline showdividers (value: bool) = Interop.mkLayoutYaxisAttr "showdividers" value
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        static member inline dividercolor (value: string) = Interop.mkLayoutYaxisAttr "dividercolor" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: int) = Interop.mkLayoutYaxisAttr "dividerwidth" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: float) = Interop.mkLayoutYaxisAttr "dividerwidth" value
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<int>) = Interop.mkLayoutYaxisAttr "domain" (values |> Array.ofSeq)
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<float>) = Interop.mkLayoutYaxisAttr "domain" (values |> Array.ofSeq)
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: int) = Interop.mkLayoutYaxisAttr "position" value
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: float) = Interop.mkLayoutYaxisAttr "position" value
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutYaxisAttr "categoryarray" (values |> Array.ofSeq)
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<string>) = Interop.mkLayoutYaxisAttr "categoryarray" (values |> Array.ofSeq)
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<int>) = Interop.mkLayoutYaxisAttr "categoryarray" (values |> Array.ofSeq)
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<float>) = Interop.mkLayoutYaxisAttr "categoryarray" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutYaxisAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutYaxisAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutYaxisAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutYaxisAttr "uirevision" (values |> Array.ofSeq)
        /// Sets the source reference on plot.ly for  tickvals .
        static member inline tickvalssrc (value: string) = Interop.mkLayoutYaxisAttr "tickvalssrc" value
        /// Sets the source reference on plot.ly for  ticktext .
        static member inline ticktextsrc (value: string) = Interop.mkLayoutYaxisAttr "ticktextsrc" value
        /// Sets the source reference on plot.ly for  categoryarray .
        static member inline categoryarraysrc (value: string) = Interop.mkLayoutYaxisAttr "categoryarraysrc" value

    [<AutoOpen>]
    module yaxis =
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        [<Erase>]
        type type' =
            static member inline dash = Interop.mkLayoutYaxisAttr "type" "-"
            static member inline category = Interop.mkLayoutYaxisAttr "type" "category"
            static member inline date = Interop.mkLayoutYaxisAttr "type" "date"
            static member inline linear = Interop.mkLayoutYaxisAttr "type" "linear"
            static member inline log = Interop.mkLayoutYaxisAttr "type" "log"
            static member inline multicategory = Interop.mkLayoutYaxisAttr "type" "multicategory"

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        [<Erase>]
        type autorange =
            static member inline reversed = Interop.mkLayoutYaxisAttr "autorange" "reversed"
            static member inline false' = Interop.mkLayoutYaxisAttr "autorange" "false"
            static member inline true' = Interop.mkLayoutYaxisAttr "autorange" "true"

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        [<Erase>]
        type rangemode =
            static member inline nonnegative = Interop.mkLayoutYaxisAttr "rangemode" "nonnegative"
            static member inline normal = Interop.mkLayoutYaxisAttr "rangemode" "normal"
            static member inline tozero = Interop.mkLayoutYaxisAttr "rangemode" "tozero"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        [<Erase>]
        type constrain =
            static member inline domain = Interop.mkLayoutYaxisAttr "constrain" "domain"
            static member inline range = Interop.mkLayoutYaxisAttr "constrain" "range"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        [<Erase>]
        type constraintoward =
            static member inline bottom = Interop.mkLayoutYaxisAttr "constraintoward" "bottom"
            static member inline center = Interop.mkLayoutYaxisAttr "constraintoward" "center"
            static member inline left = Interop.mkLayoutYaxisAttr "constraintoward" "left"
            static member inline middle = Interop.mkLayoutYaxisAttr "constraintoward" "middle"
            static member inline right = Interop.mkLayoutYaxisAttr "constraintoward" "right"
            static member inline top = Interop.mkLayoutYaxisAttr "constraintoward" "top"

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        [<Erase>]
        type tickmode =
            static member inline array = Interop.mkLayoutYaxisAttr "tickmode" "array"
            static member inline auto = Interop.mkLayoutYaxisAttr "tickmode" "auto"
            static member inline linear = Interop.mkLayoutYaxisAttr "tickmode" "linear"

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        [<Erase>]
        type ticks =
            static member inline none = Interop.mkLayoutYaxisAttr "ticks" ""
            static member inline inside = Interop.mkLayoutYaxisAttr "ticks" "inside"
            static member inline outside = Interop.mkLayoutYaxisAttr "ticks" "outside"

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        [<Erase>]
        type tickson =
            static member inline boundaries = Interop.mkLayoutYaxisAttr "tickson" "boundaries"
            static member inline labels = Interop.mkLayoutYaxisAttr "tickson" "labels"

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        [<Erase>]
        type mirror =
            static member inline all = Interop.mkLayoutYaxisAttr "mirror" "all"
            static member inline allticks = Interop.mkLayoutYaxisAttr "mirror" "allticks"
            static member inline ticks = Interop.mkLayoutYaxisAttr "mirror" "ticks"
            static member inline false' = Interop.mkLayoutYaxisAttr "mirror" "false"
            static member inline true' = Interop.mkLayoutYaxisAttr "mirror" "true"

        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        [<Erase>]
        type spikemode =
            static member inline across = Interop.mkLayoutYaxisAttr "spikemode" "across"
            static member inline acrossAndToaxis = Interop.mkLayoutYaxisAttr "spikemode" "across+toaxis"
            static member inline marker = Interop.mkLayoutYaxisAttr "spikemode" "marker"
            static member inline markerAndAcross = Interop.mkLayoutYaxisAttr "spikemode" "marker+across"
            static member inline markerAndAcrossToaxis = Interop.mkLayoutYaxisAttr "spikemode" "marker+across+toaxis"
            static member inline markerAndToaxis = Interop.mkLayoutYaxisAttr "spikemode" "marker+toaxis"
            static member inline toaxis = Interop.mkLayoutYaxisAttr "spikemode" "toaxis"

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        [<Erase>]
        type spikesnap =
            static member inline cursor = Interop.mkLayoutYaxisAttr "spikesnap" "cursor"
            static member inline data = Interop.mkLayoutYaxisAttr "spikesnap" "data"

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        [<Erase>]
        type showtickprefix =
            static member inline all = Interop.mkLayoutYaxisAttr "showtickprefix" "all"
            static member inline first = Interop.mkLayoutYaxisAttr "showtickprefix" "first"
            static member inline last = Interop.mkLayoutYaxisAttr "showtickprefix" "last"
            static member inline none = Interop.mkLayoutYaxisAttr "showtickprefix" "none"

        /// Same as `showtickprefix` but for tick suffixes.
        [<Erase>]
        type showticksuffix =
            static member inline all = Interop.mkLayoutYaxisAttr "showticksuffix" "all"
            static member inline first = Interop.mkLayoutYaxisAttr "showticksuffix" "first"
            static member inline last = Interop.mkLayoutYaxisAttr "showticksuffix" "last"
            static member inline none = Interop.mkLayoutYaxisAttr "showticksuffix" "none"

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        [<Erase>]
        type showexponent =
            static member inline all = Interop.mkLayoutYaxisAttr "showexponent" "all"
            static member inline first = Interop.mkLayoutYaxisAttr "showexponent" "first"
            static member inline last = Interop.mkLayoutYaxisAttr "showexponent" "last"
            static member inline none = Interop.mkLayoutYaxisAttr "showexponent" "none"

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        [<Erase>]
        type exponentformat =
            static member inline B = Interop.mkLayoutYaxisAttr "exponentformat" "B"
            static member inline E = Interop.mkLayoutYaxisAttr "exponentformat" "E"
            static member inline SI = Interop.mkLayoutYaxisAttr "exponentformat" "SI"
            static member inline e = Interop.mkLayoutYaxisAttr "exponentformat" "e"
            static member inline none = Interop.mkLayoutYaxisAttr "exponentformat" "none"
            static member inline power = Interop.mkLayoutYaxisAttr "exponentformat" "power"

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        [<Erase>]
        type anchor =
            static member inline free = Interop.mkLayoutYaxisAttr "anchor" "free"
            static member inline custom (value: string) = Interop.mkLayoutYaxisAttr "anchor" value

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        [<Erase>]
        type side =
            static member inline bottom = Interop.mkLayoutYaxisAttr "side" "bottom"
            static member inline left = Interop.mkLayoutYaxisAttr "side" "left"
            static member inline right = Interop.mkLayoutYaxisAttr "side" "right"
            static member inline top = Interop.mkLayoutYaxisAttr "side" "top"

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        [<Erase>]
        type overlaying =
            static member inline free = Interop.mkLayoutYaxisAttr "overlaying" "free"
            static member inline custom (value: string) = Interop.mkLayoutYaxisAttr "overlaying" value

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        [<Erase>]
        type layer =
            static member inline aboveTraces = Interop.mkLayoutYaxisAttr "layer" "above traces"
            static member inline belowTraces = Interop.mkLayoutYaxisAttr "layer" "below traces"

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        [<Erase>]
        type categoryorder =
            static member inline array = Interop.mkLayoutYaxisAttr "categoryorder" "array"
            static member inline categoryAscending = Interop.mkLayoutYaxisAttr "categoryorder" "category ascending"
            static member inline categoryDescending = Interop.mkLayoutYaxisAttr "categoryorder" "category descending"
            static member inline maxAscending = Interop.mkLayoutYaxisAttr "categoryorder" "max ascending"
            static member inline maxDescending = Interop.mkLayoutYaxisAttr "categoryorder" "max descending"
            static member inline meanAscending = Interop.mkLayoutYaxisAttr "categoryorder" "mean ascending"
            static member inline meanDescending = Interop.mkLayoutYaxisAttr "categoryorder" "mean descending"
            static member inline medianAscending = Interop.mkLayoutYaxisAttr "categoryorder" "median ascending"
            static member inline medianDescending = Interop.mkLayoutYaxisAttr "categoryorder" "median descending"
            static member inline minAscending = Interop.mkLayoutYaxisAttr "categoryorder" "min ascending"
            static member inline minDescending = Interop.mkLayoutYaxisAttr "categoryorder" "min descending"
            static member inline sumAscending = Interop.mkLayoutYaxisAttr "categoryorder" "sum ascending"
            static member inline sumDescending = Interop.mkLayoutYaxisAttr "categoryorder" "sum descending"
            static member inline totalAscending = Interop.mkLayoutYaxisAttr "categoryorder" "total ascending"
            static member inline totalDescending = Interop.mkLayoutYaxisAttr "categoryorder" "total descending"
            static member inline trace = Interop.mkLayoutYaxisAttr "categoryorder" "trace"

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        [<Erase>]
        type calendar =
            static member inline chinese = Interop.mkLayoutYaxisAttr "calendar" "chinese"
            static member inline coptic = Interop.mkLayoutYaxisAttr "calendar" "coptic"
            static member inline discworld = Interop.mkLayoutYaxisAttr "calendar" "discworld"
            static member inline ethiopian = Interop.mkLayoutYaxisAttr "calendar" "ethiopian"
            static member inline gregorian = Interop.mkLayoutYaxisAttr "calendar" "gregorian"
            static member inline hebrew = Interop.mkLayoutYaxisAttr "calendar" "hebrew"
            static member inline islamic = Interop.mkLayoutYaxisAttr "calendar" "islamic"
            static member inline jalali = Interop.mkLayoutYaxisAttr "calendar" "jalali"
            static member inline julian = Interop.mkLayoutYaxisAttr "calendar" "julian"
            static member inline mayan = Interop.mkLayoutYaxisAttr "calendar" "mayan"
            static member inline nanakshahi = Interop.mkLayoutYaxisAttr "calendar" "nanakshahi"
            static member inline nepali = Interop.mkLayoutYaxisAttr "calendar" "nepali"
            static member inline persian = Interop.mkLayoutYaxisAttr "calendar" "persian"
            static member inline taiwan = Interop.mkLayoutYaxisAttr "calendar" "taiwan"
            static member inline thai = Interop.mkLayoutYaxisAttr "calendar" "thai"
            static member inline ummalqura = Interop.mkLayoutYaxisAttr "calendar" "ummalqura"

        [<Erase>]
        type title =
            static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutYaxisTitleAttr "font" (createObj !!properties)
            /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
            static member inline text (value: string) = Interop.mkLayoutYaxisTitleAttr "text" value

        [<AutoOpen>]
        module title =
            [<Erase>]
            type font =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

        [<Erase>]
        type tickfont =
            static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutYaxisTickfontAttr "description" (createObj !!properties)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutYaxisTickfontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutYaxisTickfontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutYaxisTickfontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutYaxisTickfontAttr "color" value

        [<Erase>]
        type tickformatstops = 
            static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutYaxisTickformatstopsAttr "tickformatstop" (createObj !!properties)

        [<AutoOpen>]
        module tickformatstops =
            [<Erase>]
            type tickformatstop =
                /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                /// string - dtickformat for described zoom level, the same as *tickformat*
                static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

    [<Erase>]
    type ternary =
        static member inline domain (properties: #ILayoutTernaryDomainProperty list) = Interop.mkLayoutTernaryAttr "domain" (createObj !!properties)
        static member inline aaxis (properties: #ILayoutTernaryAaxisProperty list) = Interop.mkLayoutTernaryAttr "aaxis" (createObj !!properties)
        static member inline baxis (properties: #ILayoutTernaryBaxisProperty list) = Interop.mkLayoutTernaryAttr "baxis" (createObj !!properties)
        static member inline caxis (properties: #ILayoutTernaryCaxisProperty list) = Interop.mkLayoutTernaryAttr "caxis" (createObj !!properties)
        /// Set the background color of the subplot
        static member inline bgcolor (value: string) = Interop.mkLayoutTernaryAttr "bgcolor" value
        /// The number each triplet should sum to, and the maximum range of each axis
        static member inline sum (value: int) = Interop.mkLayoutTernaryAttr "sum" value
        /// The number each triplet should sum to, and the maximum range of each axis
        static member inline sum (value: float) = Interop.mkLayoutTernaryAttr "sum" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutTernaryAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutTernaryAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutTernaryAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutTernaryAttr "uirevision" (values |> Array.ofSeq)

    [<AutoOpen>]
    module ternary =
        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this ternary subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkLayoutTernaryDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the horizontal domain of this ternary subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkLayoutTernaryDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the vertical domain of this ternary subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkLayoutTernaryDomainAttr "y" (values |> Array.ofSeq)
            /// Sets the vertical domain of this ternary subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkLayoutTernaryDomainAttr "y" (values |> Array.ofSeq)
            /// If there is a layout grid, use the domain for this row in the grid for this ternary subplot .
            static member inline row (value: int) = Interop.mkLayoutTernaryDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this ternary subplot .
            static member inline column (value: int) = Interop.mkLayoutTernaryDomainAttr "column" value

        [<Erase>]
        type aaxis =
            static member inline title (properties: #ILayoutProperty list) = Interop.mkLayoutTernaryAaxisAttr "title" (createObj !!properties)
            static member inline tickfont (properties: #ILayoutProperty list) = Interop.mkLayoutTernaryAaxisAttr "tickfont" (createObj !!properties)
            static member inline tickformatstops (properties: #ILayoutProperty list) = Interop.mkLayoutTernaryAaxisAttr "tickformatstops" (createObj !!properties)
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutTernaryAaxisAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutTernaryAaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutTernaryAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutTernaryAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutTernaryAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutTernaryAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutTernaryAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutTernaryAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutTernaryAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutTernaryAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutTernaryAaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutTernaryAaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutTernaryAaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutTernaryAaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutTernaryAaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutTernaryAaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutTernaryAaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutTernaryAaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutTernaryAaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutTernaryAaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutTernaryAaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutTernaryAaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutTernaryAaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutTernaryAaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutTernaryAaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutTernaryAaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutTernaryAaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutTernaryAaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutTernaryAaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutTernaryAaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutTernaryAaxisAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkLayoutTernaryAaxisAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkLayoutTernaryAaxisAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutTernaryAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutTernaryAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutTernaryAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutTernaryAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutTernaryAaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutTernaryAaxisAttr "ticktextsrc" value

        [<AutoOpen>]
        module aaxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutTernaryAaxisAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutTernaryAaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutTernaryAaxisAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutTernaryAaxisAttr "ticks" ""
                static member inline inside = Interop.mkLayoutTernaryAaxisAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutTernaryAaxisAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutTernaryAaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutTernaryAaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutTernaryAaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutTernaryAaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutTernaryAaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutTernaryAaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutTernaryAaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutTernaryAaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutTernaryAaxisAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutTernaryAaxisAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutTernaryAaxisAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutTernaryAaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutTernaryAaxisAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutTernaryAaxisAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutTernaryAaxisAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutTernaryAaxisAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutTernaryAaxisAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutTernaryAaxisAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutTernaryAaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutTernaryAaxisAttr "layer" "below traces"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutAttr "text" value

            [<AutoOpen>]
            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickformatstops = 
                static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "tickformatstop" (createObj !!properties)

            [<AutoOpen>]
            module tickformatstops =
                [<Erase>]
                type tickformatstop =
                    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                    static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// string - dtickformat for described zoom level, the same as *tickformat*
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

        [<Erase>]
        type baxis =
            static member inline title (properties: #ILayoutProperty list) = Interop.mkLayoutTernaryBaxisAttr "title" (createObj !!properties)
            static member inline tickfont (properties: #ILayoutProperty list) = Interop.mkLayoutTernaryBaxisAttr "tickfont" (createObj !!properties)
            static member inline tickformatstops (properties: #ILayoutProperty list) = Interop.mkLayoutTernaryBaxisAttr "tickformatstops" (createObj !!properties)
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutTernaryBaxisAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutTernaryBaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutTernaryBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutTernaryBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutTernaryBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutTernaryBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutTernaryBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutTernaryBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutTernaryBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutTernaryBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutTernaryBaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutTernaryBaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutTernaryBaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutTernaryBaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutTernaryBaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutTernaryBaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutTernaryBaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutTernaryBaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutTernaryBaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutTernaryBaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutTernaryBaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutTernaryBaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutTernaryBaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutTernaryBaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutTernaryBaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutTernaryBaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutTernaryBaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutTernaryBaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutTernaryBaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutTernaryBaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutTernaryBaxisAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkLayoutTernaryBaxisAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkLayoutTernaryBaxisAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutTernaryBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutTernaryBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutTernaryBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutTernaryBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutTernaryBaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutTernaryBaxisAttr "ticktextsrc" value

        [<AutoOpen>]
        module baxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutTernaryBaxisAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutTernaryBaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutTernaryBaxisAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutTernaryBaxisAttr "ticks" ""
                static member inline inside = Interop.mkLayoutTernaryBaxisAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutTernaryBaxisAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutTernaryBaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutTernaryBaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutTernaryBaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutTernaryBaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutTernaryBaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutTernaryBaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutTernaryBaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutTernaryBaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutTernaryBaxisAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutTernaryBaxisAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutTernaryBaxisAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutTernaryBaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutTernaryBaxisAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutTernaryBaxisAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutTernaryBaxisAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutTernaryBaxisAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutTernaryBaxisAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutTernaryBaxisAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutTernaryBaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutTernaryBaxisAttr "layer" "below traces"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutAttr "text" value

            [<AutoOpen>]
            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickformatstops = 
                static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "tickformatstop" (createObj !!properties)

            [<AutoOpen>]
            module tickformatstops =
                [<Erase>]
                type tickformatstop =
                    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                    static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// string - dtickformat for described zoom level, the same as *tickformat*
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

        [<Erase>]
        type caxis =
            static member inline title (properties: #ILayoutProperty list) = Interop.mkLayoutTernaryCaxisAttr "title" (createObj !!properties)
            static member inline tickfont (properties: #ILayoutProperty list) = Interop.mkLayoutTernaryCaxisAttr "tickfont" (createObj !!properties)
            static member inline tickformatstops (properties: #ILayoutProperty list) = Interop.mkLayoutTernaryCaxisAttr "tickformatstops" (createObj !!properties)
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutTernaryCaxisAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutTernaryCaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutTernaryCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutTernaryCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutTernaryCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutTernaryCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutTernaryCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutTernaryCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutTernaryCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutTernaryCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutTernaryCaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutTernaryCaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutTernaryCaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutTernaryCaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutTernaryCaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutTernaryCaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutTernaryCaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutTernaryCaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutTernaryCaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutTernaryCaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutTernaryCaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutTernaryCaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutTernaryCaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutTernaryCaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutTernaryCaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutTernaryCaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutTernaryCaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutTernaryCaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutTernaryCaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutTernaryCaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutTernaryCaxisAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkLayoutTernaryCaxisAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkLayoutTernaryCaxisAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutTernaryCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutTernaryCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutTernaryCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutTernaryCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutTernaryCaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutTernaryCaxisAttr "ticktextsrc" value

        [<AutoOpen>]
        module caxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutTernaryCaxisAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutTernaryCaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutTernaryCaxisAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutTernaryCaxisAttr "ticks" ""
                static member inline inside = Interop.mkLayoutTernaryCaxisAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutTernaryCaxisAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutTernaryCaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutTernaryCaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutTernaryCaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutTernaryCaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutTernaryCaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutTernaryCaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutTernaryCaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutTernaryCaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutTernaryCaxisAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutTernaryCaxisAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutTernaryCaxisAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutTernaryCaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutTernaryCaxisAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutTernaryCaxisAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutTernaryCaxisAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutTernaryCaxisAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutTernaryCaxisAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutTernaryCaxisAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutTernaryCaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutTernaryCaxisAttr "layer" "below traces"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutAttr "text" value

            [<AutoOpen>]
            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickformatstops = 
                static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "tickformatstop" (createObj !!properties)

            [<AutoOpen>]
            module tickformatstops =
                [<Erase>]
                type tickformatstop =
                    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                    static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// string - dtickformat for described zoom level, the same as *tickformat*
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

    [<Erase>]
    type scene =
        static member inline _arrayAttrRegexps (properties: #ILayoutScene_arrayAttrRegexpsProperty list) = Interop.mkLayoutSceneAttr "_arrayAttrRegexps" (createObj !!properties)
        static member inline camera (properties: #ILayoutSceneCameraProperty list) = Interop.mkLayoutSceneAttr "camera" (createObj !!properties)
        static member inline domain (properties: #ILayoutSceneDomainProperty list) = Interop.mkLayoutSceneAttr "domain" (createObj !!properties)
        static member inline aspectratio (properties: #ILayoutSceneAspectratioProperty list) = Interop.mkLayoutSceneAttr "aspectratio" (createObj !!properties)
        static member inline xaxis (properties: #ILayoutSceneXaxisProperty list) = Interop.mkLayoutSceneAttr "xaxis" (createObj !!properties)
        static member inline yaxis (properties: #ILayoutSceneYaxisProperty list) = Interop.mkLayoutSceneAttr "yaxis" (createObj !!properties)
        static member inline zaxis (properties: #ILayoutSceneZaxisProperty list) = Interop.mkLayoutSceneAttr "zaxis" (createObj !!properties)
        static member inline annotations (properties: #ILayoutSceneAnnotationsProperty list) = Interop.mkLayoutSceneAttr "annotations" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
        static member inline bgcolor (value: string) = Interop.mkLayoutSceneAttr "bgcolor" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutSceneAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutSceneAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutSceneAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutSceneAttr "uirevision" (values |> Array.ofSeq)

    [<AutoOpen>]
    module scene =
        /// If *cube*, this scene's axes are drawn as a cube, regardless of the axes' ranges. If *data*, this scene's axes are drawn in proportion with the axes' ranges. If *manual*, this scene's axes are drawn in proportion with the input of *aspectratio* (the default behavior if *aspectratio* is provided). If *auto*, this scene's axes are drawn using the results of *data* except when one axis is more than four times the size of the two others, where in that case the results of *cube* are used.
        [<Erase>]
        type aspectmode =
            static member inline auto = Interop.mkLayoutSceneAttr "aspectmode" "auto"
            static member inline cube = Interop.mkLayoutSceneAttr "aspectmode" "cube"
            static member inline data = Interop.mkLayoutSceneAttr "aspectmode" "data"
            static member inline manual = Interop.mkLayoutSceneAttr "aspectmode" "manual"

        /// Determines the mode of drag interactions for this scene.
        [<Erase>]
        type dragmode =
            static member inline orbit = Interop.mkLayoutSceneAttr "dragmode" "orbit"
            static member inline pan = Interop.mkLayoutSceneAttr "dragmode" "pan"
            static member inline turntable = Interop.mkLayoutSceneAttr "dragmode" "turntable"
            static member inline zoom = Interop.mkLayoutSceneAttr "dragmode" "zoom"
            static member inline false' = Interop.mkLayoutSceneAttr "dragmode" "false"

        /// Determines the mode of hover interactions for this scene.
        [<Erase>]
        type hovermode =
            static member inline closest = Interop.mkLayoutSceneAttr "hovermode" "closest"
            static member inline false' = Interop.mkLayoutSceneAttr "hovermode" "false"

        [<Erase>]
        type camera = 
            static member inline up (properties: #ILayoutProperty list) = Interop.mkLayoutSceneCameraAttr "up" (createObj !!properties)
            static member inline center (properties: #ILayoutProperty list) = Interop.mkLayoutSceneCameraAttr "center" (createObj !!properties)
            static member inline eye (properties: #ILayoutProperty list) = Interop.mkLayoutSceneCameraAttr "eye" (createObj !!properties)
            static member inline projection (properties: #ILayoutProperty list) = Interop.mkLayoutSceneCameraAttr "projection" (createObj !!properties)

        [<AutoOpen>]
        module camera =
            [<Erase>]
            type up =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                static member inline x (value: int) = Interop.mkLayoutAttr "x" value
                static member inline x (value: float) = Interop.mkLayoutAttr "x" value
                static member inline y (value: int) = Interop.mkLayoutAttr "y" value
                static member inline y (value: float) = Interop.mkLayoutAttr "y" value
                static member inline z (value: int) = Interop.mkLayoutAttr "z" value
                static member inline z (value: float) = Interop.mkLayoutAttr "z" value

            [<Erase>]
            type center =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                static member inline x (value: int) = Interop.mkLayoutAttr "x" value
                static member inline x (value: float) = Interop.mkLayoutAttr "x" value
                static member inline y (value: int) = Interop.mkLayoutAttr "y" value
                static member inline y (value: float) = Interop.mkLayoutAttr "y" value
                static member inline z (value: int) = Interop.mkLayoutAttr "z" value
                static member inline z (value: float) = Interop.mkLayoutAttr "z" value

            [<Erase>]
            type eye =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                static member inline x (value: int) = Interop.mkLayoutAttr "x" value
                static member inline x (value: float) = Interop.mkLayoutAttr "x" value
                static member inline y (value: int) = Interop.mkLayoutAttr "y" value
                static member inline y (value: float) = Interop.mkLayoutAttr "y" value
                static member inline z (value: int) = Interop.mkLayoutAttr "z" value
                static member inline z (value: float) = Interop.mkLayoutAttr "z" value

            [<AutoOpen>]
            module projection =
                /// Sets the projection type. The projection type could be either *perspective* or *orthographic*. The default is *perspective*.
                [<Erase>]
                type type' =
                    static member inline orthographic = Interop.mkLayoutAttr "type" "orthographic"
                    static member inline perspective = Interop.mkLayoutAttr "type" "perspective"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this scene subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkLayoutSceneDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the horizontal domain of this scene subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkLayoutSceneDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the vertical domain of this scene subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkLayoutSceneDomainAttr "y" (values |> Array.ofSeq)
            /// Sets the vertical domain of this scene subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkLayoutSceneDomainAttr "y" (values |> Array.ofSeq)
            /// If there is a layout grid, use the domain for this row in the grid for this scene subplot .
            static member inline row (value: int) = Interop.mkLayoutSceneDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this scene subplot .
            static member inline column (value: int) = Interop.mkLayoutSceneDomainAttr "column" value

        [<Erase>]
        type aspectratio =
            static member inline impliedEdits (properties: #ILayoutProperty list) = Interop.mkLayoutSceneAspectratioAttr "impliedEdits" (createObj !!properties)
            static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutSceneAspectratioAttr "description" (createObj !!properties)
            static member inline x (value: int) = Interop.mkLayoutSceneAspectratioAttr "x" value
            static member inline x (value: float) = Interop.mkLayoutSceneAspectratioAttr "x" value
            static member inline y (value: int) = Interop.mkLayoutSceneAspectratioAttr "y" value
            static member inline y (value: float) = Interop.mkLayoutSceneAspectratioAttr "y" value
            static member inline z (value: int) = Interop.mkLayoutSceneAspectratioAttr "z" value
            static member inline z (value: float) = Interop.mkLayoutSceneAspectratioAttr "z" value

        [<AutoOpen>]
        module aspectratio =
            [<Erase>]
            type impliedEdits = 
                static member inline aspectmode (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "aspectmode" (createObj !!properties)

        [<Erase>]
        type xaxis =
            static member inline title (properties: #ILayoutProperty list) = Interop.mkLayoutSceneXaxisAttr "title" (createObj !!properties)
            static member inline tickfont (properties: #ILayoutProperty list) = Interop.mkLayoutSceneXaxisAttr "tickfont" (createObj !!properties)
            static member inline tickformatstops (properties: #ILayoutProperty list) = Interop.mkLayoutSceneXaxisAttr "tickformatstops" (createObj !!properties)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutSceneXaxisAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkLayoutSceneXaxisAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkLayoutSceneXaxisAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkLayoutSceneXaxisAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkLayoutSceneXaxisAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkLayoutSceneXaxisAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkLayoutSceneXaxisAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkLayoutSceneXaxisAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkLayoutSceneXaxisAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutSceneXaxisAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "range" (values |> Array.ofSeq)
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutSceneXaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutSceneXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutSceneXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutSceneXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutSceneXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutSceneXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutSceneXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutSceneXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutSceneXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutSceneXaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutSceneXaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutSceneXaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutSceneXaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutSceneXaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutSceneXaxisAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutSceneXaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutSceneXaxisAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutSceneXaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutSceneXaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutSceneXaxisAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutSceneXaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutSceneXaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutSceneXaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutSceneXaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutSceneXaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutSceneXaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutSceneXaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutSceneXaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutSceneXaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutSceneXaxisAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkLayoutSceneXaxisAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkLayoutSceneXaxisAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkLayoutSceneXaxisAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkLayoutSceneXaxisAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutSceneXaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutSceneXaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutSceneXaxisAttr "ticktextsrc" value

        [<AutoOpen>]
        module xaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutSceneXaxisAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutSceneXaxisAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutSceneXaxisAttr "categoryorder" "trace"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutSceneXaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutSceneXaxisAttr "type" "category"
                static member inline date = Interop.mkLayoutSceneXaxisAttr "type" "date"
                static member inline linear = Interop.mkLayoutSceneXaxisAttr "type" "linear"
                static member inline log = Interop.mkLayoutSceneXaxisAttr "type" "log"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline reversed = Interop.mkLayoutSceneXaxisAttr "autorange" "reversed"
                static member inline false' = Interop.mkLayoutSceneXaxisAttr "autorange" "false"
                static member inline true' = Interop.mkLayoutSceneXaxisAttr "autorange" "true"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline nonnegative = Interop.mkLayoutSceneXaxisAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkLayoutSceneXaxisAttr "rangemode" "normal"
                static member inline tozero = Interop.mkLayoutSceneXaxisAttr "rangemode" "tozero"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutSceneXaxisAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutSceneXaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutSceneXaxisAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutSceneXaxisAttr "ticks" ""
                static member inline inside = Interop.mkLayoutSceneXaxisAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutSceneXaxisAttr "ticks" "outside"

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline all = Interop.mkLayoutSceneXaxisAttr "mirror" "all"
                static member inline allticks = Interop.mkLayoutSceneXaxisAttr "mirror" "allticks"
                static member inline ticks = Interop.mkLayoutSceneXaxisAttr "mirror" "ticks"
                static member inline false' = Interop.mkLayoutSceneXaxisAttr "mirror" "false"
                static member inline true' = Interop.mkLayoutSceneXaxisAttr "mirror" "true"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutSceneXaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutSceneXaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutSceneXaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutSceneXaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutSceneXaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutSceneXaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutSceneXaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutSceneXaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutSceneXaxisAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutSceneXaxisAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutSceneXaxisAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutSceneXaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutSceneXaxisAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutSceneXaxisAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutSceneXaxisAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutSceneXaxisAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutSceneXaxisAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutSceneXaxisAttr "exponentformat" "power"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline chinese = Interop.mkLayoutSceneXaxisAttr "calendar" "chinese"
                static member inline coptic = Interop.mkLayoutSceneXaxisAttr "calendar" "coptic"
                static member inline discworld = Interop.mkLayoutSceneXaxisAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkLayoutSceneXaxisAttr "calendar" "ethiopian"
                static member inline gregorian = Interop.mkLayoutSceneXaxisAttr "calendar" "gregorian"
                static member inline hebrew = Interop.mkLayoutSceneXaxisAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkLayoutSceneXaxisAttr "calendar" "islamic"
                static member inline jalali = Interop.mkLayoutSceneXaxisAttr "calendar" "jalali"
                static member inline julian = Interop.mkLayoutSceneXaxisAttr "calendar" "julian"
                static member inline mayan = Interop.mkLayoutSceneXaxisAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkLayoutSceneXaxisAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkLayoutSceneXaxisAttr "calendar" "nepali"
                static member inline persian = Interop.mkLayoutSceneXaxisAttr "calendar" "persian"
                static member inline taiwan = Interop.mkLayoutSceneXaxisAttr "calendar" "taiwan"
                static member inline thai = Interop.mkLayoutSceneXaxisAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkLayoutSceneXaxisAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutAttr "text" value

            [<AutoOpen>]
            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickformatstops = 
                static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "tickformatstop" (createObj !!properties)

            [<AutoOpen>]
            module tickformatstops =
                [<Erase>]
                type tickformatstop =
                    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                    static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// string - dtickformat for described zoom level, the same as *tickformat*
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

        [<Erase>]
        type yaxis =
            static member inline title (properties: #ILayoutProperty list) = Interop.mkLayoutSceneYaxisAttr "title" (createObj !!properties)
            static member inline tickfont (properties: #ILayoutProperty list) = Interop.mkLayoutSceneYaxisAttr "tickfont" (createObj !!properties)
            static member inline tickformatstops (properties: #ILayoutProperty list) = Interop.mkLayoutSceneYaxisAttr "tickformatstops" (createObj !!properties)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutSceneYaxisAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkLayoutSceneYaxisAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkLayoutSceneYaxisAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkLayoutSceneYaxisAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkLayoutSceneYaxisAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkLayoutSceneYaxisAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkLayoutSceneYaxisAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkLayoutSceneYaxisAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkLayoutSceneYaxisAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutSceneYaxisAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "range" (values |> Array.ofSeq)
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutSceneYaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutSceneYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutSceneYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutSceneYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutSceneYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutSceneYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutSceneYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutSceneYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutSceneYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutSceneYaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutSceneYaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutSceneYaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutSceneYaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutSceneYaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutSceneYaxisAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutSceneYaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutSceneYaxisAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutSceneYaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutSceneYaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutSceneYaxisAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutSceneYaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutSceneYaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutSceneYaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutSceneYaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutSceneYaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutSceneYaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutSceneYaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutSceneYaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutSceneYaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutSceneYaxisAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkLayoutSceneYaxisAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkLayoutSceneYaxisAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkLayoutSceneYaxisAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkLayoutSceneYaxisAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutSceneYaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutSceneYaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutSceneYaxisAttr "ticktextsrc" value

        [<AutoOpen>]
        module yaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutSceneYaxisAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutSceneYaxisAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutSceneYaxisAttr "categoryorder" "trace"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutSceneYaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutSceneYaxisAttr "type" "category"
                static member inline date = Interop.mkLayoutSceneYaxisAttr "type" "date"
                static member inline linear = Interop.mkLayoutSceneYaxisAttr "type" "linear"
                static member inline log = Interop.mkLayoutSceneYaxisAttr "type" "log"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline reversed = Interop.mkLayoutSceneYaxisAttr "autorange" "reversed"
                static member inline false' = Interop.mkLayoutSceneYaxisAttr "autorange" "false"
                static member inline true' = Interop.mkLayoutSceneYaxisAttr "autorange" "true"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline nonnegative = Interop.mkLayoutSceneYaxisAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkLayoutSceneYaxisAttr "rangemode" "normal"
                static member inline tozero = Interop.mkLayoutSceneYaxisAttr "rangemode" "tozero"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutSceneYaxisAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutSceneYaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutSceneYaxisAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutSceneYaxisAttr "ticks" ""
                static member inline inside = Interop.mkLayoutSceneYaxisAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutSceneYaxisAttr "ticks" "outside"

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline all = Interop.mkLayoutSceneYaxisAttr "mirror" "all"
                static member inline allticks = Interop.mkLayoutSceneYaxisAttr "mirror" "allticks"
                static member inline ticks = Interop.mkLayoutSceneYaxisAttr "mirror" "ticks"
                static member inline false' = Interop.mkLayoutSceneYaxisAttr "mirror" "false"
                static member inline true' = Interop.mkLayoutSceneYaxisAttr "mirror" "true"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutSceneYaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutSceneYaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutSceneYaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutSceneYaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutSceneYaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutSceneYaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutSceneYaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutSceneYaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutSceneYaxisAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutSceneYaxisAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutSceneYaxisAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutSceneYaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutSceneYaxisAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutSceneYaxisAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutSceneYaxisAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutSceneYaxisAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutSceneYaxisAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutSceneYaxisAttr "exponentformat" "power"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline chinese = Interop.mkLayoutSceneYaxisAttr "calendar" "chinese"
                static member inline coptic = Interop.mkLayoutSceneYaxisAttr "calendar" "coptic"
                static member inline discworld = Interop.mkLayoutSceneYaxisAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkLayoutSceneYaxisAttr "calendar" "ethiopian"
                static member inline gregorian = Interop.mkLayoutSceneYaxisAttr "calendar" "gregorian"
                static member inline hebrew = Interop.mkLayoutSceneYaxisAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkLayoutSceneYaxisAttr "calendar" "islamic"
                static member inline jalali = Interop.mkLayoutSceneYaxisAttr "calendar" "jalali"
                static member inline julian = Interop.mkLayoutSceneYaxisAttr "calendar" "julian"
                static member inline mayan = Interop.mkLayoutSceneYaxisAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkLayoutSceneYaxisAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkLayoutSceneYaxisAttr "calendar" "nepali"
                static member inline persian = Interop.mkLayoutSceneYaxisAttr "calendar" "persian"
                static member inline taiwan = Interop.mkLayoutSceneYaxisAttr "calendar" "taiwan"
                static member inline thai = Interop.mkLayoutSceneYaxisAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkLayoutSceneYaxisAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutAttr "text" value

            [<AutoOpen>]
            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickformatstops = 
                static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "tickformatstop" (createObj !!properties)

            [<AutoOpen>]
            module tickformatstops =
                [<Erase>]
                type tickformatstop =
                    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                    static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// string - dtickformat for described zoom level, the same as *tickformat*
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

        [<Erase>]
        type zaxis =
            static member inline title (properties: #ILayoutProperty list) = Interop.mkLayoutSceneZaxisAttr "title" (createObj !!properties)
            static member inline tickfont (properties: #ILayoutProperty list) = Interop.mkLayoutSceneZaxisAttr "tickfont" (createObj !!properties)
            static member inline tickformatstops (properties: #ILayoutProperty list) = Interop.mkLayoutSceneZaxisAttr "tickformatstops" (createObj !!properties)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutSceneZaxisAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkLayoutSceneZaxisAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkLayoutSceneZaxisAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkLayoutSceneZaxisAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkLayoutSceneZaxisAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkLayoutSceneZaxisAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkLayoutSceneZaxisAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkLayoutSceneZaxisAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkLayoutSceneZaxisAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutSceneZaxisAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "range" (values |> Array.ofSeq)
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutSceneZaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutSceneZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutSceneZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutSceneZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutSceneZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutSceneZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutSceneZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutSceneZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutSceneZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutSceneZaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutSceneZaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutSceneZaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutSceneZaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutSceneZaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutSceneZaxisAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutSceneZaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutSceneZaxisAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutSceneZaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutSceneZaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutSceneZaxisAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutSceneZaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutSceneZaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutSceneZaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutSceneZaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutSceneZaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutSceneZaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutSceneZaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutSceneZaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutSceneZaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutSceneZaxisAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkLayoutSceneZaxisAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkLayoutSceneZaxisAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkLayoutSceneZaxisAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkLayoutSceneZaxisAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutSceneZaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutSceneZaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutSceneZaxisAttr "ticktextsrc" value

        [<AutoOpen>]
        module zaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutSceneZaxisAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutSceneZaxisAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutSceneZaxisAttr "categoryorder" "trace"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutSceneZaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutSceneZaxisAttr "type" "category"
                static member inline date = Interop.mkLayoutSceneZaxisAttr "type" "date"
                static member inline linear = Interop.mkLayoutSceneZaxisAttr "type" "linear"
                static member inline log = Interop.mkLayoutSceneZaxisAttr "type" "log"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline reversed = Interop.mkLayoutSceneZaxisAttr "autorange" "reversed"
                static member inline false' = Interop.mkLayoutSceneZaxisAttr "autorange" "false"
                static member inline true' = Interop.mkLayoutSceneZaxisAttr "autorange" "true"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline nonnegative = Interop.mkLayoutSceneZaxisAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkLayoutSceneZaxisAttr "rangemode" "normal"
                static member inline tozero = Interop.mkLayoutSceneZaxisAttr "rangemode" "tozero"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutSceneZaxisAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutSceneZaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutSceneZaxisAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutSceneZaxisAttr "ticks" ""
                static member inline inside = Interop.mkLayoutSceneZaxisAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutSceneZaxisAttr "ticks" "outside"

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline all = Interop.mkLayoutSceneZaxisAttr "mirror" "all"
                static member inline allticks = Interop.mkLayoutSceneZaxisAttr "mirror" "allticks"
                static member inline ticks = Interop.mkLayoutSceneZaxisAttr "mirror" "ticks"
                static member inline false' = Interop.mkLayoutSceneZaxisAttr "mirror" "false"
                static member inline true' = Interop.mkLayoutSceneZaxisAttr "mirror" "true"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutSceneZaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutSceneZaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutSceneZaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutSceneZaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutSceneZaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutSceneZaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutSceneZaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutSceneZaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutSceneZaxisAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutSceneZaxisAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutSceneZaxisAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutSceneZaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutSceneZaxisAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutSceneZaxisAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutSceneZaxisAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutSceneZaxisAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutSceneZaxisAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutSceneZaxisAttr "exponentformat" "power"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline chinese = Interop.mkLayoutSceneZaxisAttr "calendar" "chinese"
                static member inline coptic = Interop.mkLayoutSceneZaxisAttr "calendar" "coptic"
                static member inline discworld = Interop.mkLayoutSceneZaxisAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkLayoutSceneZaxisAttr "calendar" "ethiopian"
                static member inline gregorian = Interop.mkLayoutSceneZaxisAttr "calendar" "gregorian"
                static member inline hebrew = Interop.mkLayoutSceneZaxisAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkLayoutSceneZaxisAttr "calendar" "islamic"
                static member inline jalali = Interop.mkLayoutSceneZaxisAttr "calendar" "jalali"
                static member inline julian = Interop.mkLayoutSceneZaxisAttr "calendar" "julian"
                static member inline mayan = Interop.mkLayoutSceneZaxisAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkLayoutSceneZaxisAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkLayoutSceneZaxisAttr "calendar" "nepali"
                static member inline persian = Interop.mkLayoutSceneZaxisAttr "calendar" "persian"
                static member inline taiwan = Interop.mkLayoutSceneZaxisAttr "calendar" "taiwan"
                static member inline thai = Interop.mkLayoutSceneZaxisAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkLayoutSceneZaxisAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutAttr "text" value

            [<AutoOpen>]
            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickformatstops = 
                static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "tickformatstop" (createObj !!properties)

            [<AutoOpen>]
            module tickformatstops =
                [<Erase>]
                type tickformatstop =
                    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                    static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// string - dtickformat for described zoom level, the same as *tickformat*
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

        [<Erase>]
        type annotations = 
            static member inline annotation (properties: #ILayoutProperty list) = Interop.mkLayoutSceneAnnotationsAttr "annotation" (createObj !!properties)

        [<AutoOpen>]
        module annotations =
            [<Erase>]
            type annotation =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                static member inline hoverlabel (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "hoverlabel" (createObj !!properties)
                /// Determines whether or not this annotation is visible.
                static member inline visible (value: bool) = Interop.mkLayoutAttr "visible" value
                /// Sets the annotation's x position.
                static member inline x (value: bool) = Interop.mkLayoutAttr "x" value
                /// Sets the annotation's x position.
                static member inline x (values: seq<bool>) = Interop.mkLayoutAttr "x" (values |> Array.ofSeq)
                /// Sets the annotation's x position.
                static member inline x (value: string) = Interop.mkLayoutAttr "x" value
                /// Sets the annotation's x position.
                static member inline x (values: seq<string>) = Interop.mkLayoutAttr "x" (values |> Array.ofSeq)
                /// Sets the annotation's x position.
                static member inline x (value: int) = Interop.mkLayoutAttr "x" value
                /// Sets the annotation's x position.
                static member inline x (values: seq<int>) = Interop.mkLayoutAttr "x" (values |> Array.ofSeq)
                /// Sets the annotation's x position.
                static member inline x (value: float) = Interop.mkLayoutAttr "x" value
                /// Sets the annotation's x position.
                static member inline x (values: seq<float>) = Interop.mkLayoutAttr "x" (values |> Array.ofSeq)
                /// Sets the annotation's y position.
                static member inline y (value: bool) = Interop.mkLayoutAttr "y" value
                /// Sets the annotation's y position.
                static member inline y (values: seq<bool>) = Interop.mkLayoutAttr "y" (values |> Array.ofSeq)
                /// Sets the annotation's y position.
                static member inline y (value: string) = Interop.mkLayoutAttr "y" value
                /// Sets the annotation's y position.
                static member inline y (values: seq<string>) = Interop.mkLayoutAttr "y" (values |> Array.ofSeq)
                /// Sets the annotation's y position.
                static member inline y (value: int) = Interop.mkLayoutAttr "y" value
                /// Sets the annotation's y position.
                static member inline y (values: seq<int>) = Interop.mkLayoutAttr "y" (values |> Array.ofSeq)
                /// Sets the annotation's y position.
                static member inline y (value: float) = Interop.mkLayoutAttr "y" value
                /// Sets the annotation's y position.
                static member inline y (values: seq<float>) = Interop.mkLayoutAttr "y" (values |> Array.ofSeq)
                /// Sets the annotation's z position.
                static member inline z (value: bool) = Interop.mkLayoutAttr "z" value
                /// Sets the annotation's z position.
                static member inline z (values: seq<bool>) = Interop.mkLayoutAttr "z" (values |> Array.ofSeq)
                /// Sets the annotation's z position.
                static member inline z (value: string) = Interop.mkLayoutAttr "z" value
                /// Sets the annotation's z position.
                static member inline z (values: seq<string>) = Interop.mkLayoutAttr "z" (values |> Array.ofSeq)
                /// Sets the annotation's z position.
                static member inline z (value: int) = Interop.mkLayoutAttr "z" value
                /// Sets the annotation's z position.
                static member inline z (values: seq<int>) = Interop.mkLayoutAttr "z" (values |> Array.ofSeq)
                /// Sets the annotation's z position.
                static member inline z (value: float) = Interop.mkLayoutAttr "z" value
                /// Sets the annotation's z position.
                static member inline z (values: seq<float>) = Interop.mkLayoutAttr "z" (values |> Array.ofSeq)
                /// Sets the x component of the arrow tail about the arrow head (in pixels).
                static member inline ax (value: int) = Interop.mkLayoutAttr "ax" value
                /// Sets the x component of the arrow tail about the arrow head (in pixels).
                static member inline ax (value: float) = Interop.mkLayoutAttr "ax" value
                /// Sets the y component of the arrow tail about the arrow head (in pixels).
                static member inline ay (value: int) = Interop.mkLayoutAttr "ay" value
                /// Sets the y component of the arrow tail about the arrow head (in pixels).
                static member inline ay (value: float) = Interop.mkLayoutAttr "ay" value
                /// Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels.
                static member inline xshift (value: int) = Interop.mkLayoutAttr "xshift" value
                /// Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels.
                static member inline xshift (value: float) = Interop.mkLayoutAttr "xshift" value
                /// Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels.
                static member inline yshift (value: int) = Interop.mkLayoutAttr "yshift" value
                /// Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels.
                static member inline yshift (value: float) = Interop.mkLayoutAttr "yshift" value
                /// Sets the text associated with this annotation. Plotly uses a subset of HTML tags to do things like newline (<br>), bold (<b></b>), italics (<i></i>), hyperlinks (<a href='...'></a>). Tags <em>, <sup>, <sub> <span> are also supported.
                static member inline text (value: string) = Interop.mkLayoutAttr "text" value
                /// Sets the angle at which the `text` is drawn with respect to the horizontal.
                static member inline textangle (value: int) = Interop.mkLayoutAttr "textangle" value
                /// Sets the angle at which the `text` is drawn with respect to the horizontal.
                static member inline textangle (value: float) = Interop.mkLayoutAttr "textangle" value
                /// Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line.
                static member inline width (value: int) = Interop.mkLayoutAttr "width" value
                /// Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line.
                static member inline width (value: float) = Interop.mkLayoutAttr "width" value
                /// Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped.
                static member inline height (value: int) = Interop.mkLayoutAttr "height" value
                /// Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped.
                static member inline height (value: float) = Interop.mkLayoutAttr "height" value
                /// Sets the opacity of the annotation (text + arrow).
                static member inline opacity (value: int) = Interop.mkLayoutAttr "opacity" value
                /// Sets the opacity of the annotation (text + arrow).
                static member inline opacity (value: float) = Interop.mkLayoutAttr "opacity" value
                /// Sets the background color of the annotation.
                static member inline bgcolor (value: string) = Interop.mkLayoutAttr "bgcolor" value
                /// Sets the color of the border enclosing the annotation `text`.
                static member inline bordercolor (value: string) = Interop.mkLayoutAttr "bordercolor" value
                /// Sets the padding (in px) between the `text` and the enclosing border.
                static member inline borderpad (value: int) = Interop.mkLayoutAttr "borderpad" value
                /// Sets the padding (in px) between the `text` and the enclosing border.
                static member inline borderpad (value: float) = Interop.mkLayoutAttr "borderpad" value
                /// Sets the width (in px) of the border enclosing the annotation `text`.
                static member inline borderwidth (value: int) = Interop.mkLayoutAttr "borderwidth" value
                /// Sets the width (in px) of the border enclosing the annotation `text`.
                static member inline borderwidth (value: float) = Interop.mkLayoutAttr "borderwidth" value
                /// Determines whether or not the annotation is drawn with an arrow. If *true*, `text` is placed near the arrow's tail. If *false*, `text` lines up with the `x` and `y` provided.
                static member inline showarrow (value: bool) = Interop.mkLayoutAttr "showarrow" value
                /// Sets the color of the annotation arrow.
                static member inline arrowcolor (value: string) = Interop.mkLayoutAttr "arrowcolor" value
                /// Sets the end annotation arrow head style.
                static member inline arrowhead (value: int) = Interop.mkLayoutAttr "arrowhead" value
                /// Sets the start annotation arrow head style.
                static member inline startarrowhead (value: int) = Interop.mkLayoutAttr "startarrowhead" value
                /// Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
                static member inline arrowsize (value: int) = Interop.mkLayoutAttr "arrowsize" value
                /// Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
                static member inline arrowsize (value: float) = Interop.mkLayoutAttr "arrowsize" value
                /// Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
                static member inline startarrowsize (value: int) = Interop.mkLayoutAttr "startarrowsize" value
                /// Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
                static member inline startarrowsize (value: float) = Interop.mkLayoutAttr "startarrowsize" value
                /// Sets the width (in px) of annotation arrow line.
                static member inline arrowwidth (value: int) = Interop.mkLayoutAttr "arrowwidth" value
                /// Sets the width (in px) of annotation arrow line.
                static member inline arrowwidth (value: float) = Interop.mkLayoutAttr "arrowwidth" value
                /// Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
                static member inline standoff (value: int) = Interop.mkLayoutAttr "standoff" value
                /// Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
                static member inline standoff (value: float) = Interop.mkLayoutAttr "standoff" value
                /// Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
                static member inline startstandoff (value: int) = Interop.mkLayoutAttr "startstandoff" value
                /// Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
                static member inline startstandoff (value: float) = Interop.mkLayoutAttr "startstandoff" value
                /// Sets text to appear when hovering over this annotation. If omitted or blank, no hover label will appear.
                static member inline hovertext (value: string) = Interop.mkLayoutAttr "hovertext" value
                /// Determines whether the annotation text box captures mouse move and click events, or allows those events to pass through to data points in the plot that may be behind the annotation. By default `captureevents` is *false* unless `hovertext` is provided. If you use the event `plotly_clickannotation` without `hovertext` you must explicitly enable `captureevents`.
                static member inline captureevents (value: bool) = Interop.mkLayoutAttr "captureevents" value
                /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

            [<AutoOpen>]
            module annotation =
                /// Sets the text box's horizontal position anchor This anchor binds the `x` position to the *left*, *center* or *right* of the annotation. For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the right-most portion of the annotation lines up with the right-most edge of the plotting area. If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
                [<Erase>]
                type xanchor =
                    static member inline auto = Interop.mkLayoutAttr "xanchor" "auto"
                    static member inline center = Interop.mkLayoutAttr "xanchor" "center"
                    static member inline left = Interop.mkLayoutAttr "xanchor" "left"
                    static member inline right = Interop.mkLayoutAttr "xanchor" "right"

                /// Sets the text box's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation. For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the top-most portion of the annotation lines up with the top-most edge of the plotting area. If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
                [<Erase>]
                type yanchor =
                    static member inline auto = Interop.mkLayoutAttr "yanchor" "auto"
                    static member inline bottom = Interop.mkLayoutAttr "yanchor" "bottom"
                    static member inline middle = Interop.mkLayoutAttr "yanchor" "middle"
                    static member inline top = Interop.mkLayoutAttr "yanchor" "top"

                /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans more two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
                [<Erase>]
                type align =
                    static member inline center = Interop.mkLayoutAttr "align" "center"
                    static member inline left = Interop.mkLayoutAttr "align" "left"
                    static member inline right = Interop.mkLayoutAttr "align" "right"

                /// Sets the vertical alignment of the `text` within the box. Has an effect only if an explicit height is set to override the text height.
                [<Erase>]
                type valign =
                    static member inline bottom = Interop.mkLayoutAttr "valign" "bottom"
                    static member inline middle = Interop.mkLayoutAttr "valign" "middle"
                    static member inline top = Interop.mkLayoutAttr "valign" "top"

                /// Sets the annotation arrow head position.
                [<Erase>]
                type arrowside =
                    static member inline none = Interop.mkLayoutAttr "arrowside" "none"
                    static member inline end' = Interop.mkLayoutAttr "arrowside" "end"
                    static member inline start = Interop.mkLayoutAttr "arrowside" "start"
                    static member inline startAndEnd = Interop.mkLayoutAttr "arrowside" "start+end"

                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

                [<Erase>]
                type hoverlabel =
                    static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                    /// Sets the background color of the hover label. By default uses the annotation's `bgcolor` made opaque, or white if it was transparent.
                    static member inline bgcolor (value: string) = Interop.mkLayoutAttr "bgcolor" value
                    /// Sets the border color of the hover label. By default uses either dark grey or white, for maximum contrast with `hoverlabel.bgcolor`.
                    static member inline bordercolor (value: string) = Interop.mkLayoutAttr "bordercolor" value

                [<AutoOpen>]
                module hoverlabel =
                    [<Erase>]
                    type font =
                        static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                        static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                        static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                        static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                        static member inline color (value: string) = Interop.mkLayoutAttr "color" value

    [<Erase>]
    type geo =
        static member inline domain (properties: #ILayoutGeoDomainProperty list) = Interop.mkLayoutGeoAttr "domain" (createObj !!properties)
        static member inline projection (properties: #ILayoutGeoProjectionProperty list) = Interop.mkLayoutGeoAttr "projection" (createObj !!properties)
        static member inline center (properties: #ILayoutGeoCenterProperty list) = Interop.mkLayoutGeoAttr "center" (createObj !!properties)
        static member inline lonaxis (properties: #ILayoutGeoLonaxisProperty list) = Interop.mkLayoutGeoAttr "lonaxis" (createObj !!properties)
        static member inline lataxis (properties: #ILayoutGeoLataxisProperty list) = Interop.mkLayoutGeoAttr "lataxis" (createObj !!properties)
        /// Sets whether or not the coastlines are drawn.
        static member inline showcoastlines (value: bool) = Interop.mkLayoutGeoAttr "showcoastlines" value
        /// Sets the coastline color.
        static member inline coastlinecolor (value: string) = Interop.mkLayoutGeoAttr "coastlinecolor" value
        /// Sets the coastline stroke width (in px).
        static member inline coastlinewidth (value: int) = Interop.mkLayoutGeoAttr "coastlinewidth" value
        /// Sets the coastline stroke width (in px).
        static member inline coastlinewidth (value: float) = Interop.mkLayoutGeoAttr "coastlinewidth" value
        /// Sets whether or not land masses are filled in color.
        static member inline showland (value: bool) = Interop.mkLayoutGeoAttr "showland" value
        /// Sets the land mass color.
        static member inline landcolor (value: string) = Interop.mkLayoutGeoAttr "landcolor" value
        /// Sets whether or not oceans are filled in color.
        static member inline showocean (value: bool) = Interop.mkLayoutGeoAttr "showocean" value
        /// Sets the ocean color
        static member inline oceancolor (value: string) = Interop.mkLayoutGeoAttr "oceancolor" value
        /// Sets whether or not lakes are drawn.
        static member inline showlakes (value: bool) = Interop.mkLayoutGeoAttr "showlakes" value
        /// Sets the color of the lakes.
        static member inline lakecolor (value: string) = Interop.mkLayoutGeoAttr "lakecolor" value
        /// Sets whether or not rivers are drawn.
        static member inline showrivers (value: bool) = Interop.mkLayoutGeoAttr "showrivers" value
        /// Sets color of the rivers.
        static member inline rivercolor (value: string) = Interop.mkLayoutGeoAttr "rivercolor" value
        /// Sets the stroke width (in px) of the rivers.
        static member inline riverwidth (value: int) = Interop.mkLayoutGeoAttr "riverwidth" value
        /// Sets the stroke width (in px) of the rivers.
        static member inline riverwidth (value: float) = Interop.mkLayoutGeoAttr "riverwidth" value
        /// Sets whether or not country boundaries are drawn.
        static member inline showcountries (value: bool) = Interop.mkLayoutGeoAttr "showcountries" value
        /// Sets line color of the country boundaries.
        static member inline countrycolor (value: string) = Interop.mkLayoutGeoAttr "countrycolor" value
        /// Sets line width (in px) of the country boundaries.
        static member inline countrywidth (value: int) = Interop.mkLayoutGeoAttr "countrywidth" value
        /// Sets line width (in px) of the country boundaries.
        static member inline countrywidth (value: float) = Interop.mkLayoutGeoAttr "countrywidth" value
        /// Sets whether or not boundaries of subunits within countries (e.g. states, provinces) are drawn.
        static member inline showsubunits (value: bool) = Interop.mkLayoutGeoAttr "showsubunits" value
        /// Sets the color of the subunits boundaries.
        static member inline subunitcolor (value: string) = Interop.mkLayoutGeoAttr "subunitcolor" value
        /// Sets the stroke width (in px) of the subunits boundaries.
        static member inline subunitwidth (value: int) = Interop.mkLayoutGeoAttr "subunitwidth" value
        /// Sets the stroke width (in px) of the subunits boundaries.
        static member inline subunitwidth (value: float) = Interop.mkLayoutGeoAttr "subunitwidth" value
        /// Sets whether or not a frame is drawn around the map.
        static member inline showframe (value: bool) = Interop.mkLayoutGeoAttr "showframe" value
        /// Sets the color the frame.
        static member inline framecolor (value: string) = Interop.mkLayoutGeoAttr "framecolor" value
        /// Sets the stroke width (in px) of the frame.
        static member inline framewidth (value: int) = Interop.mkLayoutGeoAttr "framewidth" value
        /// Sets the stroke width (in px) of the frame.
        static member inline framewidth (value: float) = Interop.mkLayoutGeoAttr "framewidth" value
        /// Set the background color of the map
        static member inline bgcolor (value: string) = Interop.mkLayoutGeoAttr "bgcolor" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutGeoAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutGeoAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutGeoAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutGeoAttr "uirevision" (values |> Array.ofSeq)

    [<AutoOpen>]
    module geo =
        /// Sets the resolution of the base layers. The values have units of km/mm e.g. 110 corresponds to a scale ratio of 1:110,000,000.
        [<Erase>]
        type resolution =
            static member inline _110 = Interop.mkLayoutGeoAttr "resolution" "110"
            static member inline _50 = Interop.mkLayoutGeoAttr "resolution" "50"

        /// Set the scope of the map.
        [<Erase>]
        type scope =
            static member inline africa = Interop.mkLayoutGeoAttr "scope" "africa"
            static member inline asia = Interop.mkLayoutGeoAttr "scope" "asia"
            static member inline europe = Interop.mkLayoutGeoAttr "scope" "europe"
            static member inline northAmerica = Interop.mkLayoutGeoAttr "scope" "north america"
            static member inline southAmerica = Interop.mkLayoutGeoAttr "scope" "south america"
            static member inline usa = Interop.mkLayoutGeoAttr "scope" "usa"
            static member inline world = Interop.mkLayoutGeoAttr "scope" "world"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline x (values: seq<int>) = Interop.mkLayoutGeoDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the horizontal domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline x (values: seq<float>) = Interop.mkLayoutGeoDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the vertical domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline y (values: seq<int>) = Interop.mkLayoutGeoDomainAttr "y" (values |> Array.ofSeq)
            /// Sets the vertical domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline y (values: seq<float>) = Interop.mkLayoutGeoDomainAttr "y" (values |> Array.ofSeq)
            /// If there is a layout grid, use the domain for this row in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline row (value: int) = Interop.mkLayoutGeoDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline column (value: int) = Interop.mkLayoutGeoDomainAttr "column" value

        [<Erase>]
        type projection =
            static member inline rotation (properties: #ILayoutProperty list) = Interop.mkLayoutGeoProjectionAttr "rotation" (createObj !!properties)
            /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
            static member inline parallels (values: seq<int>) = Interop.mkLayoutGeoProjectionAttr "parallels" (values |> Array.ofSeq)
            /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
            static member inline parallels (values: seq<float>) = Interop.mkLayoutGeoProjectionAttr "parallels" (values |> Array.ofSeq)
            /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
            static member inline scale (value: int) = Interop.mkLayoutGeoProjectionAttr "scale" value
            /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
            static member inline scale (value: float) = Interop.mkLayoutGeoProjectionAttr "scale" value

        [<AutoOpen>]
        module projection =
            /// Sets the projection type.
            [<Erase>]
            type type' =
                static member inline aitoff = Interop.mkLayoutGeoProjectionAttr "type" "aitoff"
                static member inline albersUsa = Interop.mkLayoutGeoProjectionAttr "type" "albers usa"
                static member inline azimuthalEqualArea = Interop.mkLayoutGeoProjectionAttr "type" "azimuthal equal area"
                static member inline azimuthalEquidistant = Interop.mkLayoutGeoProjectionAttr "type" "azimuthal equidistant"
                static member inline conicConformal = Interop.mkLayoutGeoProjectionAttr "type" "conic conformal"
                static member inline conicEqualArea = Interop.mkLayoutGeoProjectionAttr "type" "conic equal area"
                static member inline conicEquidistant = Interop.mkLayoutGeoProjectionAttr "type" "conic equidistant"
                static member inline eckert4 = Interop.mkLayoutGeoProjectionAttr "type" "eckert4"
                static member inline equirectangular = Interop.mkLayoutGeoProjectionAttr "type" "equirectangular"
                static member inline gnomonic = Interop.mkLayoutGeoProjectionAttr "type" "gnomonic"
                static member inline hammer = Interop.mkLayoutGeoProjectionAttr "type" "hammer"
                static member inline kavrayskiy7 = Interop.mkLayoutGeoProjectionAttr "type" "kavrayskiy7"
                static member inline mercator = Interop.mkLayoutGeoProjectionAttr "type" "mercator"
                static member inline miller = Interop.mkLayoutGeoProjectionAttr "type" "miller"
                static member inline mollweide = Interop.mkLayoutGeoProjectionAttr "type" "mollweide"
                static member inline naturalEarth = Interop.mkLayoutGeoProjectionAttr "type" "natural earth"
                static member inline orthographic = Interop.mkLayoutGeoProjectionAttr "type" "orthographic"
                static member inline robinson = Interop.mkLayoutGeoProjectionAttr "type" "robinson"
                static member inline sinusoidal = Interop.mkLayoutGeoProjectionAttr "type" "sinusoidal"
                static member inline stereographic = Interop.mkLayoutGeoProjectionAttr "type" "stereographic"
                static member inline transverseMercator = Interop.mkLayoutGeoProjectionAttr "type" "transverse mercator"
                static member inline winkelTripel = Interop.mkLayoutGeoProjectionAttr "type" "winkel tripel"

            [<Erase>]
            type rotation =
                /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
                static member inline lon (value: int) = Interop.mkLayoutAttr "lon" value
                /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
                static member inline lon (value: float) = Interop.mkLayoutAttr "lon" value
                /// Rotates the map along meridians (in degrees North).
                static member inline lat (value: int) = Interop.mkLayoutAttr "lat" value
                /// Rotates the map along meridians (in degrees North).
                static member inline lat (value: float) = Interop.mkLayoutAttr "lat" value
                /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
                static member inline roll (value: int) = Interop.mkLayoutAttr "roll" value
                /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
                static member inline roll (value: float) = Interop.mkLayoutAttr "roll" value

        [<Erase>]
        type center =
            /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
            static member inline lon (value: int) = Interop.mkLayoutGeoCenterAttr "lon" value
            /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
            static member inline lon (value: float) = Interop.mkLayoutGeoCenterAttr "lon" value
            /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
            static member inline lat (value: int) = Interop.mkLayoutGeoCenterAttr "lat" value
            /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
            static member inline lat (value: float) = Interop.mkLayoutGeoCenterAttr "lat" value

        [<Erase>]
        type lonaxis =
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<int>) = Interop.mkLayoutGeoLonaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<float>) = Interop.mkLayoutGeoLonaxisAttr "range" (values |> Array.ofSeq)
            /// Sets whether or not graticule are shown on the map.
            static member inline showgrid (value: bool) = Interop.mkLayoutGeoLonaxisAttr "showgrid" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: int) = Interop.mkLayoutGeoLonaxisAttr "tick0" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: float) = Interop.mkLayoutGeoLonaxisAttr "tick0" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: int) = Interop.mkLayoutGeoLonaxisAttr "dtick" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: float) = Interop.mkLayoutGeoLonaxisAttr "dtick" value
            /// Sets the graticule's stroke color.
            static member inline gridcolor (value: string) = Interop.mkLayoutGeoLonaxisAttr "gridcolor" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: int) = Interop.mkLayoutGeoLonaxisAttr "gridwidth" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: float) = Interop.mkLayoutGeoLonaxisAttr "gridwidth" value

        [<Erase>]
        type lataxis =
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<int>) = Interop.mkLayoutGeoLataxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<float>) = Interop.mkLayoutGeoLataxisAttr "range" (values |> Array.ofSeq)
            /// Sets whether or not graticule are shown on the map.
            static member inline showgrid (value: bool) = Interop.mkLayoutGeoLataxisAttr "showgrid" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: int) = Interop.mkLayoutGeoLataxisAttr "tick0" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: float) = Interop.mkLayoutGeoLataxisAttr "tick0" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: int) = Interop.mkLayoutGeoLataxisAttr "dtick" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: float) = Interop.mkLayoutGeoLataxisAttr "dtick" value
            /// Sets the graticule's stroke color.
            static member inline gridcolor (value: string) = Interop.mkLayoutGeoLataxisAttr "gridcolor" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: int) = Interop.mkLayoutGeoLataxisAttr "gridwidth" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: float) = Interop.mkLayoutGeoLataxisAttr "gridwidth" value

    [<Erase>]
    type mapbox =
        static member inline _arrayAttrRegexps (properties: #ILayoutMapbox_arrayAttrRegexpsProperty list) = Interop.mkLayoutMapboxAttr "_arrayAttrRegexps" (createObj !!properties)
        static member inline domain (properties: #ILayoutMapboxDomainProperty list) = Interop.mkLayoutMapboxAttr "domain" (createObj !!properties)
        static member inline center (properties: #ILayoutMapboxCenterProperty list) = Interop.mkLayoutMapboxAttr "center" (createObj !!properties)
        static member inline layers (properties: #ILayoutMapboxLayersProperty list) = Interop.mkLayoutMapboxAttr "layers" (createObj !!properties)
        /// Sets the mapbox access token to be used for this mapbox map. Alternatively, the mapbox access token can be set in the configuration options under `mapboxAccessToken`. Note that accessToken are only required when `style` (e.g with values : basic, streets, outdoors, light, dark, satellite, satellite-streets ) and/or a layout layer references the Mapbox server.
        static member inline accesstoken (value: string) = Interop.mkLayoutMapboxAttr "accesstoken" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: bool) = Interop.mkLayoutMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<bool>) = Interop.mkLayoutMapboxAttr "style" (values |> Array.ofSeq)
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: string) = Interop.mkLayoutMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<string>) = Interop.mkLayoutMapboxAttr "style" (values |> Array.ofSeq)
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: int) = Interop.mkLayoutMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<int>) = Interop.mkLayoutMapboxAttr "style" (values |> Array.ofSeq)
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: float) = Interop.mkLayoutMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<float>) = Interop.mkLayoutMapboxAttr "style" (values |> Array.ofSeq)
        /// Sets the zoom level of the map (mapbox.zoom).
        static member inline zoom (value: int) = Interop.mkLayoutMapboxAttr "zoom" value
        /// Sets the zoom level of the map (mapbox.zoom).
        static member inline zoom (value: float) = Interop.mkLayoutMapboxAttr "zoom" value
        /// Sets the bearing angle of the map in degrees counter-clockwise from North (mapbox.bearing).
        static member inline bearing (value: int) = Interop.mkLayoutMapboxAttr "bearing" value
        /// Sets the bearing angle of the map in degrees counter-clockwise from North (mapbox.bearing).
        static member inline bearing (value: float) = Interop.mkLayoutMapboxAttr "bearing" value
        /// Sets the pitch angle of the map (in degrees, where *0* means perpendicular to the surface of the map) (mapbox.pitch).
        static member inline pitch (value: int) = Interop.mkLayoutMapboxAttr "pitch" value
        /// Sets the pitch angle of the map (in degrees, where *0* means perpendicular to the surface of the map) (mapbox.pitch).
        static member inline pitch (value: float) = Interop.mkLayoutMapboxAttr "pitch" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutMapboxAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutMapboxAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutMapboxAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutMapboxAttr "uirevision" (values |> Array.ofSeq)

    [<AutoOpen>]
    module mapbox =
        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this mapbox subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkLayoutMapboxDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the horizontal domain of this mapbox subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkLayoutMapboxDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the vertical domain of this mapbox subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkLayoutMapboxDomainAttr "y" (values |> Array.ofSeq)
            /// Sets the vertical domain of this mapbox subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkLayoutMapboxDomainAttr "y" (values |> Array.ofSeq)
            /// If there is a layout grid, use the domain for this row in the grid for this mapbox subplot .
            static member inline row (value: int) = Interop.mkLayoutMapboxDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this mapbox subplot .
            static member inline column (value: int) = Interop.mkLayoutMapboxDomainAttr "column" value

        [<Erase>]
        type center =
            /// Sets the longitude of the center of the map (in degrees East).
            static member inline lon (value: int) = Interop.mkLayoutMapboxCenterAttr "lon" value
            /// Sets the longitude of the center of the map (in degrees East).
            static member inline lon (value: float) = Interop.mkLayoutMapboxCenterAttr "lon" value
            /// Sets the latitude of the center of the map (in degrees North).
            static member inline lat (value: int) = Interop.mkLayoutMapboxCenterAttr "lat" value
            /// Sets the latitude of the center of the map (in degrees North).
            static member inline lat (value: float) = Interop.mkLayoutMapboxCenterAttr "lat" value

        [<Erase>]
        type layers = 
            static member inline layer (properties: #ILayoutProperty list) = Interop.mkLayoutMapboxLayersAttr "layer" (createObj !!properties)

        [<AutoOpen>]
        module layers =
            [<Erase>]
            type layer =
                static member inline circle (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "circle" (createObj !!properties)
                static member inline line (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "line" (createObj !!properties)
                static member inline fill (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "fill" (createObj !!properties)
                static member inline symbol (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "symbol" (createObj !!properties)
                /// Determines whether this layer is displayed
                static member inline visible (value: bool) = Interop.mkLayoutAttr "visible" value
                /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
                static member inline source (value: bool) = Interop.mkLayoutAttr "source" value
                /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
                static member inline source (values: seq<bool>) = Interop.mkLayoutAttr "source" (values |> Array.ofSeq)
                /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
                static member inline source (value: string) = Interop.mkLayoutAttr "source" value
                /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
                static member inline source (values: seq<string>) = Interop.mkLayoutAttr "source" (values |> Array.ofSeq)
                /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
                static member inline source (value: int) = Interop.mkLayoutAttr "source" value
                /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
                static member inline source (values: seq<int>) = Interop.mkLayoutAttr "source" (values |> Array.ofSeq)
                /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
                static member inline source (value: float) = Interop.mkLayoutAttr "source" value
                /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
                static member inline source (values: seq<float>) = Interop.mkLayoutAttr "source" (values |> Array.ofSeq)
                /// Specifies the layer to use from a vector tile source (mapbox.layer.source-layer). Required for *vector* source type that supports multiple layers.
                static member inline sourcelayer (value: string) = Interop.mkLayoutAttr "sourcelayer" value
                /// Sets the attribution for this source.
                static member inline sourceattribution (value: string) = Interop.mkLayoutAttr "sourceattribution" value
                /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
                static member inline coordinates (value: bool) = Interop.mkLayoutAttr "coordinates" value
                /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
                static member inline coordinates (values: seq<bool>) = Interop.mkLayoutAttr "coordinates" (values |> Array.ofSeq)
                /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
                static member inline coordinates (value: string) = Interop.mkLayoutAttr "coordinates" value
                /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
                static member inline coordinates (values: seq<string>) = Interop.mkLayoutAttr "coordinates" (values |> Array.ofSeq)
                /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
                static member inline coordinates (value: int) = Interop.mkLayoutAttr "coordinates" value
                /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
                static member inline coordinates (values: seq<int>) = Interop.mkLayoutAttr "coordinates" (values |> Array.ofSeq)
                /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
                static member inline coordinates (value: float) = Interop.mkLayoutAttr "coordinates" value
                /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
                static member inline coordinates (values: seq<float>) = Interop.mkLayoutAttr "coordinates" (values |> Array.ofSeq)
                /// Determines if the layer will be inserted before the layer with the specified ID. If omitted or set to '', the layer will be inserted above every existing layer.
                static member inline below (value: string) = Interop.mkLayoutAttr "below" value
                /// Sets the primary layer color. If `type` is *circle*, color corresponds to the circle color (mapbox.layer.paint.circle-color) If `type` is *line*, color corresponds to the line color (mapbox.layer.paint.line-color) If `type` is *fill*, color corresponds to the fill color (mapbox.layer.paint.fill-color) If `type` is *symbol*, color corresponds to the icon color (mapbox.layer.paint.icon-color)
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value
                /// Sets the opacity of the layer. If `type` is *circle*, opacity corresponds to the circle opacity (mapbox.layer.paint.circle-opacity) If `type` is *line*, opacity corresponds to the line opacity (mapbox.layer.paint.line-opacity) If `type` is *fill*, opacity corresponds to the fill opacity (mapbox.layer.paint.fill-opacity) If `type` is *symbol*, opacity corresponds to the icon/text opacity (mapbox.layer.paint.text-opacity)
                static member inline opacity (value: int) = Interop.mkLayoutAttr "opacity" value
                /// Sets the opacity of the layer. If `type` is *circle*, opacity corresponds to the circle opacity (mapbox.layer.paint.circle-opacity) If `type` is *line*, opacity corresponds to the line opacity (mapbox.layer.paint.line-opacity) If `type` is *fill*, opacity corresponds to the fill opacity (mapbox.layer.paint.fill-opacity) If `type` is *symbol*, opacity corresponds to the icon/text opacity (mapbox.layer.paint.text-opacity)
                static member inline opacity (value: float) = Interop.mkLayoutAttr "opacity" value
                /// Sets the minimum zoom level (mapbox.layer.minzoom). At zoom levels less than the minzoom, the layer will be hidden.
                static member inline minzoom (value: int) = Interop.mkLayoutAttr "minzoom" value
                /// Sets the minimum zoom level (mapbox.layer.minzoom). At zoom levels less than the minzoom, the layer will be hidden.
                static member inline minzoom (value: float) = Interop.mkLayoutAttr "minzoom" value
                /// Sets the maximum zoom level (mapbox.layer.maxzoom). At zoom levels equal to or greater than the maxzoom, the layer will be hidden.
                static member inline maxzoom (value: int) = Interop.mkLayoutAttr "maxzoom" value
                /// Sets the maximum zoom level (mapbox.layer.maxzoom). At zoom levels equal to or greater than the maxzoom, the layer will be hidden.
                static member inline maxzoom (value: float) = Interop.mkLayoutAttr "maxzoom" value
                /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

            [<AutoOpen>]
            module layer =
                /// Sets the source type for this layer, that is the type of the layer data.
                [<Erase>]
                type sourcetype =
                    static member inline geojson = Interop.mkLayoutAttr "sourcetype" "geojson"
                    static member inline image = Interop.mkLayoutAttr "sourcetype" "image"
                    static member inline raster = Interop.mkLayoutAttr "sourcetype" "raster"
                    static member inline vector = Interop.mkLayoutAttr "sourcetype" "vector"

                /// Sets the layer type, that is the how the layer data set in `source` will be rendered With `sourcetype` set to *geojson*, the following values are allowed: *circle*, *line*, *fill* and *symbol*. but note that *line* and *fill* are not compatible with Point GeoJSON geometries. With `sourcetype` set to *vector*, the following values are allowed:  *circle*, *line*, *fill* and *symbol*. With `sourcetype` set to *raster* or `*image*`, only the *raster* value is allowed.
                [<Erase>]
                type type' =
                    static member inline circle = Interop.mkLayoutAttr "type" "circle"
                    static member inline fill = Interop.mkLayoutAttr "type" "fill"
                    static member inline line = Interop.mkLayoutAttr "type" "line"
                    static member inline raster = Interop.mkLayoutAttr "type" "raster"
                    static member inline symbol = Interop.mkLayoutAttr "type" "symbol"

                [<Erase>]
                type circle =
                    /// Sets the circle radius (mapbox.layer.paint.circle-radius). Has an effect only when `type` is set to *circle*.
                    static member inline radius (value: int) = Interop.mkLayoutAttr "radius" value
                    /// Sets the circle radius (mapbox.layer.paint.circle-radius). Has an effect only when `type` is set to *circle*.
                    static member inline radius (value: float) = Interop.mkLayoutAttr "radius" value

                [<Erase>]
                type line =
                    /// Sets the line width (mapbox.layer.paint.line-width). Has an effect only when `type` is set to *line*.
                    static member inline width (value: int) = Interop.mkLayoutAttr "width" value
                    /// Sets the line width (mapbox.layer.paint.line-width). Has an effect only when `type` is set to *line*.
                    static member inline width (value: float) = Interop.mkLayoutAttr "width" value
                    /// Sets the length of dashes and gaps (mapbox.layer.paint.line-dasharray). Has an effect only when `type` is set to *line*.
                    static member inline dash (values: seq<bool>) = Interop.mkLayoutAttr "dash" (values |> Array.ofSeq)
                    /// Sets the length of dashes and gaps (mapbox.layer.paint.line-dasharray). Has an effect only when `type` is set to *line*.
                    static member inline dash (values: seq<string>) = Interop.mkLayoutAttr "dash" (values |> Array.ofSeq)
                    /// Sets the length of dashes and gaps (mapbox.layer.paint.line-dasharray). Has an effect only when `type` is set to *line*.
                    static member inline dash (values: seq<int>) = Interop.mkLayoutAttr "dash" (values |> Array.ofSeq)
                    /// Sets the length of dashes and gaps (mapbox.layer.paint.line-dasharray). Has an effect only when `type` is set to *line*.
                    static member inline dash (values: seq<float>) = Interop.mkLayoutAttr "dash" (values |> Array.ofSeq)
                    /// Sets the source reference on plot.ly for  dash .
                    static member inline dashsrc (value: string) = Interop.mkLayoutAttr "dashsrc" value

                [<Erase>]
                type fill =
                    /// Sets the fill outline color (mapbox.layer.paint.fill-outline-color). Has an effect only when `type` is set to *fill*.
                    static member inline outlinecolor (value: string) = Interop.mkLayoutAttr "outlinecolor" value

                [<Erase>]
                type symbol =
                    static member inline textfont (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "textfont" (createObj !!properties)
                    /// Sets the symbol icon image (mapbox.layer.layout.icon-image). Full list: https://www.mapbox.com/maki-icons/
                    static member inline icon (value: string) = Interop.mkLayoutAttr "icon" value
                    /// Sets the symbol icon size (mapbox.layer.layout.icon-size). Has an effect only when `type` is set to *symbol*.
                    static member inline iconsize (value: int) = Interop.mkLayoutAttr "iconsize" value
                    /// Sets the symbol icon size (mapbox.layer.layout.icon-size). Has an effect only when `type` is set to *symbol*.
                    static member inline iconsize (value: float) = Interop.mkLayoutAttr "iconsize" value
                    /// Sets the symbol text (mapbox.layer.layout.text-field).
                    static member inline text (value: string) = Interop.mkLayoutAttr "text" value

                [<AutoOpen>]
                module symbol =
                    /// Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement). If `placement` is *point*, the label is placed where the geometry is located If `placement` is *line*, the label is placed along the line of the geometry If `placement` is *line-center*, the label is placed on the center of the geometry
                    [<Erase>]
                    type placement =
                        static member inline line = Interop.mkLayoutAttr "placement" "line"
                        static member inline lineCenter = Interop.mkLayoutAttr "placement" "line-center"
                        static member inline point = Interop.mkLayoutAttr "placement" "point"

                    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
                    [<Erase>]
                    type textposition =
                        static member inline bottomCenter = Interop.mkLayoutAttr "textposition" "bottom center"
                        static member inline bottomLeft = Interop.mkLayoutAttr "textposition" "bottom left"
                        static member inline bottomRight = Interop.mkLayoutAttr "textposition" "bottom right"
                        static member inline middleCenter = Interop.mkLayoutAttr "textposition" "middle center"
                        static member inline middleLeft = Interop.mkLayoutAttr "textposition" "middle left"
                        static member inline middleRight = Interop.mkLayoutAttr "textposition" "middle right"
                        static member inline topCenter = Interop.mkLayoutAttr "textposition" "top center"
                        static member inline topLeft = Interop.mkLayoutAttr "textposition" "top left"
                        static member inline topRight = Interop.mkLayoutAttr "textposition" "top right"

                    [<Erase>]
                    type textfont =
                        static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                        static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                        static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                        static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                        static member inline color (value: string) = Interop.mkLayoutAttr "color" value

    [<Erase>]
    type polar =
        static member inline domain (properties: #ILayoutPolarDomainProperty list) = Interop.mkLayoutPolarAttr "domain" (createObj !!properties)
        static member inline radialaxis (properties: #ILayoutPolarRadialaxisProperty list) = Interop.mkLayoutPolarAttr "radialaxis" (createObj !!properties)
        static member inline angularaxis (properties: #ILayoutPolarAngularaxisProperty list) = Interop.mkLayoutPolarAttr "angularaxis" (createObj !!properties)
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        static member inline sector (values: seq<int>) = Interop.mkLayoutPolarAttr "sector" (values |> Array.ofSeq)
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        static member inline sector (values: seq<float>) = Interop.mkLayoutPolarAttr "sector" (values |> Array.ofSeq)
        /// Sets the fraction of the radius to cut out of the polar subplot.
        static member inline hole (value: int) = Interop.mkLayoutPolarAttr "hole" value
        /// Sets the fraction of the radius to cut out of the polar subplot.
        static member inline hole (value: float) = Interop.mkLayoutPolarAttr "hole" value
        /// Set the background color of the subplot
        static member inline bgcolor (value: string) = Interop.mkLayoutPolarAttr "bgcolor" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutPolarAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutPolarAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutPolarAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutPolarAttr "uirevision" (values |> Array.ofSeq)

    [<AutoOpen>]
    module polar =
        /// Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
        [<Erase>]
        type gridshape =
            static member inline circular = Interop.mkLayoutPolarAttr "gridshape" "circular"
            static member inline linear = Interop.mkLayoutPolarAttr "gridshape" "linear"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this polar subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkLayoutPolarDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the horizontal domain of this polar subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkLayoutPolarDomainAttr "x" (values |> Array.ofSeq)
            /// Sets the vertical domain of this polar subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkLayoutPolarDomainAttr "y" (values |> Array.ofSeq)
            /// Sets the vertical domain of this polar subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkLayoutPolarDomainAttr "y" (values |> Array.ofSeq)
            /// If there is a layout grid, use the domain for this row in the grid for this polar subplot .
            static member inline row (value: int) = Interop.mkLayoutPolarDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this polar subplot .
            static member inline column (value: int) = Interop.mkLayoutPolarDomainAttr "column" value

        [<Erase>]
        type radialaxis =
            static member inline title (properties: #ILayoutProperty list) = Interop.mkLayoutPolarRadialaxisAttr "title" (createObj !!properties)
            static member inline tickfont (properties: #ILayoutProperty list) = Interop.mkLayoutPolarRadialaxisAttr "tickfont" (createObj !!properties)
            static member inline tickformatstops (properties: #ILayoutProperty list) = Interop.mkLayoutPolarRadialaxisAttr "tickformatstops" (createObj !!properties)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "visible" value
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "range" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
            static member inline angle (value: int) = Interop.mkLayoutPolarRadialaxisAttr "angle" value
            /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
            static member inline angle (value: float) = Interop.mkLayoutPolarRadialaxisAttr "angle" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutPolarRadialaxisAttr "hoverformat" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutPolarRadialaxisAttr "color" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutPolarRadialaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutPolarRadialaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutPolarRadialaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutPolarRadialaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutPolarRadialaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutPolarRadialaxisAttr "gridwidth" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutPolarRadialaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutPolarRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutPolarRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutPolarRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutPolarRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutPolarRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutPolarRadialaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutPolarRadialaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutPolarRadialaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutPolarRadialaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutPolarRadialaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutPolarRadialaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutPolarRadialaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tickformat" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutPolarRadialaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutPolarRadialaxisAttr "ticktextsrc" value

        [<AutoOpen>]
        module radialaxis =
            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutPolarRadialaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutPolarRadialaxisAttr "type" "category"
                static member inline date = Interop.mkLayoutPolarRadialaxisAttr "type" "date"
                static member inline linear = Interop.mkLayoutPolarRadialaxisAttr "type" "linear"
                static member inline log = Interop.mkLayoutPolarRadialaxisAttr "type" "log"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline reversed = Interop.mkLayoutPolarRadialaxisAttr "autorange" "reversed"
                static member inline false' = Interop.mkLayoutPolarRadialaxisAttr "autorange" "false"
                static member inline true' = Interop.mkLayoutPolarRadialaxisAttr "autorange" "true"

            /// If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. If *normal*, the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).
            [<Erase>]
            type rangemode =
                static member inline nonnegative = Interop.mkLayoutPolarRadialaxisAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkLayoutPolarRadialaxisAttr "rangemode" "normal"
                static member inline tozero = Interop.mkLayoutPolarRadialaxisAttr "rangemode" "tozero"

            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutPolarRadialaxisAttr "categoryorder" "trace"

            /// Determines on which side of radial axis line the tick and tick labels appear.
            [<Erase>]
            type side =
                static member inline clockwise = Interop.mkLayoutPolarRadialaxisAttr "side" "clockwise"
                static member inline counterclockwise = Interop.mkLayoutPolarRadialaxisAttr "side" "counterclockwise"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutPolarRadialaxisAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutPolarRadialaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutPolarRadialaxisAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutPolarRadialaxisAttr "ticks" ""
                static member inline inside = Interop.mkLayoutPolarRadialaxisAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutPolarRadialaxisAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutPolarRadialaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutPolarRadialaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutPolarRadialaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutPolarRadialaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutPolarRadialaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutPolarRadialaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutPolarRadialaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutPolarRadialaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutPolarRadialaxisAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutPolarRadialaxisAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutPolarRadialaxisAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutPolarRadialaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutPolarRadialaxisAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutPolarRadialaxisAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutPolarRadialaxisAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutPolarRadialaxisAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutPolarRadialaxisAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutPolarRadialaxisAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutPolarRadialaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutPolarRadialaxisAttr "layer" "below traces"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline chinese = Interop.mkLayoutPolarRadialaxisAttr "calendar" "chinese"
                static member inline coptic = Interop.mkLayoutPolarRadialaxisAttr "calendar" "coptic"
                static member inline discworld = Interop.mkLayoutPolarRadialaxisAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkLayoutPolarRadialaxisAttr "calendar" "ethiopian"
                static member inline gregorian = Interop.mkLayoutPolarRadialaxisAttr "calendar" "gregorian"
                static member inline hebrew = Interop.mkLayoutPolarRadialaxisAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkLayoutPolarRadialaxisAttr "calendar" "islamic"
                static member inline jalali = Interop.mkLayoutPolarRadialaxisAttr "calendar" "jalali"
                static member inline julian = Interop.mkLayoutPolarRadialaxisAttr "calendar" "julian"
                static member inline mayan = Interop.mkLayoutPolarRadialaxisAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkLayoutPolarRadialaxisAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkLayoutPolarRadialaxisAttr "calendar" "nepali"
                static member inline persian = Interop.mkLayoutPolarRadialaxisAttr "calendar" "persian"
                static member inline taiwan = Interop.mkLayoutPolarRadialaxisAttr "calendar" "taiwan"
                static member inline thai = Interop.mkLayoutPolarRadialaxisAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkLayoutPolarRadialaxisAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutAttr "text" value

            [<AutoOpen>]
            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickformatstops = 
                static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "tickformatstop" (createObj !!properties)

            [<AutoOpen>]
            module tickformatstops =
                [<Erase>]
                type tickformatstop =
                    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                    static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// string - dtickformat for described zoom level, the same as *tickformat*
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

        [<Erase>]
        type angularaxis =
            static member inline tickfont (properties: #ILayoutProperty list) = Interop.mkLayoutPolarAngularaxisAttr "tickfont" (createObj !!properties)
            static member inline tickformatstops (properties: #ILayoutProperty list) = Interop.mkLayoutPolarAngularaxisAttr "tickformatstops" (createObj !!properties)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "visible" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "categoryarray" (values |> Array.ofSeq)
            /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
            static member inline period (value: int) = Interop.mkLayoutPolarAngularaxisAttr "period" value
            /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
            static member inline period (value: float) = Interop.mkLayoutPolarAngularaxisAttr "period" value
            /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
            static member inline rotation (value: int) = Interop.mkLayoutPolarAngularaxisAttr "rotation" value
            /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
            static member inline rotation (value: float) = Interop.mkLayoutPolarAngularaxisAttr "rotation" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutPolarAngularaxisAttr "hoverformat" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" (values |> Array.ofSeq)
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutPolarAngularaxisAttr "color" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutPolarAngularaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutPolarAngularaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutPolarAngularaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutPolarAngularaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutPolarAngularaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutPolarAngularaxisAttr "gridwidth" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutPolarAngularaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutPolarAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutPolarAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "tick0" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutPolarAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutPolarAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutPolarAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "dtick" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutPolarAngularaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutPolarAngularaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutPolarAngularaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutPolarAngularaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutPolarAngularaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutPolarAngularaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutPolarAngularaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tickformat" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutPolarAngularaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutPolarAngularaxisAttr "ticktextsrc" value

        [<AutoOpen>]
        module angularaxis =
            /// Sets the angular axis type. If *linear*, set `thetaunit` to determine the unit in which axis value are shown. If *category, use `period` to set the number of integer coordinates around polar axis.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutPolarAngularaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutPolarAngularaxisAttr "type" "category"
                static member inline linear = Interop.mkLayoutPolarAngularaxisAttr "type" "linear"

            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutPolarAngularaxisAttr "categoryorder" "trace"

            /// Sets the format unit of the formatted *theta* values. Has an effect only when `angularaxis.type` is *linear*.
            [<Erase>]
            type thetaunit =
                static member inline degrees = Interop.mkLayoutPolarAngularaxisAttr "thetaunit" "degrees"
                static member inline radians = Interop.mkLayoutPolarAngularaxisAttr "thetaunit" "radians"

            /// Sets the direction corresponding to positive angles.
            [<Erase>]
            type direction =
                static member inline clockwise = Interop.mkLayoutPolarAngularaxisAttr "direction" "clockwise"
                static member inline counterclockwise = Interop.mkLayoutPolarAngularaxisAttr "direction" "counterclockwise"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutPolarAngularaxisAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutPolarAngularaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutPolarAngularaxisAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutPolarAngularaxisAttr "ticks" ""
                static member inline inside = Interop.mkLayoutPolarAngularaxisAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutPolarAngularaxisAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutPolarAngularaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutPolarAngularaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutPolarAngularaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutPolarAngularaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutPolarAngularaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutPolarAngularaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutPolarAngularaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutPolarAngularaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutPolarAngularaxisAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutPolarAngularaxisAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutPolarAngularaxisAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutPolarAngularaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutPolarAngularaxisAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutPolarAngularaxisAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutPolarAngularaxisAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutPolarAngularaxisAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutPolarAngularaxisAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutPolarAngularaxisAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutPolarAngularaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutPolarAngularaxisAttr "layer" "below traces"

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickformatstops = 
                static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "tickformatstop" (createObj !!properties)

            [<AutoOpen>]
            module tickformatstops =
                [<Erase>]
                type tickformatstop =
                    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                    static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// string - dtickformat for described zoom level, the same as *tickformat*
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

    [<Erase>]
    type radialaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
        static member inline range (values: seq<int>) = Interop.mkLayoutRadialaxisAttr "range" (values |> Array.ofSeq)
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
        static member inline range (values: seq<float>) = Interop.mkLayoutRadialaxisAttr "range" (values |> Array.ofSeq)
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<int>) = Interop.mkLayoutRadialaxisAttr "domain" (values |> Array.ofSeq)
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<float>) = Interop.mkLayoutRadialaxisAttr "domain" (values |> Array.ofSeq)
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
        static member inline orientation (value: int) = Interop.mkLayoutRadialaxisAttr "orientation" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
        static member inline orientation (value: float) = Interop.mkLayoutRadialaxisAttr "orientation" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this radial axis will be shown on the figure.
        static member inline showline (value: bool) = Interop.mkLayoutRadialaxisAttr "showline" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the radial axis ticks will feature tick labels.
        static member inline showticklabels (value: bool) = Interop.mkLayoutRadialaxisAttr "showticklabels" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticklen (value: int) = Interop.mkLayoutRadialaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticklen (value: float) = Interop.mkLayoutRadialaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this radial axis.
        static member inline tickcolor (value: string) = Interop.mkLayoutRadialaxisAttr "tickcolor" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticksuffix (value: string) = Interop.mkLayoutRadialaxisAttr "ticksuffix" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: int) = Interop.mkLayoutRadialaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: float) = Interop.mkLayoutRadialaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
        static member inline visible (value: bool) = Interop.mkLayoutRadialaxisAttr "visible" value

    [<AutoOpen>]
    module radialaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the radial axis tick labels.
        [<Erase>]
        type tickorientation =
            static member inline horizontal = Interop.mkLayoutRadialaxisAttr "tickorientation" "horizontal"
            static member inline vertical = Interop.mkLayoutRadialaxisAttr "tickorientation" "vertical"

    [<Erase>]
    type angularaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
        static member inline range (values: seq<int>) = Interop.mkLayoutAngularaxisAttr "range" (values |> Array.ofSeq)
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
        static member inline range (values: seq<float>) = Interop.mkLayoutAngularaxisAttr "range" (values |> Array.ofSeq)
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<int>) = Interop.mkLayoutAngularaxisAttr "domain" (values |> Array.ofSeq)
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<float>) = Interop.mkLayoutAngularaxisAttr "domain" (values |> Array.ofSeq)
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this angular axis will be shown on the figure.
        static member inline showline (value: bool) = Interop.mkLayoutAngularaxisAttr "showline" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the angular axis ticks will feature tick labels.
        static member inline showticklabels (value: bool) = Interop.mkLayoutAngularaxisAttr "showticklabels" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticklen (value: int) = Interop.mkLayoutAngularaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticklen (value: float) = Interop.mkLayoutAngularaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this angular axis.
        static member inline tickcolor (value: string) = Interop.mkLayoutAngularaxisAttr "tickcolor" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticksuffix (value: string) = Interop.mkLayoutAngularaxisAttr "ticksuffix" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: int) = Interop.mkLayoutAngularaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: float) = Interop.mkLayoutAngularaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
        static member inline visible (value: bool) = Interop.mkLayoutAngularaxisAttr "visible" value

    [<AutoOpen>]
    module angularaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the angular axis tick labels.
        [<Erase>]
        type tickorientation =
            static member inline horizontal = Interop.mkLayoutAngularaxisAttr "tickorientation" "horizontal"
            static member inline vertical = Interop.mkLayoutAngularaxisAttr "tickorientation" "vertical"

    [<Erase>]
    type legend =
        static member inline font (properties: #ILayoutLegendFontProperty list) = Interop.mkLayoutLegendAttr "font" (createObj !!properties)
        /// Sets the legend background color.
        static member inline bgcolor (value: string) = Interop.mkLayoutLegendAttr "bgcolor" value
        /// Sets the color of the border enclosing the legend.
        static member inline bordercolor (value: string) = Interop.mkLayoutLegendAttr "bordercolor" value
        /// Sets the width (in px) of the border enclosing the legend.
        static member inline borderwidth (value: int) = Interop.mkLayoutLegendAttr "borderwidth" value
        /// Sets the width (in px) of the border enclosing the legend.
        static member inline borderwidth (value: float) = Interop.mkLayoutLegendAttr "borderwidth" value
        /// Sets the amount of vertical space (in px) between legend groups.
        static member inline tracegroupgap (value: int) = Interop.mkLayoutLegendAttr "tracegroupgap" value
        /// Sets the amount of vertical space (in px) between legend groups.
        static member inline tracegroupgap (value: float) = Interop.mkLayoutLegendAttr "tracegroupgap" value
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        static member inline x (value: int) = Interop.mkLayoutLegendAttr "x" value
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        static member inline x (value: float) = Interop.mkLayoutLegendAttr "x" value
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        static member inline y (value: int) = Interop.mkLayoutLegendAttr "y" value
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        static member inline y (value: float) = Interop.mkLayoutLegendAttr "y" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutLegendAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutLegendAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutLegendAttr "uirevision" (values |> Array.ofSeq)
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutLegendAttr "uirevision" (values |> Array.ofSeq)

    [<AutoOpen>]
    module legend =
        /// Sets the orientation of the legend.
        [<Erase>]
        type orientation =
            static member inline h = Interop.mkLayoutLegendAttr "orientation" "h"
            static member inline v = Interop.mkLayoutLegendAttr "orientation" "v"

        /// Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
        [<Erase>]
        type traceorder =
            static member inline normal = Interop.mkLayoutLegendAttr "traceorder" "normal"
            static member inline grouped = Interop.mkLayoutLegendAttr "traceorder" "grouped"
            static member inline groupedAndReversed = Interop.mkLayoutLegendAttr "traceorder" "grouped+reversed"
            static member inline reversed = Interop.mkLayoutLegendAttr "traceorder" "reversed"

        /// Determines if the legend items symbols scale with their corresponding *trace* attributes or remain *constant* independent of the symbol size on the graph.
        [<Erase>]
        type itemsizing =
            static member inline constant = Interop.mkLayoutLegendAttr "itemsizing" "constant"
            static member inline trace = Interop.mkLayoutLegendAttr "itemsizing" "trace"

        /// Determines the behavior on legend item click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item click interactions.
        [<Erase>]
        type itemclick =
            static member inline toggle = Interop.mkLayoutLegendAttr "itemclick" "toggle"
            static member inline toggleothers = Interop.mkLayoutLegendAttr "itemclick" "toggleothers"
            static member inline false' = Interop.mkLayoutLegendAttr "itemclick" "false"

        /// Determines the behavior on legend item double-click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item double-click interactions.
        [<Erase>]
        type itemdoubleclick =
            static member inline toggle = Interop.mkLayoutLegendAttr "itemdoubleclick" "toggle"
            static member inline toggleothers = Interop.mkLayoutLegendAttr "itemdoubleclick" "toggleothers"
            static member inline false' = Interop.mkLayoutLegendAttr "itemdoubleclick" "false"

        /// Sets the legend's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the legend. Value *auto* anchors legends to the right for `x` values greater than or equal to 2/3, anchors legends to the left for `x` values less than or equal to 1/3 and anchors legends with respect to their center otherwise.
        [<Erase>]
        type xanchor =
            static member inline auto = Interop.mkLayoutLegendAttr "xanchor" "auto"
            static member inline center = Interop.mkLayoutLegendAttr "xanchor" "center"
            static member inline left = Interop.mkLayoutLegendAttr "xanchor" "left"
            static member inline right = Interop.mkLayoutLegendAttr "xanchor" "right"

        /// Sets the legend's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the legend. Value *auto* anchors legends at their bottom for `y` values less than or equal to 1/3, anchors legends to at their top for `y` values greater than or equal to 2/3 and anchors legends with respect to their middle otherwise.
        [<Erase>]
        type yanchor =
            static member inline auto = Interop.mkLayoutLegendAttr "yanchor" "auto"
            static member inline bottom = Interop.mkLayoutLegendAttr "yanchor" "bottom"
            static member inline middle = Interop.mkLayoutLegendAttr "yanchor" "middle"
            static member inline top = Interop.mkLayoutLegendAttr "yanchor" "top"

        /// Sets the vertical alignment of the symbols with respect to their associated text.
        [<Erase>]
        type valign =
            static member inline bottom = Interop.mkLayoutLegendAttr "valign" "bottom"
            static member inline middle = Interop.mkLayoutLegendAttr "valign" "middle"
            static member inline top = Interop.mkLayoutLegendAttr "valign" "top"

        [<Erase>]
        type font =
            static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutLegendFontAttr "description" (createObj !!properties)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutLegendFontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutLegendFontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutLegendFontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutLegendFontAttr "color" value

    [<Erase>]
    type annotations = 
        static member inline annotation (properties: #ILayoutAnnotationsAnnotationProperty list) = Interop.mkLayoutAnnotationsAttr "annotation" (createObj !!properties)

    [<AutoOpen>]
    module annotations =
        [<Erase>]
        type annotation =
            static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAnnotationsAnnotationAttr "font" (createObj !!properties)
            static member inline hoverlabel (properties: #ILayoutProperty list) = Interop.mkLayoutAnnotationsAnnotationAttr "hoverlabel" (createObj !!properties)
            /// Determines whether or not this annotation is visible.
            static member inline visible (value: bool) = Interop.mkLayoutAnnotationsAnnotationAttr "visible" value
            /// Sets the text associated with this annotation. Plotly uses a subset of HTML tags to do things like newline (<br>), bold (<b></b>), italics (<i></i>), hyperlinks (<a href='...'></a>). Tags <em>, <sup>, <sub> <span> are also supported.
            static member inline text (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "text" value
            /// Sets the angle at which the `text` is drawn with respect to the horizontal.
            static member inline textangle (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "textangle" value
            /// Sets the angle at which the `text` is drawn with respect to the horizontal.
            static member inline textangle (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "textangle" value
            /// Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line.
            static member inline width (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "width" value
            /// Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line.
            static member inline width (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "width" value
            /// Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped.
            static member inline height (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "height" value
            /// Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped.
            static member inline height (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "height" value
            /// Sets the opacity of the annotation (text + arrow).
            static member inline opacity (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "opacity" value
            /// Sets the opacity of the annotation (text + arrow).
            static member inline opacity (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "opacity" value
            /// Sets the background color of the annotation.
            static member inline bgcolor (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "bgcolor" value
            /// Sets the color of the border enclosing the annotation `text`.
            static member inline bordercolor (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "bordercolor" value
            /// Sets the padding (in px) between the `text` and the enclosing border.
            static member inline borderpad (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "borderpad" value
            /// Sets the padding (in px) between the `text` and the enclosing border.
            static member inline borderpad (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "borderpad" value
            /// Sets the width (in px) of the border enclosing the annotation `text`.
            static member inline borderwidth (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "borderwidth" value
            /// Sets the width (in px) of the border enclosing the annotation `text`.
            static member inline borderwidth (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "borderwidth" value
            /// Determines whether or not the annotation is drawn with an arrow. If *true*, `text` is placed near the arrow's tail. If *false*, `text` lines up with the `x` and `y` provided.
            static member inline showarrow (value: bool) = Interop.mkLayoutAnnotationsAnnotationAttr "showarrow" value
            /// Sets the color of the annotation arrow.
            static member inline arrowcolor (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "arrowcolor" value
            /// Sets the end annotation arrow head style.
            static member inline arrowhead (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "arrowhead" value
            /// Sets the start annotation arrow head style.
            static member inline startarrowhead (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "startarrowhead" value
            /// Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
            static member inline arrowsize (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "arrowsize" value
            /// Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
            static member inline arrowsize (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "arrowsize" value
            /// Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
            static member inline startarrowsize (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "startarrowsize" value
            /// Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
            static member inline startarrowsize (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "startarrowsize" value
            /// Sets the width (in px) of annotation arrow line.
            static member inline arrowwidth (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "arrowwidth" value
            /// Sets the width (in px) of annotation arrow line.
            static member inline arrowwidth (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "arrowwidth" value
            /// Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
            static member inline standoff (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "standoff" value
            /// Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
            static member inline standoff (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "standoff" value
            /// Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
            static member inline startstandoff (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "startstandoff" value
            /// Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
            static member inline startstandoff (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "startstandoff" value
            /// Sets the x component of the arrow tail about the arrow head. If `axref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from right to left (left to right). If `axref` is an axis, this is an absolute value on that axis, like `x`, NOT a relative value.
            static member inline ax (value: bool) = Interop.mkLayoutAnnotationsAnnotationAttr "ax" value
            /// Sets the x component of the arrow tail about the arrow head. If `axref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from right to left (left to right). If `axref` is an axis, this is an absolute value on that axis, like `x`, NOT a relative value.
            static member inline ax (values: seq<bool>) = Interop.mkLayoutAnnotationsAnnotationAttr "ax" (values |> Array.ofSeq)
            /// Sets the x component of the arrow tail about the arrow head. If `axref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from right to left (left to right). If `axref` is an axis, this is an absolute value on that axis, like `x`, NOT a relative value.
            static member inline ax (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "ax" value
            /// Sets the x component of the arrow tail about the arrow head. If `axref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from right to left (left to right). If `axref` is an axis, this is an absolute value on that axis, like `x`, NOT a relative value.
            static member inline ax (values: seq<string>) = Interop.mkLayoutAnnotationsAnnotationAttr "ax" (values |> Array.ofSeq)
            /// Sets the x component of the arrow tail about the arrow head. If `axref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from right to left (left to right). If `axref` is an axis, this is an absolute value on that axis, like `x`, NOT a relative value.
            static member inline ax (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "ax" value
            /// Sets the x component of the arrow tail about the arrow head. If `axref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from right to left (left to right). If `axref` is an axis, this is an absolute value on that axis, like `x`, NOT a relative value.
            static member inline ax (values: seq<int>) = Interop.mkLayoutAnnotationsAnnotationAttr "ax" (values |> Array.ofSeq)
            /// Sets the x component of the arrow tail about the arrow head. If `axref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from right to left (left to right). If `axref` is an axis, this is an absolute value on that axis, like `x`, NOT a relative value.
            static member inline ax (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "ax" value
            /// Sets the x component of the arrow tail about the arrow head. If `axref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from right to left (left to right). If `axref` is an axis, this is an absolute value on that axis, like `x`, NOT a relative value.
            static member inline ax (values: seq<float>) = Interop.mkLayoutAnnotationsAnnotationAttr "ax" (values |> Array.ofSeq)
            /// Sets the y component of the arrow tail about the arrow head. If `ayref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from bottom to top (top to bottom). If `ayref` is an axis, this is an absolute value on that axis, like `y`, NOT a relative value.
            static member inline ay (value: bool) = Interop.mkLayoutAnnotationsAnnotationAttr "ay" value
            /// Sets the y component of the arrow tail about the arrow head. If `ayref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from bottom to top (top to bottom). If `ayref` is an axis, this is an absolute value on that axis, like `y`, NOT a relative value.
            static member inline ay (values: seq<bool>) = Interop.mkLayoutAnnotationsAnnotationAttr "ay" (values |> Array.ofSeq)
            /// Sets the y component of the arrow tail about the arrow head. If `ayref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from bottom to top (top to bottom). If `ayref` is an axis, this is an absolute value on that axis, like `y`, NOT a relative value.
            static member inline ay (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "ay" value
            /// Sets the y component of the arrow tail about the arrow head. If `ayref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from bottom to top (top to bottom). If `ayref` is an axis, this is an absolute value on that axis, like `y`, NOT a relative value.
            static member inline ay (values: seq<string>) = Interop.mkLayoutAnnotationsAnnotationAttr "ay" (values |> Array.ofSeq)
            /// Sets the y component of the arrow tail about the arrow head. If `ayref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from bottom to top (top to bottom). If `ayref` is an axis, this is an absolute value on that axis, like `y`, NOT a relative value.
            static member inline ay (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "ay" value
            /// Sets the y component of the arrow tail about the arrow head. If `ayref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from bottom to top (top to bottom). If `ayref` is an axis, this is an absolute value on that axis, like `y`, NOT a relative value.
            static member inline ay (values: seq<int>) = Interop.mkLayoutAnnotationsAnnotationAttr "ay" (values |> Array.ofSeq)
            /// Sets the y component of the arrow tail about the arrow head. If `ayref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from bottom to top (top to bottom). If `ayref` is an axis, this is an absolute value on that axis, like `y`, NOT a relative value.
            static member inline ay (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "ay" value
            /// Sets the y component of the arrow tail about the arrow head. If `ayref` is `pixel`, a positive (negative)  component corresponds to an arrow pointing from bottom to top (top to bottom). If `ayref` is an axis, this is an absolute value on that axis, like `y`, NOT a relative value.
            static member inline ay (values: seq<float>) = Interop.mkLayoutAnnotationsAnnotationAttr "ay" (values |> Array.ofSeq)
            /// Sets the annotation's x position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline x (value: bool) = Interop.mkLayoutAnnotationsAnnotationAttr "x" value
            /// Sets the annotation's x position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline x (values: seq<bool>) = Interop.mkLayoutAnnotationsAnnotationAttr "x" (values |> Array.ofSeq)
            /// Sets the annotation's x position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline x (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "x" value
            /// Sets the annotation's x position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline x (values: seq<string>) = Interop.mkLayoutAnnotationsAnnotationAttr "x" (values |> Array.ofSeq)
            /// Sets the annotation's x position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline x (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "x" value
            /// Sets the annotation's x position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline x (values: seq<int>) = Interop.mkLayoutAnnotationsAnnotationAttr "x" (values |> Array.ofSeq)
            /// Sets the annotation's x position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline x (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "x" value
            /// Sets the annotation's x position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline x (values: seq<float>) = Interop.mkLayoutAnnotationsAnnotationAttr "x" (values |> Array.ofSeq)
            /// Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels.
            static member inline xshift (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "xshift" value
            /// Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels.
            static member inline xshift (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "xshift" value
            /// Sets the annotation's y position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline y (value: bool) = Interop.mkLayoutAnnotationsAnnotationAttr "y" value
            /// Sets the annotation's y position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline y (values: seq<bool>) = Interop.mkLayoutAnnotationsAnnotationAttr "y" (values |> Array.ofSeq)
            /// Sets the annotation's y position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline y (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "y" value
            /// Sets the annotation's y position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline y (values: seq<string>) = Interop.mkLayoutAnnotationsAnnotationAttr "y" (values |> Array.ofSeq)
            /// Sets the annotation's y position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline y (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "y" value
            /// Sets the annotation's y position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline y (values: seq<int>) = Interop.mkLayoutAnnotationsAnnotationAttr "y" (values |> Array.ofSeq)
            /// Sets the annotation's y position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline y (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "y" value
            /// Sets the annotation's y position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline y (values: seq<float>) = Interop.mkLayoutAnnotationsAnnotationAttr "y" (values |> Array.ofSeq)
            /// Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels.
            static member inline yshift (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "yshift" value
            /// Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels.
            static member inline yshift (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "yshift" value
            /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
            static member inline xclick (value: bool) = Interop.mkLayoutAnnotationsAnnotationAttr "xclick" value
            /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
            static member inline xclick (values: seq<bool>) = Interop.mkLayoutAnnotationsAnnotationAttr "xclick" (values |> Array.ofSeq)
            /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
            static member inline xclick (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "xclick" value
            /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
            static member inline xclick (values: seq<string>) = Interop.mkLayoutAnnotationsAnnotationAttr "xclick" (values |> Array.ofSeq)
            /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
            static member inline xclick (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "xclick" value
            /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
            static member inline xclick (values: seq<int>) = Interop.mkLayoutAnnotationsAnnotationAttr "xclick" (values |> Array.ofSeq)
            /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
            static member inline xclick (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "xclick" value
            /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
            static member inline xclick (values: seq<float>) = Interop.mkLayoutAnnotationsAnnotationAttr "xclick" (values |> Array.ofSeq)
            /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
            static member inline yclick (value: bool) = Interop.mkLayoutAnnotationsAnnotationAttr "yclick" value
            /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
            static member inline yclick (values: seq<bool>) = Interop.mkLayoutAnnotationsAnnotationAttr "yclick" (values |> Array.ofSeq)
            /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
            static member inline yclick (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "yclick" value
            /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
            static member inline yclick (values: seq<string>) = Interop.mkLayoutAnnotationsAnnotationAttr "yclick" (values |> Array.ofSeq)
            /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
            static member inline yclick (value: int) = Interop.mkLayoutAnnotationsAnnotationAttr "yclick" value
            /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
            static member inline yclick (values: seq<int>) = Interop.mkLayoutAnnotationsAnnotationAttr "yclick" (values |> Array.ofSeq)
            /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
            static member inline yclick (value: float) = Interop.mkLayoutAnnotationsAnnotationAttr "yclick" value
            /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
            static member inline yclick (values: seq<float>) = Interop.mkLayoutAnnotationsAnnotationAttr "yclick" (values |> Array.ofSeq)
            /// Sets text to appear when hovering over this annotation. If omitted or blank, no hover label will appear.
            static member inline hovertext (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "hovertext" value
            /// Determines whether the annotation text box captures mouse move and click events, or allows those events to pass through to data points in the plot that may be behind the annotation. By default `captureevents` is *false* unless `hovertext` is provided. If you use the event `plotly_clickannotation` without `hovertext` you must explicitly enable `captureevents`.
            static member inline captureevents (value: bool) = Interop.mkLayoutAnnotationsAnnotationAttr "captureevents" value
            /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
            static member inline name (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "name" value
            /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
            static member inline templateitemname (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "templateitemname" value

        [<AutoOpen>]
        module annotation =
            /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans more two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
            [<Erase>]
            type align =
                static member inline center = Interop.mkLayoutAnnotationsAnnotationAttr "align" "center"
                static member inline left = Interop.mkLayoutAnnotationsAnnotationAttr "align" "left"
                static member inline right = Interop.mkLayoutAnnotationsAnnotationAttr "align" "right"

            /// Sets the vertical alignment of the `text` within the box. Has an effect only if an explicit height is set to override the text height.
            [<Erase>]
            type valign =
                static member inline bottom = Interop.mkLayoutAnnotationsAnnotationAttr "valign" "bottom"
                static member inline middle = Interop.mkLayoutAnnotationsAnnotationAttr "valign" "middle"
                static member inline top = Interop.mkLayoutAnnotationsAnnotationAttr "valign" "top"

            /// Sets the annotation arrow head position.
            [<Erase>]
            type arrowside =
                static member inline none = Interop.mkLayoutAnnotationsAnnotationAttr "arrowside" "none"
                static member inline end' = Interop.mkLayoutAnnotationsAnnotationAttr "arrowside" "end"
                static member inline start = Interop.mkLayoutAnnotationsAnnotationAttr "arrowside" "start"
                static member inline startAndEnd = Interop.mkLayoutAnnotationsAnnotationAttr "arrowside" "start+end"

            /// Indicates in what terms the tail of the annotation (ax,ay)  is specified. If `pixel`, `ax` is a relative offset in pixels  from `x`. If set to an x axis id (e.g. *x* or *x2*), `ax` is  specified in the same terms as that axis. This is useful  for trendline annotations which should continue to indicate  the correct trend when zoomed.
            [<Erase>]
            type axref =
                static member inline pixel = Interop.mkLayoutAnnotationsAnnotationAttr "axref" "pixel"
                static member inline custom (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "axref" value

            /// Indicates in what terms the tail of the annotation (ax,ay)  is specified. If `pixel`, `ay` is a relative offset in pixels  from `y`. If set to a y axis id (e.g. *y* or *y2*), `ay` is  specified in the same terms as that axis. This is useful  for trendline annotations which should continue to indicate  the correct trend when zoomed.
            [<Erase>]
            type ayref =
                static member inline pixel = Interop.mkLayoutAnnotationsAnnotationAttr "ayref" "pixel"
                static member inline custom (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "ayref" value

            /// Sets the annotation's x coordinate axis. If set to an x axis id (e.g. *x* or *x2*), the `x` position refers to an x coordinate If set to *paper*, the `x` position refers to the distance from the left side of the plotting area in normalized coordinates where 0 (1) corresponds to the left (right) side.
            [<Erase>]
            type xref =
                static member inline paper = Interop.mkLayoutAnnotationsAnnotationAttr "xref" "paper"
                static member inline custom (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "xref" value

            /// Sets the text box's horizontal position anchor This anchor binds the `x` position to the *left*, *center* or *right* of the annotation. For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the right-most portion of the annotation lines up with the right-most edge of the plotting area. If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
            [<Erase>]
            type xanchor =
                static member inline auto = Interop.mkLayoutAnnotationsAnnotationAttr "xanchor" "auto"
                static member inline center = Interop.mkLayoutAnnotationsAnnotationAttr "xanchor" "center"
                static member inline left = Interop.mkLayoutAnnotationsAnnotationAttr "xanchor" "left"
                static member inline right = Interop.mkLayoutAnnotationsAnnotationAttr "xanchor" "right"

            /// Sets the annotation's y coordinate axis. If set to an y axis id (e.g. *y* or *y2*), the `y` position refers to an y coordinate If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where 0 (1) corresponds to the bottom (top).
            [<Erase>]
            type yref =
                static member inline paper = Interop.mkLayoutAnnotationsAnnotationAttr "yref" "paper"
                static member inline custom (value: string) = Interop.mkLayoutAnnotationsAnnotationAttr "yref" value

            /// Sets the text box's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation. For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the top-most portion of the annotation lines up with the top-most edge of the plotting area. If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
            [<Erase>]
            type yanchor =
                static member inline auto = Interop.mkLayoutAnnotationsAnnotationAttr "yanchor" "auto"
                static member inline bottom = Interop.mkLayoutAnnotationsAnnotationAttr "yanchor" "bottom"
                static member inline middle = Interop.mkLayoutAnnotationsAnnotationAttr "yanchor" "middle"
                static member inline top = Interop.mkLayoutAnnotationsAnnotationAttr "yanchor" "top"

            /// Makes this annotation respond to clicks on the plot. If you click a data point that exactly matches the `x` and `y` values of this annotation, and it is hidden (visible: false), it will appear. In *onoff* mode, you must click the same point again to make it disappear, so if you click multiple points, you can show multiple annotations. In *onout* mode, a click anywhere else in the plot (on another data point or not) will hide this annotation. If you need to show/hide this annotation in response to different `x` or `y` values, you can set `xclick` and/or `yclick`. This is useful for example to label the side of a bar. To label markers though, `standoff` is preferred over `xclick` and `yclick`.
            [<Erase>]
            type clicktoshow =
                static member inline onoff = Interop.mkLayoutAnnotationsAnnotationAttr "clicktoshow" "onoff"
                static member inline onout = Interop.mkLayoutAnnotationsAnnotationAttr "clicktoshow" "onout"
                static member inline false' = Interop.mkLayoutAnnotationsAnnotationAttr "clicktoshow" "false"

            [<Erase>]
            type font =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type hoverlabel =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Sets the background color of the hover label. By default uses the annotation's `bgcolor` made opaque, or white if it was transparent.
                static member inline bgcolor (value: string) = Interop.mkLayoutAttr "bgcolor" value
                /// Sets the border color of the hover label. By default uses either dark grey or white, for maximum contrast with `hoverlabel.bgcolor`.
                static member inline bordercolor (value: string) = Interop.mkLayoutAttr "bordercolor" value

            [<AutoOpen>]
            module hoverlabel =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

    [<Erase>]
    type shapes = 
        static member inline shape (properties: #ILayoutShapesShapeProperty list) = Interop.mkLayoutShapesAttr "shape" (createObj !!properties)

    [<AutoOpen>]
    module shapes =
        [<Erase>]
        type shape =
            static member inline line (properties: #ILayoutProperty list) = Interop.mkLayoutShapesShapeAttr "line" (createObj !!properties)
            /// Determines whether or not this shape is visible.
            static member inline visible (value: bool) = Interop.mkLayoutShapesShapeAttr "visible" value
            /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
            static member inline xanchor (value: bool) = Interop.mkLayoutShapesShapeAttr "xanchor" value
            /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
            static member inline xanchor (values: seq<bool>) = Interop.mkLayoutShapesShapeAttr "xanchor" (values |> Array.ofSeq)
            /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
            static member inline xanchor (value: string) = Interop.mkLayoutShapesShapeAttr "xanchor" value
            /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
            static member inline xanchor (values: seq<string>) = Interop.mkLayoutShapesShapeAttr "xanchor" (values |> Array.ofSeq)
            /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
            static member inline xanchor (value: int) = Interop.mkLayoutShapesShapeAttr "xanchor" value
            /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
            static member inline xanchor (values: seq<int>) = Interop.mkLayoutShapesShapeAttr "xanchor" (values |> Array.ofSeq)
            /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
            static member inline xanchor (value: float) = Interop.mkLayoutShapesShapeAttr "xanchor" value
            /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
            static member inline xanchor (values: seq<float>) = Interop.mkLayoutShapesShapeAttr "xanchor" (values |> Array.ofSeq)
            /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
            static member inline x0 (value: bool) = Interop.mkLayoutShapesShapeAttr "x0" value
            /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
            static member inline x0 (values: seq<bool>) = Interop.mkLayoutShapesShapeAttr "x0" (values |> Array.ofSeq)
            /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
            static member inline x0 (value: string) = Interop.mkLayoutShapesShapeAttr "x0" value
            /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
            static member inline x0 (values: seq<string>) = Interop.mkLayoutShapesShapeAttr "x0" (values |> Array.ofSeq)
            /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
            static member inline x0 (value: int) = Interop.mkLayoutShapesShapeAttr "x0" value
            /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
            static member inline x0 (values: seq<int>) = Interop.mkLayoutShapesShapeAttr "x0" (values |> Array.ofSeq)
            /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
            static member inline x0 (value: float) = Interop.mkLayoutShapesShapeAttr "x0" value
            /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
            static member inline x0 (values: seq<float>) = Interop.mkLayoutShapesShapeAttr "x0" (values |> Array.ofSeq)
            /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
            static member inline x1 (value: bool) = Interop.mkLayoutShapesShapeAttr "x1" value
            /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
            static member inline x1 (values: seq<bool>) = Interop.mkLayoutShapesShapeAttr "x1" (values |> Array.ofSeq)
            /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
            static member inline x1 (value: string) = Interop.mkLayoutShapesShapeAttr "x1" value
            /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
            static member inline x1 (values: seq<string>) = Interop.mkLayoutShapesShapeAttr "x1" (values |> Array.ofSeq)
            /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
            static member inline x1 (value: int) = Interop.mkLayoutShapesShapeAttr "x1" value
            /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
            static member inline x1 (values: seq<int>) = Interop.mkLayoutShapesShapeAttr "x1" (values |> Array.ofSeq)
            /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
            static member inline x1 (value: float) = Interop.mkLayoutShapesShapeAttr "x1" value
            /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
            static member inline x1 (values: seq<float>) = Interop.mkLayoutShapesShapeAttr "x1" (values |> Array.ofSeq)
            /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
            static member inline yanchor (value: bool) = Interop.mkLayoutShapesShapeAttr "yanchor" value
            /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
            static member inline yanchor (values: seq<bool>) = Interop.mkLayoutShapesShapeAttr "yanchor" (values |> Array.ofSeq)
            /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
            static member inline yanchor (value: string) = Interop.mkLayoutShapesShapeAttr "yanchor" value
            /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
            static member inline yanchor (values: seq<string>) = Interop.mkLayoutShapesShapeAttr "yanchor" (values |> Array.ofSeq)
            /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
            static member inline yanchor (value: int) = Interop.mkLayoutShapesShapeAttr "yanchor" value
            /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
            static member inline yanchor (values: seq<int>) = Interop.mkLayoutShapesShapeAttr "yanchor" (values |> Array.ofSeq)
            /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
            static member inline yanchor (value: float) = Interop.mkLayoutShapesShapeAttr "yanchor" value
            /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
            static member inline yanchor (values: seq<float>) = Interop.mkLayoutShapesShapeAttr "yanchor" (values |> Array.ofSeq)
            /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
            static member inline y0 (value: bool) = Interop.mkLayoutShapesShapeAttr "y0" value
            /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
            static member inline y0 (values: seq<bool>) = Interop.mkLayoutShapesShapeAttr "y0" (values |> Array.ofSeq)
            /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
            static member inline y0 (value: string) = Interop.mkLayoutShapesShapeAttr "y0" value
            /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
            static member inline y0 (values: seq<string>) = Interop.mkLayoutShapesShapeAttr "y0" (values |> Array.ofSeq)
            /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
            static member inline y0 (value: int) = Interop.mkLayoutShapesShapeAttr "y0" value
            /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
            static member inline y0 (values: seq<int>) = Interop.mkLayoutShapesShapeAttr "y0" (values |> Array.ofSeq)
            /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
            static member inline y0 (value: float) = Interop.mkLayoutShapesShapeAttr "y0" value
            /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
            static member inline y0 (values: seq<float>) = Interop.mkLayoutShapesShapeAttr "y0" (values |> Array.ofSeq)
            /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
            static member inline y1 (value: bool) = Interop.mkLayoutShapesShapeAttr "y1" value
            /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
            static member inline y1 (values: seq<bool>) = Interop.mkLayoutShapesShapeAttr "y1" (values |> Array.ofSeq)
            /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
            static member inline y1 (value: string) = Interop.mkLayoutShapesShapeAttr "y1" value
            /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
            static member inline y1 (values: seq<string>) = Interop.mkLayoutShapesShapeAttr "y1" (values |> Array.ofSeq)
            /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
            static member inline y1 (value: int) = Interop.mkLayoutShapesShapeAttr "y1" value
            /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
            static member inline y1 (values: seq<int>) = Interop.mkLayoutShapesShapeAttr "y1" (values |> Array.ofSeq)
            /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
            static member inline y1 (value: float) = Interop.mkLayoutShapesShapeAttr "y1" value
            /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
            static member inline y1 (values: seq<float>) = Interop.mkLayoutShapesShapeAttr "y1" (values |> Array.ofSeq)
            /// For `type` *path* - a valid SVG path with the pixel values replaced by data values in `xsizemode`/`ysizemode` being *scaled* and taken unmodified as pixels relative to `xanchor` and `yanchor` in case of *pixel* size mode. There are a few restrictions / quirks only absolute instructions, not relative. So the allowed segments are: M, L, H, V, Q, C, T, S, and Z arcs (A) are not allowed because radius rx and ry are relative. In the future we could consider supporting relative commands, but we would have to decide on how to handle date and log axes. Note that even as is, Q and C Bezier paths that are smooth on linear axes may not be smooth on log, and vice versa. no chained \"polybezier\" commands - specify the segment type for each one. On category axes, values are numbers scaled to the serial numbers of categories because using the categories themselves there would be no way to describe fractional positions On data axes: because space and T are both normal components of path strings, we can't use either to separate date from time parts. Therefore we'll use underscore for this purpose: 2015-02-21_13:45:56.789
            static member inline path (value: string) = Interop.mkLayoutShapesShapeAttr "path" value
            /// Sets the opacity of the shape.
            static member inline opacity (value: int) = Interop.mkLayoutShapesShapeAttr "opacity" value
            /// Sets the opacity of the shape.
            static member inline opacity (value: float) = Interop.mkLayoutShapesShapeAttr "opacity" value
            /// Sets the color filling the shape's interior.
            static member inline fillcolor (value: string) = Interop.mkLayoutShapesShapeAttr "fillcolor" value
            /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
            static member inline name (value: string) = Interop.mkLayoutShapesShapeAttr "name" value
            /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
            static member inline templateitemname (value: string) = Interop.mkLayoutShapesShapeAttr "templateitemname" value

        [<AutoOpen>]
        module shape =
            /// Specifies the shape type to be drawn. If *line*, a line is drawn from (`x0`,`y0`) to (`x1`,`y1`) with respect to the axes' sizing mode. If *circle*, a circle is drawn from ((`x0`+`x1`)/2, (`y0`+`y1`)/2)) with radius (|(`x0`+`x1`)/2 - `x0`|, |(`y0`+`y1`)/2 -`y0`)|) with respect to the axes' sizing mode. If *rect*, a rectangle is drawn linking (`x0`,`y0`), (`x1`,`y0`), (`x1`,`y1`), (`x0`,`y1`), (`x0`,`y0`) with respect to the axes' sizing mode. If *path*, draw a custom SVG path using `path`. with respect to the axes' sizing mode.
            [<Erase>]
            type type' =
                static member inline circle = Interop.mkLayoutShapesShapeAttr "type" "circle"
                static member inline line = Interop.mkLayoutShapesShapeAttr "type" "line"
                static member inline path = Interop.mkLayoutShapesShapeAttr "type" "path"
                static member inline rect = Interop.mkLayoutShapesShapeAttr "type" "rect"

            /// Specifies whether shapes are drawn below or above traces.
            [<Erase>]
            type layer =
                static member inline above = Interop.mkLayoutShapesShapeAttr "layer" "above"
                static member inline below = Interop.mkLayoutShapesShapeAttr "layer" "below"

            /// Sets the shape's x coordinate axis. If set to an x axis id (e.g. *x* or *x2*), the `x` position refers to an x coordinate. If set to *paper*, the `x` position refers to the distance from the left side of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right) side. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, then you must convert the date to unix time in milliseconds.
            [<Erase>]
            type xref =
                static member inline paper = Interop.mkLayoutShapesShapeAttr "xref" "paper"
                static member inline custom (value: string) = Interop.mkLayoutShapesShapeAttr "xref" value

            /// Sets the shapes's sizing mode along the x axis. If set to *scaled*, `x0`, `x1` and x coordinates within `path` refer to data values on the x axis or a fraction of the plot area's width (`xref` set to *paper*). If set to *pixel*, `xanchor` specifies the x position in terms of data or plot fraction but `x0`, `x1` and x coordinates within `path` are pixels relative to `xanchor`. This way, the shape can have a fixed width while maintaining a position relative to data or plot fraction.
            [<Erase>]
            type xsizemode =
                static member inline pixel = Interop.mkLayoutShapesShapeAttr "xsizemode" "pixel"
                static member inline scaled = Interop.mkLayoutShapesShapeAttr "xsizemode" "scaled"

            /// Sets the annotation's y coordinate axis. If set to an y axis id (e.g. *y* or *y2*), the `y` position refers to an y coordinate If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top).
            [<Erase>]
            type yref =
                static member inline paper = Interop.mkLayoutShapesShapeAttr "yref" "paper"
                static member inline custom (value: string) = Interop.mkLayoutShapesShapeAttr "yref" value

            /// Sets the shapes's sizing mode along the y axis. If set to *scaled*, `y0`, `y1` and y coordinates within `path` refer to data values on the y axis or a fraction of the plot area's height (`yref` set to *paper*). If set to *pixel*, `yanchor` specifies the y position in terms of data or plot fraction but `y0`, `y1` and y coordinates within `path` are pixels relative to `yanchor`. This way, the shape can have a fixed height while maintaining a position relative to data or plot fraction.
            [<Erase>]
            type ysizemode =
                static member inline pixel = Interop.mkLayoutShapesShapeAttr "ysizemode" "pixel"
                static member inline scaled = Interop.mkLayoutShapesShapeAttr "ysizemode" "scaled"

            [<Erase>]
            type line =
                /// Sets the line color.
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value
                /// Sets the line width (in px).
                static member inline width (value: int) = Interop.mkLayoutAttr "width" value
                /// Sets the line width (in px).
                static member inline width (value: float) = Interop.mkLayoutAttr "width" value
                /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
                static member inline dash (value: string) = Interop.mkLayoutAttr "dash" value

    [<Erase>]
    type images = 
        static member inline image (properties: #ILayoutImagesImageProperty list) = Interop.mkLayoutImagesAttr "image" (createObj !!properties)

    [<AutoOpen>]
    module images =
        [<Erase>]
        type image =
            /// Determines whether or not this image is visible.
            static member inline visible (value: bool) = Interop.mkLayoutImagesImageAttr "visible" value
            /// Specifies the URL of the image to be used. The URL must be accessible from the domain where the plot code is run, and can be either relative or absolute.
            static member inline source (value: string) = Interop.mkLayoutImagesImageAttr "source" value
            /// Sets the image container size horizontally. The image will be sized based on the `position` value. When `xref` is set to `paper`, units are sized relative to the plot width.
            static member inline sizex (value: int) = Interop.mkLayoutImagesImageAttr "sizex" value
            /// Sets the image container size horizontally. The image will be sized based on the `position` value. When `xref` is set to `paper`, units are sized relative to the plot width.
            static member inline sizex (value: float) = Interop.mkLayoutImagesImageAttr "sizex" value
            /// Sets the image container size vertically. The image will be sized based on the `position` value. When `yref` is set to `paper`, units are sized relative to the plot height.
            static member inline sizey (value: int) = Interop.mkLayoutImagesImageAttr "sizey" value
            /// Sets the image container size vertically. The image will be sized based on the `position` value. When `yref` is set to `paper`, units are sized relative to the plot height.
            static member inline sizey (value: float) = Interop.mkLayoutImagesImageAttr "sizey" value
            /// Sets the opacity of the image.
            static member inline opacity (value: int) = Interop.mkLayoutImagesImageAttr "opacity" value
            /// Sets the opacity of the image.
            static member inline opacity (value: float) = Interop.mkLayoutImagesImageAttr "opacity" value
            /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
            static member inline x (value: bool) = Interop.mkLayoutImagesImageAttr "x" value
            /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
            static member inline x (values: seq<bool>) = Interop.mkLayoutImagesImageAttr "x" (values |> Array.ofSeq)
            /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
            static member inline x (value: string) = Interop.mkLayoutImagesImageAttr "x" value
            /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
            static member inline x (values: seq<string>) = Interop.mkLayoutImagesImageAttr "x" (values |> Array.ofSeq)
            /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
            static member inline x (value: int) = Interop.mkLayoutImagesImageAttr "x" value
            /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
            static member inline x (values: seq<int>) = Interop.mkLayoutImagesImageAttr "x" (values |> Array.ofSeq)
            /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
            static member inline x (value: float) = Interop.mkLayoutImagesImageAttr "x" value
            /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
            static member inline x (values: seq<float>) = Interop.mkLayoutImagesImageAttr "x" (values |> Array.ofSeq)
            /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
            static member inline y (value: bool) = Interop.mkLayoutImagesImageAttr "y" value
            /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
            static member inline y (values: seq<bool>) = Interop.mkLayoutImagesImageAttr "y" (values |> Array.ofSeq)
            /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
            static member inline y (value: string) = Interop.mkLayoutImagesImageAttr "y" value
            /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
            static member inline y (values: seq<string>) = Interop.mkLayoutImagesImageAttr "y" (values |> Array.ofSeq)
            /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
            static member inline y (value: int) = Interop.mkLayoutImagesImageAttr "y" value
            /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
            static member inline y (values: seq<int>) = Interop.mkLayoutImagesImageAttr "y" (values |> Array.ofSeq)
            /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
            static member inline y (value: float) = Interop.mkLayoutImagesImageAttr "y" value
            /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
            static member inline y (values: seq<float>) = Interop.mkLayoutImagesImageAttr "y" (values |> Array.ofSeq)
            /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
            static member inline name (value: string) = Interop.mkLayoutImagesImageAttr "name" value
            /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
            static member inline templateitemname (value: string) = Interop.mkLayoutImagesImageAttr "templateitemname" value

        [<AutoOpen>]
        module image =
            /// Specifies whether images are drawn below or above traces. When `xref` and `yref` are both set to `paper`, image is drawn below the entire plot area.
            [<Erase>]
            type layer =
                static member inline above = Interop.mkLayoutImagesImageAttr "layer" "above"
                static member inline below = Interop.mkLayoutImagesImageAttr "layer" "below"

            /// Specifies which dimension of the image to constrain.
            [<Erase>]
            type sizing =
                static member inline contain = Interop.mkLayoutImagesImageAttr "sizing" "contain"
                static member inline fill = Interop.mkLayoutImagesImageAttr "sizing" "fill"
                static member inline stretch = Interop.mkLayoutImagesImageAttr "sizing" "stretch"

            /// Sets the anchor for the x position
            [<Erase>]
            type xanchor =
                static member inline center = Interop.mkLayoutImagesImageAttr "xanchor" "center"
                static member inline left = Interop.mkLayoutImagesImageAttr "xanchor" "left"
                static member inline right = Interop.mkLayoutImagesImageAttr "xanchor" "right"

            /// Sets the anchor for the y position.
            [<Erase>]
            type yanchor =
                static member inline bottom = Interop.mkLayoutImagesImageAttr "yanchor" "bottom"
                static member inline middle = Interop.mkLayoutImagesImageAttr "yanchor" "middle"
                static member inline top = Interop.mkLayoutImagesImageAttr "yanchor" "top"

            /// Sets the images's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to an x data coordinate If set to *paper*, the `x` position refers to the distance from the left of plot in normalized coordinates where *0* (*1*) corresponds to the left (right).
            [<Erase>]
            type xref =
                static member inline paper = Interop.mkLayoutImagesImageAttr "xref" "paper"
                static member inline custom (value: string) = Interop.mkLayoutImagesImageAttr "xref" value

            /// Sets the images's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y data coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plot in normalized coordinates where *0* (*1*) corresponds to the bottom (top).
            [<Erase>]
            type yref =
                static member inline paper = Interop.mkLayoutImagesImageAttr "yref" "paper"
                static member inline custom (value: string) = Interop.mkLayoutImagesImageAttr "yref" value

    [<Erase>]
    type updatemenus = 
        static member inline updatemenu (properties: #ILayoutUpdatemenusUpdatemenuProperty list) = Interop.mkLayoutUpdatemenusAttr "updatemenu" (createObj !!properties)

    [<AutoOpen>]
    module updatemenus =
        [<Erase>]
        type updatemenu =
            static member inline _arrayAttrRegexps (properties: #ILayoutProperty list) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "_arrayAttrRegexps" (createObj !!properties)
            static member inline buttons (properties: #ILayoutProperty list) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "buttons" (createObj !!properties)
            static member inline pad (properties: #ILayoutProperty list) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "pad" (createObj !!properties)
            static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "font" (createObj !!properties)
            /// Determines whether or not the update menu is visible.
            static member inline visible (value: bool) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "visible" value
            /// Determines which button (by index starting from 0) is considered active.
            static member inline active (value: int) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "active" value
            /// Highlights active dropdown item or active button if true.
            static member inline showactive (value: bool) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "showactive" value
            /// Sets the x position (in normalized coordinates) of the update menu.
            static member inline x (value: int) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "x" value
            /// Sets the x position (in normalized coordinates) of the update menu.
            static member inline x (value: float) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "x" value
            /// Sets the y position (in normalized coordinates) of the update menu.
            static member inline y (value: int) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "y" value
            /// Sets the y position (in normalized coordinates) of the update menu.
            static member inline y (value: float) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "y" value
            /// Sets the background color of the update menu buttons.
            static member inline bgcolor (value: string) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "bgcolor" value
            /// Sets the color of the border enclosing the update menu.
            static member inline bordercolor (value: string) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "bordercolor" value
            /// Sets the width (in px) of the border enclosing the update menu.
            static member inline borderwidth (value: int) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "borderwidth" value
            /// Sets the width (in px) of the border enclosing the update menu.
            static member inline borderwidth (value: float) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "borderwidth" value
            /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
            static member inline name (value: string) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "name" value
            /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
            static member inline templateitemname (value: string) = Interop.mkLayoutUpdatemenusUpdatemenuAttr "templateitemname" value

        [<AutoOpen>]
        module updatemenu =
            /// Determines whether the buttons are accessible via a dropdown menu or whether the buttons are stacked horizontally or vertically
            [<Erase>]
            type type' =
                static member inline buttons = Interop.mkLayoutUpdatemenusUpdatemenuAttr "type" "buttons"
                static member inline dropdown = Interop.mkLayoutUpdatemenusUpdatemenuAttr "type" "dropdown"

            /// Determines the direction in which the buttons are laid out, whether in a dropdown menu or a row/column of buttons. For `left` and `up`, the buttons will still appear in left-to-right or top-to-bottom order respectively.
            [<Erase>]
            type direction =
                static member inline down = Interop.mkLayoutUpdatemenusUpdatemenuAttr "direction" "down"
                static member inline left = Interop.mkLayoutUpdatemenusUpdatemenuAttr "direction" "left"
                static member inline right = Interop.mkLayoutUpdatemenusUpdatemenuAttr "direction" "right"
                static member inline up = Interop.mkLayoutUpdatemenusUpdatemenuAttr "direction" "up"

            /// Sets the update menu's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
            [<Erase>]
            type xanchor =
                static member inline auto = Interop.mkLayoutUpdatemenusUpdatemenuAttr "xanchor" "auto"
                static member inline center = Interop.mkLayoutUpdatemenusUpdatemenuAttr "xanchor" "center"
                static member inline left = Interop.mkLayoutUpdatemenusUpdatemenuAttr "xanchor" "left"
                static member inline right = Interop.mkLayoutUpdatemenusUpdatemenuAttr "xanchor" "right"

            /// Sets the update menu's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
            [<Erase>]
            type yanchor =
                static member inline auto = Interop.mkLayoutUpdatemenusUpdatemenuAttr "yanchor" "auto"
                static member inline bottom = Interop.mkLayoutUpdatemenusUpdatemenuAttr "yanchor" "bottom"
                static member inline middle = Interop.mkLayoutUpdatemenusUpdatemenuAttr "yanchor" "middle"
                static member inline top = Interop.mkLayoutUpdatemenusUpdatemenuAttr "yanchor" "top"

            [<Erase>]
            type buttons = 
                static member inline button (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "button" (createObj !!properties)

            [<AutoOpen>]
            module buttons =
                [<Erase>]
                type button =
                    /// Determines whether or not this button is visible.
                    static member inline visible (value: bool) = Interop.mkLayoutAttr "visible" value
                    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
                    static member inline args (values: seq<bool>) = Interop.mkLayoutAttr "args" (values |> Array.ofSeq)
                    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
                    static member inline args (values: seq<int>) = Interop.mkLayoutAttr "args" (values |> Array.ofSeq)
                    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
                    static member inline args (values: seq<float>) = Interop.mkLayoutAttr "args" (values |> Array.ofSeq)
                    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
                    static member inline args (values: seq<string>) = Interop.mkLayoutAttr "args" (values |> Array.ofSeq)
                    /// Sets the text label to appear on the button.
                    static member inline label (value: string) = Interop.mkLayoutAttr "label" value
                    /// When true, the API method is executed. When false, all other behaviors are the same and command execution is skipped. This may be useful when hooking into, for example, the `plotly_buttonclicked` method and executing the API command manually without losing the benefit of the updatemenu automatically binding to the state of the plot through the specification of `method` and `args`.
                    static member inline execute (value: bool) = Interop.mkLayoutAttr "execute" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

                [<AutoOpen>]
                module button =
                    /// Sets the Plotly method to be called on click. If the `skip` method is used, the API updatemenu will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to updatemenu events manually via JavaScript.
                    [<Erase>]
                    type method =
                        static member inline animate = Interop.mkLayoutAttr "method" "animate"
                        static member inline relayout = Interop.mkLayoutAttr "method" "relayout"
                        static member inline restyle = Interop.mkLayoutAttr "method" "restyle"
                        static member inline skip = Interop.mkLayoutAttr "method" "skip"
                        static member inline update = Interop.mkLayoutAttr "method" "update"

            [<Erase>]
            type pad =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// The amount of padding (in px) along the top of the component.
                static member inline t (value: int) = Interop.mkLayoutAttr "t" value
                /// The amount of padding (in px) along the top of the component.
                static member inline t (value: float) = Interop.mkLayoutAttr "t" value
                /// The amount of padding (in px) on the right side of the component.
                static member inline r (value: int) = Interop.mkLayoutAttr "r" value
                /// The amount of padding (in px) on the right side of the component.
                static member inline r (value: float) = Interop.mkLayoutAttr "r" value
                /// The amount of padding (in px) along the bottom of the component.
                static member inline b (value: int) = Interop.mkLayoutAttr "b" value
                /// The amount of padding (in px) along the bottom of the component.
                static member inline b (value: float) = Interop.mkLayoutAttr "b" value
                /// The amount of padding (in px) on the left side of the component.
                static member inline l (value: int) = Interop.mkLayoutAttr "l" value
                /// The amount of padding (in px) on the left side of the component.
                static member inline l (value: float) = Interop.mkLayoutAttr "l" value

            [<Erase>]
            type font =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

    [<Erase>]
    type sliders = 
        static member inline slider (properties: #ILayoutSlidersSliderProperty list) = Interop.mkLayoutSlidersAttr "slider" (createObj !!properties)

    [<AutoOpen>]
    module sliders =
        [<Erase>]
        type slider =
            static member inline steps (properties: #ILayoutProperty list) = Interop.mkLayoutSlidersSliderAttr "steps" (createObj !!properties)
            static member inline pad (properties: #ILayoutProperty list) = Interop.mkLayoutSlidersSliderAttr "pad" (createObj !!properties)
            static member inline transition (properties: #ILayoutProperty list) = Interop.mkLayoutSlidersSliderAttr "transition" (createObj !!properties)
            static member inline currentvalue (properties: #ILayoutProperty list) = Interop.mkLayoutSlidersSliderAttr "currentvalue" (createObj !!properties)
            static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutSlidersSliderAttr "font" (createObj !!properties)
            /// Determines whether or not the slider is visible.
            static member inline visible (value: bool) = Interop.mkLayoutSlidersSliderAttr "visible" value
            /// Determines which button (by index starting from 0) is considered active.
            static member inline active (value: int) = Interop.mkLayoutSlidersSliderAttr "active" value
            /// Determines which button (by index starting from 0) is considered active.
            static member inline active (value: float) = Interop.mkLayoutSlidersSliderAttr "active" value
            /// Sets the length of the slider This measure excludes the padding of both ends. That is, the slider's length is this length minus the padding on both ends.
            static member inline len (value: int) = Interop.mkLayoutSlidersSliderAttr "len" value
            /// Sets the length of the slider This measure excludes the padding of both ends. That is, the slider's length is this length minus the padding on both ends.
            static member inline len (value: float) = Interop.mkLayoutSlidersSliderAttr "len" value
            /// Sets the x position (in normalized coordinates) of the slider.
            static member inline x (value: int) = Interop.mkLayoutSlidersSliderAttr "x" value
            /// Sets the x position (in normalized coordinates) of the slider.
            static member inline x (value: float) = Interop.mkLayoutSlidersSliderAttr "x" value
            /// Sets the y position (in normalized coordinates) of the slider.
            static member inline y (value: int) = Interop.mkLayoutSlidersSliderAttr "y" value
            /// Sets the y position (in normalized coordinates) of the slider.
            static member inline y (value: float) = Interop.mkLayoutSlidersSliderAttr "y" value
            /// Sets the background color of the slider grip while dragging.
            static member inline activebgcolor (value: string) = Interop.mkLayoutSlidersSliderAttr "activebgcolor" value
            /// Sets the background color of the slider.
            static member inline bgcolor (value: string) = Interop.mkLayoutSlidersSliderAttr "bgcolor" value
            /// Sets the color of the border enclosing the slider.
            static member inline bordercolor (value: string) = Interop.mkLayoutSlidersSliderAttr "bordercolor" value
            /// Sets the width (in px) of the border enclosing the slider.
            static member inline borderwidth (value: int) = Interop.mkLayoutSlidersSliderAttr "borderwidth" value
            /// Sets the width (in px) of the border enclosing the slider.
            static member inline borderwidth (value: float) = Interop.mkLayoutSlidersSliderAttr "borderwidth" value
            /// Sets the length in pixels of step tick marks
            static member inline ticklen (value: int) = Interop.mkLayoutSlidersSliderAttr "ticklen" value
            /// Sets the length in pixels of step tick marks
            static member inline ticklen (value: float) = Interop.mkLayoutSlidersSliderAttr "ticklen" value
            /// Sets the color of the border enclosing the slider.
            static member inline tickcolor (value: string) = Interop.mkLayoutSlidersSliderAttr "tickcolor" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutSlidersSliderAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutSlidersSliderAttr "tickwidth" value
            /// Sets the length in pixels of minor step tick marks
            static member inline minorticklen (value: int) = Interop.mkLayoutSlidersSliderAttr "minorticklen" value
            /// Sets the length in pixels of minor step tick marks
            static member inline minorticklen (value: float) = Interop.mkLayoutSlidersSliderAttr "minorticklen" value
            /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
            static member inline name (value: string) = Interop.mkLayoutSlidersSliderAttr "name" value
            /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
            static member inline templateitemname (value: string) = Interop.mkLayoutSlidersSliderAttr "templateitemname" value

        [<AutoOpen>]
        module slider =
            /// Determines whether this slider length is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
            [<Erase>]
            type lenmode =
                static member inline fraction = Interop.mkLayoutSlidersSliderAttr "lenmode" "fraction"
                static member inline pixels = Interop.mkLayoutSlidersSliderAttr "lenmode" "pixels"

            /// Sets the slider's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
            [<Erase>]
            type xanchor =
                static member inline auto = Interop.mkLayoutSlidersSliderAttr "xanchor" "auto"
                static member inline center = Interop.mkLayoutSlidersSliderAttr "xanchor" "center"
                static member inline left = Interop.mkLayoutSlidersSliderAttr "xanchor" "left"
                static member inline right = Interop.mkLayoutSlidersSliderAttr "xanchor" "right"

            /// Sets the slider's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
            [<Erase>]
            type yanchor =
                static member inline auto = Interop.mkLayoutSlidersSliderAttr "yanchor" "auto"
                static member inline bottom = Interop.mkLayoutSlidersSliderAttr "yanchor" "bottom"
                static member inline middle = Interop.mkLayoutSlidersSliderAttr "yanchor" "middle"
                static member inline top = Interop.mkLayoutSlidersSliderAttr "yanchor" "top"

            [<Erase>]
            type steps = 
                static member inline step (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "step" (createObj !!properties)

            [<AutoOpen>]
            module steps =
                [<Erase>]
                type step =
                    /// Determines whether or not this step is included in the slider.
                    static member inline visible (value: bool) = Interop.mkLayoutAttr "visible" value
                    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
                    static member inline args (values: seq<bool>) = Interop.mkLayoutAttr "args" (values |> Array.ofSeq)
                    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
                    static member inline args (values: seq<int>) = Interop.mkLayoutAttr "args" (values |> Array.ofSeq)
                    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
                    static member inline args (values: seq<float>) = Interop.mkLayoutAttr "args" (values |> Array.ofSeq)
                    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
                    static member inline args (values: seq<string>) = Interop.mkLayoutAttr "args" (values |> Array.ofSeq)
                    /// Sets the text label to appear on the slider
                    static member inline label (value: string) = Interop.mkLayoutAttr "label" value
                    /// Sets the value of the slider step, used to refer to the step programatically. Defaults to the slider label if not provided.
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When true, the API method is executed. When false, all other behaviors are the same and command execution is skipped. This may be useful when hooking into, for example, the `plotly_sliderchange` method and executing the API command manually without losing the benefit of the slider automatically binding to the state of the plot through the specification of `method` and `args`.
                    static member inline execute (value: bool) = Interop.mkLayoutAttr "execute" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

                [<AutoOpen>]
                module step =
                    /// Sets the Plotly method to be called when the slider value is changed. If the `skip` method is used, the API slider will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to slider events manually via JavaScript.
                    [<Erase>]
                    type method =
                        static member inline animate = Interop.mkLayoutAttr "method" "animate"
                        static member inline relayout = Interop.mkLayoutAttr "method" "relayout"
                        static member inline restyle = Interop.mkLayoutAttr "method" "restyle"
                        static member inline skip = Interop.mkLayoutAttr "method" "skip"
                        static member inline update = Interop.mkLayoutAttr "method" "update"

            [<Erase>]
            type pad =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// The amount of padding (in px) along the top of the component.
                static member inline t (value: int) = Interop.mkLayoutAttr "t" value
                /// The amount of padding (in px) along the top of the component.
                static member inline t (value: float) = Interop.mkLayoutAttr "t" value
                /// The amount of padding (in px) on the right side of the component.
                static member inline r (value: int) = Interop.mkLayoutAttr "r" value
                /// The amount of padding (in px) on the right side of the component.
                static member inline r (value: float) = Interop.mkLayoutAttr "r" value
                /// The amount of padding (in px) along the bottom of the component.
                static member inline b (value: int) = Interop.mkLayoutAttr "b" value
                /// The amount of padding (in px) along the bottom of the component.
                static member inline b (value: float) = Interop.mkLayoutAttr "b" value
                /// The amount of padding (in px) on the left side of the component.
                static member inline l (value: int) = Interop.mkLayoutAttr "l" value
                /// The amount of padding (in px) on the left side of the component.
                static member inline l (value: float) = Interop.mkLayoutAttr "l" value

            [<Erase>]
            type transition =
                /// Sets the duration of the slider transition
                static member inline duration (value: int) = Interop.mkLayoutAttr "duration" value
                /// Sets the duration of the slider transition
                static member inline duration (value: float) = Interop.mkLayoutAttr "duration" value

            [<AutoOpen>]
            module transition =
                /// Sets the easing function of the slider transition
                [<Erase>]
                type easing =
                    static member inline back = Interop.mkLayoutAttr "easing" "back"
                    static member inline backIn = Interop.mkLayoutAttr "easing" "back-in"
                    static member inline backInOut = Interop.mkLayoutAttr "easing" "back-in-out"
                    static member inline backOut = Interop.mkLayoutAttr "easing" "back-out"
                    static member inline bounce = Interop.mkLayoutAttr "easing" "bounce"
                    static member inline bounceIn = Interop.mkLayoutAttr "easing" "bounce-in"
                    static member inline bounceInOut = Interop.mkLayoutAttr "easing" "bounce-in-out"
                    static member inline bounceOut = Interop.mkLayoutAttr "easing" "bounce-out"
                    static member inline circle = Interop.mkLayoutAttr "easing" "circle"
                    static member inline circleIn = Interop.mkLayoutAttr "easing" "circle-in"
                    static member inline circleInOut = Interop.mkLayoutAttr "easing" "circle-in-out"
                    static member inline circleOut = Interop.mkLayoutAttr "easing" "circle-out"
                    static member inline cubic = Interop.mkLayoutAttr "easing" "cubic"
                    static member inline cubicIn = Interop.mkLayoutAttr "easing" "cubic-in"
                    static member inline cubicInOut = Interop.mkLayoutAttr "easing" "cubic-in-out"
                    static member inline cubicOut = Interop.mkLayoutAttr "easing" "cubic-out"
                    static member inline elastic = Interop.mkLayoutAttr "easing" "elastic"
                    static member inline elasticIn = Interop.mkLayoutAttr "easing" "elastic-in"
                    static member inline elasticInOut = Interop.mkLayoutAttr "easing" "elastic-in-out"
                    static member inline elasticOut = Interop.mkLayoutAttr "easing" "elastic-out"
                    static member inline exp = Interop.mkLayoutAttr "easing" "exp"
                    static member inline expIn = Interop.mkLayoutAttr "easing" "exp-in"
                    static member inline expInOut = Interop.mkLayoutAttr "easing" "exp-in-out"
                    static member inline expOut = Interop.mkLayoutAttr "easing" "exp-out"
                    static member inline linear = Interop.mkLayoutAttr "easing" "linear"
                    static member inline linearIn = Interop.mkLayoutAttr "easing" "linear-in"
                    static member inline linearInOut = Interop.mkLayoutAttr "easing" "linear-in-out"
                    static member inline linearOut = Interop.mkLayoutAttr "easing" "linear-out"
                    static member inline quad = Interop.mkLayoutAttr "easing" "quad"
                    static member inline quadIn = Interop.mkLayoutAttr "easing" "quad-in"
                    static member inline quadInOut = Interop.mkLayoutAttr "easing" "quad-in-out"
                    static member inline quadOut = Interop.mkLayoutAttr "easing" "quad-out"
                    static member inline sin = Interop.mkLayoutAttr "easing" "sin"
                    static member inline sinIn = Interop.mkLayoutAttr "easing" "sin-in"
                    static member inline sinInOut = Interop.mkLayoutAttr "easing" "sin-in-out"
                    static member inline sinOut = Interop.mkLayoutAttr "easing" "sin-out"

            [<Erase>]
            type currentvalue =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Shows the currently-selected value above the slider.
                static member inline visible (value: bool) = Interop.mkLayoutAttr "visible" value
                /// The amount of space, in pixels, between the current value label and the slider.
                static member inline offset (value: int) = Interop.mkLayoutAttr "offset" value
                /// The amount of space, in pixels, between the current value label and the slider.
                static member inline offset (value: float) = Interop.mkLayoutAttr "offset" value
                /// When currentvalue.visible is true, this sets the prefix of the label.
                static member inline prefix (value: string) = Interop.mkLayoutAttr "prefix" value
                /// When currentvalue.visible is true, this sets the suffix of the label.
                static member inline suffix (value: string) = Interop.mkLayoutAttr "suffix" value

            [<AutoOpen>]
            module currentvalue =
                /// The alignment of the value readout relative to the length of the slider.
                [<Erase>]
                type xanchor =
                    static member inline center = Interop.mkLayoutAttr "xanchor" "center"
                    static member inline left = Interop.mkLayoutAttr "xanchor" "left"
                    static member inline right = Interop.mkLayoutAttr "xanchor" "right"

                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type font =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

    [<Erase>]
    type colorscale =
        /// Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work.
        static member inline sequential (values: seq<string>) = Interop.mkLayoutColorscaleAttr "sequential" (values |> Array.ofSeq)
        /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
        static member inline sequentialminus (values: seq<string>) = Interop.mkLayoutColorscaleAttr "sequentialminus" (values |> Array.ofSeq)
        /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
        static member inline diverging (values: seq<string>) = Interop.mkLayoutColorscaleAttr "diverging" (values |> Array.ofSeq)

    [<Erase>]
    type coloraxis =
        static member inline description (properties: #ILayoutColoraxisDescriptionProperty list) = Interop.mkLayoutColoraxisAttr "description" (createObj !!properties)
        static member inline colorbar (properties: #ILayoutColoraxisColorbarProperty list) = Interop.mkLayoutColoraxisAttr "colorbar" (createObj !!properties)
        /// Determines whether or not the color domain is computed with respect to the input data (here corresponding trace color array(s)) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        static member inline cauto (value: bool) = Interop.mkLayoutColoraxisAttr "cauto" value
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        static member inline cmin (value: int) = Interop.mkLayoutColoraxisAttr "cmin" value
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        static member inline cmin (value: float) = Interop.mkLayoutColoraxisAttr "cmin" value
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        static member inline cmax (value: int) = Interop.mkLayoutColoraxisAttr "cmax" value
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        static member inline cmax (value: float) = Interop.mkLayoutColoraxisAttr "cmax" value
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        static member inline cmid (value: int) = Interop.mkLayoutColoraxisAttr "cmid" value
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        static member inline cmid (value: float) = Interop.mkLayoutColoraxisAttr "cmid" value
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        static member inline colorscale (values: seq<string>) = Interop.mkLayoutColoraxisAttr "colorscale" (values |> Array.ofSeq)
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        static member inline autocolorscale (value: bool) = Interop.mkLayoutColoraxisAttr "autocolorscale" value
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        static member inline reversescale (value: bool) = Interop.mkLayoutColoraxisAttr "reversescale" value
        /// Determines whether or not a colorbar is displayed for this trace.
        static member inline showscale (value: bool) = Interop.mkLayoutColoraxisAttr "showscale" value

    [<AutoOpen>]
    module coloraxis =
        [<Erase>]
        type colorbar =
            static member inline tickfont (properties: #ILayoutProperty list) = Interop.mkLayoutColoraxisColorbarAttr "tickfont" (createObj !!properties)
            static member inline tickformatstops (properties: #ILayoutProperty list) = Interop.mkLayoutColoraxisColorbarAttr "tickformatstops" (createObj !!properties)
            static member inline title (properties: #ILayoutProperty list) = Interop.mkLayoutColoraxisColorbarAttr "title" (createObj !!properties)
            /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
            static member inline thickness (value: int) = Interop.mkLayoutColoraxisColorbarAttr "thickness" value
            /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
            static member inline thickness (value: float) = Interop.mkLayoutColoraxisColorbarAttr "thickness" value
            /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
            static member inline len (value: int) = Interop.mkLayoutColoraxisColorbarAttr "len" value
            /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
            static member inline len (value: float) = Interop.mkLayoutColoraxisColorbarAttr "len" value
            /// Sets the x position of the color bar (in plot fraction).
            static member inline x (value: int) = Interop.mkLayoutColoraxisColorbarAttr "x" value
            /// Sets the x position of the color bar (in plot fraction).
            static member inline x (value: float) = Interop.mkLayoutColoraxisColorbarAttr "x" value
            /// Sets the amount of padding (in px) along the x direction.
            static member inline xpad (value: int) = Interop.mkLayoutColoraxisColorbarAttr "xpad" value
            /// Sets the amount of padding (in px) along the x direction.
            static member inline xpad (value: float) = Interop.mkLayoutColoraxisColorbarAttr "xpad" value
            /// Sets the y position of the color bar (in plot fraction).
            static member inline y (value: int) = Interop.mkLayoutColoraxisColorbarAttr "y" value
            /// Sets the y position of the color bar (in plot fraction).
            static member inline y (value: float) = Interop.mkLayoutColoraxisColorbarAttr "y" value
            /// Sets the amount of padding (in px) along the y direction.
            static member inline ypad (value: int) = Interop.mkLayoutColoraxisColorbarAttr "ypad" value
            /// Sets the amount of padding (in px) along the y direction.
            static member inline ypad (value: float) = Interop.mkLayoutColoraxisColorbarAttr "ypad" value
            /// Sets the axis line color.
            static member inline outlinecolor (value: string) = Interop.mkLayoutColoraxisColorbarAttr "outlinecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline outlinewidth (value: int) = Interop.mkLayoutColoraxisColorbarAttr "outlinewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline outlinewidth (value: float) = Interop.mkLayoutColoraxisColorbarAttr "outlinewidth" value
            /// Sets the axis line color.
            static member inline bordercolor (value: string) = Interop.mkLayoutColoraxisColorbarAttr "bordercolor" value
            /// Sets the width (in px) or the border enclosing this color bar.
            static member inline borderwidth (value: int) = Interop.mkLayoutColoraxisColorbarAttr "borderwidth" value
            /// Sets the width (in px) or the border enclosing this color bar.
            static member inline borderwidth (value: float) = Interop.mkLayoutColoraxisColorbarAttr "borderwidth" value
            /// Sets the color of padded area.
            static member inline bgcolor (value: string) = Interop.mkLayoutColoraxisColorbarAttr "bgcolor" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutColoraxisColorbarAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutColoraxisColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutColoraxisColorbarAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutColoraxisColorbarAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutColoraxisColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutColoraxisColorbarAttr "tick0" (values |> Array.ofSeq)
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutColoraxisColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutColoraxisColorbarAttr "tick0" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutColoraxisColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutColoraxisColorbarAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutColoraxisColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutColoraxisColorbarAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutColoraxisColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutColoraxisColorbarAttr "dtick" (values |> Array.ofSeq)
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutColoraxisColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutColoraxisColorbarAttr "dtick" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutColoraxisColorbarAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutColoraxisColorbarAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutColoraxisColorbarAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutColoraxisColorbarAttr "tickvals" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutColoraxisColorbarAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutColoraxisColorbarAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutColoraxisColorbarAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutColoraxisColorbarAttr "ticktext" (values |> Array.ofSeq)
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutColoraxisColorbarAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutColoraxisColorbarAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutColoraxisColorbarAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutColoraxisColorbarAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutColoraxisColorbarAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutColoraxisColorbarAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutColoraxisColorbarAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tickformat" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutColoraxisColorbarAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutColoraxisColorbarAttr "separatethousands" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutColoraxisColorbarAttr "ticktextsrc" value

        [<AutoOpen>]
        module colorbar =
            /// Determines whether this color bar's thickness (i.e. the measure in the constant color direction) is set in units of plot *fraction* or in *pixels*. Use `thickness` to set the value.
            [<Erase>]
            type thicknessmode =
                static member inline fraction = Interop.mkLayoutColoraxisColorbarAttr "thicknessmode" "fraction"
                static member inline pixels = Interop.mkLayoutColoraxisColorbarAttr "thicknessmode" "pixels"

            /// Determines whether this color bar's length (i.e. the measure in the color variation direction) is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
            [<Erase>]
            type lenmode =
                static member inline fraction = Interop.mkLayoutColoraxisColorbarAttr "lenmode" "fraction"
                static member inline pixels = Interop.mkLayoutColoraxisColorbarAttr "lenmode" "pixels"

            /// Sets this color bar's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the color bar.
            [<Erase>]
            type xanchor =
                static member inline center = Interop.mkLayoutColoraxisColorbarAttr "xanchor" "center"
                static member inline left = Interop.mkLayoutColoraxisColorbarAttr "xanchor" "left"
                static member inline right = Interop.mkLayoutColoraxisColorbarAttr "xanchor" "right"

            /// Sets this color bar's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the color bar.
            [<Erase>]
            type yanchor =
                static member inline bottom = Interop.mkLayoutColoraxisColorbarAttr "yanchor" "bottom"
                static member inline middle = Interop.mkLayoutColoraxisColorbarAttr "yanchor" "middle"
                static member inline top = Interop.mkLayoutColoraxisColorbarAttr "yanchor" "top"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutColoraxisColorbarAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutColoraxisColorbarAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutColoraxisColorbarAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutColoraxisColorbarAttr "ticks" ""
                static member inline inside = Interop.mkLayoutColoraxisColorbarAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutColoraxisColorbarAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutColoraxisColorbarAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutColoraxisColorbarAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutColoraxisColorbarAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutColoraxisColorbarAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutColoraxisColorbarAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutColoraxisColorbarAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutColoraxisColorbarAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutColoraxisColorbarAttr "showticksuffix" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutColoraxisColorbarAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutColoraxisColorbarAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutColoraxisColorbarAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutColoraxisColorbarAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutColoraxisColorbarAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutColoraxisColorbarAttr "exponentformat" "power"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutColoraxisColorbarAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutColoraxisColorbarAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutColoraxisColorbarAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutColoraxisColorbarAttr "showexponent" "none"

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutAttr "color" value

            [<Erase>]
            type tickformatstops = 
                static member inline tickformatstop (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "tickformatstop" (createObj !!properties)

            [<AutoOpen>]
            module tickformatstops =
                [<Erase>]
                type tickformatstop =
                    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
                    static member inline enabled (value: bool) = Interop.mkLayoutAttr "enabled" value
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<bool>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<int>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<float>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
                    static member inline dtickrange (values: seq<string>) = Interop.mkLayoutAttr "dtickrange" (values |> Array.ofSeq)
                    /// string - dtickformat for described zoom level, the same as *tickformat*
                    static member inline value (value: string) = Interop.mkLayoutAttr "value" value
                    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
                    static member inline name (value: string) = Interop.mkLayoutAttr "name" value
                    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
                    static member inline templateitemname (value: string) = Interop.mkLayoutAttr "templateitemname" value

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
                /// Sets the title of the color bar. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutAttr "text" value

            [<AutoOpen>]
            module title =
                /// Determines the location of color bar's title with respect to the color bar. Note that the title's location used to be set by the now deprecated `titleside` attribute.
                [<Erase>]
                type side =
                    static member inline bottom = Interop.mkLayoutAttr "side" "bottom"
                    static member inline right = Interop.mkLayoutAttr "side" "right"
                    static member inline top = Interop.mkLayoutAttr "side" "top"

                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "description" (createObj !!properties)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutAttr "color" value

    [<Erase>]
    type bar =
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        static member inline bargap (value: int) = Interop.mkLayoutBarAttr "bargap" value
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        static member inline bargap (value: float) = Interop.mkLayoutBarAttr "bargap" value
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        static member inline bargroupgap (value: int) = Interop.mkLayoutBarAttr "bargroupgap" value
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        static member inline bargroupgap (value: float) = Interop.mkLayoutBarAttr "bargroupgap" value

    [<AutoOpen>]
    module bar =
        /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *relative*, the bars are stacked on top of one another, with negative values below the axis, positive values above With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
        [<Erase>]
        type barmode =
            static member inline group = Interop.mkLayoutBarAttr "barmode" "group"
            static member inline overlay = Interop.mkLayoutBarAttr "barmode" "overlay"
            static member inline relative = Interop.mkLayoutBarAttr "barmode" "relative"
            static member inline stack = Interop.mkLayoutBarAttr "barmode" "stack"

        /// Sets the normalization for bar traces on the graph. With *fraction*, the value of each bar is divided by the sum of all values at that location coordinate. *percent* is the same but multiplied by 100 to show percentages.
        [<Erase>]
        type barnorm =
            static member inline none = Interop.mkLayoutBarAttr "barnorm" ""
            static member inline fraction = Interop.mkLayoutBarAttr "barnorm" "fraction"
            static member inline percent = Interop.mkLayoutBarAttr "barnorm" "percent"

    [<Erase>]
    type box =
        /// Sets the gap (in plot fraction) between boxes of adjacent location coordinates. Has no effect on traces that have *width* set.
        static member inline boxgap (value: int) = Interop.mkLayoutBoxAttr "boxgap" value
        /// Sets the gap (in plot fraction) between boxes of adjacent location coordinates. Has no effect on traces that have *width* set.
        static member inline boxgap (value: float) = Interop.mkLayoutBoxAttr "boxgap" value
        /// Sets the gap (in plot fraction) between boxes of the same location coordinate. Has no effect on traces that have *width* set.
        static member inline boxgroupgap (value: int) = Interop.mkLayoutBoxAttr "boxgroupgap" value
        /// Sets the gap (in plot fraction) between boxes of the same location coordinate. Has no effect on traces that have *width* set.
        static member inline boxgroupgap (value: float) = Interop.mkLayoutBoxAttr "boxgroupgap" value

    [<AutoOpen>]
    module box =
        /// Determines how boxes at the same location coordinate are displayed on the graph. If *group*, the boxes are plotted next to one another centered around the shared location. If *overlay*, the boxes are plotted over one another, you might need to set *opacity* to see them multiple boxes. Has no effect on traces that have *width* set.
        [<Erase>]
        type boxmode =
            static member inline group = Interop.mkLayoutBoxAttr "boxmode" "group"
            static member inline overlay = Interop.mkLayoutBoxAttr "boxmode" "overlay"

    [<Erase>]
    type histogram =
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        static member inline bargap (value: int) = Interop.mkLayoutHistogramAttr "bargap" value
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        static member inline bargap (value: float) = Interop.mkLayoutHistogramAttr "bargap" value
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        static member inline bargroupgap (value: int) = Interop.mkLayoutHistogramAttr "bargroupgap" value
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        static member inline bargroupgap (value: float) = Interop.mkLayoutHistogramAttr "bargroupgap" value

    [<AutoOpen>]
    module histogram =
        /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *relative*, the bars are stacked on top of one another, with negative values below the axis, positive values above With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
        [<Erase>]
        type barmode =
            static member inline group = Interop.mkLayoutHistogramAttr "barmode" "group"
            static member inline overlay = Interop.mkLayoutHistogramAttr "barmode" "overlay"
            static member inline relative = Interop.mkLayoutHistogramAttr "barmode" "relative"
            static member inline stack = Interop.mkLayoutHistogramAttr "barmode" "stack"

        /// Sets the normalization for bar traces on the graph. With *fraction*, the value of each bar is divided by the sum of all values at that location coordinate. *percent* is the same but multiplied by 100 to show percentages.
        [<Erase>]
        type barnorm =
            static member inline none = Interop.mkLayoutHistogramAttr "barnorm" ""
            static member inline fraction = Interop.mkLayoutHistogramAttr "barnorm" "fraction"
            static member inline percent = Interop.mkLayoutHistogramAttr "barnorm" "percent"

    [<Erase>]
    type violin =
        /// Sets the gap (in plot fraction) between violins of adjacent location coordinates. Has no effect on traces that have *width* set.
        static member inline violingap (value: int) = Interop.mkLayoutViolinAttr "violingap" value
        /// Sets the gap (in plot fraction) between violins of adjacent location coordinates. Has no effect on traces that have *width* set.
        static member inline violingap (value: float) = Interop.mkLayoutViolinAttr "violingap" value
        /// Sets the gap (in plot fraction) between violins of the same location coordinate. Has no effect on traces that have *width* set.
        static member inline violingroupgap (value: int) = Interop.mkLayoutViolinAttr "violingroupgap" value
        /// Sets the gap (in plot fraction) between violins of the same location coordinate. Has no effect on traces that have *width* set.
        static member inline violingroupgap (value: float) = Interop.mkLayoutViolinAttr "violingroupgap" value

    [<AutoOpen>]
    module violin =
        /// Determines how violins at the same location coordinate are displayed on the graph. If *group*, the violins are plotted next to one another centered around the shared location. If *overlay*, the violins are plotted over one another, you might need to set *opacity* to see them multiple violins. Has no effect on traces that have *width* set.
        [<Erase>]
        type violinmode =
            static member inline group = Interop.mkLayoutViolinAttr "violinmode" "group"
            static member inline overlay = Interop.mkLayoutViolinAttr "violinmode" "overlay"

    [<Erase>]
    type funnel =
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        static member inline funnelgap (value: int) = Interop.mkLayoutFunnelAttr "funnelgap" value
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        static member inline funnelgap (value: float) = Interop.mkLayoutFunnelAttr "funnelgap" value
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        static member inline funnelgroupgap (value: int) = Interop.mkLayoutFunnelAttr "funnelgroupgap" value
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        static member inline funnelgroupgap (value: float) = Interop.mkLayoutFunnelAttr "funnelgroupgap" value

    [<AutoOpen>]
    module funnel =
        /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
        [<Erase>]
        type funnelmode =
            static member inline group = Interop.mkLayoutFunnelAttr "funnelmode" "group"
            static member inline overlay = Interop.mkLayoutFunnelAttr "funnelmode" "overlay"
            static member inline stack = Interop.mkLayoutFunnelAttr "funnelmode" "stack"

    [<Erase>]
    type waterfall =
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        static member inline waterfallgap (value: int) = Interop.mkLayoutWaterfallAttr "waterfallgap" value
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        static member inline waterfallgap (value: float) = Interop.mkLayoutWaterfallAttr "waterfallgap" value
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        static member inline waterfallgroupgap (value: int) = Interop.mkLayoutWaterfallAttr "waterfallgroupgap" value
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        static member inline waterfallgroupgap (value: float) = Interop.mkLayoutWaterfallAttr "waterfallgroupgap" value

    [<AutoOpen>]
    module waterfall =
        /// Determines how bars at the same location coordinate are displayed on the graph. With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
        [<Erase>]
        type waterfallmode =
            static member inline group = Interop.mkLayoutWaterfallAttr "waterfallmode" "group"
            static member inline overlay = Interop.mkLayoutWaterfallAttr "waterfallmode" "overlay"

    [<Erase>]
    type pie =
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        static member inline hiddenlabels (values: seq<bool>) = Interop.mkLayoutPieAttr "hiddenlabels" (values |> Array.ofSeq)
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        static member inline hiddenlabels (values: seq<string>) = Interop.mkLayoutPieAttr "hiddenlabels" (values |> Array.ofSeq)
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        static member inline hiddenlabels (values: seq<int>) = Interop.mkLayoutPieAttr "hiddenlabels" (values |> Array.ofSeq)
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        static member inline hiddenlabels (values: seq<float>) = Interop.mkLayoutPieAttr "hiddenlabels" (values |> Array.ofSeq)
        /// Sets the default pie slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendpiecolors`.
        static member inline piecolorway (values: seq<string>) = Interop.mkLayoutPieAttr "piecolorway" (values |> Array.ofSeq)
        /// If `true`, the pie slice colors (whether given by `piecolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
        static member inline extendpiecolors (value: bool) = Interop.mkLayoutPieAttr "extendpiecolors" value
        /// Sets the source reference on plot.ly for  hiddenlabels .
        static member inline hiddenlabelssrc (value: string) = Interop.mkLayoutPieAttr "hiddenlabelssrc" value

    [<Erase>]
    type sunburst =
        /// Sets the default sunburst slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendsunburstcolors`.
        static member inline sunburstcolorway (values: seq<string>) = Interop.mkLayoutSunburstAttr "sunburstcolorway" (values |> Array.ofSeq)
        /// If `true`, the sunburst slice colors (whether given by `sunburstcolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
        static member inline extendsunburstcolors (value: bool) = Interop.mkLayoutSunburstAttr "extendsunburstcolors" value

    [<Erase>]
    type treemap =
        /// Sets the default treemap slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendtreemapcolors`.
        static member inline treemapcolorway (values: seq<string>) = Interop.mkLayoutTreemapAttr "treemapcolorway" (values |> Array.ofSeq)
        /// If `true`, the treemap slice colors (whether given by `treemapcolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
        static member inline extendtreemapcolors (value: bool) = Interop.mkLayoutTreemapAttr "extendtreemapcolors" value

    [<Erase>]
    type funnelarea =
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        static member inline hiddenlabels (values: seq<bool>) = Interop.mkLayoutFunnelareaAttr "hiddenlabels" (values |> Array.ofSeq)
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        static member inline hiddenlabels (values: seq<string>) = Interop.mkLayoutFunnelareaAttr "hiddenlabels" (values |> Array.ofSeq)
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        static member inline hiddenlabels (values: seq<int>) = Interop.mkLayoutFunnelareaAttr "hiddenlabels" (values |> Array.ofSeq)
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        static member inline hiddenlabels (values: seq<float>) = Interop.mkLayoutFunnelareaAttr "hiddenlabels" (values |> Array.ofSeq)
        /// Sets the default funnelarea slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendfunnelareacolors`.
        static member inline funnelareacolorway (values: seq<string>) = Interop.mkLayoutFunnelareaAttr "funnelareacolorway" (values |> Array.ofSeq)
        /// If `true`, the funnelarea slice colors (whether given by `funnelareacolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
        static member inline extendfunnelareacolors (value: bool) = Interop.mkLayoutFunnelareaAttr "extendfunnelareacolors" value
        /// Sets the source reference on plot.ly for  hiddenlabels .
        static member inline hiddenlabelssrc (value: string) = Interop.mkLayoutFunnelareaAttr "hiddenlabelssrc" value

    [<Erase>]
    type candlestick =
        /// Sets the gap (in plot fraction) between boxes of adjacent location coordinates. Has no effect on traces that have *width* set.
        static member inline boxgap (value: int) = Interop.mkLayoutCandlestickAttr "boxgap" value
        /// Sets the gap (in plot fraction) between boxes of adjacent location coordinates. Has no effect on traces that have *width* set.
        static member inline boxgap (value: float) = Interop.mkLayoutCandlestickAttr "boxgap" value
        /// Sets the gap (in plot fraction) between boxes of the same location coordinate. Has no effect on traces that have *width* set.
        static member inline boxgroupgap (value: int) = Interop.mkLayoutCandlestickAttr "boxgroupgap" value
        /// Sets the gap (in plot fraction) between boxes of the same location coordinate. Has no effect on traces that have *width* set.
        static member inline boxgroupgap (value: float) = Interop.mkLayoutCandlestickAttr "boxgroupgap" value

    [<AutoOpen>]
    module candlestick =
        /// Determines how boxes at the same location coordinate are displayed on the graph. If *group*, the boxes are plotted next to one another centered around the shared location. If *overlay*, the boxes are plotted over one another, you might need to set *opacity* to see them multiple boxes. Has no effect on traces that have *width* set.
        [<Erase>]
        type boxmode =
            static member inline group = Interop.mkLayoutCandlestickAttr "boxmode" "group"
            static member inline overlay = Interop.mkLayoutCandlestickAttr "boxmode" "overlay"

    [<Erase>]
    type barpolar =
        /// Sets the gap between bars of adjacent location coordinates. Values are unitless, they represent fractions of the minimum difference in bar positions in the data.
        static member inline bargap (value: int) = Interop.mkLayoutBarpolarAttr "bargap" value
        /// Sets the gap between bars of adjacent location coordinates. Values are unitless, they represent fractions of the minimum difference in bar positions in the data.
        static member inline bargap (value: float) = Interop.mkLayoutBarpolarAttr "bargap" value

    [<AutoOpen>]
    module barpolar =
        /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
        [<Erase>]
        type barmode =
            static member inline overlay = Interop.mkLayoutBarpolarAttr "barmode" "overlay"
            static member inline stack = Interop.mkLayoutBarpolarAttr "barmode" "stack"
