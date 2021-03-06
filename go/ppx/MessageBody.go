// Code generated by the FlatBuffers compiler. DO NOT EDIT.

package ppx

import "strconv"

type MessageBody byte

const (
	MessageBodyNONE            MessageBody = 0
	MessageBodyHandshake       MessageBody = 1
	MessageBodyHandshakeResult MessageBody = 2
	MessageBodyRun             MessageBody = 3
	MessageBodyRunResult       MessageBody = 4
	MessageBodySample          MessageBody = 5
	MessageBodySampleResult    MessageBody = 6
	MessageBodyObserve         MessageBody = 7
	MessageBodyObserveResult   MessageBody = 8
	MessageBodyTag             MessageBody = 9
	MessageBodyTagResult       MessageBody = 10
	MessageBodyReset           MessageBody = 11
)

var EnumNamesMessageBody = map[MessageBody]string{
	MessageBodyNONE:            "NONE",
	MessageBodyHandshake:       "Handshake",
	MessageBodyHandshakeResult: "HandshakeResult",
	MessageBodyRun:             "Run",
	MessageBodyRunResult:       "RunResult",
	MessageBodySample:          "Sample",
	MessageBodySampleResult:    "SampleResult",
	MessageBodyObserve:         "Observe",
	MessageBodyObserveResult:   "ObserveResult",
	MessageBodyTag:             "Tag",
	MessageBodyTagResult:       "TagResult",
	MessageBodyReset:           "Reset",
}

var EnumValuesMessageBody = map[string]MessageBody{
	"NONE":            MessageBodyNONE,
	"Handshake":       MessageBodyHandshake,
	"HandshakeResult": MessageBodyHandshakeResult,
	"Run":             MessageBodyRun,
	"RunResult":       MessageBodyRunResult,
	"Sample":          MessageBodySample,
	"SampleResult":    MessageBodySampleResult,
	"Observe":         MessageBodyObserve,
	"ObserveResult":   MessageBodyObserveResult,
	"Tag":             MessageBodyTag,
	"TagResult":       MessageBodyTagResult,
	"Reset":           MessageBodyReset,
}

func (v MessageBody) String() string {
	if s, ok := EnumNamesMessageBody[v]; ok {
		return s
	}
	return "MessageBody(" + strconv.FormatInt(int64(v), 10) + ")"
}
