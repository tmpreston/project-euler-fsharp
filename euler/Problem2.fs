#light
module Problem2
  open CommonHelpers

    let rec fibonacci nth =
      if nth = 0
      then 1
      else nth + (nth + 1)

    //http://diditwith.net/
    let fibonacciSequence =
        seq {
            let i = ref 1
            let j = ref 2
            while true do
            let x = !i
            yield x
            do i := !j
            do j := !j + x
        }

    let answer = fibonacciSequence 
                |> Seq.filter isEven
                |> Seq.takeWhile (isLessThanOrEqualTo 4000000)
                |> Seq.fold (+) 0
//4613732
