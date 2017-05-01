open System
open Microsoft.FSharp.Collections

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let SomeArray = [2;3;1;451;45;1;1234;2;34]

let Add a = a + 23

let rec filt f list =
    match list with
       | [] -> []
       | (x::xs) when f x -> x :: filt f xs
       | (_::xs) -> filt f xs

let rec sort list = 
    match list with 
         | [] -> []
         | (x::xs) -> List.append (filt (fun i -> i < x) xs) (x :: (filt (fun i -> i >= x) xs))

[<EntryPoint>]
let main argv = 
    //Console.Out.WriteLine SomeArray sort 
    Console.Out.WriteLine (filt (fun f -> f >10) SomeArray)
    Console.Out.WriteLine (sort SomeArray)
    //let i  = Add 2
    //Console.Out.WriteLine i 
    Console.In.ReadLine()
    0 // return an integer exit code



