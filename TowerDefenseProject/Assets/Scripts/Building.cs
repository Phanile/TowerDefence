using UnityEngine;

public abstract class Building : MonoBehaviour
{
    protected ITowerRotatable _rotatable;

    protected abstract void InitBehaviours();
}
