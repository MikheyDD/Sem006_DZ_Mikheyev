// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую");
var nums = Console.ReadLine();
// if (nums is string)
// {
//     string[] numsArray = nums.Split(",");
//     int[] numsArrayConvert = ConvertNums(numsArray);
//     Print(numsArrayConvert);
//     Console.WriteLine();
//     Console.WriteLine(GetCount(numsArrayConvert));
// }
// else 
// {
//     Console.WriteLine("неверный ввод чисел");
// }
string[] numsArray = nums.Split(",");
int[] numsArrayConvert = ConvertNums(numsArray);
Print(numsArrayConvert);
Console.WriteLine();
Console.WriteLine(GetCount(numsArrayConvert));

int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] ConvertNums(string[] arr)
{
   int[] arrayConvert = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrayConvert[i] = Convert.ToInt32(arr[i]);
    }
    return arrayConvert;
}

void Print(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
}




// char[] separators = { ' ', ',' };
//         var arrayOfEnteredText = Console.ReadLine()
//             ?.Split(separators,
//                 StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);


// string numbers = Console.ReadLine();
//     int[] arr = numbers.Split(' ').Select(int.Parse).ToArray();
// вот так проще для понимания

// var enteredNumbers = GetEnteredNumbers("Введите числа через пробел или запятую :");
// static int[] GetEnteredNumbers(string outputText = "")
//     {
//         var arrayInts = Array.Empty<int>();
//         Console.WriteLine(outputText);
//         char[] separators = { ' ', ',' };
//         var arrayOfEnteredText = Console.ReadLine()
//             ?.Split(separators,
//                 StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
//         if (arrayOfEnteredText != null)
//         {
//             arrayInts = Array.ConvertAll(arrayOfEnteredText, s => int.Parse(s));
//         }
//         return arrayInts;
//     }
