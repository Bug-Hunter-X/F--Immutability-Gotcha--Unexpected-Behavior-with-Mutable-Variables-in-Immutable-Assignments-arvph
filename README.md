# F# Immutability Gotcha: Unexpected Behavior with Mutable Variables in Immutable Assignments

This example demonstrates a common pitfall in F#:  the seemingly counter-intuitive behavior when using mutable variables within an expression that's then assigned to an immutable value.

## The Bug

In F#, immutability is the default.  However, mutable variables (`let mutable`) can be declared.  The surprising behavior occurs when a mutable variable is used in an expression, and the result of that expression is then assigned to an immutable value. Subsequent changes to the mutable variable *do not* affect the immutable value.

The `bug.fs` file contains code that illustrates this issue.  The variable `z` is assigned the result of `x + y`. Although `x` is modified later, `z` retains its original value because it is immutable. 

## The Solution

The solution involves understanding and embracing F#'s immutability. If you need a value that reflects the ongoing changes of mutable variables, you need to recalculate it whenever the mutable variables change. The solution file demonstrates this using a function which updates the value dynamically.