// Задача 3: Напишите программу, 
// которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

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

//______________________

int[] myArray = GenerateArray(10, 0, 100);
System.Console.WriteLine("Полученный случайным образом массив:");
PrintArray(myArray);
System.Console.WriteLine();

Array.Reverse(myArray);
System.Console.WriteLine("Мы перевернули, и получилось: ");
PrintArray(myArray);