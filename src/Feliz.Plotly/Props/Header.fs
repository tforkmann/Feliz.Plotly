namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type header =
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: bool) = Interop.mkHeaderAttr "values" (value |> Array.singleton)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool>) = Interop.mkHeaderAttr "values" (values |> Array.ofSeq)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: string) = Interop.mkHeaderAttr "values" (value |> Array.singleton)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string>) = Interop.mkHeaderAttr "values" (values |> Array.ofSeq)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: int) = Interop.mkHeaderAttr "values" (value |> Array.singleton)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int>) = Interop.mkHeaderAttr "values" (values |> Array.ofSeq)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: float) = Interop.mkHeaderAttr "values" (value |> Array.singleton)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float>) = Interop.mkHeaderAttr "values" (values |> Array.ofSeq)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: bool) = Interop.mkHeaderAttr "format" (value |> Array.singleton)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool>) = Interop.mkHeaderAttr "format" (values |> Array.ofSeq)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: string) = Interop.mkHeaderAttr "format" (value |> Array.singleton)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string>) = Interop.mkHeaderAttr "format" (values |> Array.ofSeq)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: int) = Interop.mkHeaderAttr "format" (value |> Array.singleton)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int>) = Interop.mkHeaderAttr "format" (values |> Array.ofSeq)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: float) = Interop.mkHeaderAttr "format" (value |> Array.singleton)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float>) = Interop.mkHeaderAttr "format" (values |> Array.ofSeq)
    /// Prefix for cell values.
    static member inline prefix (value: string) = Interop.mkHeaderAttr "prefix" value
    /// Prefix for cell values.
    static member inline prefix (values: seq<string>) = Interop.mkHeaderAttr "prefix" (values |> Array.ofSeq)
    /// Suffix for cell values.
    static member inline suffix (value: string) = Interop.mkHeaderAttr "suffix" value
    /// Suffix for cell values.
    static member inline suffix (values: seq<string>) = Interop.mkHeaderAttr "suffix" (values |> Array.ofSeq)
    /// The height of cells.
    static member inline height (value: int) = Interop.mkHeaderAttr "height" value
    /// The height of cells.
    static member inline height (value: float) = Interop.mkHeaderAttr "height" value
    static member inline line (properties: #ILineProperty list) = Interop.mkHeaderAttr "line" (createObj !!properties)
    static member inline fill (properties: #IFillProperty list) = Interop.mkHeaderAttr "fill" (createObj !!properties)
    static member inline font (properties: #IFontProperty list) = Interop.mkHeaderAttr "font" (createObj !!properties)
    /// Sets the source reference on plot.ly for  values .
    static member inline valuessrc (value: string) = Interop.mkHeaderAttr "valuessrc" value
    /// Sets the source reference on plot.ly for  format .
    static member inline formatsrc (value: string) = Interop.mkHeaderAttr "formatsrc" value
    /// Sets the source reference on plot.ly for  prefix .
    static member inline prefixsrc (value: string) = Interop.mkHeaderAttr "prefixsrc" value
    /// Sets the source reference on plot.ly for  suffix .
    static member inline suffixsrc (value: string) = Interop.mkHeaderAttr "suffixsrc" value
    /// Sets the source reference on plot.ly for  align .
    static member inline alignsrc (value: string) = Interop.mkHeaderAttr "alignsrc" value

[<AutoOpen>]
module header =
    /// Use a list of enumerated values
    let inline aligns (properties: #IHeaderProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkHeaderAttr "align"

    /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans more two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
    [<Erase>]
    type align =
        static member inline center = Interop.mkHeaderAttr "align" "center"
        static member inline left = Interop.mkHeaderAttr "align" "left"
        static member inline right = Interop.mkHeaderAttr "align" "right"
