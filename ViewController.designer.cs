// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CiscoCommand
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField bannerString { get; set; }

		[Outlet]
		AppKit.NSTextField ConsolePass { get; set; }

		[Outlet]
		AppKit.NSTextField enablePass { get; set; }

		[Outlet]
		AppKit.NSTextField HostName { get; set; }

		[Outlet]
		AppKit.NSMatrix IFSelect { get; set; }

		[Outlet]
		AppKit.NSTextField IFV1 { get; set; }

		[Outlet]
		AppKit.NSTextField IFV2 { get; set; }

		[Outlet]
		AppKit.NSTextField IFV3 { get; set; }

		[Outlet]
		AppKit.NSTextField IFV4 { get; set; }

		[Outlet]
		AppKit.NSTextField IP1st { get; set; }

		[Outlet]
		AppKit.NSTextField IP2nd { get; set; }

		[Outlet]
		AppKit.NSTextField IP3rd { get; set; }

		[Outlet]
		AppKit.NSTextField IP4th { get; set; }

		[Outlet]
		AppKit.NSTextField IPV1 { get; set; }

		[Outlet]
		AppKit.NSTextField IPV2 { get; set; }

		[Outlet]
		AppKit.NSTextField IPV3 { get; set; }

		[Outlet]
		AppKit.NSTextField IPV4 { get; set; }

		[Outlet]
		AppKit.NSButton IsBanner { get; set; }

		[Outlet]
		AppKit.NSButton IsConsoleLogging { get; set; }

		[Outlet]
		AppKit.NSButton IsConsolePass { get; set; }

		[Outlet]
		AppKit.NSButton IsDNS { get; set; }

		[Outlet]
		AppKit.NSButton IsEnablePass { get; set; }

		[Outlet]
		AppKit.NSButton IsHost { get; set; }

		[Outlet]
		AppKit.NSButton IsSave { get; set; }

		[Outlet]
		AppKit.NSButton IsVTYLogging { get; set; }

		[Outlet]
		AppKit.NSButton IsVTYPass { get; set; }

		[Outlet]
		AppKit.NSButton Remove1st { get; set; }

		[Outlet]
		AppKit.NSButton Remove2nd { get; set; }

		[Outlet]
		AppKit.NSButton Remove3rd { get; set; }

		[Outlet]
		AppKit.NSButton Remove4th { get; set; }

		[Outlet]
		AppKit.NSTextField SubV1 { get; set; }

		[Outlet]
		AppKit.NSTextField SubV2 { get; set; }

		[Outlet]
		AppKit.NSTextField SubV3 { get; set; }

		[Outlet]
		AppKit.NSTextField SubV4 { get; set; }

		[Outlet]
		AppKit.NSButton testck { get; set; }

		[Outlet]
		AppKit.NSTextField testlabel { get; set; }

		[Outlet]
		AppKit.NSTextField vtyPass { get; set; }

		[Action ("addIPSet:")]
		partial void addIPSet (Foundation.NSObject sender);

		[Action ("CreateCommand:")]
		partial void CreateCommand (Foundation.NSObject sender);

		[Action ("IFset:")]
		partial void IFset (Foundation.NSObject sender);

		[Action ("isBanner:")]
		partial void isBanner (Foundation.NSObject sender);

		[Action ("isConsoleLoggin:")]
		partial void isConsoleLoggin (Foundation.NSObject sender);

		[Action ("isConsolePass:")]
		partial void isConsolePass (Foundation.NSObject sender);

		[Action ("isDNS:")]
		partial void isDNS (Foundation.NSObject sender);

		[Action ("isEnablePass:")]
		partial void isEnablePass (Foundation.NSObject sender);

		[Action ("isHost:")]
		partial void isHost (Foundation.NSObject sender);

		[Action ("isSave:")]
		partial void isSave (Foundation.NSObject sender);

		[Action ("isVTYloggin:")]
		partial void isVTYloggin (Foundation.NSObject sender);

		[Action ("isVTYPass:")]
		partial void isVTYPass (Foundation.NSObject sender);

		[Action ("MakeCommand:")]
		partial void MakeCommand (Foundation.NSObject sender);

		[Action ("RemoveIFSet:")]
		partial void RemoveIFSet (Foundation.NSObject sender);

		[Action ("Sub1st:")]
		partial void Sub1st (AppKit.NSPopUpButton sender);

		[Action ("Sub2nd:")]
		partial void Sub2nd (AppKit.NSPopUpButton sender);

		[Action ("Sub3rd:")]
		partial void Sub3rd (AppKit.NSPopUpButton sender);

		[Action ("Sub4th:")]
		partial void Sub4th (AppKit.NSPopUpButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (bannerString != null) {
				bannerString.Dispose ();
				bannerString = null;
			}

			if (ConsolePass != null) {
				ConsolePass.Dispose ();
				ConsolePass = null;
			}

			if (enablePass != null) {
				enablePass.Dispose ();
				enablePass = null;
			}

			if (HostName != null) {
				HostName.Dispose ();
				HostName = null;
			}

			if (IFSelect != null) {
				IFSelect.Dispose ();
				IFSelect = null;
			}

			if (IFV1 != null) {
				IFV1.Dispose ();
				IFV1 = null;
			}

			if (IFV2 != null) {
				IFV2.Dispose ();
				IFV2 = null;
			}

			if (IFV3 != null) {
				IFV3.Dispose ();
				IFV3 = null;
			}

			if (IFV4 != null) {
				IFV4.Dispose ();
				IFV4 = null;
			}

			if (IP1st != null) {
				IP1st.Dispose ();
				IP1st = null;
			}

			if (IP2nd != null) {
				IP2nd.Dispose ();
				IP2nd = null;
			}

			if (IP3rd != null) {
				IP3rd.Dispose ();
				IP3rd = null;
			}

			if (IP4th != null) {
				IP4th.Dispose ();
				IP4th = null;
			}

			if (IPV1 != null) {
				IPV1.Dispose ();
				IPV1 = null;
			}

			if (IPV2 != null) {
				IPV2.Dispose ();
				IPV2 = null;
			}

			if (IPV3 != null) {
				IPV3.Dispose ();
				IPV3 = null;
			}

			if (IPV4 != null) {
				IPV4.Dispose ();
				IPV4 = null;
			}

			if (IsBanner != null) {
				IsBanner.Dispose ();
				IsBanner = null;
			}

			if (IsConsoleLogging != null) {
				IsConsoleLogging.Dispose ();
				IsConsoleLogging = null;
			}

			if (IsConsolePass != null) {
				IsConsolePass.Dispose ();
				IsConsolePass = null;
			}

			if (IsDNS != null) {
				IsDNS.Dispose ();
				IsDNS = null;
			}

			if (IsEnablePass != null) {
				IsEnablePass.Dispose ();
				IsEnablePass = null;
			}

			if (IsHost != null) {
				IsHost.Dispose ();
				IsHost = null;
			}

			if (IsSave != null) {
				IsSave.Dispose ();
				IsSave = null;
			}

			if (IsVTYLogging != null) {
				IsVTYLogging.Dispose ();
				IsVTYLogging = null;
			}

			if (IsVTYPass != null) {
				IsVTYPass.Dispose ();
				IsVTYPass = null;
			}

			if (Remove1st != null) {
				Remove1st.Dispose ();
				Remove1st = null;
			}

			if (Remove2nd != null) {
				Remove2nd.Dispose ();
				Remove2nd = null;
			}

			if (Remove3rd != null) {
				Remove3rd.Dispose ();
				Remove3rd = null;
			}

			if (Remove4th != null) {
				Remove4th.Dispose ();
				Remove4th = null;
			}

			if (SubV1 != null) {
				SubV1.Dispose ();
				SubV1 = null;
			}

			if (SubV2 != null) {
				SubV2.Dispose ();
				SubV2 = null;
			}

			if (SubV3 != null) {
				SubV3.Dispose ();
				SubV3 = null;
			}

			if (SubV4 != null) {
				SubV4.Dispose ();
				SubV4 = null;
			}

			if (testck != null) {
				testck.Dispose ();
				testck = null;
			}

			if (testlabel != null) {
				testlabel.Dispose ();
				testlabel = null;
			}

			if (vtyPass != null) {
				vtyPass.Dispose ();
				vtyPass = null;
			}
		}
	}
}
