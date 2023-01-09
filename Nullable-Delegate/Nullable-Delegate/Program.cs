

#region Nullable
//string name = null;

//int? num = null;

//if (name == null)
//{
//    Console.WriteLine("ddsd");
//}

//int? m = 5;

//GetPersonById(m);

//static void GetPersonById(int? id)
//{
//	if (id == null)
//	{
//		Console.WriteLine("Notfound");
//	}
//}
#endregion






using DomainLayer.Models;
using Nullable_Delegate;
using Nullable_Delegate.Constants;
using Nullable_Delegate.Exseptions;
using ServicesLayer.Services;
using ServicesLayer.Services.Interfaces;

//PracticeDelegate calculate = new PracticeDelegate();

//calculate.CheckDelegate();

//calculate.CheckWord();

//calculate.ShowString();

//int m = 5;
//int n = 0;

//var res = m / n;



//Console.WriteLine(res);

//try
//{

//    int m = 5;
//    int n = 0;

//    Divide(m, n);

//    //var res = m / n;

//    //int[] arr = { 1, 2, 3 };

//    //arr[5] = 100;  
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Divide(5, 0);


//static void Divide(int n, int m)
//{

//    bool isSuccess = false;
//    try
//    {
//        int[] arr = { 1, 2, 3 };
//        arr[5] = 100;
//        var result = n / m;
//        isSuccess = true;
//        Console.WriteLine(result);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        isSuccess= false;
//    }
//    finally
//    {
//        string message = string.Empty;
//        if (isSuccess)
//        {
//            message = "Register is ok";
//        }
//        else
//        {
//            message = "Something is wrong";
//        }

//        SendEmail(message);
//    }
//}

//static void SendEmail(string message)
//{
//    Console.WriteLine(message);
//}



//Login("pe5rvin123", "pervin12345");

//static void Login(string username, string password)
//{
//	try
//	{
//		if (username == "pervin123" && password == "pervin12345")
//		{
//			Console.WriteLine("Login is success");
//		}
//		else
//		{
//			throw new InvalidLoginExseption(ExseptionsMessages.InvalidLogin);
//		}



//	}
//	catch(Exception ex)
//	{
//		Console.WriteLine(ex.Message);
//	}	
//}



IEmployeeService service = new EmployeeService();  

Console.WriteLine(service.GetCountByAge(25));


