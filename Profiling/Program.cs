static List<int> BubbleSort(List<int> list) //Bubble Sort
{
    int temp;
    bool swap = false;
    do
    {
        swap = false;
        for (int j = 0; j <= list.Count - 2; j++)
        {
            if (list[j] > list[j + 1])
            {
                temp = list[j + 1];
                list[j + 1] = list[j];
                list[j] = temp;
                swap = true;
            }
        }
    }
    while (swap);

    return list;
}

static List<int> AutoSort(List<int> list)
{
    list.Sort(); //Predefined Method 
    return list;
}

static void PrintList(List<int> list, string title)
{
    Console.Write($"{ title }: ");

    foreach (int num in list)
        Console.Write($" {num} ");

    Console.Write("\n");
}

static void PrintStats(List<int> list)
{
    //Count
    Console.WriteLine($"Count: {list.Count}");

    //Mean
    Console.WriteLine($"Mean: { list.Sum() / list.Count}");

    //Median
    int mid = (list.Count / 2) - 1;
    Console.WriteLine($"Median: { list[mid]}");

    //Mode

    Dictionary<int, int> modes = new Dictionary<int, int>();

    foreach (int num in list)
    {
        if (modes.ContainsKey(num))
        {
            modes[num] += 1;
        }
        else
        {
            modes[num] = 1;
        }
    }

    int mode = 0;
    foreach (KeyValuePair<int, int> item in modes)
    {
       if (item.Value > mode)
            mode = item.Key;
    }

    Console.WriteLine($"Mode: { mode }");
    
}

List<int> list = new List<int> { 12, 54, 54, 1, 22, 11, 7, 99 };

PrintList(list, "Original List");

list = AutoSort(list);

PrintList(list, "Sorted List");

PrintStats(list);