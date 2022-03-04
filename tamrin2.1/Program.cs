Console.WriteLine("please enter interger array:");
var input = Console.ReadLine();
string[] inputArray = input.Split(',');
for (int i = 0; i < inputArray.Length; i++)
{
    inputArray[i] = inputArray[i].Trim();
}
int[] inputNumber = new int[inputArray.Length];

for (int i = 0; i < inputArray.Length; i++)
{
    inputNumber[i] = Convert.ToInt32(inputArray[i]);
}
Console.WriteLine("1-min");
int t = Convert.ToInt32(Console.ReadLine());
switch (t)
{
    case 1:
        Console.WriteLine(min(inputNumber);
        break;
    default:
        break;
}


int min(int[] array,)
{
    int min = array[0];
    foreach (var item in array)
    {
        if (item<min)
        {
            min = item;
        }
    }
    return min;
}