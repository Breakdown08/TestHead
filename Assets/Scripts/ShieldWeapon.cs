using UnityEngine;
public class ShieldWeapon : BaseItem
{
    private void Awake()
    {
        itemType = ItemType.Shield;
    }

    public override void SetCharacteristicsRange()
    {
        healthPointsMin = 5;
        healthPointsMax = 10;
        attackMin = 5;
        attackMax = 10;
        defenceMin = 30;
        defenceMax = 60;
    }
}
