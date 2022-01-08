
using System;
using System.Collections.Generic;
using Features_9;

//Top Level Statements Feature ....
#region Records

Console.WriteLine("Record Types");

var project1 = new SoftwareProject("X Project", 5, 100, "C#");
// all values are copied and you can change specific one
SoftwareProject project2 = project1 with { Language = "Python" };
//project3 is completely same with project 1
SoftwareProject project3 = project1 with { };
SoftwareProject project4 = project1 with { Language = "Go" };
MachineProject machineProject = new MachineProject("PhotoMachine1", 3, 5);
Console.WriteLine(project1);


//Record Comparations
Console.WriteLine(ReferenceEquals(project1, project2)); //False
Console.WriteLine(ReferenceEquals(project2, project4)); //False
Console.WriteLine(ReferenceEquals(project1, project3)); //False

Console.WriteLine(Equals(project1, project4)); //False
Console.WriteLine(Equals(project2, project4)); //False
Console.WriteLine(Equals(project1, project3)); //True

Console.WriteLine(project1 == project3); //True
Console.WriteLine(project1 == project2); //False

//deconstruction
var (f, l) = project1;
Console.WriteLine("Record Deconstruction");
Console.WriteLine(f);
Console.WriteLine(l);
#endregion


Console.WriteLine("Init Only Setters");
BookInit initBook = new BookInit() { BookName = "Rules of the Direction of the Mind", ISBN = "ISBN 6051270289", PageCount = 254, Price = 10.50 };
//Error
//initBook.ISBN = "ISBN 11111111111";
Console.WriteLine(initBook.ToString());


Console.WriteLine("Pattern Matching");
Console.WriteLine(PatternMatchingEnhancements.CheckPageCount(initBook));
Console.WriteLine(initBook.IsExpensive());


Console.WriteLine("Fit and Finish Feature");
TargetTypedNewFeature feature = new();
List<int> myNumberList = new();
TargetTypedNewFeature feature2 = new() { FeatureName = "new()" };
Console.WriteLine(PatternMatchingEnhancements.CheckPageCount(new() { PageCount = 259 }));


Console.WriteLine("Attributes on Local");
AttributesOnLocalMethods.LocalFunctionsTest();

Console.WriteLine("GetEnumerator Support");
GetEnumeratorSupportsForeach.WriteItems();

Console.WriteLine("Static Anonymous Function Support");
StaticAnonymousFunctions staticAnonymousFunctions = new();


Console.Read();

