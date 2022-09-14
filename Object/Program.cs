using Object;

Employee lasse = new Employee();

lasse.name = "Lasse Andersson";
lasse.lön = 35000;
lasse.CountSalary();

Console.WriteLine(lasse.name + "har " +lasse.lön );
Console.WriteLine(lasse.name + "har" + lasse.SetLön(15000));
Console.WriteLine("Hellow World");

Console.ReadKey();






