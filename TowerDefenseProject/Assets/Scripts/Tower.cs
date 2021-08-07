using System.Linq;
using UnityEngine;

public class Tower : Building
{
    [Header("Data")]
    [SerializeField] private TowerData _data;

    [Header("Target")]
    [SerializeField] private EnemyEntity _target;

    private void Update()
    {
        if (_target == null)
        {
            if (FindEnemy() != null)
            {
                _target = FindEnemy().GetComponent<EnemyEntity>();
            }
        }
        if (FindEnemy() == null)
        {
            if (_target != null)
            {
                _target = null;
            }
        }
    }

    private Collider FindEnemy()
    {
        Collider[] enemies = Physics.OverlapSphere(transform.position, _data.range, GameLayers.EnemyMask);

        if (enemies != null)
        {
            switch (_data.type)
            {
                case TowerType.Both:
                    return enemies[0];
                case TowerType.Ground:
                    foreach (var enemy in enemies)
                    {
                        if (enemy.GetComponent<EnemyEntity>() is FlyableEntity == false)
                        {
                            return enemy;
                        }
                    }
                    break;
                case TowerType.Air:
                    foreach (var enemy in enemies)
                    {
                        if (enemy.GetComponent<EnemyEntity>() is FlyableEntity)
                        {
                            return enemy;
                        }
                    }
                    break;
            }
        }
        return null;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, _data.range);
    }
}
