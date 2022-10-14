// See https://aka.ms/new-console-template for more information

int aSize;
Console.WriteLine("Enter the Array Size :");
aSize =Convert.ToInt32( Console.ReadLine());

int[] arrayData = new int[aSize];

Console.WriteLine("Enter the Array Elements :");
for (int i = 0; i < aSize; i++)
{
    arrayData[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("The Array Elements :");
for (int i = 0; i < aSize; i++)
{
    Console.WriteLine(arrayData[i]);
}
//comment
//hjgscj

//changes in shilpa branch


