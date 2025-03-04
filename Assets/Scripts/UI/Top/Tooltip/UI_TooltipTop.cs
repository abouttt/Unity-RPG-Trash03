using UnityEngine;

public class UI_TooltipTop : UI_Base
{
    public UI_ItemTooltip ItemTooltip { get; private set; }
    public UI_SkillTooltip SkillTooltip { get; private set; }

    protected override void Init()
    {
        Managers.UI.Register<UI_TooltipTop>(this);

        ItemTooltip = GetComponentInChildren<UI_ItemTooltip>();
        SkillTooltip = GetComponentInChildren<UI_SkillTooltip>();
    }
}
