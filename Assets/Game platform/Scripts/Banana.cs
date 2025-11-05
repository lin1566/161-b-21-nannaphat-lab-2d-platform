using UnityEngine;

public class Banana : Weapon
{
    // 1 reference
    public override void Move()
    {
        throw new System.NotImplementedException();
    }

    // 2 references
    public override void OnHitWith(Character character)
    {
        throw new System.NotImplementedException();
    }
}