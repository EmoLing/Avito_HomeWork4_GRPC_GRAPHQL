using System;
using System.Collections.Generic;
using System.Text;
using RevService.Generated;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace GrpcServiceExample.ReverseService
{
    public class ReverseServiceImplementation : RevService.Generated.RevService.RevServiceBase
    {
        public override Task<Data> Reverse(Data request, ServerCallContext context)
        {
            var user_request = new string(request.Str);
            var user_number = JObject.Parse(user_request)["data"]["users"][0]["number"].ToString();
            var user_code = JObject.Parse(user_request)["data"]["users"][0]["code"].ToString();
            string server_responce = string.Empty;
            if (UsersKeys(user_number, user_code))
                server_responce = "Доступ разрешен!";
            else
                server_responce = "Доступ закрыт!";

            var response = new Data() { Str = new string(server_responce) };
            return Task.FromResult(response);
        }
        private bool UsersKeys(string user_number, string user_code)
        {
            Dictionary<string, string> AllKeys = new Dictionary<string, string>();
            AllKeys.Add("89104914001", "6666");
            AllKeys.Add("88005533535", "1111");

            if (AllKeys.ContainsKey(user_number) && AllKeys.ContainsValue(user_code))
                return true;
            else return false;
        }
    }
}
