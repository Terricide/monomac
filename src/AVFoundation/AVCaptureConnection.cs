//
// AVCaptureConnection: Extensions to the class
//
// Authors:
//   Miguel de Icaza
//   Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2011-2012, Xamarin, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using ObjCRuntime;
using Foundation;

namespace AVFoundation {
	public partial class AVCaptureConnection {

		public bool SupportsVideoMinFrameDuration {
			get {
				if (RespondsToSelector (new Selector ("isVideoMinFrameDurationSupported")))
					return _SupportsVideoMinFrameDuration;
				return false;
			}
		}

		public bool SupportsVideoMaxFrameDuration {
			get {
#if !MONOMAC
				if (RespondsToSelector (new Selector ("isVideoMaxFrameDurationSupported")))
					return _SupportsVideoMaxFrameDuration;
#endif
				return false;
			}
		}

		[Advice ("Use InputPorts")]
		public AVCaptureInputPort [] inputPorts { 
			get { return InputPorts; }
		}
	}
}