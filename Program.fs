// Learn more about F# at http://fsharp.org

open System

open Farmer
open Farmer.Builders


[<EntryPoint>]
let main argv =
    let outputFile = 
        match argv with
        | [| _ |] -> "myFirstTemplate"
        | [| _; fname |] -> fname

    let myWebApp = webApp {
        name "yourFirstFarmerApp"
    }

    let deployment = arm {
        location Location.WestEurope
        add_resource myWebApp
    }

    printfn "Writing ARM template to %s..." outputFile

    deployment
    |> Writer.quickWrite outputFile

    0 // return an integer exit code

