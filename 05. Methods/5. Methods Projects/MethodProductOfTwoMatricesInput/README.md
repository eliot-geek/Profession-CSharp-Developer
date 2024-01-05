# Task: Matrix Multiplication

## Description

Develop a method that takes two matrices as input and calculates their product.

### Tasks

1. Implement a method that accepts two matrices.
2. Ensure that the number of columns in the first matrix is equal to the number of rows in the second matrix; this is a prerequisite for matrix multiplication.
3. Multiply the matrices following the rules of matrix multiplication.
4. Return the resulting matrix.

The program should accept two matrices, validate their dimensions, perform matrix multiplication, and return the resulting product matrix.

## Example

Matrix A:

\[ 
\begin{bmatrix}
1 & 3 & 5 \\
4 & 5 & 7 \\
5 & 3 & 1 \\
\end{bmatrix}
\]

Matrix B:

\[ 
\begin{bmatrix}
1 & 3 & 4 \\
2 & 5 & 6 \\
3 & 6 & 7 \\
\end{bmatrix}
\]

Resulting Matrix C:

\[ 
\begin{bmatrix}
1 \cdot 1 + 3 \cdot 2 + 5 \cdot 3 & 1 \cdot 3 + 3 \cdot 5 + 5 \cdot 6 & 1 \cdot 4 + 3 \cdot 6 + 5 \cdot 7 \\
4 \cdot 1 + 5 \cdot 2 + 7 \cdot 3 & 4 \cdot 3 + 5 \cdot 5 + 7 \cdot 6 & 4 \cdot 4 + 5 \cdot 6 + 7 \cdot 7 \\
5 \cdot 1 + 3 \cdot 2 + 1 \cdot 3 & 5 \cdot 3 + 3 \cdot 5 + 1 \cdot 6 & 5 \cdot 4 + 3 \cdot 6 + 1 \cdot 7 \\
\end{bmatrix}
\]

Resulting Matrix C:

\[ 
\begin{bmatrix}
22 & 48 & 57 \\
35 & 79 & 95 \\
14 & 36 & 45 \\
\end{bmatrix}
\]
