using UnityEngine;

public class GameLayers : MonoBehaviour
{
    [Header("Layers")]
    [SerializeField] private LayerMask _enemyMask;

    public static LayerMask EnemyMask { get; private set; }

    private void Awake()
    {
        EnemyMask = _enemyMask;
    }
}
