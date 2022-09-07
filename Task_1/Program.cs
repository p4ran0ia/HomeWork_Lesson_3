Console.WriteLine("Input a five-digit number: ");
string array = Console.ReadLine();
if(array.Length != 5)
Console.WriteLine("error");
else if(array[0] == array[4] && array[1] == array[3])
Console.WriteLine("palindrome");
else
Console.WriteLine("no palindrome");

