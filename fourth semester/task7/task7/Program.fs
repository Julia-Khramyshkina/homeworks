open System.ComponentModel

let numberOfStreams = 100
let sum : int ref = ref 0
          
type backgroundWorkerFor100(number) =
    let length = 1000000
    let array = Array.create length 1
    let start = number * (length / numberOfStreams)
    let finish = (number + 1) * (length / numberOfStreams) - 1
    
    let worker = new BackgroundWorker()

    let completed = new Event<_>()
    let error = new Event<_>()
    let cancelled = new Event<_>()          

    do worker.DoWork.Add(fun args -> 
        let rec sumPart startP finishP  =
            if worker.CancellationPending then
                args.Cancel <- true
            elif (finishP - startP > 0) then
               sum := !sum + array.[startP]
               let startP = startP + 1
               sumPart startP finishP
            else
               args.Result <- sum   
        sumPart start finish)

    do worker.RunWorkerCompleted.Add(fun args ->
        if args.Cancelled then cancelled.Trigger ()
        elif args.Error <> null then error.Trigger args.Error
        else completed.Trigger (args.Result :?> int))

    member x.WorkerCompleted = completed.Publish
    member x.WorkerCancelled = cancelled.Publish
    member x.WorkerError = error.Publish

    member x.RunWorkerAsync() = worker.RunWorkerAsync()
    member x.CancelAsync() = worker.CancelAsync()

let backgroundWorkers = [|for i in 0..numberOfStreams - 1 -> new backgroundWorkerFor100(i)|]

for i in 0..numberOfStreams - 1 do
   backgroundWorkers.[i].RunWorkerAsync()

printfn "%d" !sum