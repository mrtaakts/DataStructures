List<int> list = new List<int>();
list.AddRange(new int[] { 72, 54, 59, 30, 31, 78, 2, 77, 82, 12 });
list = SortByInsertionSort(list);
list.ForEach(listElement => Console.WriteLine($"{list.IndexOf(listElement)} - value:{listElement} "));

static List<int> SortByInsertionSort(List<int> list)
{
    for(int i = 1; i < list.Count; i++)
    {
        int temp = list[i];
        int j = i - 1;
        while(j >= 0 && list[j] > temp)
        {
            list[j+1] = list[j];
            j--;
        }
        list[j+1] = temp;
    }
    return list;
}