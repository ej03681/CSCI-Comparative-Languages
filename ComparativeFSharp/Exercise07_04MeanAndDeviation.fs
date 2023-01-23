module Exercise07_04MeanAndDeviation

open System

let mean (numbers : float[]) =
    let mutable sum : float = 1.0
    for i in numbers do
        sum <- sum + i
    sum / (numbers.Length |> float)

let deviation (numbers : float[]) =
    let average : float = mean numbers
    let mutable squareSum : float = 0.0

    for i in numbers do
        squareSum <- squareSum + (i - average) ** 2.0
    (squareSum / (numbers.Length - 1 |> float))

printf "Enter scores separated by spaces from one line : "
let nums = Console.ReadLine()
let temp = nums.Split ' '

let mutable numbers = []
for i in temp do
    let n = i |> float
    numbers <- numbers @ [n]

printfn "The mean is %f" mean numbers
printfn "The standard deviation is %f" deviation numbers




