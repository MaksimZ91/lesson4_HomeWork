//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень числа: ");
// int index =  Convert.ToInt32(Console.ReadLine());

// int Exponentiation (int number, int index)
// {
//   int result = 1;
//   for(int i = 0; i < index; i++)
//   {
//     result *=number;
//   }
//   return result;
// }

// Console.WriteLine(Exponentiation(number,index));
// Console.WriteLine(Math.Pow(number, index)); //проверка решения



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum (int number)
// {
//   int result = 0;
//   while(number > 0)
//   {
//     result += number % 10;
//     number /= 10;
//   }
//   return result;
// }
// Console.Write(sum(number));

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int arrayLength = 8;
// int[] array = new int [arrayLength];
// for (int i = 0; i < array.Length; i++)
// {
//   Console.Write("Введите число № " + (i+1) + ": ");
//   array[i]= Convert.ToInt32(Console.ReadLine());
// }
// Console.Write ("[ " + string.Join(", ", array) + " ]" );


//Дополнительная задача

int N = new Random().Next(3, 1001);
Console.WriteLine("Всего кустов черники: " + N);
// Console.Write("Введите требуемое количество кустов: "); //Можем не генерировать количество кустов, 
// int N = Convert.ToInt32(Console.ReadLine());            //а запрашивать у пользователя. (не совсем понял какой вариант подразумевает задание)
// while ( N < 3 || N > 1000) 
// {
//   Console.Write("Введите требуемое количество кустов: "); 
//   N = Convert.ToInt32(Console.ReadLine());
// }
int[] array = new int [N];
for (int i = 0; i <= array.Length-1; i++)
{
  array[i] = i+1;
}
Console.Write("Введите номер куста в диапозоне от " + array[0] + " до " + array[array.Length-1] + ": ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (array[number-1] == array[array.Length-1]) //выбран крайний  куст => обрабатываем его и два куста слева от него.
result = number * 3 - 3;
else if(array[number-1] == array[array.Length-2]) // выбран предпоследний куст => обрабатываем его и кусты слева и справа от него.
result = number * 3;
else                                            // выбран любой другой куст от первого до предпоследнего => обрабатываем  его и два куста справа от него.
result = number * 3 + 3;
Console.WriteLine("Максимальное число ягод, которое можно собрать за один заход: " + result);





