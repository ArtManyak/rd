//
// Created by jetbrains on 13.08.2018.
//

#ifndef RD_CORE_CPP_UTIL_H
#define RD_CORE_CPP_UTIL_H

#include "wrapper.h"

#include "optional.hpp"

#include <memory>
#include <cassert>
#include <iostream>
#include <string>
#include <thread>
#include <atomic>

#define MY_ASSERT_MSG(expr, msg) if(!(expr)){std::cerr<<std::endl<<(msg)<<std::endl;assert(expr);}
#define MY_ASSERT_THROW_MSG(expr, msg) if(!(expr)){std::cerr<<std::endl<<(msg)<<std::endl;throw std::runtime_error(msg);}

namespace rd {
	template<typename T>
	struct TransparentKeyEqual {
		using is_transparent = void;

		bool operator()(T const &val_l, T const &val_r) const {
			return val_l == val_r;
		}

		bool operator()(Wrapper<T> const &ptr_l, Wrapper<T> const &ptr_r) const {
			return ptr_l == ptr_r;
		}

		bool operator()(T const *val_l, T const *val_r) const {
			return *val_l == *val_r;
		}

		bool operator()(T const &val_r, Wrapper<T> const &ptr_l) const {
			return *ptr_l == val_r;
		}

		bool operator()(T const &val_l, T const *ptr_r) const {
			return val_l == *ptr_r;
		}

		bool operator()(Wrapper<T> const &val_l, T const *ptr_r) const {
			return *val_l == *ptr_r;
		}
	};

	template<typename T>
	struct TransparentHash {
		using is_transparent = void;
		using transparent_key_equal = std::equal_to<>;

		size_t operator()(T const &val) const noexcept {
			return std::hash<T>()(val);
		}

		size_t operator()(Wrapper<T> const &ptr) const noexcept {
			return std::hash<Wrapper<T>>()(ptr);
		}

		size_t operator()(T const *val) const noexcept {
			return std::hash<T>()(*val);
		}
	};


	//region to_string

/*
    template<typename T>
    std::string to_string(T const &val) {
        return "";
    }
*/

	template<typename T>
	typename std::enable_if<std::is_arithmetic<T>::value, std::string>::type to_string(T const &val) {
		return std::to_string(val);
	}

	template<typename T>
	typename std::enable_if<!std::is_arithmetic<T>::value, std::string>::type to_string(T const &val) {
		return "";
	}

	template<>
	inline std::string to_string<std::string>(std::string const &val) {
		return val;
	}

	template<>
	inline std::string to_string<std::wstring>(std::wstring const &val) {
		return std::string(val.begin(), val.end());
	}

	template<typename T>
	inline std::string to_string(tl::optional<T> const &val) {
		if (val.has_value()) {
			return to_string(*val);
		} else {
			return "nullopt";
		}
	}

	inline std::string to_string(std::thread::id const &id) {
		return "";
		//todo
	}

	template<typename T>
	inline std::string to_string(Wrapper<T> const &value) {
		return to_string(*value);
	}

	template<typename T>
	inline std::string to_string(std::atomic<T> const &value) {
		return to_string(value.load());
	}
	//endregion
}

#endif //RD_CORE_CPP_UTIL_H
