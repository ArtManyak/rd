//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.10.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#ifndef FOO_GENERATED_H
#define FOO_GENERATED_H


#include "protocol/Protocol.h"
#include "types/DateTime.h"
#include "impl/RdSignal.h"
#include "impl/RdProperty.h"
#include "impl/RdList.h"
#include "impl/RdSet.h"
#include "impl/RdMap.h"
#include "base/ISerializersOwner.h"
#include "base/IUnknownInstance.h"
#include "serialization/ISerializable.h"
#include "serialization/Polymorphic.h"
#include "serialization/NullableSerializer.h"
#include "serialization/ArraySerializer.h"
#include "serialization/InternedSerializer.h"
#include "serialization/SerializationCtx.h"
#include "serialization/Serializers.h"
#include "ext/RdExtBase.h"
#include "task/RdCall.h"
#include "task/RdEndpoint.h"
#include "task/RdSymmetricCall.h"
#include "std/to_string.h"
#include "std/hash.h"
#include "std/allocator.h"
#include "util/enum.h"
#include "util/gen_util.h"

#include <cstring>
#include <cstdint>
#include <vector>
#include <ctime>

#include "thirdparty.hpp"
#include "instantiations_ExampleRootNova.h"



#ifdef _MSC_VER
#pragma warning( push )
#pragma warning( disable:4250 )
#pragma warning( disable:4307 )
#pragma warning( disable:4267 )
#pragma warning( disable:4244 )
#pragma warning( disable:4100 )
#endif

/// <summary>
/// <p>Generated from: Example.kt:34</p>
/// </summary>
namespace org.example {

// abstract
class Foo : public rd::IPolymorphicSerializable, public rd::RdBindableBase {

private:
    // custom serializers

public:
    // constants

protected:
    // fields
    int32_t x_;
    rd::RdMap<int32_t, int32_t, rd::Polymorphic<int32_t>, rd::Polymorphic<int32_t>> sdf_;
    

private:
    // initializer
    void initialize();

public:
    // primary ctor
    Foo(int32_t x_, rd::RdMap<int32_t, int32_t, rd::Polymorphic<int32_t>, rd::Polymorphic<int32_t>> sdf_);
    
    // default ctors and dtors
    
    Foo() = delete;
    
    Foo(Foo &&) = default;
    
    Foo& operator=(Foo &&) = default;
    
    virtual ~Foo() = default;
    
    // reader
    static rd::Wrapper<Foo> readUnknownInstance(rd::SerializationCtx& ctx, rd::Buffer & buffer, rd::RdId const& unknownId, int32_t size);
    
    // writer
    virtual void write(rd::SerializationCtx& ctx, rd::Buffer& buffer) const override = 0;
    
    // virtual init
    void init(rd::Lifetime lifetime) const override;
    
    // identify
    void identify(const rd::Identities &identities, rd::RdId const &id) const override;
    
    // getters
    int32_t const & get_x() const;
    rd::IViewableMap<int32_t, int32_t> const & get_sdf() const;
    
    // intern

private:
    // equals trait

public:
    // equality operators
    friend bool operator==(const Foo &lhs, const Foo &rhs);
    friend bool operator!=(const Foo &lhs, const Foo &rhs);
    // hash code trait
    // type name trait
    std::string type_name() const override;
    // static type name trait
    static std::string static_type_name();

private:
    // polymorphic to string
    std::string toString() const override;

public:
    // external to string
    friend std::string to_string(const Foo & value);
};

}

#ifdef _MSC_VER
#pragma warning( pop )
#endif



#endif // FOO_GENERATED_H
