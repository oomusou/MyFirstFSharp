open System

[<EntryPoint>]
let main argv =
    let numbers = [1; 2; 3; 4; 5]

    let isOdd x = x % 2 <> 0
    let square x = x * x
    let addOne x = x + 1
    let sqaureAddOne = square >> addOne
    
    let func = List.filter isOdd  >> List.map sqaureAddOne
    
    printfn "%A" (func numbers)
    
    0