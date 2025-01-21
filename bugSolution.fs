let mutable x = 10
let mutable y = 20
let z () = x + y // z is now a function that calculates the sum, not an immutable value
printf "%d\n" (z ()) // Print 30
x <- 30
printf "%d\n" (z ()) // Print 50 (because now the function calculates the sum with updated values)

//Another example
let mutable sum = 0
let updateSum x y = sum <- x + y

updateSum 10 20
printf "%d\n" sum // prints 30
updateSum 10 30
printf "%d\n" sum//prints 40