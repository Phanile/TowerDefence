using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float _delay;

    [Header("Wave")]
    [SerializeField] private EnemyWave _wave; 

    public IEnumerator SpawnEnemies(EnemyEntity[] enemyEntities)
    {
        for(int i = 0; i < enemyEntities.Length; i++)
        {
            Instantiate(enemyEntities[i], GameBoard.enemiesRoot);
            yield return new WaitForSeconds(_delay);
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemies(_wave.GetEnemies()));
    }
}
