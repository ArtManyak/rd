//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.07.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

using JetBrains.Core;
using JetBrains.Diagnostics;
using JetBrains.Collections;
using JetBrains.Collections.Viewable;
using JetBrains.Lifetimes;
using JetBrains.Serialization;
using JetBrains.Rd;
using JetBrains.Rd.Base;
using JetBrains.Rd.Impl;
using JetBrains.Rd.Tasks;
using JetBrains.Rd.Util;
using JetBrains.Rd.Text;


// ReSharper disable RedundantEmptyObjectCreationArgumentList
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantOverflowCheckingContext


namespace Test.RdFramework.Reflection.Generated
{
  
  
  /// <summary>
  /// <p>Generated from: RefRoot.kt:21</p>
  /// </summary>
  public class RefExt : RdExtBase
  {
    //fields
    //public fields
    [NotNull] public IViewableProperty<Base> Struct => _Struct;
    [NotNull] public IViewableProperty<OpenClass> OpenModel => _OpenModel;
    
    //private fields
    [NotNull] private readonly RdProperty<Base> _Struct;
    [NotNull] private readonly RdProperty<OpenClass> _OpenModel;
    
    //primary constructor
    private RefExt(
      [NotNull] RdProperty<Base> @struct,
      [NotNull] RdProperty<OpenClass> openModel
    )
    {
      if (@struct == null) throw new ArgumentNullException("struct");
      if (openModel == null) throw new ArgumentNullException("openModel");
      
      _Struct = @struct;
      _OpenModel = openModel;
      _Struct.OptimizeNested = true;
      BindableChildren.Add(new KeyValuePair<string, object>("struct", _Struct));
      BindableChildren.Add(new KeyValuePair<string, object>("openModel", _OpenModel));
    }
    //secondary constructor
    private RefExt (
    ) : this (
      new RdProperty<Base>(Base.Read, Base.Write),
      new RdProperty<OpenClass>(OpenClass.Read, WriteOpenClass)
    ) {}
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<OpenClass> ReadOpenClass = Polymorphic<OpenClass>.ReadAbstract(OpenClass_Unknown.Read);
    
    public static  CtxWriteDelegate<OpenClass> WriteOpenClass = Polymorphic<OpenClass>.Write;
    
    protected override long SerializationHash => 7552167435222878147L;
    
    protected override Action<ISerializers> Register => RegisterDeclaredTypesSerializers;
    public static void RegisterDeclaredTypesSerializers(ISerializers serializers)
    {
      serializers.Register(OpenClass.Read, OpenClass.Write);
      serializers.Register(Derived.Read, Derived.Write);
      serializers.Register(Open.Read, Open.Write);
      serializers.Register(OpenDerived.Read, OpenDerived.Write);
      serializers.Register(Base_Unknown.Read, Base_Unknown.Write);
      serializers.Register(OpenClass_Unknown.Read, OpenClass_Unknown.Write);
      serializers.Register(Open_Unknown.Read, Open_Unknown.Write);
      serializers.Register(OpenDerived_Unknown.Read, OpenDerived_Unknown.Write);
      
      serializers.RegisterToplevelOnce(typeof(RefRoot), RefRoot.RegisterDeclaredTypesSerializers);
    }
    
