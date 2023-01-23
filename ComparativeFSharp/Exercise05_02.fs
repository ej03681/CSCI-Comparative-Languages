module Exercise05_02

open System

let mutable tuition:float = 10000.0
let mutable yearlyIncrease:float = 0.05
let mutable fourYearCost:float = 0.0

for i in [1..10] do
    tuition <- tuition + (tuition * yearlyIncrease)

printfn "Tuition in 10 years: $%.2f" tuition

for i in [2..5] do 
    fourYearCost <- fourYearCost + tuition
    tuition <- tuition + (tuition * yearlyIncrease)

printfn "Total tution : $%.2f" fourYearCost
