// Code generated by the FlatBuffers compiler. DO NOT EDIT.

package ppx

import "strconv"

type Distribution byte

const (
	DistributionNONE        Distribution = 0
	DistributionNormal      Distribution = 1
	DistributionUniform     Distribution = 2
	DistributionCategorical Distribution = 3
	DistributionPoisson     Distribution = 4
	DistributionBernoulli   Distribution = 5
	DistributionBeta        Distribution = 6
	DistributionExponential Distribution = 7
	DistributionGamma       Distribution = 8
	DistributionLogNormal   Distribution = 9
	DistributionBinomial    Distribution = 10
	DistributionWeibull     Distribution = 11
)

var EnumNamesDistribution = map[Distribution]string{
	DistributionNONE:        "NONE",
	DistributionNormal:      "Normal",
	DistributionUniform:     "Uniform",
	DistributionCategorical: "Categorical",
	DistributionPoisson:     "Poisson",
	DistributionBernoulli:   "Bernoulli",
	DistributionBeta:        "Beta",
	DistributionExponential: "Exponential",
	DistributionGamma:       "Gamma",
	DistributionLogNormal:   "LogNormal",
	DistributionBinomial:    "Binomial",
	DistributionWeibull:     "Weibull",
}

var EnumValuesDistribution = map[string]Distribution{
	"NONE":        DistributionNONE,
	"Normal":      DistributionNormal,
	"Uniform":     DistributionUniform,
	"Categorical": DistributionCategorical,
	"Poisson":     DistributionPoisson,
	"Bernoulli":   DistributionBernoulli,
	"Beta":        DistributionBeta,
	"Exponential": DistributionExponential,
	"Gamma":       DistributionGamma,
	"LogNormal":   DistributionLogNormal,
	"Binomial":    DistributionBinomial,
	"Weibull":     DistributionWeibull,
}

func (v Distribution) String() string {
	if s, ok := EnumNamesDistribution[v]; ok {
		return s
	}
	return "Distribution(" + strconv.FormatInt(int64(v), 10) + ")"
}
