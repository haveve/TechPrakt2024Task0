try
{
	Console.Write("First number: ");
	double num1 = double.Parse(Console.ReadLine());
	Console.Write("Second number: ");
	double num2 = double.Parse(Console.ReadLine());
	Console.WriteLine("{1} + {2} = {0}",num1+num2,num1,num2);
}
catch{
	Console.WriteLine("One of the numers are incorrect");
}