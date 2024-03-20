using System;
using System.Reflection;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AppDomain subsidiaryDomain = AppDomain.CreateDomain("SubsidiaryDomain");

            try
            {
               
                Assembly assembly = subsidiaryDomain.Load("SubsidiaryCodeDLL");

              
                Type type = assembly.GetType("SubsidiaryCodeDLL.SubsidiaryCodeClass");
                dynamic instance = Activator.CreateInstance(type);
                Console.WriteLine("Enter any Integer number: ");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Data Sent to SubsidiaryCodeDLL is: " + input.ToString());
                    string result = instance.ProcessData(input);


                    Console.WriteLine("Response from SubsidiaryCodeDLL:");
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter input number: " + ex.Message);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing subsidiary code: " + ex.Message);
            }
            finally
            {
                
                AppDomain.Unload(subsidiaryDomain);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
