using System;
					
Console.WriteLine("ENTER  FIRST NAME ");
const string Firstname;

Firstname = Console.ReadLine();
Console.WriteLine(Firstname);

/* make  constant varaible*/

const double  Pi = 3.14; 
Console.WriteLine(Pi);


/////FOREACH  LOOP 
using System;
					
string[] Names = {"ZANDREW","ANTHONY","JIMMY"};

Names.Sort(); //sort array
Names.Reverse(); //reverses  array
foreach (string name in Names)
{
Console.WriteLine(name);
}

Console.WriteLine(Names.Length);
