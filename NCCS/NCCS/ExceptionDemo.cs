
//Exception is any abnormal condition that disturb the normal flow of program. so to handle such exception, Exception handling is required
//exeception handling includes following keywords
//try : if error can occur in code then it is surrounded by try block
//catch : for every try block catch is required
//throw : use to generate own exception ( custom exception )
//finally : every code in finally block are executed whether exception occur or not
namespace NCCS
{
    class ExceptionDemo
    {
        public void setException()
        {
            //user input
            Console.WriteLine("enter first number : ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number : ");
            int y = Int32.Parse(Console.ReadLine());
            try
            {
                int div = x / y;
                Console.WriteLine("div is " + div);
            } catch (DivideByZeroException d) 
            {
                Console.WriteLine("Cannot divide " + d);
            }
            catch(Exception e) //garne yeti error ko name thaha xaina bane yo matra lekhne
            {
                Console.WriteLine("error message !!!");
            }
            finally
            {
                Console.WriteLine("always  executed !!");       
            }
            Console.WriteLine("out of try catch ");

        }
    }
}
