using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcServiceExample.Consumer
{
    public class UserDB
    {
        public static IEnumerable<User> GetCode()
        {  
            Console.WriteLine("Введите номер");
            var userNumber =  Console.ReadLine();
            Console.WriteLine("Введите код");
            var userCode = Console.ReadLine();

            return new List<User>()
            {
                new User(){ Number = userNumber, Code=userCode}
            };
        }
    }
}
