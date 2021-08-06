using UnityEngine;

public abstract class EnemyEntity : MonoBehaviour
{
    protected IMovable _movable;

    protected abstract void InitBehaviours();
}
