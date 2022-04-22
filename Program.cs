// See https://aka.ms/new-console-template for more information
/*
1. What type would you choose for the following “numbers”?
A person’s telephone number 
    string
A person’s height
    double
A person’s age
    int
A person’s gender (Male, Female, Prefer Not To Answer)
    string
A person’s salary
    double
A book’s ISBN
    string
A book’s price
    double
A book’s shipping weight
    double
A country’s population
    int
The number of stars in the universe
    int
The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business)
    int
2. What are the difference between value type and reference type variables? What is
boxing and unboxing?
    value type will be hold by value, reference type will be hold by memory address 
    or refference for value
    value type are stored in stack memory, reference type are stored in heap memory
    value type will not be collected by garbage collector, but reference type will
    value type can be created by struct or enum, reference type can be created by class, 
    interface, delegate, and array
    value type cannot have null value, but reference can 
    boxing is convert a value type data to reference tpye
    unboxing is convert a reference type to value
3. What is meant by the terms managed resource and unmanaged resource in .NET
    Managed resources are those that are pure . NET code and managed by the runtime 
    and are under its direct control. Unmanaged resources are those that are not.
4. Whats the purpose of Garbage Collector in .NET?
    NET's garbage collector manages the allocation and release of memory for your application.
*/
/*
string a; 

Console.WriteLine("Enter a number :");
a = Console.ReadLine();
Console.WriteLine(a);
*/
/*
sbyte signedBytes;
byte usignedBytes;
short signedShort;
ushort usignedShort;
int signedInt;
uint usignedInt;
long signedLong;
ulong usignerLong;
float Flot;
double Double;
decimal Decimal;

signedBytes = -128;
Console.WriteLine("min of sbyte: " + signedBytes);
signedBytes = 127;
Console.WriteLine("max of sbyte: " + signedBytes + "\n");

usignedBytes = 0;
Console.WriteLine("min of sbyte: " + usignedBytes);
usignedBytes = 255;
Console.WriteLine("max of sbyte: " + usignedBytes + "\n");

signedShort = -32768;
Console.WriteLine("min of sbyte: " + signedShort);
signedShort = 32767;
Console.WriteLine("max of sbyte: " + signedShort + "\n");

usignedShort = 0;
Console.WriteLine("min of sbyte: " + usignedShort);
usignedShort = 65535;
Console.WriteLine("max of sbyte: " + usignedShort + "\n");

signedInt = -2147483648;
Console.WriteLine("min of sbyte: " + signedInt);
signedInt = 2147483647;
Console.WriteLine("max of sbyte: " + signedInt + "\n");

usignedInt = 0;
Console.WriteLine("min of sbyte: " + usignedInt);
usignedInt = 4294967295;
Console.WriteLine("max of sbyte: " + usignedInt + "\n");

signedLong = -9223372036854775808l;
Console.WriteLine("min of sbyte: " + signedLong);
signedLong = 9223372036854775807l;
Console.WriteLine("max of sbyte: " + signedLong + "\n");

usignerLong = 0ul;
Console.WriteLine("min of sbyte: " + usignerLong);
usignerLong = 18446744073709551615ul;
Console.WriteLine("max of sbyte: " + usignerLong + "\n");

Flot = -3.402823e38f;
Console.WriteLine("min of sbyte: " + Flot);
Flot = 3.402823e38f;
Console.WriteLine("max of sbyte: " + Flot + "\n");

Double = -1.7976931348623157E+308d;
Console.WriteLine("min of sbyte: " + Double);
Double = 1.7976931348623157E+308d;
Console.WriteLine("max of sbyte: " + Double + "\n");

Decimal = 79228162514264337593543950335m;
Console.WriteLine("min of sbyte: " + Decimal);
Decimal = -79228162514264337593543950335m;
Console.WriteLine("max of sbyte: " + Decimal + "\n"); 
*/
/*
Decimal intTemp = Convert.ToInt64(Console.ReadLine());
Console.WriteLine(intTemp + " centuries = " + intTemp*100 + " years = " + intTemp*100*365 + " days = " +
   intTemp*100*365*24 + " hours = " + intTemp* 100*365*24*60 + " minutes = " + 
   intTemp*100*365*24*60*60 + " seconds = " + intTemp * 100 * 365 * 24 * 60 * 60 * 1000 + " milliseconds =" +
   intTemp * 100 * 365 * 24 * 60 * 60 * 1000*1000 + " microseconds = " + intTemp * 100 * 365 * 24 * 60 * 
   60 * 1000 * 1000*1000 + " nanoseconds");
*/
/*
1. What happens when you divide an int variable by 0?
    will get: An unhandled exception of type 'System.DivideByZeroException' occurred in ConsoleApp1.dll
    Attempted to divide by zero.
2. What happens when you divide a double variable by 0?
    will get infinity
3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
    get a negative result
4. What is the difference between x = y++; and x = ++y;?
    the result of x = y++ is x=y, and the result of x = ++y is x=y+1
5. What is the difference between break, continue, and return when used inside a loop statement?
    The break statement: terminates the closest enclosing iteration statement or switch statement.
    The continue statement: starts a new iteration of the closest enclosing iteration statement.
    The return statement: terminates execution of the function in which it appears and returns control to the caller.
6. What are the three parts of a for statement and which of them are required?
    initializer section, condition section and iterator section.
    condition section is the required. for loop can run without other twos. 
7. What is the difference between the = and == operators?
    = means left value is right value
    == means left value equal right value
8. Does the following statement compile? for ( ; true; ) ;
    yes. it's a infinite loop
9. What does the underscore _ represent in a switch expression?
    default
10. What interface must an object implement to be enumerated over by using the foreach statement?
    IEnumerable interface
*/
/*
int i = 0;
for(i=0; i<=100;i++)
{
    if (i % 15 == 0)
        Console.WriteLine("fizzbuzz ");
    else if (i % 3 == 0)
        Console.WriteLine("fizz ");
    else if (i % 5 == 0)
        Console.WriteLine("buzz ");
    else
        Console.WriteLine(i+" ");
}
*/
/*
 * this program will keep print the number from 0 to 255
int max = 500;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}

we can add a comment as a notice to show that this is an infinite loop
*/
/*
//Practice loops and operators
int correctNumber = new Random().Next(3) + 1;
int uInsert;

uInsert= Convert.ToInt32(Console.ReadLine());
if (uInsert > 3 || uInsert < 1)
    Console.WriteLine("not in the range");
else
{
    if (uInsert == correctNumber)
        Console.WriteLine("good guess");
    else if (uInsert < correctNumber)
        Console.WriteLine("too low");
    else
        Console.WriteLine("too high");
}
*/
/*
//print pyramid
int h;
h = Convert.ToInt32(Console.ReadLine());
for(int i=0;i<h;i++)
{
    for (int j = h-i; j >0; j--)
        Console.Write(" ");
    for (int k = 0; k < i*2+1; k++)
        Console.Write("*");
    Console.Write("\n");
}
*/
/*
DateTime localDate = DateTime.Now;
if (localDate.Hour > 0 && localDate.Hour < 6)
    Console.WriteLine("good night");
else if (localDate.Hour > 6 && localDate.Hour < 12)
    Console.WriteLine("good morning");
else if (localDate.Hour > 12 && localDate.Hour < 18)
    Console.WriteLine("good afternoon");
else
    Console.WriteLine("good evening");
*/
/*
for(int i=1;i<5;i++)
{
    for(int j=0;j<25;j++)
    {
        if(j%i==0)
            Console.Write(j+",");
    }
    Console.Write("\n");
}
*/
/*
1.When to use String vs. StringBuilder in C# ?
    if we want to change one or more data in the string, we should use stringBuilder
2. What is the base class for all arrays in C#?
    list interface
3.How do you sort an array in C#?
    int[] arrayName = new int[5] {1,2,3,4,5}
4.What property of an array object can be used to get the total number of elements in an array?
    length property
5. Can you store multiple data types in System.Array?
    No, we cannot store multiple datatype in an Array, we can store similar datatype only in an Array.
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
    The clone is of the same Type as the original Array. 
The CopyTo() method copies the elements into another existing array.
*/
/*
//Copying an Array
int [] num = new int[10];
for(int i=0;i<10;i++)
    num[i] = i;
int[] num2 = new int[10];
for( int i=0;i<10;i++)
    num2[i] = num[i];
Console.Write("num: ");
foreach (int i in num)
    Console.Write("{0}", i);

Console.Write("\nnum2: ");
foreach (int i in num2)
    Console.Write("{0}", i);
*/
/*
//calculate items
int item = 0, numChange;
string uInsert;
bool k = true;
Console.WriteLine("items: "+item);
while(k)
{
    Console.Write("Enter command (+ item, - item, -- to clear, or others to exit):");
    uInsert = Console.ReadLine();
    if (uInsert == "+")
    {
        Console.Write("Enter the number of items that are ognna change:");
        numChange = Convert.ToInt32(Console.ReadLine());
        item += numChange;
        Console.WriteLine("items: " + item);
    }
    else if (uInsert == "-")
    {
        Console.Write("Enter the number of items that are ognna change:");
        numChange = Convert.ToInt32(Console.ReadLine());
        item -= numChange;
        Console.WriteLine("items: " + item);
    }
    else if (uInsert == "--")
    {
        item = 0;
        Console.WriteLine("items: " + item);
    }
    else
        k = false;
}
*/
/*
//Print Prime Numbers
int a, b, n, d;
Console.WriteLine("enter the left number of the range");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the right number of the range");
b = Convert.ToInt32(Console.ReadLine());
n = b - a + 1;

int[] FindPrimesInRange = new int[n];
for (int i = 0; i < n; i++)
{
    FindPrimesInRange[i] = a;
    a++;
}
for (int i = 0; i < n; i++)
{
    if (FindPrimesInRange[i] == 1)
    {
        FindPrimesInRange[i] = 0;
        continue;
    }
    else
    {
        d = FindPrimesInRange[i] / 2 + 1;
        for (int j = 2; j < d; j++)
        {
            if (FindPrimesInRange[i] % j == 0)
            {
                FindPrimesInRange[i] = 0;
                continue;
            }
        }
    }
}
for(int i = 0; i < n; i++)
{
    if (FindPrimesInRange[i] != 0)
        Console.Write(FindPrimesInRange[i] + " ");
}
*/
/*
//sum after array rotate
string nums;
int r, j, count=0;
Console.WriteLine("enter the numbers");
nums = Console.ReadLine();
string[] takens = nums.Split();
int[] numbers = Array.ConvertAll(takens, int.Parse);
Console.WriteLine("enter the rotate times");
r = Convert.ToInt32(Console.ReadLine()); 

int l = numbers.Length;
int[] sum = new int[l];
for (int i = 0; i < l; i++)
    sum[i] = 0;
for (int i = 0; i < l; i++)
{
    j = i-1;
    if (j < 0)
        j = l - 1;
    while(count<r)
    {
        sum[i] += numbers[j];
        j--;
        if (j < 0 )
            j = l - 1;
        count++;
    }
    count = 0;
}

for(int i=0;i<l;i++)
    Console.Write(sum[i]+" ");
*/
/*
Console.WriteLine("enter the numbers");
string nums = Console.ReadLine();
string[] takens = nums.Split();
int[] numbers = Array.ConvertAll(takens, int.Parse);
int l = numbers.Length, count=0, temp, max=0;

temp = numbers[0];

for (int i = 0; i <l;i++)
{
    for(int j = 0; j <l; j++)
    {
        if(numbers[i] == numbers[j])
            count++;
    }
    if(count > max)
    {
        temp = numbers[i];
        max = count;
    }
    count = 0;
}
Console.WriteLine(temp);
*/
/*
reverse a string
Console.WriteLine("enter a string");
String readInput = Console.ReadLine();
char[] charReadInput = readInput.ToCharArray();
string reverString=string.Empty;

for (int i = charReadInput.Length-1; i >=0 ; i--)
    reverString+=charReadInput[i];
Console.WriteLine(reverString);
*/
/*
//reverse the sentence
Console.WriteLine("enter the sentence");
string inputSentence = Console.ReadLine();
string[] takens = inputSentence.Split();

for(int i = takens.Length-1; i >=0 ; i--)
    Console.Write(takens[i]+" ");
*/
/*
//find and print palindromes in sentence
Console.WriteLine("enter the sentence");
string inputSentence = Console.ReadLine();
string[] takens = inputSentence.Split();
bool k = true;
int l;
for(int i = 0; i < takens.Length; i++)
{
    char[] charReadInput = takens[i].ToCharArray();
    if(charReadInput.Length != 1)
    {
        l = charReadInput.Length / 2 + 1;
        for (int j = 0; j < l; j++)
        {
            if (charReadInput[j] != charReadInput[(charReadInput.Length -1 - j)])
            {
                k = false;
                break;
            }
        }
    }
    if(k)
        Console.WriteLine(takens[i]);
    k=true;
}
*/
/*
//print URL detail
Console.WriteLine("enter the URL");
//string readURL = Console.ReadLine();
char[] readChars = Console.ReadLine().ToCharArray();
//Console.WriteLine(readChars);
string temp;
int count = 0;
temp=string.Empty;
for(int i = 0; i < readChars.Length; i++)
{
    if (readChars[i].Equals(':'))
    {
        Console.WriteLine("protocol: " + temp);
        temp = string.Empty;
        continue;
    }
    else if (readChars[i].Equals('/'))
    {
        count++;
        if (count > 2)
        {
            Console.WriteLine("server: " + temp);
            temp = string.Empty;
            count = 0;
        }
        continue;
    }
    else if (i==readChars.Length-1)
    {
        Console.WriteLine("resource: " + temp);
        continue;
    }
    temp += readChars[i];
}
*/