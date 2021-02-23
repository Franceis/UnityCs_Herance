using UnityEngine;

public class Player : MonoBehaviour
{
    public float life;
    private float maxLife;

    private float spBar;
    private float spBarMax;

    private float damage;
    private float defense;

    bool canAttack = true;

    public virtual void Start()
    {

    }

    public virtual void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

        if (Input.GetMouseButton(0))
        {
            Block();
        }
    }

    private void Attack()
    {
        //Attack animation
    }

    private void Block()
    {
        //Block animation
    }
}
