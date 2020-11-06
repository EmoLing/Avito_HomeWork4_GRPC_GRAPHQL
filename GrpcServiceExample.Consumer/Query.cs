using System;
using System.Collections.Generic;
using System.Text;
using GraphQL;
namespace GrpcServiceExample.Consumer
{
    public class Query
    {
        [GraphQLMetadata("users")]
        public IEnumerable<User> GetCode()
        {
            return UserDB.GetCode();
        }
    }
}
