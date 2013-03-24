module CommonHelpers

  let takeWhile f (ie : #seq<'a>) =
    seq { use e = ie.GetEnumerator()
      while e.MoveNext() && f e.Current do
    yield e.Current }

  let isEven n = n % 2 = 0

  let isLessThanOrEqualTo x = (fun n -> n <= x)

  let sum s = Seq.fold (+) 0 s

