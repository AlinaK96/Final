string [] Array = {"one" , "two0" ,  "hello" , "rus", "test", "Developer", "GeekBrains"};
int size = 0;

for (int i = 0; i < Array.Length; i++)
{
   if (Array[i].Length <= 3)
    {
        size++;
    } 
}

string [] newArray = new string[size];

int index = 0;

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
        {
            newArray[index] = Array[i];
            index++;
        }
}

string PrintArray (string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            output+= ($"\"{array[i]}\"");
        }
        else
        output+= ($"\"{array[i]}\", ");
    }
    return output;
}
Console.WriteLine($"[{PrintArray(newArray)}]");