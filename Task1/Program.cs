// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например:
// 4 3 1     (1,2) => 9
// 2 6 9 

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

// 1 вариант:

// void returnValue(int rowNumber, int colNumber, int [,] matrixForReturn){
//     int rowSize = matrixForReturn.GetLength(0);
//     int colSize = matrixForReturn.GetLength(1);
//     if (rowNumber <= rowSize && colNumber <= colSize){
//         System.Console.WriteLine($"Значение элемента в [{rowNumber}] строке и [{colNumber}] столбце => {matrixForReturn[rowNumber, colNumber]}");
//     } else {
//         Console.WriteLine("Такого числа в массиве нет");
//     }   
// }

// 2 вариант:
 
void returnValue(int rowNumber, int colNumber, int [,] matrixForReturn){
    bool flag = true;
    for(int i = 0; flag && i < matrixForReturn.GetLength(0); i++){
        for(int j = 0; flag && j < matrixForReturn.GetLength(1); j++){
            if(i == rowNumber && j == colNumber){
                System.Console.WriteLine(matrixForReturn[i, j]);
                break;
            } else if(rowNumber > matrixForReturn.GetLength(0) && colNumber > matrixForReturn.GetLength(1)){
                flag = false;
                System.Console.WriteLine("Такого элемента нет");
                break;
            }                           
        }        
    }    
}



int rows = ReadInt("Введите количество строк в массиве: ");
int cols = ReadInt("Введите количество столбцов в массиве: ");
int [,] matrix = GenerateMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);
int rowNumber = ReadInt("Введите номер строки: ");
int colNumber = ReadInt("Введите номер столбца: ");
returnValue(rowNumber, colNumber, matrix);
