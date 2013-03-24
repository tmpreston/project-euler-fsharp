#light
module Problem1
    let sumMultiple upTo =
        let baseArray = [|1 .. upTo-1 |]
        let multiples = baseArray |> Array.filter (fun x -> x % 3 = 0 || x % 5 = 0)
        let sumOf = multiples |> Array.sum
        sumOf

    let answer = sumMultiple 1000