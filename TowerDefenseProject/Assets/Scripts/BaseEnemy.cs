using UnityEngine;

public class BaseEnemy : EnemyEntity
{
    [Header("Stats")]
    [SerializeField] private int _health;
    [SerializeField] private int _moveSpeed;
    [SerializeField] private int _rotateSpeed;

    protected override void InitBehaviours()
    {
        _movable = new StandartMoveBehaviour(this.transform);
        _rotatable = (IRotatable)_movable;
    }

    private void Start()
    {
        InitBehaviours();
    }

    private void Update()
    {
        _movable.Move(_moveSpeed);
        _rotatable.Rotate(_rotateSpeed);
    }
}
