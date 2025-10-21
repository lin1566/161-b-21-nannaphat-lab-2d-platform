using UnityEngine;

public abstract class Enemy : Character
{
    public int DamageHit {  get; protected set; }

    
    public abstract void Behavior();
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
