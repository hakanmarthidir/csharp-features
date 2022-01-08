using Features_10;

//IMPLICIT USING : C# 10 automatically comes with Implicit Using feature. We can call directly Console object here. 
//Check this out folder : obj/debug/net6.0  -> inside this folder you will see a .cs file named GlocalUsing.g.cs, and this topic is related global using. 
Console.WriteLine("Record Type Enhancements");
MyTestClassForRecord myTestClassForRecord = new();


Console.WriteLine("CallerArgumentSample--");
CallerArgumentExpressionAttributeUsage callerArgumentExpressionAttributeUsage = new CallerArgumentExpressionAttributeUsage();
callerArgumentExpressionAttributeUsage.DoSomething(new MyParameter() { Name="Test", LastName="LastTest" });

