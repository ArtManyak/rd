package com.jetbrains.rider.util.log

import com.jetbrains.rider.util.*

object ErrorAccumulatorLoggerFactory : ILoggerFactory {
    var warnAsErrors = false

    val errors = mutableListOf<String>()

    override fun getLogger(category: String): Logger = object : Logger {
        override fun log(level: LogLevel, message: Any?, throwable: Throwable?) {
            if (isEnabled(level)) {
                val renderMessage = "$level | $message | "+ throwable?.getThrowableText()
                synchronized(this) {
                    errors.add(renderMessage)
                }
            }
        }

        override fun isEnabled(level: LogLevel): Boolean {
            return level == LogLevel.Fatal || level == LogLevel.Error || (warnAsErrors && level == LogLevel.Warn)
        }
    }

    fun throwAndClear() {
        if (errors.isEmpty()) return

        val text = "There are ${errors.size} exceptions:$eol" +
                errors.joinToString("$eol$eol --------------------------- $eol$eol")
        errors.clear()
        throw IllegalStateException(text)
    }
}