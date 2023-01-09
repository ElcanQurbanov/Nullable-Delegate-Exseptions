using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Delegate
{
    internal class PracticeDelegate
    {
        #region Predicate
        //public delegate bool CheckNums(int num, string txt);


        //public bool CheckNumByOdd(int number)
        //{
        //    return number % 2 == 1;
        //}

        //public bool CheckNumByEven(int number) => number % 2 == 0;


        //public bool CheckNumThanFive(int number) => number > 5;


        //public void CheckDelegate()
        //{
        //    List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, };

        //    var res = nums.FindAll(CheckNumByOdd).Sum(m => m);

        //    //Console.WriteLine(SumOfListItems(m=> m > 5 , nums));
        //}


        //public int SumOfListItems(Predicate<int> func, List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}


        //public int SumOfListByOdd(CheckNums func, List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //public int SumOfListByEven(List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //public int SumOfListThanFive(List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (item > 5)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}
        #endregion

        #region Action
        //public delegate void ChangeString(string str)

        //public void StringtoUpper(string word)
        //{
        //    Console.WriteLine(word.ToUpper());
        //}

        //public void StringtoLower(string word)
        //{
        //    Console.WriteLine(word.ToLower());
        //}

        //public void CheckWord()
        //{
        //    //ShowWord(StringtoUpper, "Cavid");    
        //    //ShowWord(StringtoLower, "Cavid");

        //    //ChangeString changeString = new ChangeString(StringtoUpper);

        //    //ChangeString changeString = StringtoUpper;

        //    //changeString += StringtoLower;

        //    //changeString.Invoke("Pervin");

        //    //changeString += delegate (string str)
        //    //{
        //    //    Console.WriteLine(str.ToLower());
        //    //};

        //    //changeString("Pervin");

        //    //ChangeString changeString = StringtoUpper;

        //    //changeString += (string str) => Console.WriteLine(str.ToLower());

        //    //changeString("Pervin"); 

        //    Action<string> action = StringtoUpper;
        //    action += (string str) => Console.WriteLine(str.ToLower());
        //    action("Pervin");
        //}



        //public void ShowWord(ChangeString func, string str)
        //{
        //    func(str);
        //}
        #endregion

        #region Func
        //public delegate int CheckString(string str, int age);

        //public int GetStringLenght(string word, int num)
        //{
        //    return word.Length + num;
        //}


        //public void ShowStringLenght(Func<string, int, int> func, string text)
        //{
        //    Console.WriteLine(func(text, 10));
        //}


        //public void ShowString()
        //{
        //    ShowStringLenght(GetStringLenght, "Cavid");

        //    Func<string, int, int> func = GetStringLenght;

        //    Console.WriteLine(func("Cahandar", 6));
        //}
        #endregion



    }
}
