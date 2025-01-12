# F# Mutable Variable Unexpected Behavior

This example demonstrates a common issue in F# related to mutable variables and how they interact with immutable bindings.  The code appears to modify a mutable variable (`x`), but the result is unexpected due to the way immutable bindings are handled.

## Bug

The code initializes a mutable variable `x` to 0.  It then creates an immutable binding `y` which is set to `x + 1`. Even after changing the value of `x`, the value of `y` remains unchanged. 

## Solution

The solution involves understanding that immutable bindings are created at the time of their declaration. They do not maintain a live reference to the mutable variable. To achieve the desired behavior, you need to either recalculate `y` when `x` changes or use a different approach that better suits the program's logic.