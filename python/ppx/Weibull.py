# automatically generated by the FlatBuffers compiler, do not modify

# namespace: ppx

import flatbuffers
from flatbuffers.compat import import_numpy
np = import_numpy()

class Weibull(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsWeibull(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = Weibull()
        x.Init(buf, n + offset)
        return x

    @classmethod
    def WeibullBufferHasIdentifier(cls, buf, offset, size_prefixed=False):
        return flatbuffers.util.BufferHasIdentifier(buf, offset, b"\x50\x50\x58\x46", size_prefixed=size_prefixed)

    # Weibull
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # Weibull
    def Scale(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Indirect(o + self._tab.Pos)
            from ppx.Tensor import Tensor
            obj = Tensor()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # Weibull
    def Concentration(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            x = self._tab.Indirect(o + self._tab.Pos)
            from ppx.Tensor import Tensor
            obj = Tensor()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

def WeibullStart(builder): builder.StartObject(2)
def WeibullAddScale(builder, scale): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(scale), 0)
def WeibullAddConcentration(builder, concentration): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(concentration), 0)
def WeibullEnd(builder): return builder.EndObject()
