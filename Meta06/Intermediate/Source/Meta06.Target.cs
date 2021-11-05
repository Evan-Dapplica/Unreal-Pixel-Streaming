using UnrealBuildTool;

public class Meta06Target : TargetRules
{
	public Meta06Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Meta06");
	}
}
