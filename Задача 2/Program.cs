// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] GenerateArray(int size, int leftRange, int rightRange){
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(leftRange, rightRange +1);
    }
    return array;
}
void PrintArray(int[] arrayForPrint)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.Write("]");
}
int CountNumbers(int[] imputArray){
    int count = 0;
    for (int i = 0; i < imputArray.Length; i++){
        if (imputArray[i] % 2 == 0){
            count++;
        }
    }
    return count;
}

//_________________________________________

int[] myArray = GenerateArray(10, 100, 999);
PrintArray(myArray);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве: {CountNumbers(myArray)}");
