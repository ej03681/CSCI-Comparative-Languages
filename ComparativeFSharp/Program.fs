// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let mutable x = 10
    printfn "%10i %s" x (if x > 1 then " times" else " time")

    while x < 10 do 
        x <- x + 1
        x <- x

    for i in [1 .. 10 ] do
        printfn "%f " ((float i) * 5.5)

    let f(x, y) = x + y
    printfn "%i" (f(1, 3))

    let f1()= 
        printfn "No return values"
    f1()

    let mutable colors = ["red"; "green"; "blue"]
    colors <- "purple" :: colors 
    colors <- colors @ ["orange"]

    let colors1 = ["red", "green", "blue"]
    printfn "%A" colors
    printfn "%s" colors.[1]
    printfn "%A" colors1.[0]

    printf "Enter a number: "
    let s = Console.ReadLine()
    let v1 = (int s)
    printfn "v1 is %i" v1


    printfn "Hello World from F#!"
    0 // return an integer exit code
