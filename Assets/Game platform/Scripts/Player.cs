using UnityEngine;

public class Player : Character
{

    private void Start()
    {
        base.Initialize(100);
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        { 
        OnHitWith(enemy);
        }
    }
    private void Update()
    {
        
    }
}
