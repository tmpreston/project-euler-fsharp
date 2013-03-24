#light
[<EntryPoint>]
let main argv =
    
    let sw = System.Diagnostics.Stopwatch()
    ignore(sw.Start)
    //Call current problem
    

    let result = Problem2.answer
    System.Diagnostics.Debug.WriteLine("Answer: {0}", result)

    //End problem and display timing
    ignore(sw.Stop)
    System.Diagnostics.Debug.WriteLine("Time elapsed: {0}", sw.Elapsed)
    0