using ObjCRuntime;

[assembly: LinkWith ("FBSDKPlacesKit.a",
		     LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64,
		     LinkerFlags = "-ObjC",
		     SmartLink = true,
		     ForceLoad = true)]
