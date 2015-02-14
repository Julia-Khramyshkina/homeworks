let main argv = 
    printfn "%A" argv

System.Console.WriteLine("Please enter a number for the factorial")
let startValue = System.Console.ReadLine()
let result : int = int startValue   

let rec factorial n = 
    if n = 0 
    then 1 
    else n * factorial(n - 1)
System.Console.WriteLine(factorial result)
0