// Прописали 2 метода: 1 для заполнения массива, другой для печати его. 
// Затем прописали наш массив, он будет состоять из 10 элементов.
// вызвали методы - заполнили наш массив и распечатали.

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

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);