Console.Write("Hello, Please enter the length of the Palindrome: ");
string readw = Console.ReadLine();
int w = Convert.ToInt32(readw);

Console.Write("Please enter total number of ablhabets inside the Palindrome: ");
string readx = Console.ReadLine();
int x = Convert.ToInt32(readx);

Console.Write("Please enter the total number of numerics inside the Palindrome: ");
string ready = Console.ReadLine();
int y = Convert.ToInt32(ready);

Console.Write("Please enter the total number of special characters inside Palindrome: ");
string readz = Console.ReadLine();
int z = Convert.ToInt32(readz);

string Palindrome;
int totallength = x + y + z;

if (w < 0 || w > 20)
    Console.WriteLine("Length of Palindrome exceeding max lenght");
else
{
    if (totallength != w || x > w || y > w || z > w)
    {
        Console.WriteLine("Total length does not match the length of Palindrome provided");
    }
    else
    {
        if ((totallength % 2) == 0)
        {
            if ((x % 2) != 0 || (y % 2) != 0 || (z % 2) != 0)
                Console.WriteLine("Length of the Albhabets/Numbers/Special Characters do not match the total lenght");
        }
        else if ((totallength % 2) != 0)
        {
            if ((x % 2) == 0 && (y % 2) == 0 && (z % 2) == 0)
                Console.WriteLine("Length of the Albhabets/Numbers/Special Characters do not match the total lenght");
        }
        else
        {
            for (int i = 0; i < w; i++)
            {

            }
        }
    }
}