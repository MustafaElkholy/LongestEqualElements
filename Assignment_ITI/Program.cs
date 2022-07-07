int sizeOfArray;
Console.Write("Please Enter the size of the array:");
sizeOfArray = Convert.ToInt32(Console.ReadLine());

int[] Arr = new int[sizeOfArray];

Console.WriteLine("Please Enter the elements of the array:");
for (int i = 0; i < sizeOfArray; i++)
{
    Arr[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("--------------------------------");

//set value to distance 1 and distance 2
// distance 1 is the place of first element and distance 2  is the place of last element with the same value
// maxLength is the diffrence between the distance between two places

int maxLength = 0;
int distance1 = 0, distance2 = 0;

//declare the first array to check from the first element and the second one check the second element in the array

for (int i = 0; i < sizeOfArray; i++)
{
    for (int j = i + 1; j < sizeOfArray; j++)
    {
        // if the first element equal the second set distance1 = the place of the first element
        // and distance = the place of the second element
        if (Arr[i] == Arr[j])
        {
            distance1 = i;
            distance2 = j;
        }
        // always check if the diffrence between the places is greater than the calculated maxLength, if so set max length = d2-d1
        // if not let maxlength be the same as calculated before
        
        if (distance2 - distance1 > maxLength)
        {
            maxLength = distance2 - distance1;
        }
    }

}
// here we assume the first element in place 1 and the second equal element in place 10, so the diffrence between them is 10-1 = 8 
// as in array start with index 0 the maxLength in the loop is 9 so we abstract 1 from 9 to be the exact distance.
Console.WriteLine(maxLength - 1);


