// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: dev_tuningfork.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Android.PerformanceTuner {

  /// <summary>Holder for reflection information generated from dev_tuningfork.proto</summary>
  public static partial class DevTuningforkReflection {

    #region Descriptor
    /// <summary>File descriptor for dev_tuningfork.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DevTuningforkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRkZXZfdHVuaW5nZm9yay5wcm90byIjCgpBbm5vdGF0aW9uEhUKBXNjZW5l",
            "GAEgASgOMgYuU2NlbmUiHwoORmlkZWxpdHlQYXJhbXMSDQoFbGV2ZWwYASAB",
            "KAUqGgoFU2NlbmUSEQoNU0NFTkVfSU5WQUxJRBAAQiKqAh9Hb29nbGUuQW5k",
            "cm9pZC5QZXJmb3JtYW5jZVR1bmVyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Android.PerformanceTuner.Scene), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Android.PerformanceTuner.Annotation), global::Google.Android.PerformanceTuner.Annotation.Parser, new[]{ "Scene" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Android.PerformanceTuner.FidelityParams), global::Google.Android.PerformanceTuner.FidelityParams.Parser, new[]{ "Level" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Scene {
    [pbr::OriginalName("SCENE_INVALID")] Invalid = 0,
  }

  #endregion

  #region Messages
  public sealed partial class Annotation : pb::IMessage<Annotation> {
    private static readonly pb::MessageParser<Annotation> _parser = new pb::MessageParser<Annotation>(() => new Annotation());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Annotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Android.PerformanceTuner.DevTuningforkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Annotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Annotation(Annotation other) : this() {
      scene_ = other.scene_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Annotation Clone() {
      return new Annotation(this);
    }

    /// <summary>Field number for the "scene" field.</summary>
    public const int SceneFieldNumber = 1;
    private global::Google.Android.PerformanceTuner.Scene scene_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Android.PerformanceTuner.Scene Scene {
      get { return scene_; }
      set {
        scene_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Annotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Annotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Scene != other.Scene) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Scene != 0) hash ^= Scene.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Scene != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Scene);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Scene != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Scene);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Annotation other) {
      if (other == null) {
        return;
      }
      if (other.Scene != 0) {
        Scene = other.Scene;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            scene_ = (global::Google.Android.PerformanceTuner.Scene) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class FidelityParams : pb::IMessage<FidelityParams> {
    private static readonly pb::MessageParser<FidelityParams> _parser = new pb::MessageParser<FidelityParams>(() => new FidelityParams());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FidelityParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Android.PerformanceTuner.DevTuningforkReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FidelityParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FidelityParams(FidelityParams other) : this() {
      level_ = other.level_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FidelityParams Clone() {
      return new FidelityParams(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FidelityParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FidelityParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Level);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FidelityParams other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Level = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
