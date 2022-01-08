using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_10
{
    public class FileScopedNamespaces
    {

        //Before c# 9 
        //    namespace SampleNamespace
        //{
        //    class SampleClass { }
        //    interface ISampleInterface { }
        //    struct SampleStruct { }
        //    enum SampleEnum { a, b }
        //    delegate void SampleDelegate(int i);

        //    namespace Nested
        //    {
        //        class SampleClass2 { }
        //    }
        //}

        //With c# 10
        //    using System;
        //    namespace SampleFileScopedNamespace;
        //    class SampleClass { }
        //    interface ISampleInterface { }
        //    struct SampleStruct { }
        //    enum SampleEnum { a, b }
        //    delegate void SampleDelegate(int i);

        //we are rescuing the curly bracets however we have some limitations. for example : you cant declare nested namespace or second file-scoped namespaces in file-scoped namespace. 
        //LIMITATIONS : 
        //namespace OtherNamespaceInFileScoped; // Not Possible!

        //According to Microsoft Documentation ->
        //Within a namespace, you can declare zero or more of the following types:
        //class
        //interface
        //struct
        //enum
        //delegate
        //nested namespaces can be declared except in file scoped namespace declarations
    }
}
