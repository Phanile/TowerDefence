using UnityEngine;

public class GameLayers : MonoBehaviour
{
    [Header("Layers")]
    [SerializeField] private LayerMask _enemyMask;
    [SerializeField] private LayerMask _tileMask;

    public static LayerMask EnemyMask { get; private set; }
    public static LayerMask TileMask { get; private set; }

    private void Awake()
    {
        EnemyMask = _enemyMask;
        TileMask = _tileMask;
    }
}
