module FinalExam

//Edgar Jaimes
open System

printf "Enter integers in one line : "
let nums = Console.ReadLine()
let temp = nums.Split ' '

let mutable scores = []
for i in temp do
    let n = i |> int
    scores <- scores @ [n]

let mutable max = 0
for i in scores do
    if i > max then
        max <- i

let mutable count = 0
for i = 0 to scores.Length - 1 do
        if max = scores.[i] then 
            count <- count + 1

printfn "The largest number is %i" max
printfn "The occurrence count of the largest number is %i" count