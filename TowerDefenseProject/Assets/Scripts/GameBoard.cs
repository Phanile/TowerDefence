using UnityEngine;

public class GameBoard : MonoBehaviour
{
    [Header("Way Points")]
    [SerializeField] private Transform[] _wayPoints;

    [Header("Links")]
    [SerializeField] private Transform _enemiesRoot;
    [SerializeField] private Transform _towersRoot;
    
    public static Transform[] WayPoints { get; private set; }
    public static Transform EnemiesRoot { get; private set; }
    public static Transform TowersRoot { get; private set; }

    private void Awake()
    {
        WayPoints = _wayPoints;
        EnemiesRoot = _enemiesRoot;
        TowersRoot = _towersRoot;
    }
}
