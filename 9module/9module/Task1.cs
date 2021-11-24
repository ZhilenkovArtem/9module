using System;

namespace _9module
{
    class Task1
    {
        /*static void Main()
        {
            Exception[] exceptions = new Exception[]
            {
                new NewException(),
                new ArgumentException(),
                new ArgumentNullException(),
                new ExecutionEngineException(),
                new FieldAccessException()
            };

            try
            {

            }
            catch (Exception ex)
            {
                foreach (var exception in exceptions)
                {
                    if (ex.GetType() == exception.GetType())
                        Console.WriteLine(ex.GetType());
                }
            }
        }*/
    }

    class NewException : Exception
    { }
}
