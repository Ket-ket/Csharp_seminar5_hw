// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например:
// 4 3 1  =>  4 6 2
// 2 6 9  =>  2 6 9
// 4 6 2  =>  4 3 1

int ReadInt(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange){
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for(int i = 0; i < tempMatrix.GetLength(0); i++){
        for(int j = 0; j < tempMatrix.GetLength(1); j++){
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint){
    for(int i = 0; i < matrixForPrint.GetLength(0); i++){
        for(int j = 0; j < matrixForPrint.GetLength(1); j++){
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ChangeElements(int[,] matrixChange, int i){
    int temp = matrixChange[0, i];
    matrixChange[0, i] = matrixChange[matrixChange.GetLength(0) - 1, i]; 
    matrixChange[matrixChange.GetLength(0) - 1, i] = temp;
}

int[,] ChangeRows(int[,] matrixForChange){    
    for (int i = 0; i < matrixForChange.GetLength(1); i++){
        ChangeElements(matrixForChange, i);
    }
    return matrixForChange;
}

void PrintResult(int[,] matrixResult){
    PrintMatrix(ChangeRows(matrixResult));  
    }

int rows = ReadInt("Введите количество строк в массиве: ");
int cols = ReadInt("Введите количество столбцов в массиве: ");
int[,] matrix = GenerateMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintResult(matrix);

