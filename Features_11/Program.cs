// See https://aka.ms/new-console-template for more information
using Features_11;

Console.WriteLine("Hello, net7!");



//------------1- StaticAbstractVirtualMethods

var myMethods = new StaticAbstractVirtualMethods();
myMethods.Iterate();

//------------


//------------2- NewLines Interpolated String Samples

Console.WriteLine(NewLinesStringInterpolation.SampleInterpolatedString1());
Console.WriteLine(NewLinesStringInterpolation.SampleInterpolatedString2());

//------------

//------------3- RawStringLiteral

Console.WriteLine(RawStringLiteral.RawLiteralStringSample1());
Console.WriteLine(RawStringLiteral.RawLiteralStringSample2());

//------------


ListPattern listPattern = new ListPattern();

Console.ReadLine();
