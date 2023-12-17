// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

    


int[] NewArray (){
string str = number.ToString();
int[] array = new int[str.Length];
for(int i = 0; i < str.Length; i++)
{
array[i] = int.Parse(str[i].ToString());
}
return array;
}

int Summa(int sum){
int[] myArray = NewArray();
for(int i = 0; i < myArray.Length - 1; i++)
{
    sum = myArray.Sum();
}
return sum;
}
//--------------------

int sum = Summa(number);
if (number < 10){
    System.Console.WriteLine("Введено слишком короткое число");
}
if (number > 2){
    sum /= 2;
}
if (sum % 2 == 0){
   System.Console.WriteLine("Число четное, программа выполнена"); 
}

// Не получается зациклить ()бесконечно) ввод с консоли, чтобы и программа считала, подскажете как это сделать? 
// Над задачей честно работал 5 с половиной часов...