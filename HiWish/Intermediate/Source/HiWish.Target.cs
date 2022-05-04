using UnrealBuildTool;

public class HiWishTarget : TargetRules
{
	public HiWishTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HiWish");
	}
}
