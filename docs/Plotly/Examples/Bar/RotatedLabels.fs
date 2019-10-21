﻿[<RequireQualifiedAccess>]
module Samples.Bar.RotatedLabels

open Feliz
open Feliz.Plotly

let xData = [ "Jan"; "Feb"; "Mar"; "Apr"; "May"; "Jun"; "Jul"; "Aug"; "Sep"; "Oct"; "Nov"; "Dec" ]
let yData = [ 20; 14; 25; 16; 18; 22; 19; 15; 12; 16; 14; 17 ]
let yData2 = [ 19; 14; 22; 14; 16; 19; 15; 14; 10; 12; 12; 16 ]

let chart () =
    Plotly.plot [
        plot.data [
            data.bar [
                bar.x xData
                bar.y yData
                bar.text "Primary Product"
                bar.textposition.auto
                bar.hoverinfo.none
                bar.marker [
                    bar.marker.color (colors.rgb(49, 130, 189))
                    bar.marker.opacity 0.7
                ]
            ]
            data.bar [
                bar.x xData
                bar.y yData2
                bar.text "Secondary Product"
                bar.textposition.auto
                bar.hoverinfo.none
                bar.marker [
                    bar.marker.color (colors.rgb(204, 204, 204))
                    bar.marker.opacity 0.5
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "2013 Sales Report"
            ]
            layout.xaxis [
                layout.xaxis.tickangle -45
            ]
            layout.bar [
                layout.bar.barmode.group
            ]
        ]
    ]