using UnityEngine;

public class Ant : Enemy
{
    [SerializeField]Vector2 velocity;
    public Transform[] MovePoint;
    private void Start()
    {
        base.Initialize(20);
    }

    public override void Behavior()
    {
        throw new System.NotImplementedException();
    }
    private void Update()
    {
        
    }
}
