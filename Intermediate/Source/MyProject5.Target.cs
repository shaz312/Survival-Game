using UnrealBuildTool;

public class MyProject5Target : TargetRules
{
	public MyProject5Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyProject5");
	}
}
