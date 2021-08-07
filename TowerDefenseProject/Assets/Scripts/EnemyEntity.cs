using UnityEngine;

public abstract class EnemyEntity : MonoBehaviour
{
    protected IMovable _movable;
    protected IRotatable _rotatable;

    protected abstract void InitBehaviours();
}
