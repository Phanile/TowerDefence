using UnityEngine;
using UnityEngine.Events;

public abstract class EnemyEntity : MonoBehaviour
{
    public abstract void Move();

    public abstract void TakeDamage(int damage);

    protected UnityEvent<int> Damaged { get; }
}
