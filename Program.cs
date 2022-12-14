using System.Numerics;

//This function Takes a string and sees if there are any vowels in them it will tally up how many vowels and output them in vowelCount
static int GetVowelCount(string str)
{
    int vowelCount = 0;
    for (int i = 0; i < str.Length; i++)
    {
        // the str[i] checks each letter if that letter contains a, e, i ,o ,u:
        if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
        {
            vowelCount++;
        }
    }
    return vowelCount;
}

//This Method Checks if Array/object 'a' contain 'x'

static bool Check(object[] a, object x)
{
    return a.Contains(x);
    //This Method will add Extremely long numbers together using BigInteger value
    //must use
    //using System.Numerical must be used or BigInteger will be unusable.
    static string Add(string a, string b)
    {
        BigInteger c = 0;
        BigInteger d = 0;


        c = BigInteger.Parse(a);
        d = BigInteger.Parse(b);

        return $"{c + d}";

    }
}
//This method will take an input (1-7) depending on the input will output a day of the week.
static string WhatDay(int n)
{
    string S = "";
    string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
    if (n <= 0 || n > 7)
    {
        S = "Wrong, please enter a number between 1 and 7";
    }
    else
    {
        n = n - 1;
        S = days[n];
    }
    return S;
}

//This method will take in 2 inputs a string and an int
//it will then repeat the string 'n' number of times.
static string RepeatStr(int n, string s)
{// we are givin a number "n" we will repeat the string n times

    string res = "";
    for (int i = 0; i < n; i++)
    {
        res += s;
    };
    return res;

}

// This method will take in factorials meaning if num is 5 it will be 5*4*3*2*1 = 120
static int FirstFactorial(int num)
{

    int number1 = num;
    for (int i = 1; i < num; i++)
    {// we will 
        number1 = number1 * i;
    }
    num = number1;
    return num;
}
// Adding ONLY positive integers in arrays.
static int PositiveSum(int[] arr)
{
    int num = 0;

    for (int i = 0; i < arr.Length; i++)
    {// IF Array Index is greater than 0 Then it Will be added to NUM
     // This Repeats until the length of the array is finsihed.
        if (arr[i] > 0)
        {
            num += arr[i];
        }
    }
    return num;
}
Console.Clear();

// Comparing X And O's in a string, if the X == O then true if not return false.
string input = "XXOOOOO";
input.ToLower();

int O = 0;
int X = 0;

bool results = true;
// (Char c is declared 
foreach (char c in input)
{// Char.ToLower(c) == o is making o what input is being checked with.
    if (char.ToLower(c) == 'o')
    { O++; }
    else if (char.ToLower(c) == 'x')
    { X++; }
}
if (X == O)
{ results = true; }
else
{ results = false; }
Console.WriteLine(O);
Console.WriteLine(X);
Console.WriteLine(results);


//this method will count how many take the int input of Ex: 10 and if a number that is divisble by 3 or 5 that is less than 10 it will
//take the sum of those numbers which are (3, 5, 6, 9) resulting in 23 being displayed
static int Solution(int value)
{

    int num = 0;

    //we will cicle thrue the value (10) 10 times
    for (int i = 3; i < value; i++)
    {
        //if i incirments are divisible by 3 or 5 it will be added to the variable num.
        if (i % 3 == 0 || i % 5 == 0)
        {
            num += i;
        }
    }
    return num;
}


//This method will sort an incoming integer variable Ex 5989187 first in accending order and the reverse it.
static int DescendingOrder(int num)
{
    //"var' is a keyword, it is used to declare an implicit type variable,
    // meaning it can be an int or a string depening on what is assigned to it.
    var chars = num.ToString().ToCharArray();
    //the above code converts num into a string and then into a char array.

    //The below cod Sorts the char array into ascending order and then we reverse with Array.Reverse
    Array.Sort(chars);
    Array.Reverse(chars);
    //we then convert it into a string with a new var
    var s = new string(chars);
    //finally we return it into an int with Int32.Parse.
    return Int32.Parse(s);
}

static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
{
    List<int> result = new List<int>();

    for (int i = 0; i < listOfItems.Count; i++)
    {
        if (listOfItems[i] is int)
        {
            result.Add((int)listOfItems[i]);
        }
    }
    return result;
}


{
    static bool Check(object[] a, object x)
    {//if a has x is true
     // x can be int and a string

        bool c = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (x.ToString() == a[i].ToString())
            {
                c = true;
            }
        }
        return c;

    }
}

// Fibonacci Two ways!
//Recursion
// fibonacci numbers are:
//   0      1      2     3       4     5     6     7   etc
//   0      1      2      3      5     7     9     11   etc
// (0+0)  (0+1)  (1+1)  (1+2)   2+3   3+4   4+5   5+6    etc

static int fib(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    return fib(n - 1) + fib(n - 2);
}

// fibonacci for loop way


static int Fibonacci(int n)
{
    int num1 = 0;
    int num2 = 1;
    int num = n;
    for (int i = 1; i < n; i++)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp + num2;
    }
    return num2;
}
// Spliting a string into an array and seperating it by spaces
//I.E. string = "john went to the store"
//is converted too ["john", "went", "to, "The", "Store"]
static string[] StringToArray(string str)
{
    string[] arr = new string[] { "" };
    arr = str.Split(' ');
    return arr;
}

//Find numbers which are divisible by given number
//IE [1, 2, 3, 4, 5, 6], 2 --> [2, 4, 6]
static int[] DivisibleBy(int[] n, int d)
{
    int count = 0;
    // the first for loop is to find the length of our final array
    for (int i = 0; i < n.Length; i++)
    {// we use modulo to get the count of numbers that are divisible by variable 'd'
        if (n[i] % d == 0)
            count++;
    }
    int q = 0;
    // we put the count as our new array length.
    int[] a = new int[count];
    for (int i = 0; i < n.Length; i++)
    {
        if (n[i] % d == 0)
        {//we store the ints that are divisible by d in our new array:
            a[q] = n[i];
            q++;
        }
    }
    return a;
}