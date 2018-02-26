open System

[<EntryPoint>]
let main argv =
    let numbers = [1; 2; 3; 4; 5]

    let isOdd x = x % 2 <> 0
    let square x = x * x
    let addOne x = x + 1
    
    let func values =
        values 
        |> List.filter isOdd
        |> List.map(fun x -> x |> square |> addOne)
        
    printfn "%A" (func numbers)
    
    0