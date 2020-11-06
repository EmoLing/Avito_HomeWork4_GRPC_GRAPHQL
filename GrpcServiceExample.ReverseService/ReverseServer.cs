using System;
using System.Collections.Generic;
using System.Text;
using RevService.Generated;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;

namespace GrpcServiceExample.ReverseService
{
    public class ReverseServer
    {
        private readonly Server _server;

        public ReverseServer()
        {
            _server = new Server();
            {
                _server.Ports.Add("localhost", 1111, ServerCredentials.Insecure);
                _server.Services.Add(RevService.Generated.RevService.BindService(new ReverseServiceImplementation()));
            };
        }
        public void Start()
        {
            _server.Start();
        }
        public async Task ShutDownAsync()
        {
            await _server.ShutdownAsync();
        }
    }
}
