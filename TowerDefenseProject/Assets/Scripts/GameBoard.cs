using UnityEngine;

public class GameBoard : MonoBehaviour
{
    [Header("Way Points")]
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private Transform _enemiesRoot;
    
    public static Transform[] wayPoints;
    public static Transform enemiesRoot;

    private void Awake()
    {
        wayPoints = _wayPoints;
        enemiesRoot = _enemiesRoot;
    }
}
