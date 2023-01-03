// int ReadInt()
// {
// Console.WriteLine("Input row/column numbers");
// int m = int.Parse(Console.ReadLine());
// return m;
// }
// int [,] MakeFillArray(int Length1, int Length2)
// {
//  int[,] arr = new int[Length1, Length2];
//  for(int i = 0; i < Length1; i++)
//  {
//   for(int j = 0; j < Length2; j++)
//   arr[i, j] = new Random().Next(-100,101);
//  }
//   return arr;
// }
// void PrintArray(int[,] Arr)
// {
//  for(int i = 0; i < Arr.GetLength(0); i++)
//  {
//   for(int j = 0; j < Arr.GetLength(1); j++)      
//   Console.Write($"{Arr[i,j]} ");
//   Console.WriteLine();
//  }
// }
// void UpdateArray(int [,] Arr)
// {  
//   for(int k = 0; k < Arr.GetLength(0); k++)
//   {
//     for(int j = 0; j<Arr.GetLength(1); j++)
//      {
//       for(int i = j+1; i<Arr.GetLength(1); i++)
//        {
//         if(Arr[k,i] > Arr[k,j])
//         {
//          int Temp = Arr[k,i];
//          Arr[k,i] = Arr[k,j];
//          Arr[k,j] = Temp;
//         }
//        }
//       Console.Write($"{Arr[k,j]} ");
//      }
//     Console.WriteLine();  
//   }
//  }     
// int[,] Array = MakeFillArray(ReadInt(),ReadInt());
// PrintArray(Array);
// Console.WriteLine();
// UpdateArray(Array);

// int ReadInt()
// {
//   Console.WriteLine("Input row/column numbers");
//  int m = int.Parse(Console.ReadLine());
//  return m;
// }
// int [,] MakeFillArray(int Length1, int Length2)
// {
//   int[,] arr = new int[Length1, Length2];
//   for(int i = 0; i < Length1; i++)
//   {
//     for(int j = 0; j < Length2; j++)
//     arr[i, j] = new Random().Next(-100,101);
//   }
//   return arr;
// }
// void PrintArray(int[,] Arr)
// {
//   for(int i = 0; i < Arr.GetLength(0); i++)
//  {
//   for(int j = 0; j < Arr.GetLength(1); j++)      
//   Console.Write($"{Arr[i,j]} ");
//   Console.WriteLine();
//  }
// }
// void FindMinRowSum(int [,] Arr)
// {
//  int[] row = new int[Arr.GetLength(0)];
//  int Min = row[0];
//  int MinIndex = 0;
//  for(int i = 0; i < Arr.GetLength(0); i++)
//  {
//   int Sum =0;
//   for(int j = 0; j < Arr.GetLength(1); j++)
//   {
//    row[i] = Sum+=Arr[i, j];
//   }
//    if(row[i] < Min)
//   {
//    Min = row[i];
//    MinIndex = i;
//   }
//  }
//  Console.Write($"Min sum cells row from top  is {MinIndex+1} ");
// }     
// int[,] Array = MakeFillArray(ReadInt(),ReadInt());
// PrintArray(Array);
// Console.WriteLine();
// FindMinRowSum(Array);

// int[,] CreateMatrix(int x,int y,int a)
// {
//   int[,] matrix = new int[x,y];
//   for(int i=0;i<x;i++)
//   {
//    Console.WriteLine($"Input numbers of matrix {a} row {i+1}");
//    for(int j=0;j<y;j++)
//    {
//     matrix[i,j] = int.Parse(Console.ReadLine());
//    }
//   }
//    Console.WriteLine();
//    for(int i=0;i<x;i++)   
//   {  
//    for(int j=0;j<y;j++)
//    {
//     Console.Write($"{matrix[i,j]} "); 
//    }
//    Console.WriteLine();
//   }
//   return matrix;
// }  
// int[,] ProductOfTwoMatrxs(int[,] arr1,int [,] arr2)
// {
//  Console.WriteLine();
//  int[,]product = new int[arr1.GetLength(0),arr2.GetLength(1)];
//  for(int i=0;i<arr1.GetLength(0);i++)
//  {
//   for(int j=0;j<arr2.GetLength(1);j++)
//   {
//    for(int k=0;k<arr1.GetLength(1);k++)
//    {
//     product[i,j]+=arr1[i,k]*arr2[k,j];
//    }
//    Console.Write($"{product[i,j]} ");
//   }
//    Console.WriteLine();
//  }
//  return product;
// }
//  Console.WriteLine("Input number of matrix 1 rows");
//  int m = int.Parse(Console.ReadLine());
//  Console.WriteLine("Input number of matrix 1 columns equal to the number of matrix 2 rows");
//  int l = int.Parse(Console.ReadLine());
//  Console.WriteLine("Input number of matrix 2 columns");
//  int n = int.Parse(Console.ReadLine()); 
// ProductOfTwoMatrxs(CreateMatrix(m,l,1),CreateMatrix(l,n,2));

// Console.WriteLine("Enter dimension sizes of threeD array, less than 14 in sum");
// int l = int.Parse(Console.ReadLine());
// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// if(l+m+n<14)
// {
//  int[]arr=Enumerable.Range(10,11+l*m*n).ToArray();
//  int[,,]array=new int[l,m,n];
//  int y=0;
//  for(int i=0;i<l;i++)
//  {
//   for(int j=0;j<m;j++)
//   {
//    for(int k=0;k<n;k++)
//    {    
//      array[i,j,k]=arr[y];
//      y++;    
//      Console.Write($"{array[i,j,k]} ({i},{j},{k}), "); 
//    }  
//    Console.WriteLine();
//   }
//  }
// }
// else Console.WriteLine("Sum of dimensions is not less than 14");

// int n=4;
// int[,]matrix=new int[n,n];
//   int row=0;  
//   int col=0;
//   matrix[row,col]=1; 
//   for(int i=0;i<n;i++)
//   {
//    matrix[i,0]=i+1;
//   } 
//   for(int i=0;i<n;i++)
//   {
//    matrix[n-1,i]=matrix[n-1,0]+i;
//   } 
//   for(int i=n-2;i>=0;i--)
//   {
//    matrix[i,n-1]=matrix[n-1,n-1]+n-1-i; 
//   }
//   for(int i=n-2;i>0;i--)
//   {
//    matrix[0,i]=matrix[n-1,0]+(n-1)*(n-1)-i;  
//   }
//   for(int i=1;i<n-1;i++)
//   {
//    matrix[i,1]=matrix[0,1]+i; 
//   }
//   for(int i=2;i<n-1;i++)
//   {
//    matrix[n-2,i]=matrix[n-2,i-1]+1; 
//   }
//   for(int i=n-3;i>0;i--)
//   {
//    matrix[i,n-2]=matrix[n-2,i+1]+1; 
//   }
//  for(int j=0;j<n;j++)
//  {
//   for(int i=0;i<n;i++)
//   {
//    Console.Write($"{matrix[i,j].ToString("D2")}  ");
//   }
//   Console.WriteLine();
//  }
