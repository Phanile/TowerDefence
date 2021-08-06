using UnityEngine;

public class BaseEnemy : EnemyEntity
{
    [Header("Stats")]
    [SerializeField] private int _health;
    [SerializeField] private int _moveSpeed;

    protected override void InitBehaviours()
    {
        _movable = new StandartMoveBehaviour(this.transform);
    }

    private void Start()
    {
        InitBehaviours();
    }

    private void Update()
    {
        _movable.Move(_moveSpeed);
    }
}
