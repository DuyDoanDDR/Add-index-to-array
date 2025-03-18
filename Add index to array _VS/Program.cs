using System.ComponentModel.Design;

int[] array01 = new int[10];
array01[0] = 10;
array01[1] = 4;
array01[2] = 6;
array01[3] = 7;
array01[4] = 8;
int x;
int index;

//Nhap du lieu va kiem tra
Console.WriteLine("Enter an index: ");
while (true)
{
    if (int.TryParse(Console.ReadLine(), out x))
    {
        break;
    }
    else
    {
        Console.WriteLine("Index must be an integer / Enter again: ");
    }
}

Console.WriteLine("Enter expect position: ");
while (true)
{
    if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= array01.Length - 1)
    {
        break;
    }
    else
    {
        Console.WriteLine("Cannot add index to array / Enter again: ");
    }
}

//dich chuyen cac gia tri cua phan tu ra sau ke tu vi tri duoc chen
    for (int i = array01.Length - 1; i > index; i--)
    {
        array01[i] = array01[i - 1];
    }

array01[index] = x;

//In mang ra
Console.WriteLine("Array now: ");
foreach (int i in array01)
{
    
    Console.Write(i + " ");
}



