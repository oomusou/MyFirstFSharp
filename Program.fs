open System

[<EntryPoint>]
let main argv =
    let numbers = [1; 2; 3; 4; 5]

    let isOdd x = x % 2 <> 0
    let square x = x * x
    let addOne x = x + 1
    
    let func values =
        let odds = List.filter isOdd values
        let squares = List.map square odds
        let result = List.map addOne squares
        result
        
    printfn "%A" (func numbers)
    
    0