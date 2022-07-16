/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N + 1];
Cube(array);
PrintArray(array);

void Cube(int[] cube)
{
  int i = 1;
  int length = cube.Length;
  while (i < length)
  {
    cube[i] = Convert.ToInt32(Math.Pow(i, 3));
    i++;
  }
}


void PrintArray(int[] arg)
{
  int y = arg.Length;
  int index = 1;
  while(index < y)
  {
    Console.WriteLine( "куб от " + index + " = " + arg[index]);
    index++;
  }
}



 

