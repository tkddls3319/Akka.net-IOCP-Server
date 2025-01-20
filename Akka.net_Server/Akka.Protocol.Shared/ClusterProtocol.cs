// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClusterProtocol.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.ClusterProtocol {

  /// <summary>Holder for reflection information generated from ClusterProtocol.proto</summary>
  public static partial class ClusterProtocolReflection {

    #region Descriptor
    /// <summary>File descriptor for ClusterProtocol.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClusterProtocolReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVDbHVzdGVyUHJvdG9jb2wucHJvdG8SD0NsdXN0ZXJQcm90b2NvbBofZ29v",
            "Z2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byI8Cg9TTF9DaGF0V3JpdGVM",
            "b2cSKQoEQ2hhdBgBIAEoCzIbLkNsdXN0ZXJQcm90b2NvbC5DaGF0T2JqZWN0",
            "IiAKDlNMX0NoYXRSZWFkTG9nEg4KBnJvb21JZBgBIAEoBSI8Cg5MU19DaGF0",
            "UmVhZExvZxIqCgVjaGF0cxgBIAMoCzIbLkNsdXN0ZXJQcm90b2NvbC5DaGF0",
            "T2JqZWN0IjwKCkNoYXRPYmplY3QSEAoIb2JqZWN0SWQYASABKAUSDgoGcm9v",
            "bUlkGAIgASgFEgwKBGNoYXQYAyABKAlCIqoCH0dvb2dsZS5Qcm90b2J1Zi5D",
            "bHVzdGVyUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.SL_ChatWriteLog), global::Google.Protobuf.ClusterProtocol.SL_ChatWriteLog.Parser, new[]{ "Chat" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.SL_ChatReadLog), global::Google.Protobuf.ClusterProtocol.SL_ChatReadLog.Parser, new[]{ "RoomId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.LS_ChatReadLog), global::Google.Protobuf.ClusterProtocol.LS_ChatReadLog.Parser, new[]{ "Chats" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.ChatObject), global::Google.Protobuf.ClusterProtocol.ChatObject.Parser, new[]{ "ObjectId", "RoomId", "Chat" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SL_ChatWriteLog : pb::IMessage<SL_ChatWriteLog> {
    private static readonly pb::MessageParser<SL_ChatWriteLog> _parser = new pb::MessageParser<SL_ChatWriteLog>(() => new SL_ChatWriteLog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SL_ChatWriteLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatWriteLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatWriteLog(SL_ChatWriteLog other) : this() {
      chat_ = other.chat_ != null ? other.chat_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatWriteLog Clone() {
      return new SL_ChatWriteLog(this);
    }

    /// <summary>Field number for the "Chat" field.</summary>
    public const int ChatFieldNumber = 1;
    private global::Google.Protobuf.ClusterProtocol.ChatObject chat_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.ClusterProtocol.ChatObject Chat {
      get { return chat_; }
      set {
        chat_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SL_ChatWriteLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SL_ChatWriteLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Chat, other.Chat)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (chat_ != null) hash ^= Chat.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (chat_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Chat);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (chat_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Chat);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SL_ChatWriteLog other) {
      if (other == null) {
        return;
      }
      if (other.chat_ != null) {
        if (chat_ == null) {
          Chat = new global::Google.Protobuf.ClusterProtocol.ChatObject();
        }
        Chat.MergeFrom(other.Chat);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (chat_ == null) {
              Chat = new global::Google.Protobuf.ClusterProtocol.ChatObject();
            }
            input.ReadMessage(Chat);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SL_ChatReadLog : pb::IMessage<SL_ChatReadLog> {
    private static readonly pb::MessageParser<SL_ChatReadLog> _parser = new pb::MessageParser<SL_ChatReadLog>(() => new SL_ChatReadLog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SL_ChatReadLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatReadLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatReadLog(SL_ChatReadLog other) : this() {
      roomId_ = other.roomId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatReadLog Clone() {
      return new SL_ChatReadLog(this);
    }

    /// <summary>Field number for the "roomId" field.</summary>
    public const int RoomIdFieldNumber = 1;
    private int roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SL_ChatReadLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SL_ChatReadLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomId != other.RoomId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RoomId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SL_ChatReadLog other) {
      if (other == null) {
        return;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RoomId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class LS_ChatReadLog : pb::IMessage<LS_ChatReadLog> {
    private static readonly pb::MessageParser<LS_ChatReadLog> _parser = new pb::MessageParser<LS_ChatReadLog>(() => new LS_ChatReadLog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LS_ChatReadLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LS_ChatReadLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LS_ChatReadLog(LS_ChatReadLog other) : this() {
      chats_ = other.chats_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LS_ChatReadLog Clone() {
      return new LS_ChatReadLog(this);
    }

    /// <summary>Field number for the "chats" field.</summary>
    public const int ChatsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Protobuf.ClusterProtocol.ChatObject> _repeated_chats_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Protobuf.ClusterProtocol.ChatObject.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.ClusterProtocol.ChatObject> chats_ = new pbc::RepeatedField<global::Google.Protobuf.ClusterProtocol.ChatObject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.ClusterProtocol.ChatObject> Chats {
      get { return chats_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LS_ChatReadLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LS_ChatReadLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!chats_.Equals(other.chats_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= chats_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      chats_.WriteTo(output, _repeated_chats_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += chats_.CalculateSize(_repeated_chats_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LS_ChatReadLog other) {
      if (other == null) {
        return;
      }
      chats_.Add(other.chats_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            chats_.AddEntriesFrom(input, _repeated_chats_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ChatObject : pb::IMessage<ChatObject> {
    private static readonly pb::MessageParser<ChatObject> _parser = new pb::MessageParser<ChatObject>(() => new ChatObject());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatObject> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatObject() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatObject(ChatObject other) : this() {
      objectId_ = other.objectId_;
      roomId_ = other.roomId_;
      chat_ = other.chat_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatObject Clone() {
      return new ChatObject(this);
    }

    /// <summary>Field number for the "objectId" field.</summary>
    public const int ObjectIdFieldNumber = 1;
    private int objectId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ObjectId {
      get { return objectId_; }
      set {
        objectId_ = value;
      }
    }

    /// <summary>Field number for the "roomId" field.</summary>
    public const int RoomIdFieldNumber = 2;
    private int roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "chat" field.</summary>
    public const int ChatFieldNumber = 3;
    private string chat_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Chat {
      get { return chat_; }
      set {
        chat_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatObject);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatObject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ObjectId != other.ObjectId) return false;
      if (RoomId != other.RoomId) return false;
      if (Chat != other.Chat) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ObjectId != 0) hash ^= ObjectId.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (Chat.Length != 0) hash ^= Chat.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ObjectId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ObjectId);
      }
      if (RoomId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RoomId);
      }
      if (Chat.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Chat);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ObjectId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ObjectId);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomId);
      }
      if (Chat.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Chat);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatObject other) {
      if (other == null) {
        return;
      }
      if (other.ObjectId != 0) {
        ObjectId = other.ObjectId;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.Chat.Length != 0) {
        Chat = other.Chat;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ObjectId = input.ReadInt32();
            break;
          }
          case 16: {
            RoomId = input.ReadInt32();
            break;
          }
          case 26: {
            Chat = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