    public RefExt(Lifetime lifetime, IProtocol protocol) : this()
    {
      Identify(protocol.Identities, RdId.Root.Mix("RefExt"));
      Bind(lifetime, protocol, "RefExt");
    }
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("RefExt (");
      using (printer.IndentCookie()) {
        printer.Print("struct = "); _Struct.PrintEx(printer); printer.Println();
        printer.Print("openModel = "); _OpenModel.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: RefRoot.kt:26</p>
  /// </summary>
  public abstract class Base{
    //fields
    //public fields
    
    //private fields
    //primary constructor
    //secondary constructor
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<Base> Read = Polymorphic<Base>.ReadAbstract(Base_Unknown.Read);
    
    public static CtxWriteDelegate<Base> Write = Polymorphic<Base>.Write;
    
    //constants
    public const char const_base = 'B';
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    //toString
  }
  
  
  public sealed class Base_Unknown : Base
  {
    //fields
    //public fields
    
    //private fields
    //primary constructor
    //secondary constructor
    //deconstruct trait
    //statics
    
    public static new CtxReadDelegate<Base_Unknown> Read = (ctx, reader) => 
    {
      var _result = new Base_Unknown();
      return _result;
    };
    
    public static new CtxWriteDelegate<Base_Unknown> Write = (ctx, writer, value) => 
    {
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((Base_Unknown) obj);
    }
    public bool Equals(Base_Unknown other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return true;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        return hash;
      }
    }
    //pretty print
    public void Print(PrettyPrinter printer)
    {
      printer.Println("Base_Unknown (");
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: RefRoot.kt:47</p>
  /// </summary>
  public sealed class ComplicatedPair : IPrintable, IEquatable<ComplicatedPair>
  {
    //fields
    //public fields
    [NotNull] public Derived First {get; private set;}
    [NotNull] public Derived Second {get; private set;}
    
    //private fields
    //primary constructor
    public ComplicatedPair(
      [NotNull] Derived first,
      [NotNull] Derived second
    )
    {
      if (first == null) throw new ArgumentNullException("first");
      if (second == null) throw new ArgumentNullException("second");
      
      First = first;
      Second = second;
    }
    //secondary constructor
    //deconstruct trait
    public void Deconstruct([NotNull] out Derived first, [NotNull] out Derived second)
    {
      first = First;
      second = Second;
    }
    //statics
    
    public static CtxReadDelegate<ComplicatedPair> Read = (ctx, reader) => 
    {
      var first = Derived.Read(ctx, reader);
      var second = Derived.Read(ctx, reader);
      var _result = new ComplicatedPair(first, second);
      return _result;
    };
    
    public static CtxWriteDelegate<ComplicatedPair> Write = (ctx, writer, value) => 
    {
      Derived.Write(ctx, writer, value.First);
      Derived.Write(ctx, writer, value.Second);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((ComplicatedPair) obj);
    }
    public bool Equals(ComplicatedPair other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return Equals(First, other.First) && Equals(Second, other.Second);
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + First.GetHashCode();
        hash = hash * 31 + Second.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public void Print(PrettyPrinter printer)
    {
      printer.Println("ComplicatedPair (");
      using (printer.IndentCookie()) {
        printer.Print("first = "); First.PrintEx(printer); printer.Println();
        printer.Print("second = "); Second.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: RefRoot.kt:35</p>
  /// </summary>
  public sealed class Derived : Base
  {
    //fields
    //public fields
    [NotNull] public string String {get; private set;}
    
    //private fields
    //primary constructor
    public Derived(
      [NotNull] string @string
    )
    {
      if (@string == null) throw new ArgumentNullException("string");
      
      String = @string;
    }
    //secondary constructor
    //deconstruct trait
    //statics
    
    public static new CtxReadDelegate<Derived> Read = (ctx, reader) => 
    {
      var @string = reader.ReadString();
      var _result = new Derived(@string);
      return _result;
    };
    
    public static new CtxWriteDelegate<Derived> Write = (ctx, writer, value) => 
    {
      writer.Write(value.String);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((Derived) obj);
    }
    public bool Equals(Derived other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return String == other.String;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + String.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public void Print(PrettyPrinter printer)
    {
      printer.Println("Derived (");
      using (printer.IndentCookie()) {
        printer.Print("string = "); String.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: RefRoot.kt:39</p>
  /// </summary>
  public class Open : Base
  {
    //fields
    //public fields
    [NotNull] public string OpenString {get; private set;}
    
    //private fields
    //primary constructor
    public Open(
      [NotNull] string openString
    )
    {
      if (openString == null) throw new ArgumentNullException("openString");
      
      OpenString = openString;
    }
    //secondary constructor
    //deconstruct trait
    //statics
    
    public static new CtxReadDelegate<Open> Read = (ctx, reader) => 
    {
      var openString = reader.ReadString();
      var _result = new Open(openString);
      return _result;
    };
    
    public static new CtxWriteDelegate<Open> Write = (ctx, writer, value) => 
    {
      writer.Write(value.OpenString);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((Open) obj);
    }
    public bool Equals(Open other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return OpenString == other.OpenString;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + OpenString.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public virtual void Print(PrettyPrinter printer)
    {
      printer.Println("Open (");
      using (printer.IndentCookie()) {
        printer.Print("openString = "); OpenString.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: RefRoot.kt:30</p>
  /// </summary>
  public class OpenClass : RdBindableBase
  {
    //fields
    //public fields
    [NotNull] public IViewableProperty<string> String => _String;
    [NotNull] public string Field {get; private set;}
    
    //private fields
    [NotNull] protected readonly RdProperty<string> _String;
    
    //primary constructor
    protected OpenClass(
      [NotNull] RdProperty<string> @string,
      [NotNull] string field
    )
    {
      if (@string == null) throw new ArgumentNullException("string");
      if (field == null) throw new ArgumentNullException("field");
      
      _String = @string;
      Field = field;
      _String.OptimizeNested = true;
      BindableChildren.Add(new KeyValuePair<string, object>("string", _String));
    }
    //secondary constructor
    public OpenClass (
      [NotNull] string field
    ) : this (
      new RdProperty<string>(JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString),
      field
    ) {}
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<OpenClass> Read = (ctx, reader) => 
    {
      var _id = RdId.Read(reader);
      var @string = RdProperty<string>.Read(ctx, reader, JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString);
      var field = reader.ReadString();
      var _result = new OpenClass(@string, field).WithId(_id);
      return _result;
    };
    
    public static CtxWriteDelegate<OpenClass> Write = (ctx, writer, value) => 
    {
      value.RdId.Write(writer);
      RdProperty<string>.Write(ctx, writer, value._String);
      writer.Write(value.Field);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("OpenClass (");
      using (printer.IndentCookie()) {
        printer.Print("string = "); _String.PrintEx(printer); printer.Println();
        printer.Print("field = "); Field.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  public sealed class OpenClass_Unknown : OpenClass
  {
    //fields
    //public fields
    
    //private fields
    //primary constructor
    private OpenClass_Unknown(
      [NotNull] RdProperty<string> @string,
      [NotNull] string field
    ) : base (
      @string,
      field
     ) 
    {
    }
    //secondary constructor
    public OpenClass_Unknown (
      [NotNull] string field
    ) : this (
      new RdProperty<string>(JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString),
      field
    ) {}
    //deconstruct trait
    //statics
    
    public static new CtxReadDelegate<OpenClass_Unknown> Read = (ctx, reader) => 
    {
      var _id = RdId.Read(reader);
      var @string = RdProperty<string>.Read(ctx, reader, JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString);
      var field = reader.ReadString();
      var _result = new OpenClass_Unknown(@string, field).WithId(_id);
      return _result;
    };
    
    public static new CtxWriteDelegate<OpenClass_Unknown> Write = (ctx, writer, value) => 
    {
      value.RdId.Write(writer);
      RdProperty<string>.Write(ctx, writer, value._String);
      writer.Write(value.Field);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("OpenClass_Unknown (");
      using (printer.IndentCookie()) {
        printer.Print("string = "); _String.PrintEx(printer); printer.Println();
        printer.Print("field = "); Field.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: RefRoot.kt:43</p>
  /// </summary>
  public class OpenDerived : Open
  {
    //fields
    //public fields
    [NotNull] public string OpenDerivedString {get; private set;}
    
    //private fields
    //primary constructor
    public OpenDerived(
      [NotNull] string openDerivedString,
      [NotNull] string openString
    ) : base (
      openString
     ) 
    {
      if (openDerivedString == null) throw new ArgumentNullException("openDerivedString");
      
      OpenDerivedString = openDerivedString;
    }
    //secondary constructor
    //deconstruct trait
    //statics
    
    public static new CtxReadDelegate<OpenDerived> Read = (ctx, reader) => 
    {
      var openString = reader.ReadString();
      var openDerivedString = reader.ReadString();
      var _result = new OpenDerived(openDerivedString, openString);
      return _result;
    };
    
    public static new CtxWriteDelegate<OpenDerived> Write = (ctx, writer, value) => 
    {
      writer.Write(value.OpenString);
      writer.Write(value.OpenDerivedString);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((OpenDerived) obj);
    }
    public bool Equals(OpenDerived other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return OpenDerivedString == other.OpenDerivedString && OpenString == other.OpenString;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + OpenDerivedString.GetHashCode();
        hash = hash * 31 + OpenString.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("OpenDerived (");
      using (printer.IndentCookie()) {
        printer.Print("openDerivedString = "); OpenDerivedString.PrintEx(printer); printer.Println();
        printer.Print("openString = "); OpenString.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  public sealed class OpenDerived_Unknown : OpenDerived
  {
    //fields
    //public fields
    
    //private fields
    //primary constructor
    public OpenDerived_Unknown(
      [NotNull] string openDerivedString,
      [NotNull] string openString
    ) : base (
      openDerivedString,
      openString
     ) 
    {
    }
    //secondary constructor
    //deconstruct trait
    //statics
    
    public static new CtxReadDelegate<OpenDerived_Unknown> Read = (ctx, reader) => 
    {
      var openDerivedString = reader.ReadString();
      var openString = reader.ReadString();
      var _result = new OpenDerived_Unknown(openDerivedString, openString);
      return _result;
    };
    
    public static new CtxWriteDelegate<OpenDerived_Unknown> Write = (ctx, writer, value) => 
    {
      writer.Write(value.OpenDerivedString);
      writer.Write(value.OpenString);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((OpenDerived_Unknown) obj);
    }
    public bool Equals(OpenDerived_Unknown other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return OpenDerivedString == other.OpenDerivedString && OpenString == other.OpenString;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + OpenDerivedString.GetHashCode();
        hash = hash * 31 + OpenString.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("OpenDerived_Unknown (");
      using (printer.IndentCookie()) {
        printer.Print("openDerivedString = "); OpenDerivedString.PrintEx(printer); printer.Println();
        printer.Print("openString = "); OpenString.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  public sealed class Open_Unknown : Open
  {
    //fields
    //public fields
    
    //private fields
    //primary constructor
    public Open_Unknown(
      [NotNull] string openString
    ) : base (
      openString
     ) 
    {
    }
    //secondary constructor
    //deconstruct trait
    //statics
    
    public static new CtxReadDelegate<Open_Unknown> Read = (ctx, reader) => 
    {
      var openString = reader.ReadString();
      var _result = new Open_Unknown(openString);
      return _result;
    };
    
    public static new CtxWriteDelegate<Open_Unknown> Write = (ctx, writer, value) => 
    {
      writer.Write(value.OpenString);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((Open_Unknown) obj);
    }
    public bool Equals(Open_Unknown other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return OpenString == other.OpenString;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + OpenString.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("Open_Unknown (");
      using (printer.IndentCookie()) {
        printer.Print("openString = "); OpenString.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
}