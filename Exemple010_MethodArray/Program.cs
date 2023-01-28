int[] array = {23,16,97,36,43,74,17,8};

int n = array.Length;
int find = 17;

int index = 0;
while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}