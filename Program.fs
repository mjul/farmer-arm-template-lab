// Learn more about F# at http://fsharp.org

open System

open Farmer
open Farmer.Builders



[<EntryPoint>]
let main argv =

    let myWebApp = webApp {
        name "yourFirstFarmerApp"
    }

    let deployment = arm {
        location Location.NorthEurope
        add_resource myWebApp
    }

    deployment
    |> Writer.quickWrite "myFirstTemplate"

    0 // return an integer exit code

