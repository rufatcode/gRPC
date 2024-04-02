// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: file.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace grpcFileClient {

  /// <summary>Holder for reflection information generated from file.proto</summary>
  public static partial class FileReflection {

    #region Descriptor
    /// <summary>File descriptor for file.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpmaWxlLnByb3RvEgpmaWxlU2VydmVyGhtnb29nbGUvcHJvdG9idWYvZW1w",
            "dHkucHJvdG8iMwoIRmlsZUluZm8SEAoIZmlsZU5hbWUYASABKAkSFQoNZmls",
            "ZUV4dGVudGlvbhgCIAEoCSJmCgxCeXRlc0NvbnRlbnQSEAoIZmlsZVNpemUY",
            "ASABKAMSDgoGYnVmZmVyGAIgASgMEiIKBGluZm8YAyABKAsyFC5maWxlU2Vy",
            "dmVyLkZpbGVJbmZvEhAKCHJlYWRCeXRlGAQgASgFMpABCgpGaWxlUHJvc2Vz",
            "EkAKCkZpbGVVcGxvYWQSGC5maWxlU2VydmVyLkJ5dGVzQ29udGVudBoWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eSgBEkAKDEZpbGVEb3duTG9hZBIULmZpbGVT",
            "ZXJ2ZXIuRmlsZUluZm8aGC5maWxlU2VydmVyLkJ5dGVzQ29udGVudDABQhGq",
            "Ag5ncnBjRmlsZUNsaWVudGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcFileClient.FileInfo), global::grpcFileClient.FileInfo.Parser, new[]{ "FileName", "FileExtention" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcFileClient.BytesContent), global::grpcFileClient.BytesContent.Parser, new[]{ "FileSize", "Buffer", "Info", "ReadByte" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FileInfo : pb::IMessage<FileInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FileInfo> _parser = new pb::MessageParser<FileInfo>(() => new FileInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FileInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcFileClient.FileReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FileInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FileInfo(FileInfo other) : this() {
      fileName_ = other.fileName_;
      fileExtention_ = other.fileExtention_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FileInfo Clone() {
      return new FileInfo(this);
    }

    /// <summary>Field number for the "fileName" field.</summary>
    public const int FileNameFieldNumber = 1;
    private string fileName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FileName {
      get { return fileName_; }
      set {
        fileName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fileExtention" field.</summary>
    public const int FileExtentionFieldNumber = 2;
    private string fileExtention_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FileExtention {
      get { return fileExtention_; }
      set {
        fileExtention_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FileInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FileInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FileName != other.FileName) return false;
      if (FileExtention != other.FileExtention) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FileName.Length != 0) hash ^= FileName.GetHashCode();
      if (FileExtention.Length != 0) hash ^= FileExtention.GetHashCode();
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
      if (FileName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FileName);
      }
      if (FileExtention.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FileExtention);
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
      if (FileName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FileName);
      }
      if (FileExtention.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FileExtention);
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
      if (FileName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileName);
      }
      if (FileExtention.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileExtention);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FileInfo other) {
      if (other == null) {
        return;
      }
      if (other.FileName.Length != 0) {
        FileName = other.FileName;
      }
      if (other.FileExtention.Length != 0) {
        FileExtention = other.FileExtention;
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
            FileName = input.ReadString();
            break;
          }
          case 18: {
            FileExtention = input.ReadString();
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
            FileName = input.ReadString();
            break;
          }
          case 18: {
            FileExtention = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BytesContent : pb::IMessage<BytesContent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BytesContent> _parser = new pb::MessageParser<BytesContent>(() => new BytesContent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BytesContent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcFileClient.FileReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BytesContent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BytesContent(BytesContent other) : this() {
      fileSize_ = other.fileSize_;
      buffer_ = other.buffer_;
      info_ = other.info_ != null ? other.info_.Clone() : null;
      readByte_ = other.readByte_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BytesContent Clone() {
      return new BytesContent(this);
    }

    /// <summary>Field number for the "fileSize" field.</summary>
    public const int FileSizeFieldNumber = 1;
    private long fileSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long FileSize {
      get { return fileSize_; }
      set {
        fileSize_ = value;
      }
    }

    /// <summary>Field number for the "buffer" field.</summary>
    public const int BufferFieldNumber = 2;
    private pb::ByteString buffer_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Buffer {
      get { return buffer_; }
      set {
        buffer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 3;
    private global::grpcFileClient.FileInfo info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::grpcFileClient.FileInfo Info {
      get { return info_; }
      set {
        info_ = value;
      }
    }

    /// <summary>Field number for the "readByte" field.</summary>
    public const int ReadByteFieldNumber = 4;
    private int readByte_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ReadByte {
      get { return readByte_; }
      set {
        readByte_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BytesContent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BytesContent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FileSize != other.FileSize) return false;
      if (Buffer != other.Buffer) return false;
      if (!object.Equals(Info, other.Info)) return false;
      if (ReadByte != other.ReadByte) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FileSize != 0L) hash ^= FileSize.GetHashCode();
      if (Buffer.Length != 0) hash ^= Buffer.GetHashCode();
      if (info_ != null) hash ^= Info.GetHashCode();
      if (ReadByte != 0) hash ^= ReadByte.GetHashCode();
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
      if (FileSize != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(FileSize);
      }
      if (Buffer.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Buffer);
      }
      if (info_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Info);
      }
      if (ReadByte != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ReadByte);
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
      if (FileSize != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(FileSize);
      }
      if (Buffer.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Buffer);
      }
      if (info_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Info);
      }
      if (ReadByte != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ReadByte);
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
      if (FileSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FileSize);
      }
      if (Buffer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Buffer);
      }
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
      if (ReadByte != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ReadByte);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BytesContent other) {
      if (other == null) {
        return;
      }
      if (other.FileSize != 0L) {
        FileSize = other.FileSize;
      }
      if (other.Buffer.Length != 0) {
        Buffer = other.Buffer;
      }
      if (other.info_ != null) {
        if (info_ == null) {
          Info = new global::grpcFileClient.FileInfo();
        }
        Info.MergeFrom(other.Info);
      }
      if (other.ReadByte != 0) {
        ReadByte = other.ReadByte;
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
          case 8: {
            FileSize = input.ReadInt64();
            break;
          }
          case 18: {
            Buffer = input.ReadBytes();
            break;
          }
          case 26: {
            if (info_ == null) {
              Info = new global::grpcFileClient.FileInfo();
            }
            input.ReadMessage(Info);
            break;
          }
          case 32: {
            ReadByte = input.ReadInt32();
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
          case 8: {
            FileSize = input.ReadInt64();
            break;
          }
          case 18: {
            Buffer = input.ReadBytes();
            break;
          }
          case 26: {
            if (info_ == null) {
              Info = new global::grpcFileClient.FileInfo();
            }
            input.ReadMessage(Info);
            break;
          }
          case 32: {
            ReadByte = input.ReadInt32();
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
