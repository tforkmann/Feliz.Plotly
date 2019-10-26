# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-labellinglineswithannotations
[<RequireQualifiedAccess>]
module Samples.Line.LabellingLinesWithAnnotations

open Feliz
open Feliz.Plotly

let xData = 
    [2001; 2002; 2003; 2004; 2005; 2006; 2007; 2008; 2009; 2010; 2011; 2013]
    |> List.replicate 4

let yData =
    [ [ 74; 82; 80; 74; 73; 72; 74; 70; 70; 66; 66; 69]
      [ 45; 42; 50; 46; 36; 36; 34; 35; 32; 31; 31; 28]
      [ 13; 14; 20; 24; 20; 24; 24; 40; 35; 41; 43; 50]
      [ 18; 21; 18; 21; 16; 14; 13; 18; 17; 16; 19; 23] ]

let plotColors = 
    [ colors.rgba(67, 67, 67, 1.)
      colors.rgba(115, 115, 115, 1.)
      colors.rgba(49, 130, 189, 1.)
      colors.rgba(189, 189, 189, 1.) ]

let lineSize = [ 2; 2; 4; 2 ]

let labels = ["Television"; "Newspaper"; "Internet"; "Radio"]

let traces' =
    [ 0 .. 3 ]
    |> List.collect (fun i ->
        [ traces.scatter [
            scatter.x xData.[i]
            scatter.y yData.[i]
            scatter.mode.lines
            scatter.line [
                line.color plotColors.[i]
                line.width lineSize.[i]
            ]
          ]
          traces.scatter [
            scatter.x xData.[i]
            scatter.y yData.[i]
            scatter.mode.markers
            scatter.marker [
                marker.color plotColors.[i]
                marker.size 12
            ]
          ] ])

let tracesAnnotations =
    [ 0 .. xData.Length-1 ]
    |> List.collect (fun i ->
        [ annotations.annotation [
            annotation.xref.paper
            annotation.x 0.05
            annotation.y yData.[i].Head
            annotation.xanchor.right
            annotation.yanchor.middle
            annotation.text (sprintf "%s %i%s" labels.[i] yData.[i].Head "%")
            annotation.font [
                font.family "Arial"
                font.size 16
                font.color colors.black
            ]
            annotation.showarrow false
          ]
          annotations.annotation [
            annotation.xref.paper
            annotation.x 0.95
            annotation.y yData.[i].[11]
            annotation.xanchor.left
            annotation.yanchor.middle
            annotation.text (sprintf "%i%s" yData.[i].[11] "%")
            annotation.font [
                font.family "Arial"
                font.size 16
                font.color colors.black
            ]
            annotation.showarrow false
          ]  
        ])

let chart () =
    Plotly.plot [
        plot.traces traces'
        plot.layout [
            layout.showlegend false
            layout.autosize false
            layout.height 400
            layout.width 1300
            layout.xaxis [
                xaxis.showline true
                xaxis.showgrid false
                xaxis.showticklabels true
                xaxis.linecolor (colors.rgb(204, 204, 204))
                xaxis.linewidth 2
                xaxis.ticks.outside
                xaxis.tickcolor (colors.rgb(204, 204, 204))
                xaxis.tickwidth 2
                xaxis.ticklen 5
                xaxis.tickfont [
                    tickfont.family "Arial"
                    tickfont.size 12
                    tickfont.color (colors.rgb(82, 82, 82))
                ]
            ]
            layout.yaxis [
                yaxis.showgrid false
                yaxis.zeroline false
                yaxis.showline false
                yaxis.showticklabels false
            ]
            layout.margin [
                margin.l 100
                margin.r 20
                margin.t 100
            ]
            layout.annotations [
                annotations.annotation [
                    annotation.xref.paper
                    annotation.yref.paper
                    annotation.x 0.5
                    annotation.y 1.05
                    annotation.xanchor.center
                    annotation.yanchor.bottom
                    annotation.text "Main Source for News"
                    annotation.font [
                        font.family "Arial"
                        font.size 30
                        font.color (colors.rgb(37, 37, 37))
                    ]
                    annotation.showarrow false
                ]
                annotations.annotation [
                    annotation.xref.paper
                    annotation.yref.paper
                    annotation.x 0.5
                    annotation.y -0.1
                    annotation.xanchor.center
                    annotation.yanchor.top
                    annotation.text "Source: Pew Research Center & Storytelling with traces"
                    annotation.font [
                        font.family "Arial"
                        font.size 12
                        font.color (colors.rgb(150, 150, 150))
                    ]
                    annotation.showarrow false
                ]
                yield! tracesAnnotations
            ]
        ]
    ]
```