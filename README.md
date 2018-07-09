# PPX [![Build Status](https://travis-ci.org/probprog/ppx.svg?branch=master)](https://travis-ci.org/probprog/ppx)

<p align="left"><img width="40%" src="docs/ppx_logo.png" /></p>

`PPX` is a cross-platform [**P**robabilistic **P**rogramming](http://www.probabilistic-programming.org) e**X**ecution protocol and API based on [flatbuffers](https://google.github.io/flatbuffers/). It is intended as an open interoperability protocol between models and inference engines implemented in different probabilistic programming languages.

Probabilistic programming is about the execution probabilistic models under the control of inference engines, and `PPX` allows the model and the inference engine to be
* implemented in different programming languages and
* executed in separate processes and on separate machines across networks.

`PPX` is inspired by [ONNX](https://onnx.ai/), the Open Neural Network Exchange project allowing interoperability between major deep learning frameworks.

## Supported languages

We provide `PPX` compiled to all programming languages officially supported by flatbuffers. These are:

* C++
* C#
* Go
* Java
* JavaScript
* PHP
* Python
* TypeScript

## License

`PPX` is distributed under the BSD License.

## Authors

`PPX` has been developed by [Atılım Güneş Baydin](http://www.robots.ox.ac.uk/~gunes/) and [Tuan Anh Le](http://www.tuananhle.co.uk/) within the Programming Languages and AI group led by [Frank Wood](http://www.cs.ubc.ca/~fwood/index.html) at the University of Oxford and University of British Columbia.
