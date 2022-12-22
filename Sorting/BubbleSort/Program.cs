List<int> list = new List<int>();
list.AddRange(new int[] { 72, 54, 59, 30, 31, 78, 2, 77, 82, 12 });
list = SortByBubbleSort(list);
list.ForEach(listElement => Console.WriteLine($"{list.IndexOf(listElement)} - value:{listElement} "));

static List<int> SortByBubbleSort(List<int> list)
{
    int temp;
    for (int i = 0; i < list.Count; i++)
    {
        for (int j = 0; j < list.Count; j++)
        {
            if (list[j] > list[i])
            {
                temp = list[j];
                list[j] = list[i];
                list[i] = temp;
            }
        }
    }
    return list;
}



