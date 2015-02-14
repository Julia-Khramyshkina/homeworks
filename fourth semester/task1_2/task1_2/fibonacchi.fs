let main argv = 
    printfn "%A" argv
System.Console.WriteLine("Please enter a number for the Fibonacchi")
let startValue = System.Console.ReadLine()
let value : int = int startValue   

let f0 = 1
let f1 = 1
let rec fibonacchi n =
    if n <= 1
    then 1
    else fibonacchi(n - 1) + fibonacchi(n - 2)


if value = 0 
then System.Console.WriteLine(f0)
else if value = 1
then System.Console.WriteLine(f1)
else  System.Console.WriteLine(fibonacchi value)
0