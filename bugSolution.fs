let mutable x = 0
let y = fun () -> x + 1
printf "%d %d" (y ()) x
x <- 1
printf "%d %d" (y ()) x