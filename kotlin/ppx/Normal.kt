// automatically generated by the FlatBuffers compiler, do not modify

package ppx

import java.nio.*
import kotlin.math.sign
import com.google.flatbuffers.*

@Suppress("unused")
@ExperimentalUnsignedTypes
class Normal : Table() {

    fun __init(_i: Int, _bb: ByteBuffer)  {
        __reset(_i, _bb)
    }
    fun __assign(_i: Int, _bb: ByteBuffer) : Normal {
        __init(_i, _bb)
        return this
    }
    val mean : ppx.Tensor? get() = mean(ppx.Tensor())
    fun mean(obj: ppx.Tensor) : ppx.Tensor? {
        val o = __offset(4)
        return if (o != 0) {
            obj.__assign(__indirect(o + bb_pos), bb)
        } else {
            null
        }
    }
    val stddev : ppx.Tensor? get() = stddev(ppx.Tensor())
    fun stddev(obj: ppx.Tensor) : ppx.Tensor? {
        val o = __offset(6)
        return if (o != 0) {
            obj.__assign(__indirect(o + bb_pos), bb)
        } else {
            null
        }
    }
    companion object {
        fun validateVersion() = Constants.FLATBUFFERS_1_12_0()
        fun getRootAsNormal(_bb: ByteBuffer): Normal = getRootAsNormal(_bb, Normal())
        fun getRootAsNormal(_bb: ByteBuffer, obj: Normal): Normal {
            _bb.order(ByteOrder.LITTLE_ENDIAN)
            return (obj.__assign(_bb.getInt(_bb.position()) + _bb.position(), _bb))
        }
        fun createNormal(builder: FlatBufferBuilder, meanOffset: Int, stddevOffset: Int) : Int {
            builder.startTable(2)
            addStddev(builder, stddevOffset)
            addMean(builder, meanOffset)
            return endNormal(builder)
        }
        fun startNormal(builder: FlatBufferBuilder) = builder.startTable(2)
        fun addMean(builder: FlatBufferBuilder, mean: Int) = builder.addOffset(0, mean, 0)
        fun addStddev(builder: FlatBufferBuilder, stddev: Int) = builder.addOffset(1, stddev, 0)
        fun endNormal(builder: FlatBufferBuilder) : Int {
            val o = builder.endTable()
            return o
        }
    }
}