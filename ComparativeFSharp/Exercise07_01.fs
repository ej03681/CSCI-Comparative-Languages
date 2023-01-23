module Exercise07_01

open System

printf "Enter scores separated by spaces from one line : "
let nums = Console.ReadLine()
let temp = nums.Split ' '

let mutable scores = []
for i in temp do
    let n = i |> int
    scores <- scores @ [n]

let mutable best = 0
for i in scores do
    if i > best then
        best <- i

let mutable grade = ""
for i = 0 to scores.Length - 1 do
    if scores.[i] >= best - 10 then
        grade <- "A"
    elif scores.[i] >= best - 20 then
        grade <- "B"
    elif scores.[i] >= best - 30 then
        grade <- "C"
    elif scores.[i] >= best - 40 then
        grade <- "D"
    else 
        grade <- "F"

    printfn "Student %i score is  %i and grade is %s" i scores.[i] grade