using UnityEngine;

public abstract class Character : MonoBehaviour
{

    private int health;
    public int Health 
    {  
        get { return health; } 
        set { health = (value < 0)? 0 : value; }
    }

    protected Animator anin;
    protected Rigidbody2D rb;

    public void Initialize(int startHealth)
    { 
        Health = startHealth;
        Debug.Log($"{this.name} is inirialed Health{this.Health}");

        rb = GetComponent<Rigidbody2D>();

        anin = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    { 
        Health -= damage;
        Debug.Log($"{this.name} take damage {damage} .Current Health: {Health}");
        IsDead();

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
