using System;
					
Console.WriteLine("ENTER  FIRST NAME ");
const string Firstname;

Firstname = Console.ReadLine();
Console.WriteLine(Firstname);

/* make  constant varaible*/

const double  Pi = 3.14; 
Console.WriteLine(Pi);


/////FOREACH  LOOP 
string[] Names = {"ANDREW","ANTHONY","JIMMY"};
foreach (string name in Names)
{
Console.WriteLine(name);
}