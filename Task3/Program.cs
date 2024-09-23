// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например:
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 

int ReadInt(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GenerateMatrix(int row, int col, int leftRange, int rightRange){
    int [,] tempMarix = new int[row, col];
    Random rand = new Random();
    for(int i = 0; i < tempMarix.GetLength(0); i++){
        for(int j = 0; j < tempMarix.GetLength(1); j++){
            tempMarix[i, j] = rand.Next(leftRange, rightRange +1);
        }
    }
    return tempMarix;
}

void PrintMatrix(int [,] matrixForPrint){
    for(int i = 0; i < matrixForPrint.GetLength(0); i++){
        for(int j = 0; j < matrixForPrint.GetLength(1); j++){
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int [] SumRows(int[,] matrixRowsSum){
    int[] sumRow = new int[matrixRowsSum.GetLength(0)];
    for (int i = 0; i < matrixRowsSum.GetLength(0); i++){
        for (int j = 0; j < matrixRowsSum.GetLength(1); j++){
            sumRow[i] += matrixRowsSum[i, j];
        }
    Console.Write($"{sumRow[i]} ");
    }
    return sumRow;
}

void minElementRow (int[] arrayElement){
    int minElement = 0;
    for (int i = 0; i < arrayElement.Length; i++){
        if (arrayElement[minElement] > arrayElement[i])
            minElement = i;
    }
    Console.Write($"Наименьшая сумма элементов: {arrayElement[minElement]}");
    Console.WriteLine();
    Console.Write ($"Строка с наименьшей суммой: {minElement+1}");
}


int rows = ReadInt("Введите количество строк в массиве: ");
int cols = ReadInt("Введите количество столбцов в массиве: ");
int [,] matrix = GenerateMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);
System.Console.WriteLine();
int [] array = SumRows(matrix);
System.Console.WriteLine();
minElementRow(array);
