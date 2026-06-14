using System;
					
Console.WriteLine("ANDREW");


Test1 t1 = new Test1(); 
t1.ShowName();
Console.WriteLine(t1.Name);
Console.WriteLine( t1.ShowName2("ANDY"));

class Test1
{
	
public string Name; 

public string ShowName()
{
	Name = "OKUTU";
	return Name;
}
	
public string ShowName2(string Nm)
{
	return Nm;
	
}
	

}

