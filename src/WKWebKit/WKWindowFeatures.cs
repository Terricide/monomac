//
// WKWebKit/WKWindowFeatures.cs
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2014 Xamarin Inc. All rights reserved.
//

using System;

using Foundation;

namespace MonoMac.WebKit
{
	public partial class WKWindowFeatures
	{
		public bool? MenuBarVisibility {
			get { return menuBarVisibility == null ? (bool?)null : menuBarVisibility.BoolValue; }
		}

		public bool? StatusBarVisibility {
			get { return statusBarVisibility == null ? (bool?)null : statusBarVisibility.BoolValue; }
		}

		public bool? ToolbarsVisibility {
			get { return toolbarsVisibility == null ? (bool?)null : toolbarsVisibility.BoolValue; }
		}

		public bool? AllowsResizing {
			get { return allowsResizing == null ? (bool?)null : allowsResizing.BoolValue; }
		}

		static nfloat? NFloatValue (NSNumber number)
		{
			if (number == null)
				return null;
			else if (IntPtr.Size == 4)
				return (nfloat)number.FloatValue;
			else
				return (nfloat)number.DoubleValue;
		}

		public nfloat? X {
			get { return NFloatValue (x); }
		}

		public nfloat? Y {
			get { return NFloatValue (y); }
		}

		public nfloat? Width {
			get { return NFloatValue (width); }
		}

		public nfloat? Height {
			get { return NFloatValue (height); }
		}
	}
}
