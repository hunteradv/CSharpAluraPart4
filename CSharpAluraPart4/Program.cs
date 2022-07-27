using System;
using System.IO;

namespace CSharpAluraPart4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChargeAccounts();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }

            Console.ReadLine();
        }

        private static void ChargeAccounts()
        {
            using (FileReader reader = new FileReader("file.txt"))
            {
                reader.ReadNextLine();
            }


            // -----------------------------------------------

            //FileReader file = null;

            //try
            //{
            //    file = new FileReader("file2.txt");

            //    file.ReadNextLine();
            //}
            //finally
            //{
            //    Console.WriteLine("EXECUTANDO O FINALLY");

            //    if (file != null)
            //    {
            //        file.Close();
            //    }
            //}
        }

        private static void TestInnerException()
        {
            try
            {
                CheckingAccount acc = new CheckingAccount(456, 456159);
                CheckingAccount acc2 = new CheckingAccount(456, 456109);

                acc.Withdraw(10000);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine("Argumento com problema: " + e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Balance);
                Console.WriteLine(e.WithdrawValue);

                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Exceção do tipo InsufficientFundsException");
                Console.WriteLine(e.Message);
            }
            catch (FinancialOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
