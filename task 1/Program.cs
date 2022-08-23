
int[] array = new int[5];
Random  rand = new Random();
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100,1000);
    if(array[i] % 2 ==0 )
    {
        count ++;
    }

    
}
Console.WriteLine(string.Join(", ",array));
Console.WriteLine($"Кодичество четных чисел в массиве = {count}");




