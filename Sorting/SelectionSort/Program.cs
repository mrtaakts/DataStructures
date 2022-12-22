List<int> list = new List<int>();
list.AddRange(new int[] { 72, 54, 59, 30, 31, 78, 2, 77, 82, 12 });
list = SortBySelectionSort(list);
list.ForEach(listElement => Console.WriteLine($"{list.IndexOf(listElement)} - value:{listElement} "));

static List<int> SortBySelectionSort(List<int> list)
{
    for (int i = 0; i < list.Count - 1; i++)
    {
        int MinIndex = i;
        for (int j = i + 1; j < list.Count; j++)
            if (list[j] < list[MinIndex])
                MinIndex = j;

        int smallerNumber = list[MinIndex];
        list[MinIndex] = list[i];
        list[i] = smallerNumber;
    }
    return list;
}
