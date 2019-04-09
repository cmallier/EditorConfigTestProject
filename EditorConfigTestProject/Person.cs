using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EditorConfigTestProject
{
    public class Person : IPerson
    {
        // Fields
        private const int SomeConstant = 5;
        private readonly int _aNumber;


        // Constructor
        public Person( string firstName, int aNumber )
        {
            FirstName = firstName;
            _aNumber = aNumber;
        }

        // Properties
        public int MyProperty { get; set; }
        public string FirstName { get; }
        public int ANUmber { get; }
        public bool IsAdmin => true;


        // Methods
        public int Method1( int number )
        {
            int x = 0;

            if( number > SomeConstant )
            {
                x = _aNumber + AddOne( number );
            }
            else
            {
                x = _aNumber + AddOne( number ) + 2;
            }


            // Local functions
            int AddOne( int number2 )
            {
                return number2 + 1;
            }

            return x;
        }

        public int Method2( int number )
        {
            int a;
            switch( number )
            {
                case 1:
                    a = 1;
                    break;
                case 2:
                    a = 2;
                    break;
                default:
                    a = 3;
                    break;
            }

            return a;
        }

        public string Method3()
        {
            try
            {
                return "a";
            }
            catch( Exception ex )
            {
                return ex.Message;
            }
            finally
            {
            }
        }

        public IList<string> Method4()
        {
            var list = new List<string> { "a", "b" };

            return list;
        }

        public int Method5()
        {
            int i = 0;
            int j = 1;

            return i + j;
        }

        public async Task<int> GetMethod2Async()
        {
            return await Task.FromResult( 1 );
        }
    }
}
