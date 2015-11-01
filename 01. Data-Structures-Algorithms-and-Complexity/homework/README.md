## Data Structures, Algorithms and Complexity Homework

1. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      
      // The complexity of the for-loop is n
      // Because we have n iterrations
      for (int i = 0; i < arr.Length; i++)
      {
          int start = 0, end = arr.Length - 1;
          
          // The complexity of the while-loop is n
          // Because in the worst case scenario (the numbers are sorted - desc or asc)
          // we will have n itterations
          while (start < end)
              if (arr[start] < arr[end])
              {
                start++;
                count++;
              }
              else 
              {
                end--;
              }
      }
      
      return count;
  }
  ```
  Answer: The expected running time of the code is O(n*n). The complexity of the code is Quadratic.
  P.S. Note that there are comments in the code above.

2. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      
      // let's assume that matrix.GetLength(0) = n
      // and matrix.GetLength(1) = m
      
      // we have n itterations in the outer for-loop
      // so the complexity is n
      for (int row=0; row<matrix.GetLength(0); row++)
      
          // worst case -> this is always true
          if (matrix[row, 0] % 2 == 0)
          
              // we have m itterations in the inner for-loop
              // we have complexity m
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
  Answer: The expected running time is O(n*m). The complexity is n*m.
  P.S. Note that there are comments in the code above.

3. **(*) What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      
      // let's assume that matrix.GetLength(0) = n
      // and matrix.GetLength(1) = m
      
      // The complexity here is n -> we have n itterations
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
          
      // Worst case is if row = 0
      // Then we will exec CalcSum method for all the rows
      // This is complexity m
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  // That is actually calculating the sum of every cell in the matrix
  // Row by row, starting from row 0
  Console.WriteLine(CalcSum(matrix, 0));
  ```
Answer: The expected running time of the code is O(n*m). The complexity is n*m.
