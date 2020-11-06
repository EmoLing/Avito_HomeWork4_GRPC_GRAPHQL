// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/reverseservicecontract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RevService.Generated {
  public static partial class RevService
  {
    static readonly string __ServiceName = "proto.RevService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::RevService.Generated.Data> __Marshaller_proto_Data = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RevService.Generated.Data.Parser));

    static readonly grpc::Method<global::RevService.Generated.Data, global::RevService.Generated.Data> __Method_Reverse = new grpc::Method<global::RevService.Generated.Data, global::RevService.Generated.Data>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Reverse",
        __Marshaller_proto_Data,
        __Marshaller_proto_Data);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RevService.Generated.ReverseservicecontractReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RevService</summary>
    [grpc::BindServiceMethod(typeof(RevService), "BindService")]
    public abstract partial class RevServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::RevService.Generated.Data> Reverse(global::RevService.Generated.Data request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RevService</summary>
    public partial class RevServiceClient : grpc::ClientBase<RevServiceClient>
    {
      /// <summary>Creates a new client for RevService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RevServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RevService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RevServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RevServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RevServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::RevService.Generated.Data Reverse(global::RevService.Generated.Data request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Reverse(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RevService.Generated.Data Reverse(global::RevService.Generated.Data request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Reverse, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RevService.Generated.Data> ReverseAsync(global::RevService.Generated.Data request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReverseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RevService.Generated.Data> ReverseAsync(global::RevService.Generated.Data request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Reverse, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RevServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RevServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RevServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Reverse, serviceImpl.Reverse).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RevServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Reverse, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RevService.Generated.Data, global::RevService.Generated.Data>(serviceImpl.Reverse));
    }

  }
}
#endregion
