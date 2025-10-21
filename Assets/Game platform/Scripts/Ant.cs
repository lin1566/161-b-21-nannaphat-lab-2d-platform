using UnityEditor.Tilemaps;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField]Vector2 velocity;
    public Transform[] MovePoint;
    private void Start()
    {
        base.Initialize(20);

        DamageHit = (20);
        velocity = new Vector2(-1.0f, 0.0f);
    }

    public override void Behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        if (velocity.x < 0 && rb.position.x <= MovePoint[0].position.x)
        {
            Flip();
        }
        if (velocity.x > 0 && rb.position.x >= MovePoint[1].position.x)
        {
            Flip();
        }
    }
    void Flip()
    {
        velocity.x *= -1;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    private void FixedUpdate()
    {
        Behavior();
        
    }
    private void Update()
    {
       // Debug.Log(Time.deltaTime);
    }
}
