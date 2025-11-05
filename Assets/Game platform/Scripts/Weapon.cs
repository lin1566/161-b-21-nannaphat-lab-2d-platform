using UnityEngine;

public abstract class Weapon : MonoBehaviour 
{
    public int damage;
    public IShootable Shooter;
    public abstract void Move();
    public abstract void OnHitWith(Character character);

    public void InitWeapon(int newDamage, IShootable newShootable)
    {
        damage = newDamage;
        Shooter = newShootable;


    }
    public int GetShootDirection()
    {
        float value = Shooter.ShootPoint.position.x - Shooter.ShootPoint.parent.position.x;

        if (value > 0)
            return 1; //face right
        else
            return -1; //face left
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Character character = other.GetComponent<Character>();

        if (character != null)
        {
            OnHitWith(character);
            Destroy(this.gameObject, 5f);
        }
    }
    public void Start()
    {
        
    }
    public void Update()
    {
        
    }
}
