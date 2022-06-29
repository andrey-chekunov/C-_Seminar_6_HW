// Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] stringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',') count++;

    }
    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string tempString = "";
        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                tempString += input[i].ToString();
                i++;
            }
            else
            {
                tempString += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(tempString);
        index++;
    }
    return numbers;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Enter the numbers separated by commas: ");
int[] numbers = stringToNum(Console.ReadLine());
PrintArray(numbers);
Console.WriteLine();
int countNumbers=0;
for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]>0) countNumbers++;
}
Console.WriteLine($"The number of numbers greater than zero: {countNumbers}");