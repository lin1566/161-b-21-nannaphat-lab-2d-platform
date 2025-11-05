using UnityEngine;

public class Rock : Weapon
{
    public Character owner;
    private bool hasHit = false;
    public Rigidbody2D rb; //show this in Unity
    public Vector2 force; // use to throw Rock

    public override void Move()
    {
        //use physics in Unity (RigidBody2D) to add force to throw Rock
        rb.AddForce(force);
    }

    public override void OnHitWith(Character obj)
    {
        if (obj != this.owner) 
    {
        obj.TakeDamage(this.damage);
    }
    }

    void Start()
    {
        damage = 40;
        force = new Vector2(GetShootDirection() * 90, 400);
        Move(); //add force to rock immediately once created
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Character characterHit = collision.GetComponent<Character>();

        if (characterHit != null && !hasHit)
        {
            hasHit = true;
            OnHitWith(characterHit);

            // **หยุดการชนทันที**
            rb.simulated = false; // หยุด Rigidbody
            GetComponent<Collider2D>().enabled = false; // ปิด Collider

            // **ทำลายวัตถุหลังจากหน่วงเวลาสั้น ๆ**
            Destroy(gameObject, 0.1f);
        }
    }
}
