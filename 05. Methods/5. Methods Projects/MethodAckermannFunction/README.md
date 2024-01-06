# Ackermann Function Implementation

## Task

Write a C# program to implement the Ackermann function using recursion.

```
A(2, 5), A(1, 2)
```

## Ackermann Function Definition
The Ackermann function is defined as follows:

```        
A(n, m) = m + 1 if n = 0,
A(n, m) = A(n - 1, 1) if n ≠ 0 and m = 0,
A(n, m) = A(n - 1, A(n, m - 1)) if n > 0 and m > 0.

```

## Reference
[Ackermann Function](https://en.wikipedia.org/wiki/Ackermann_function)
