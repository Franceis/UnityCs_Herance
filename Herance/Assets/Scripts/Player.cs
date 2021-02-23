using UnityEngine;

public class Player : MonoBehaviour
{
    private float life;
    protected float maxLife;

    private float spBar;
    protected float maxSpBar;

    protected float damage;
    protected float defense;

    private Rigidbody2D rb;

    public virtual void Start()
    {
        if (rb == null) { rb = this.GetComponent<Rigidbody2D>(); }
        
        life = maxLife;
        spBar = maxSpBar;
    }

    public virtual void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Block();
        }
    }

    private void Attack()
    {
        //Attack animation
        print("Attack!");
    }

    private void Block()
    {
        //Block animation
        print("Block!");
    }
}
