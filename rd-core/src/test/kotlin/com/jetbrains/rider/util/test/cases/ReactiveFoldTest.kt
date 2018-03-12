package com.jetbrains.rider.util.test.cases

import com.jetbrains.rider.util.lifetime.Lifetime
import com.jetbrains.rider.util.reactive.*
import org.testng.annotations.Test

class ReactiveFoldTest {

    @Test
    fun reactiveFoldEmpty() {
        val xs = arrayListOf<OptProperty<Int>>()
        val x = xs.fold(Lifetime.Eternal, 1) { acc, x -> acc * x }
        assert(!x.hasValue)
    }

    @Test
    fun reactiveFold1() {
        val xs = arrayListOf(OptProperty(100), OptProperty())
        val x = xs.fold(Lifetime.Eternal, 1) { acc, x -> acc * x }
        assert(x.valueOrThrow == 100)
        xs[1].set(10)
        assert(x.valueOrThrow == 1000)
    }

    @Test
    fun reactiveFold2() {
        val xs = arrayListOf<Int>(0, 0, 0, 0).map { OptProperty(it) }

        val x = xs.fold(Lifetime.Eternal, Int.MIN_VALUE) { acc, x -> Math.max(acc, x) }
        assert(x.valueOrThrow == 0)

        xs[0].set(100)
        assert(x.valueOrThrow == 100)

        xs[1].set(99)
        assert(x.valueOrThrow == 100)

        xs[3].set(999)
        assert(x.valueOrThrow == 999)
    }

    @Test
    fun reactiveFold3() {
        val xs = arrayListOf<Int>(1, 2, 3, 4).map { OptProperty(it.toString()) }
        val x = xs.fold(Lifetime.Eternal, "start") { acc, x -> acc + " " + x }
        assert(x.valueOrThrow == "start 1 2 3 4")
        xs[1].set(100.toString())
        assert(x.valueOrThrow == "start 1 100 3 4")
    }

    @Test
    fun reactiveFoldRight3() {
        val xs = arrayListOf<Int>(1, 2, 3, 4).map { OptProperty(it.toString()) }
        val x = xs.foldRight(Lifetime.Eternal, "end") { x, acc -> x + " " + acc }
        assert(x.valueOrThrow == "1 2 3 4 end")
        xs[1].set(100.toString())
        assert(x.valueOrThrow == "1 100 3 4 end")
    }
}