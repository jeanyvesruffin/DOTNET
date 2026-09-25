int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue=Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

string[] fraudulentOrderIDsoldSyntaxe = { "A123", "B456", "C789" };
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDsoldSyntaxe[2]}");
Console.WriteLine($"There are {fraudulentOrderIDsoldSyntaxe.Length} fraudulent orders to process.");
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

foreach (string fraudulentOrderID in fraudulentOrderIDs)
{
    Console.WriteLine(fraudulentOrderID);
}


string[] numberOfCommandes =["B123","C234","A345","C15","B177","G3003","C235","B179"];
foreach (string commande in numberOfCommandes )
{
    if (commande.StartsWith("B"))
    {
        Console.WriteLine("The name start 'B' !");
    }
}


int num1=5;

if (num1>0)
{
int num2=6;    
num1 += num2;
}

Console.WriteLine(num1);