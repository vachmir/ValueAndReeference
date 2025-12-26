namespace ValueAndReeference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //Change(a);
            //Console.WriteLine($"Value type Without Ref Keyword - {a}");
            //Console.WriteLine();

            //int b = 20;            
            //ChangeRef(ref b);
            //Console.WriteLine($"Value type With Ref Keyword - {b}");
            //Console.WriteLine();

            //Box box = new Box {  Value = 44 };
            //ChangeClass(box);
            //Console.WriteLine($"Change Reference type Without Ref Keyword - {box.Value}");
            //Console.WriteLine();

            //Box boxRef = new Box { Value = 10 };
            //ChangeRefClass(ref boxRef);
            //Console.WriteLine($"Change Reference type With Ref Keyword - {boxRef.Value}");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Examples with Strings");
            //string text = "Hello";
            //ChangeString(text);
            //Console.WriteLine($"Change the string Without Ref - {text}");

            //string text2 = "Hello";
            //ChangeStringRef(ref text2);
            //Console.WriteLine($"Change the string With Ref - {text2}");


            #region Assignment and Modification 1
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1) Modify object WITHOUT ref");
            Box box1 = new Box { Value = 10 };
            ModifyObject(box1);
            Console.WriteLine($"Result: {box1.Value}");
            Console.WriteLine();

            Console.WriteLine("2) Reassign parameter WITHOUT ref");
            Box box2 = new Box { Value = 10 };
            ReassignObject(box2);
            Console.WriteLine($"Result: {box2.Value}");
            Console.WriteLine();

            Console.WriteLine("3) Modify object WITH ref");
            Box box3 = new Box { Value = 10 };
            ModifyObjectRef(ref box3);
            Console.WriteLine($"Result: {box3.Value}");
            Console.WriteLine();

            Console.WriteLine("4) Reassign parameter WITH ref");
            Box box4 = new Box { Value = 10 };
            ReassignObjectRef(ref box4);
            Console.WriteLine($"Result: {box4.Value}");
            Console.WriteLine();
            #endregion


            Box box;

            box = new Box { Value = 10 };
            Modify(box);
            Print("Modify WITHOUT ref", box);

            box = new Box { Value = 10 };
            Reassign(box);
            Print("Reassign WITHOUT ref", box);

            box = new Box { Value = 10 };
            ModifyRef(ref box);
            Print("Modify WITH ref", box);

            box = new Box { Value = 10 };
            ReassignRef(ref box);
            Print("Reassign WITH ref", box);


            int[] smallArray = { 1, 2, 3, 4, 5 };
            int[] largeArray = { 10, 20, 30, 40, 50 };

            int index = 7;
            ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]);
            Console.WriteLine();
            Console.WriteLine(refValue);
            Console.WriteLine(string.Join(" ", smallArray));
            Console.WriteLine(string.Join(" ", largeArray));
            refValue = 0;

            index = 2;
            ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]) = 100;

            Console.WriteLine(string.Join(" ", smallArray));
            Console.WriteLine(string.Join(" ", largeArray));

            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            
            // B 
            var result = a[^3] - a[2] + a[^8];
            // result == 8 
            
            Console.WriteLine(a[2..5]);

            Console.WriteLine(a[^8]);

            Console.WriteLine($"|{"Left",-7}|{"Right",7}|");

            const string s1 = "Hello, world!";
            string s2 = "Hello, world!";

            // A
            const string str = "\\Hello" + ", " + "world" + "!\\";

            // B 
            const string str2 = $"{s1}";

            // C 
            const string str4 = $"\\\u0048ello, world!\\";

            // D 
            string str = string.Format("{1} {0}", "Hello,", "world!");
        }

        #region Pass by Value and Reference        
        static void Change(int x)
        {
            Console.WriteLine($"Variable inside called method before assignment - {x}");
            x = 95;
            Console.WriteLine($"Variable inside called method after assignment - {x}");
        }

        static void ChangeRef(ref int x)
        {
            Console.WriteLine($"Variable inside called method before assignment - {x}");
            x = 100;
            Console.WriteLine($"Variable inside called method after assignment - {x}");
        }

        static void ChangeClass(Box b)
        {
            Console.WriteLine($"Variable inside called method before assignment - {b.Value}");
            b.Value = 55;
            Console.WriteLine($"Variable inside called method after assignment - {b.Value}");
        }

        static void ChangeRefClass(ref Box b)
        {
            Console.WriteLine($"Variable inside called method before assignment - {b.Value}");
            b = new Box { Value = 100 };
            Console.WriteLine($"Variable inside called method after assignment - {b.Value}");
        }

        static void ChangeString(string s)
        {
            Console.WriteLine($"Variable inside called method before adding \" World\" - {s}");
            s = s + " World";
            Console.WriteLine($"Variable inside called method after adding \" World\" - {s}");
        }

        static void ChangeStringRef(ref string s)
        {
            Console.WriteLine($"Variable inside called method before adding \" World\" - {s}");
            s = s + " World";
            Console.WriteLine($"Variable inside called method after adding \" World\" - {s}");
        }
        #endregion

        #region Assignment and Modification 1
        static void ModifyObject(Box b)
        {
            b.Value = 50;
        }

        static void ReassignObject(Box b)
        {
            b = new Box { Value = 60 };
        }

        static void ModifyObjectRef(ref Box b)
        {
            b.Value = 70;
        }

        static void ReassignObjectRef(ref Box b)
        {
            b = new Box { Value = 80 };
        }
        #endregion

        static void Modify(Box b) => b.Value = 50;
        static void Reassign(Box b) => b = new Box { Value = 60 };
        static void ModifyRef(ref Box b) => b.Value = 70;
        static void ReassignRef(ref Box b) => b = new Box { Value = 80 };

        static void Print(string title, Box box)
        {
            Console.WriteLine($"{title}: {box.Value}");
        }
    }
}