using UnityEngine;

[CreateAssetMenu(menuName = "Waves/Wave")]
public class EnemyWave : ScriptableObject
{
    [SerializeField] private EnemyEntity[] _enemies;

    public EnemyEntity[] GetEnemies()
    {
        return _enemies;
    }
}
