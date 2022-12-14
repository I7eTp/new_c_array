/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 100;
int b2 = 23;
int c2 = 33;

int a3 = 13;
int b3 = 213;
int c3 = 303;

if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;
*/
/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
*/
/*
int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3)
    );

Console.WriteLine(max);
*/

/*
//Поиск максимума из "9" 
//Создание массива
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int [] array ={1, 21, 35, 400, 55, 60, 77, 81, 900};
array[0] = 12;
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));
    Console.WriteLine(max);
*/

/*
// Массив 
Console.Write("Ваше число  ");
int find = int.Parse(Console.ReadLine()!);

int [] array = {11, 12, 13, 44, 11, 25, 46, 17, 58};
int n = array.Length;

int index = 0;
while (index < n) 
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
   
    index++;    //index = index + 1;
}
*/

//Создадим новый массив используя заполнения случайными числами.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) 

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
//array[4] = 4; специально добавили 4
//array[8] = 4; специально добавили 4
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 400);
Console.WriteLine(pos);
