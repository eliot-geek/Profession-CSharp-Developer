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

## Overview

The Ackermann function is a recursive mathematical function that takes two non-negative integer arguments `n` and `m` and returns a non-negative integer value. It is defined by a set of recursive rules and is notable for being one of the simplest examples of a computable but not primitive recursive function. The Ackermann function grows very quickly as the values of `n` and `m` increase, making it a useful tool for analyzing the efficiency of algorithms and computing systems.

## Reference

[Ackermann Function](https://en.wikipedia.org/wiki/Ackermann_function)

[Table of Values](https://en.wikipedia.org/wiki/Ackermann_function#Table_of_values)
