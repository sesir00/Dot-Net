using System;
//to create own exception
//1. create error class and inherit Exception class
//2. use throw keyword to throw specific exception

namespace NCCS
{
    //error class
    class AgeException : Exception
    {
        public AgeException( string m ) : base(m)
        {

        }
    }
    class OwnException
    {
        public void sendAge(int  age) 
        {
            if(age < 16 )
            {
                throw new AgeException("age cannot be less than 16");
            }
             else
            {
                Console.WriteLine("Welcome");
            }
        }
       
    }
}
