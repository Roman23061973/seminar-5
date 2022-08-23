
int[] array = new int[123];
Random rand = new Random();
int count = 0;
for(int i = 0; i< array.Length; i ++)

{ 
    array[i] = rand.Next(0,151);
    if(array[i] >= 10 && array[i] <= 99)
    {
        count ++;
    }

}
Console.WriteLine(string.Join(", ",array));
Console.WriteLine($"Лоличествоэдементов массива, значения которых лежат в отрезке [10,99] = {count}");


    