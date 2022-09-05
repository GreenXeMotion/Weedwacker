// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeVerifyData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HomeVerifyData.proto</summary>
  public static partial class HomeVerifyDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeVerifyData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeVerifyDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRIb21lVmVyaWZ5RGF0YS5wcm90bxoiSG9tZVNjZW5lQXJyYW5nZW1lbnRN",
            "dWlwRGF0YS5wcm90bxoZSG9tZVZlcmlmeVNjZW5lRGF0YS5wcm90bxoSTGFu",
            "Z3VhZ2VUeXBlLnByb3RvIu4BCg5Ib21lVmVyaWZ5RGF0YRIbChNVbmsyNzAw",
            "X09BS0JES0tCRkhQGAcgASgJEhEKCXRpbWVzdGFtcBgPIAEoBxILCgN1aWQY",
            "BSABKA0SOgoTVW5rMjcwMF9DREVMREJMS0xETxgJIAEoCzIdLkhvbWVTY2Vu",
            "ZUFycmFuZ2VtZW50TXVpcERhdGESDgoGcmVnaW9uGAMgASgJEg0KBXRva2Vu",
            "GAEgASgJEicKCWhvbWVfaW5mbxgGIAEoCzIULkhvbWVWZXJpZnlTY2VuZURh",
            "dGESGwoEbGFuZxgIIAEoDjINLkxhbmd1YWdlVHlwZUIaqgIXV2VlZHdhY2tl",
            "ci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.HomeSceneArrangementMuipDataReflection.Descriptor, global::Weedwacker.Server.Proto.HomeVerifySceneDataReflection.Descriptor, global::Weedwacker.Server.Proto.LanguageTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomeVerifyData), global::Weedwacker.Server.Proto.HomeVerifyData.Parser, new[]{ "Unk2700OAKBDKKBFHP", "Timestamp", "Uid", "Unk2700CDELDBLKLDO", "Region", "Token", "HomeInfo", "Lang" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeVerifyData : pb::IMessage<HomeVerifyData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeVerifyData> _parser = new pb::MessageParser<HomeVerifyData>(() => new HomeVerifyData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeVerifyData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HomeVerifyDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeVerifyData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeVerifyData(HomeVerifyData other) : this() {
      unk2700OAKBDKKBFHP_ = other.unk2700OAKBDKKBFHP_;
      timestamp_ = other.timestamp_;
      uid_ = other.uid_;
      unk2700CDELDBLKLDO_ = other.unk2700CDELDBLKLDO_ != null ? other.unk2700CDELDBLKLDO_.Clone() : null;
      region_ = other.region_;
      token_ = other.token_;
      homeInfo_ = other.homeInfo_ != null ? other.homeInfo_.Clone() : null;
      lang_ = other.lang_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeVerifyData Clone() {
      return new HomeVerifyData(this);
    }

    /// <summary>Field number for the "Unk2700_OAKBDKKBFHP" field.</summary>
    public const int Unk2700OAKBDKKBFHPFieldNumber = 7;
    private string unk2700OAKBDKKBFHP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk2700OAKBDKKBFHP {
      get { return unk2700OAKBDKKBFHP_; }
      set {
        unk2700OAKBDKKBFHP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 15;
    private uint timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 5;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_CDELDBLKLDO" field.</summary>
    public const int Unk2700CDELDBLKLDOFieldNumber = 9;
    private global::Weedwacker.Server.Proto.HomeSceneArrangementMuipData unk2700CDELDBLKLDO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.HomeSceneArrangementMuipData Unk2700CDELDBLKLDO {
      get { return unk2700CDELDBLKLDO_; }
      set {
        unk2700CDELDBLKLDO_ = value;
      }
    }

    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 3;
    private string region_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Region {
      get { return region_; }
      set {
        region_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 1;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "home_info" field.</summary>
    public const int HomeInfoFieldNumber = 6;
    private global::Weedwacker.Server.Proto.HomeVerifySceneData homeInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.HomeVerifySceneData HomeInfo {
      get { return homeInfo_; }
      set {
        homeInfo_ = value;
      }
    }

    /// <summary>Field number for the "lang" field.</summary>
    public const int LangFieldNumber = 8;
    private global::Weedwacker.Server.Proto.LanguageType lang_ = global::Weedwacker.Server.Proto.LanguageType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.LanguageType Lang {
      get { return lang_; }
      set {
        lang_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeVerifyData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeVerifyData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700OAKBDKKBFHP != other.Unk2700OAKBDKKBFHP) return false;
      if (Timestamp != other.Timestamp) return false;
      if (Uid != other.Uid) return false;
      if (!object.Equals(Unk2700CDELDBLKLDO, other.Unk2700CDELDBLKLDO)) return false;
      if (Region != other.Region) return false;
      if (Token != other.Token) return false;
      if (!object.Equals(HomeInfo, other.HomeInfo)) return false;
      if (Lang != other.Lang) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700OAKBDKKBFHP.Length != 0) hash ^= Unk2700OAKBDKKBFHP.GetHashCode();
      if (Timestamp != 0) hash ^= Timestamp.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (unk2700CDELDBLKLDO_ != null) hash ^= Unk2700CDELDBLKLDO.GetHashCode();
      if (Region.Length != 0) hash ^= Region.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (homeInfo_ != null) hash ^= HomeInfo.GetHashCode();
      if (Lang != global::Weedwacker.Server.Proto.LanguageType.None) hash ^= Lang.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Token.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Token);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Region);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      if (homeInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(HomeInfo);
      }
      if (Unk2700OAKBDKKBFHP.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Unk2700OAKBDKKBFHP);
      }
      if (Lang != global::Weedwacker.Server.Proto.LanguageType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Lang);
      }
      if (unk2700CDELDBLKLDO_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Unk2700CDELDBLKLDO);
      }
      if (Timestamp != 0) {
        output.WriteRawTag(125);
        output.WriteFixed32(Timestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Token.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Token);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Region);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      if (homeInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(HomeInfo);
      }
      if (Unk2700OAKBDKKBFHP.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Unk2700OAKBDKKBFHP);
      }
      if (Lang != global::Weedwacker.Server.Proto.LanguageType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Lang);
      }
      if (unk2700CDELDBLKLDO_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Unk2700CDELDBLKLDO);
      }
      if (Timestamp != 0) {
        output.WriteRawTag(125);
        output.WriteFixed32(Timestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Unk2700OAKBDKKBFHP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk2700OAKBDKKBFHP);
      }
      if (Timestamp != 0) {
        size += 1 + 4;
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (unk2700CDELDBLKLDO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2700CDELDBLKLDO);
      }
      if (Region.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (homeInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HomeInfo);
      }
      if (Lang != global::Weedwacker.Server.Proto.LanguageType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Lang);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeVerifyData other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700OAKBDKKBFHP.Length != 0) {
        Unk2700OAKBDKKBFHP = other.Unk2700OAKBDKKBFHP;
      }
      if (other.Timestamp != 0) {
        Timestamp = other.Timestamp;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.unk2700CDELDBLKLDO_ != null) {
        if (unk2700CDELDBLKLDO_ == null) {
          Unk2700CDELDBLKLDO = new global::Weedwacker.Server.Proto.HomeSceneArrangementMuipData();
        }
        Unk2700CDELDBLKLDO.MergeFrom(other.Unk2700CDELDBLKLDO);
      }
      if (other.Region.Length != 0) {
        Region = other.Region;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.homeInfo_ != null) {
        if (homeInfo_ == null) {
          HomeInfo = new global::Weedwacker.Server.Proto.HomeVerifySceneData();
        }
        HomeInfo.MergeFrom(other.HomeInfo);
      }
      if (other.Lang != global::Weedwacker.Server.Proto.LanguageType.None) {
        Lang = other.Lang;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Token = input.ReadString();
            break;
          }
          case 26: {
            Region = input.ReadString();
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 50: {
            if (homeInfo_ == null) {
              HomeInfo = new global::Weedwacker.Server.Proto.HomeVerifySceneData();
            }
            input.ReadMessage(HomeInfo);
            break;
          }
          case 58: {
            Unk2700OAKBDKKBFHP = input.ReadString();
            break;
          }
          case 64: {
            Lang = (global::Weedwacker.Server.Proto.LanguageType) input.ReadEnum();
            break;
          }
          case 74: {
            if (unk2700CDELDBLKLDO_ == null) {
              Unk2700CDELDBLKLDO = new global::Weedwacker.Server.Proto.HomeSceneArrangementMuipData();
            }
            input.ReadMessage(Unk2700CDELDBLKLDO);
            break;
          }
          case 125: {
            Timestamp = input.ReadFixed32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Token = input.ReadString();
            break;
          }
          case 26: {
            Region = input.ReadString();
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 50: {
            if (homeInfo_ == null) {
              HomeInfo = new global::Weedwacker.Server.Proto.HomeVerifySceneData();
            }
            input.ReadMessage(HomeInfo);
            break;
          }
          case 58: {
            Unk2700OAKBDKKBFHP = input.ReadString();
            break;
          }
          case 64: {
            Lang = (global::Weedwacker.Server.Proto.LanguageType) input.ReadEnum();
            break;
          }
          case 74: {
            if (unk2700CDELDBLKLDO_ == null) {
              Unk2700CDELDBLKLDO = new global::Weedwacker.Server.Proto.HomeSceneArrangementMuipData();
            }
            input.ReadMessage(Unk2700CDELDBLKLDO);
            break;
          }
          case 125: {
            Timestamp = input.ReadFixed32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code