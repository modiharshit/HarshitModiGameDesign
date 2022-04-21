using UnrealBuildTool;

public class GameProjectTarget : TargetRules
{
	public GameProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameProject");
	}
}
