using UnityEngine;

public class Croccodile:Enemy
{
    [SerializeField] private float atkRange;
    public Player player;
    private void Start()
    {
        base.Initialize(50);
        DamageHit = 30;
        //set atk range and target
        atkRange = 6.0f;
        player = GameObject.FindFirstObjectByType<Player>();
    }

    private void FixedUpdate()
    {
        Behavior();
    }

    public override void Behavior()
    {
        Vector2 distance = transform.position - player.transform.position;
        if (distance.magnitude <= atkRange)
        {
            Debug.Log($"{player.name} is in the {this.name}'s atk range!");
            Shoot();
        }
    }
    public void Shoot()
    {
        Debug.Log($"{this.name} shoots rock to the {player.name}!");
    }
    private void Update()
    {
        Behavior();
    }
}
