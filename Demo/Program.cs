namespace Demo
{
    internal class Program
    {
        public delegate int StringFuncDelegate(string str);
        static void Main(string[] args)
        {
            #region Delegate

            //StringFuncDelegate stringFuncDelegate = new StringFuncDelegate(StringFunctions.GetCountOfUpperChars);
            //StringFuncDelegate stringFuncDelegate;

            //stringFuncDelegate = new StringFuncDelegate(StringFunctions.GetCountOfUpperChars);

            //stringFuncDelegate = StringFunctions.GetCountOfUpperChars;

            //int R = stringFuncDelegate.Invoke("MaHmoud");
            //Console.WriteLine(R);

            //stringFuncDelegate += StringFunctions.GetCountOfLowerChars;

            //int R = stringFuncDelegate.Invoke("MaHmoud");
            //Console.WriteLine(R);

            //stringFuncDelegate -= StringFunctions.GetCountOfLowerChars;

            //int R = stringFuncDelegate/*.Invoke*/("MaHmoud");
            //Console.WriteLine(R);

            //StringFunctions.GetCountOfUpperChars("Ali");
            #endregion

            //string[] Names = { "Ahmed", "Mohamed", "Ali", "Omar" };
            //SortingAlgorithms<string>.BubbleSort(Names, CompareFunctions.SortDescending);

            //foreach (string Name in Names)
            //{
            //    Console.WriteLine(Name);
            //}

            //Predicate<int> predicate;
            //predicate = TestingFunctions.Test01;
            //Console.WriteLine(predicate(40));

            ////Func<int, string> func;
            //var func = (int X) => X.ToString();
            //Console.WriteLine(func(42));

            ////Action actionn;
            //var actionn =   () => Console.WriteLine("Hello");
            //actionn();

            ////Action<string> action;
            //var action = (string Name) =>  Console.WriteLine($"Hello {Name}");
            //action("Mohamed");


        }
    }
    class TestingFunctions
    {
        public static bool Test01(int X)
        {
            return X > 0;
        }

    }
}
