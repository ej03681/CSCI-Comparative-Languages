module Exercise05_01

open System

let mutable pos = 0
let mutable neg = 0
let mutable count = 0
let mutable total = 0
printf "Enter an integer, the input end if it is 0: "

let mutable n = Console.ReadLine()
let mutable t1 = (int n)

while t1 <> 0 do
    if t1 > 0 then 
        pos <- pos + 1
    elif t1 < 0 then 
        neg <- neg + 1

    total <- total + t1
    count <- count + 1

    printf "Enter an integer, the input end if it is 0: "
    n <- Console.ReadLine()
    t1 <- (int n)
    


if count = 0 then 
    printf "No numbers are entered except 0"
else 
    printfn "The number of positives is %i" pos  
    printfn "The number of negatives is %i" neg 
    printfn "The total is %i" total
    printfn "The average is %f" ((float total) / (float count))

