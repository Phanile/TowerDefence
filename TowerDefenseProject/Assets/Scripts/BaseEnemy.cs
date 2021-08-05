using UnityEngine;

public class BaseEnemy : EnemyEntity
{
    [Header("Stats")]
    [SerializeField] private int _health;
    [SerializeField] private int _moveSpeed;

    private void Start()
    {
       
    }

    public override void Move()
    {
        
    }

    public override void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
