let mutable x = 10
let mutable y = 20
let z = x + y
printf "%d\n" z
x <- 30
printf "%d\n" z // z will still print 30, not 50 because z is immutable after it's assigned a value

//Another example
let add x y = x + y
let result = add 10 20
let result2 = add 10 30
printf "%d\n" result // prints 30
printf "%d\n" result2//prints 40