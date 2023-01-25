using System;

namespace Hello_Exception_stud
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("Observation titmouse flight");
            Bird My_Bird = new Bird("Titmouse", 20);
           

            //1. Create the skeleton code with the  basic exception handling for the menu in the main method 
            //try - catch
            // 1. begin
            //2. Create code for the nested special exception handling in the main method
            //try - catch - catch - finally
            // 2. begin

            //3. Create the menu for three options in the inner try block  
            //In the second option throw the System.Exception
            // 3. begin

            //4. in case 1 code array overflow exception 
            //in case 2 code throw (new System.Exception("Oh! My system exception..."));
            //in case 3  code the sequentially incrementing of Bird speed until to the exception 

            // 3. end

            // 2. end

            // 1. end
            //char rdk;
            //try
            //{
            //    do
            //    {
            //        rdk = Console.ReadKey().KeyChar;
            //    } while (rdk != ' ');

            //}
            //catch ( Exception ex)
            //{

            //}
/*
            try
            {
                My_Bird.FlyAway(20);
            }
            catch ( BirdFlewAwayException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.When);
                Console.WriteLine(e.Why);
            }
            catch( Exception ex )
            {
                Console.WriteLine("ex massage - " + ex.Message + " source - " + ex.Source);
            }
            finally
            {
                Console.WriteLine("for the next step ...");
            }
*/
            
            Console.WriteLine("chek 3 block");

            Console.WriteLine("1. array overflow ");
            Console.WriteLine("2. throw ex ");
            Console.WriteLine("3. user ex ");

            uint i = uint.Parse(Console.ReadLine());
            switch(i)
            {
                case 1: break;
                case 2: throw (new System.Exception("my sys ex"));
                case 3: break;
                default: break;

            }
            
            Console.ReadKey();
        }

    }
}
