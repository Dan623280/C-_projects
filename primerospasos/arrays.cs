// Declare a single-dimensional array of 5 integers.
int[] array1 = new int[5];

// Declare and set array element values.
int[] array2 = [1, 2, 3, 4, 5, 6];

// Declare a two dimensional array.
int[,] multiDimensionalArray1 = new int[2, 3];

// Declare and set array element values.
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

// Declare a jagged array.
int[][] jaggedArray = new int[6][];

// Set the values of the first array in the jagged array structure.
jaggedArray[0] = [1, 2, 3, 4];

Console.WriteLine($@"

array1: {array1[3]}

array2: {array2[0]}

multiDimensionalArray1:  {multiDimensionalArray1}

multiDimensionalArray2 : {multiDimensionalArray2}

jagged array 1 is {jaggedArray[0][0]}

");

foreach (var numero in array1)
{
    Console.WriteLine(numero);
}