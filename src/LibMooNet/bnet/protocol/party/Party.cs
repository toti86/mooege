// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol.party {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public static partial class Party {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Party() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "CiRzZXJ2aWNlL3BhcnR5L2RlZmluaXRpb24vcGFydHkucHJvdG8SE2JuZXQu" + 
          "cHJvdG9jb2wucGFydHkaI3NlcnZpY2UvY2hhbm5lbC9jaGFubmVsX3R5cGVz" + 
          "LnByb3RvGhxsaWIvcHJvdG9jb2wvYXR0cmlidXRlLnByb3RvGhlsaWIvcHJv" + 
          "dG9jb2wvZW50aXR5LnByb3RvGh1saWIvcHJvdG9jb2wvaW52aXRhdGlvbi5w" + 
          "cm90bxoRbGliL3JwYy9ycGMucHJvdG8y4QIKDFBhcnR5U2VydmljZRJwCg1D" + 
          "cmVhdGVDaGFubmVsEisuYm5ldC5wcm90b2NvbC5jaGFubmVsLkNyZWF0ZUNo" + 
          "YW5uZWxSZXF1ZXN0GiwuYm5ldC5wcm90b2NvbC5jaGFubmVsLkNyZWF0ZUNo" + 
          "YW5uZWxSZXNwb25zZSIEgLUYARJqCgtKb2luQ2hhbm5lbBIpLmJuZXQucHJv" + 
          "dG9jb2wuY2hhbm5lbC5Kb2luQ2hhbm5lbFJlcXVlc3QaKi5ibmV0LnByb3Rv" + 
          "Y29sLmNoYW5uZWwuSm9pbkNoYW5uZWxSZXNwb25zZSIEgLUYAhJzCg5HZXRD" + 
          "aGFubmVsSW5mbxIsLmJuZXQucHJvdG9jb2wuY2hhbm5lbC5HZXRDaGFubmVs" + 
          "SW5mb1JlcXVlc3QaLS5ibmV0LnByb3RvY29sLmNoYW5uZWwuR2V0Q2hhbm5l" + 
          "bEluZm9SZXNwb25zZSIEgLUYA0IDgAEA");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::bnet.protocol.channel.ChannelTypes.RegisterAllExtensions(registry);
        global::bnet.protocol.attribute.Proto.Attribute.RegisterAllExtensions(registry);
        global::bnet.protocol.Entity.RegisterAllExtensions(registry);
        global::bnet.protocol.invitation.Proto.Invitation.RegisterAllExtensions(registry);
        global::bnet.protocol.Rpc.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::bnet.protocol.channel.ChannelTypes.Descriptor, 
          global::bnet.protocol.attribute.Proto.Attribute.Descriptor, 
          global::bnet.protocol.Entity.Descriptor, 
          global::bnet.protocol.invitation.Proto.Invitation.Descriptor, 
          global::bnet.protocol.Rpc.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Services
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public abstract class PartyService : pb::IService {
    public abstract void CreateChannel(
        pb::IRpcController controller,
        global::bnet.protocol.channel.CreateChannelRequest request,
        global::System.Action<global::bnet.protocol.channel.CreateChannelResponse> done);
    public abstract void JoinChannel(
        pb::IRpcController controller,
        global::bnet.protocol.channel.JoinChannelRequest request,
        global::System.Action<global::bnet.protocol.channel.JoinChannelResponse> done);
    public abstract void GetChannelInfo(
        pb::IRpcController controller,
        global::bnet.protocol.channel.GetChannelInfoRequest request,
        global::System.Action<global::bnet.protocol.channel.GetChannelInfoResponse> done);
    
    public static pbd::ServiceDescriptor Descriptor {
      get { return Party.Descriptor.Services[0]; }
    }
    public pbd::ServiceDescriptor DescriptorForType {
      get { return Descriptor; }
    }
    
    public void CallMethod(
        pbd::MethodDescriptor method,
        pb::IRpcController controller,
        pb::IMessage request,
        global::System.Action<pb::IMessage> done) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.CallMethod() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          this.CreateChannel(controller, (global::bnet.protocol.channel.CreateChannelRequest) request,
              pb::RpcUtil.SpecializeCallback<global::bnet.protocol.channel.CreateChannelResponse>(
              done));
          return;
        case 1:
          this.JoinChannel(controller, (global::bnet.protocol.channel.JoinChannelRequest) request,
              pb::RpcUtil.SpecializeCallback<global::bnet.protocol.channel.JoinChannelResponse>(
              done));
          return;
        case 2:
          this.GetChannelInfo(controller, (global::bnet.protocol.channel.GetChannelInfoRequest) request,
              pb::RpcUtil.SpecializeCallback<global::bnet.protocol.channel.GetChannelInfoResponse>(
              done));
          return;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public pb::IMessage GetRequestPrototype(pbd::MethodDescriptor method) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.GetRequestPrototype() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          return global::bnet.protocol.channel.CreateChannelRequest.DefaultInstance;
        case 1:
          return global::bnet.protocol.channel.JoinChannelRequest.DefaultInstance;
        case 2:
          return global::bnet.protocol.channel.GetChannelInfoRequest.DefaultInstance;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public pb::IMessage GetResponsePrototype(pbd::MethodDescriptor method) {
      if (method.Service != Descriptor) {
        throw new global::System.ArgumentException(
            "Service.GetResponsePrototype() given method descriptor for wrong service type.");
      }
      switch(method.Index) {
        case 0:
          return global::bnet.protocol.channel.CreateChannelResponse.DefaultInstance;
        case 1:
          return global::bnet.protocol.channel.JoinChannelResponse.DefaultInstance;
        case 2:
          return global::bnet.protocol.channel.GetChannelInfoResponse.DefaultInstance;
        default:
          throw new global::System.InvalidOperationException("Can't get here.");
      }
    }
    
    public static Stub CreateStub(pb::IRpcChannel channel) {
      return new Stub(channel);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public class Stub : global::bnet.protocol.party.PartyService {
      internal Stub(pb::IRpcChannel channel) {
        this.channel = channel;
      }
      
      private readonly pb::IRpcChannel channel;
      
      public pb::IRpcChannel Channel {
        get { return channel; }
      }
      
      public override void CreateChannel(
          pb::IRpcController controller,
          global::bnet.protocol.channel.CreateChannelRequest request,
          global::System.Action<global::bnet.protocol.channel.CreateChannelResponse> done) {
        channel.CallMethod(Descriptor.Methods[0],
            controller, request, global::bnet.protocol.channel.CreateChannelResponse.DefaultInstance,
            pb::RpcUtil.GeneralizeCallback<global::bnet.protocol.channel.CreateChannelResponse, global::bnet.protocol.channel.CreateChannelResponse.Builder>(done, global::bnet.protocol.channel.CreateChannelResponse.DefaultInstance));
      }
      
      public override void JoinChannel(
          pb::IRpcController controller,
          global::bnet.protocol.channel.JoinChannelRequest request,
          global::System.Action<global::bnet.protocol.channel.JoinChannelResponse> done) {
        channel.CallMethod(Descriptor.Methods[1],
            controller, request, global::bnet.protocol.channel.JoinChannelResponse.DefaultInstance,
            pb::RpcUtil.GeneralizeCallback<global::bnet.protocol.channel.JoinChannelResponse, global::bnet.protocol.channel.JoinChannelResponse.Builder>(done, global::bnet.protocol.channel.JoinChannelResponse.DefaultInstance));
      }
      
      public override void GetChannelInfo(
          pb::IRpcController controller,
          global::bnet.protocol.channel.GetChannelInfoRequest request,
          global::System.Action<global::bnet.protocol.channel.GetChannelInfoResponse> done) {
        channel.CallMethod(Descriptor.Methods[2],
            controller, request, global::bnet.protocol.channel.GetChannelInfoResponse.DefaultInstance,
            pb::RpcUtil.GeneralizeCallback<global::bnet.protocol.channel.GetChannelInfoResponse, global::bnet.protocol.channel.GetChannelInfoResponse.Builder>(done, global::bnet.protocol.channel.GetChannelInfoResponse.DefaultInstance));
      }
    }
  }
  #endregion
  
}

#endregion Designer generated code