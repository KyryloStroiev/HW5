int[] arr = new[] { 1, 2, 3 };

AddX(arr, 5);



foreach (var item in arr)

{

    Console.Write(item);

}



static void AddX(int[] arr, int x)

{

    for (var i = 0; i < arr.Length; ++i)

    {

        arr[i] += x;

    }

}