//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.13.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#include "Document.Generated.h"



#ifdef _MSC_VER
#pragma warning( push )
#pragma warning( disable:4250 )
#pragma warning( disable:4307 )
#pragma warning( disable:4267 )
#pragma warning( disable:4244 )
#pragma warning( disable:4100 )
#endif

namespace org.example {
// companion
// constants
// initializer
void Document::initialize()
{
}
// primary ctor
Document::Document(rd::Wrapper<FooBar> moniker_, rd::Wrapper<std::wstring> buffer_, rd::RdCall<std::wstring, int32_t, rd::Polymorphic<std::wstring>, rd::Polymorphic<int32_t>> andBackAgain_, rd::Wrapper<Completion> completion_, std::vector<uint8_t> arr1_, std::vector<std::vector<bool>> arr2_) :
rd::IPolymorphicSerializable(), rd::RdBindableBase()
,moniker_(std::move(moniker_)), buffer_(std::move(buffer_)), andBackAgain_(std::move(andBackAgain_)), completion_(std::move(completion_)), arr1_(std::move(arr1_)), arr2_(std::move(arr2_))
{
    initialize();
}
// secondary constructor
Document::Document(rd::Wrapper<FooBar> moniker_, rd::Wrapper<std::wstring> buffer_, std::vector<uint8_t> arr1_, std::vector<std::vector<bool>> arr2_) : 
Document((std::move(moniker_)),(std::move(buffer_)),{},{},(std::move(arr1_)),(std::move(arr2_)))
{
    initialize();
}
// default ctors and dtors
// reader
Document Document::read(rd::SerializationCtx& ctx, rd::Buffer & buffer)
{
    auto _id = rd::RdId::read(buffer);
    auto moniker_ = FooBar::read(ctx, buffer);
    auto buffer_ = buffer.read_nullable<std::wstring>(
    [&ctx, &buffer]() mutable  
    { return buffer.read_wstring(); }
    );
    auto andBackAgain_ = rd::RdCall<std::wstring, int32_t, rd::Polymorphic<std::wstring>, rd::Polymorphic<int32_t>>::read(ctx, buffer);
    auto completion_ = Completion::read(ctx, buffer);
    auto arr1_ = buffer.read_array<std::vector, uint8_t, rd::allocator<uint8_t>>(
    [&ctx, &buffer]() mutable  
    { return buffer.read_integral<uint8_t>(); }
    );
    auto arr2_ = buffer.read_array<std::vector, std::vector<bool>, rd::allocator<std::vector<bool>>>(
    [&ctx, &buffer]() mutable  
    { return buffer.read_array<std::vector, bool, rd::allocator<bool>>(
    [&ctx, &buffer]() mutable  
    { return buffer.read_bool(); }
    ); }
    );
    Document res{std::move(moniker_), std::move(buffer_), std::move(andBackAgain_), std::move(completion_), std::move(arr1_), std::move(arr2_)};
    withId(res, _id);
    return res;
}
// writer
void Document::write(rd::SerializationCtx& ctx, rd::Buffer& buffer) const
{
    this->rdid.write(buffer);
    rd::Polymorphic<std::decay_t<decltype(moniker_)>>::write(ctx, buffer, moniker_);
    buffer.write_nullable<std::wstring>(buffer_, 
    [&ctx, &buffer](rd::Wrapper<std::wstring> const & it) mutable  -> void 
    { buffer.write_wstring(it); }
    );
    andBackAgain_.write(ctx, buffer);
    rd::Polymorphic<std::decay_t<decltype(completion_)>>::write(ctx, buffer, completion_);
    buffer.write_array<std::vector, uint8_t, rd::allocator<uint8_t>>(arr1_,
    [&ctx, &buffer](uint8_t const & it) mutable  -> void 
    { buffer.write_integral(it); }
    );
    buffer.write_array<std::vector, std::vector<bool>, rd::allocator<std::vector<bool>>>(arr2_,
    [&ctx, &buffer](std::vector<bool> const & it) mutable  -> void 
    { buffer.write_array<std::vector, bool, rd::allocator<bool>>(it,
    [&ctx, &buffer](bool const & it) mutable  -> void 
    { buffer.write_bool(it); }
    ); }
    );
}
// virtual init
void Document::init(rd::Lifetime lifetime) const
{
    rd::RdBindableBase::init(lifetime);
    bindPolymorphic(moniker_, lifetime, this, "moniker");
    bindPolymorphic(andBackAgain_, lifetime, this, "andBackAgain");
    bindPolymorphic(completion_, lifetime, this, "completion");
}
// identify
void Document::identify(const rd::Identities &identities, rd::RdId const &id) const
{
    rd::RdBindableBase::identify(identities, id);
    identifyPolymorphic(moniker_, identities, id.mix(".moniker"));
    identifyPolymorphic(andBackAgain_, identities, id.mix(".andBackAgain"));
    identifyPolymorphic(completion_, identities, id.mix(".completion"));
}
// getters
FooBar const & Document::get_moniker() const
{
    return *moniker_;
}
rd::Wrapper<std::wstring> const & Document::get_buffer() const
{
    return buffer_;
}
rd::RdCall<std::wstring, int32_t, rd::Polymorphic<std::wstring>, rd::Polymorphic<int32_t>> const & Document::get_andBackAgain() const
{
    return andBackAgain_;
}
Completion const & Document::get_completion() const
{
    return *completion_;
}
std::vector<uint8_t> const & Document::get_arr1() const
{
    return arr1_;
}
std::vector<std::vector<bool>> const & Document::get_arr2() const
{
    return arr2_;
}
// intern
// equals trait
bool Document::equals(rd::ISerializable const& object) const
{
    auto const &other = dynamic_cast<Document const&>(object);
    return this == &other;
}
// equality operators
bool operator==(const Document &lhs, const Document &rhs) {
    return &lhs == &rhs;
}
bool operator!=(const Document &lhs, const Document &rhs){
    return !(lhs == rhs);
}
// hash code trait
// type name trait
std::string Document::type_name() const
{
    return "Document";
}
// static type name trait
std::string Document::static_type_name()
{
    return "Document";
}
// polymorphic to string
std::string Document::toString() const
{
    std::string res = "Document\n";
    res += "\tmoniker = ";
    res += rd::to_string(moniker_);
    res += '\n';
    res += "\tbuffer = ";
    res += rd::to_string(buffer_);
    res += '\n';
    res += "\tandBackAgain = ";
    res += rd::to_string(andBackAgain_);
    res += '\n';
    res += "\tcompletion = ";
    res += rd::to_string(completion_);
    res += '\n';
    res += "\tarr1 = ";
    res += rd::to_string(arr1_);
    res += '\n';
    res += "\tarr2 = ";
    res += rd::to_string(arr2_);
    res += '\n';
    return res;
}
// external to string
std::string to_string(const Document & value)
{
    return value.toString();
}
}

#ifdef _MSC_VER
#pragma warning( pop )
#endif

