#include "Buffer.h"

#include <string>
#include <algorithm>

namespace rd {
	Buffer::Buffer() : Buffer(16) {

	}

	Buffer::Buffer(size_t initialSize) {
		data_.resize(initialSize);
	}

	Buffer::Buffer(const ByteArray &array, size_t offset) :
			data_(array), offset(offset) {}

	Buffer::Buffer(ByteArray &&array, size_t offset) :
			data_(std::move(array)), offset(offset) {}

	size_t Buffer::get_position() const {
		return offset;
	}

	void Buffer::set_position(size_t value) const {
		offset = value;
	}

	void Buffer::check_available(size_t moreSize) const {
		if (offset + moreSize > size()) {
			throw std::out_of_range(
					"Expected " + std::to_string(moreSize) + " bytes in buffer, only" +
					std::to_string(size() - offset) +
					"available");
		}
	}

	void Buffer::read(word_t *dst, size_t size) const {
		if (size == 0) return;
		check_available(size);
		std::copy(&data_[offset], &data_[offset] + size, dst);
		offset += size;
	}

	void Buffer::write(const word_t *src, size_t size) const {
		if (size == 0) return;
		require_available(size);
		std::copy(src, src + size, &data_[offset]);
		offset += size;
	}

	void Buffer::require_available(size_t moreSize) const {
		if (offset + moreSize >= size()) {
			const size_t new_size = (std::max)(size() * 2, offset + moreSize);
			data_.resize(new_size);
		}
	}

	void Buffer::rewind() const {
		set_position(0);
	}

	Buffer::ByteArray Buffer::getArray() const &{
		return data_;
	}

	Buffer::ByteArray Buffer::getArray() &&{
		rewind();
		return std::move(data_);
	}

	Buffer::ByteArray Buffer::getRealArray() const &{
		auto res = getArray();
		res.resize(offset);
		return res;
	}

	Buffer::ByteArray Buffer::getRealArray() &&{
		auto res = std::move(data_);
		res.resize(offset);
		rewind();
		return res;
	}

	const Buffer::word_t *Buffer::data() const {
		return data_.data();
	}

	Buffer::word_t *Buffer::data() {
		return data_.data();
	}

	size_t Buffer::size() const {
		return data_.size();
	}

	/*std::string Buffer::readString() const {
    auto v = readArray<uint8_t>();
    return std::string(v.begin(), v.end());
}

void Buffer::writeString(std::string const &value) const {
    std::vector<uint8_t> v(value.begin(), value.end());
    writeArray<uint8_t>(v);
}*/

	std::wstring Buffer::read_wstring() const {
		auto v = read_array<uint16_t>();
		return std::wstring(v.begin(), v.end());
	}

	void Buffer::write_wstring(std::wstring const &value) const {
		std::vector<uint16_t> v(value.begin(), value.end());
		write_array<uint16_t>(v);
	}

	void Buffer::write_wstring(Wrapper<std::wstring> const &value) const {
		write_wstring(*value);
	}

	bool Buffer::read_bool() const {
		auto res = read_integral<uint8_t>();
		RD_ASSERT_MSG(res == 0 || res == 1, "get byte:" + std::to_string(res) + " instead of 0 or 1");
		return res == 1;
	}

	void Buffer::write_bool(bool value) const {
		write_integral<word_t>(value ? 1 : 0);
	}

	void Buffer::read_byte_array(ByteArray& array) const {
		const int32_t length = read_integral<int32_t>();
		array.resize(length);
		read_byte_array_raw(array);
	}

	void Buffer::read_byte_array_raw(ByteArray &array) const {
		read(array.data(), array.size());
	}

	void Buffer::write_byte_array_raw(const ByteArray &array) const {
		write(array.data(), array.size());
	}

	Buffer::ByteArray &Buffer::get_data() {
		return data_;
	}
}
