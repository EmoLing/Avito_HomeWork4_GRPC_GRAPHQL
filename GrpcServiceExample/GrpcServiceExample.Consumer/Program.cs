using System;
using System.Threading.Tasks;
using System.Linq;
using Grpc.Core;
using RevService.Generated;
using System.Threading;
using GraphQL;
using GraphQL.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Collections.Generic;

namespace GrpcServiceExample.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var reverseString = Reverse().GetAwaiter().GetResult();

            Console.WriteLine(reverseString);
            Console.ReadKey();
        }
        static async Task<string> Reverse()
        {
            Channel channel = new Channel("localhost", 1111, ChannelCredentials.Insecure);

            RevService.Generated.RevService.RevServiceClient client = new RevService.Generated.RevService.RevServiceClient(channel);
            

            var schema = Schema.For(@"
                  type User {
                      number: String,
                      code: String
                  }

                  type Query {
                       users: [User]
                  }
                  ", _ =>
                  {
                  _.Types.Include<Query>();
                  });

            var json = schema.Execute(_ =>
            {
                _.Query = "{ users { number, code } }";
            });

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(json);

            Thread.Sleep(50);
            Console.Clear();
            Console.ResetColor();
            var data = new RevService.Generated.Data() { Str = json };

            var res = await client.ReverseAsync(data);

            return res.Str;
        }
    }
}
