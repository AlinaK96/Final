string [] inputArray = {"one" , "two0" ,  "hello" , "rus", "test", "Developer", "GeekBrains"};
int newSize = 0;

for (int i = 0; i < inputArray.Length; i++)
{
   if (inputArray[i].Length <= 3)
   {
    newSize++;
   } 
}

string [] newArray = new string[newSize];

int index= 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        newArray[index] = inputArray[i];
        index++;
    }
}
