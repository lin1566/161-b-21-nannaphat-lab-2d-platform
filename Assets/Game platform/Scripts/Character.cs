using UnityEngine;

public abstract class Character : MonoBehaviour
{

    private int health;
    public int Health {  get { return health; } set { health = (value < 0)? 0 : value; }
    }
    protected Animation anin;
    protected Rigidbody2D rb;
    
    public void TakeDamage(int damage)
    { 
        Health -= damage;
        Debug.Log($"{this.name} take damage {damage} .c");

    }
    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        return false;
    }
    
    
}
