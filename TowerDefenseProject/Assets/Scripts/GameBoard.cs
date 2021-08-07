using UnityEngine;

public class GameBoard : MonoBehaviour
{
    [Header("Way Points")]
    [SerializeField] private Transform[] _wayPoints;

    [Header("Links")]
    [SerializeField] private Transform _enemiesRoot;
    
    public static Transform[] WayPoints { get; private set; }
    public static Transform EnemiesRoot { get; private set; }

    private void Awake()
    {
        WayPoints = _wayPoints;
        EnemiesRoot = _enemiesRoot;
    }
}
