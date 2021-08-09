using UnityEngine;

public class Tower : Building
{
    [Header("Data")]
    [SerializeField] private TowerData _data;

    [Header("Target")]
    [SerializeField] private Transform _target;

    [Header("RotatableObjects")]
    [SerializeField] private Transform _muzzle;
    [SerializeField] private Transform _turret;

    private void Start()
    {
        InitBehaviours();
    }

    protected override void InitBehaviours()
    {
        if (_data.type == TowerType.Air)
        {
            _rotatable = new AirTowerRotationBehaviour(_turret, _muzzle);
        }
        else
        {
            _rotatable = new TowerRotationBehaviour(_turret);
        }
    }

    private void Update()
    {
        if (_target == null)
        {
            if (FindEnemy() != null)
            {
                _target = FindEnemy();
            }
        }
        if (FindEnemy() == null)
        {
            if (_target != null)
            {
                _target = null;
            }
        }
        if (_target != null)
        {
            _rotatable.Rotate(_data.rotationSpeed, _target);
        }
    }

    private Transform FindEnemy()
    {
        Collider[] enemies = Physics.OverlapSphere(transform.position, _data.range, GameLayers.EnemyMask);

        if (enemies != null)
        {
            switch (_data.type)
            {
                case TowerType.Both:
                    return enemies[0].GetComponent<Transform>();
                case TowerType.Ground:
                    foreach (var enemy in enemies)
                    {
                        if (enemy.GetComponent<EnemyEntity>() is FlyableEntity == false)
                        {
                            return enemy.GetComponent<Transform>();
                        }
                    }
                    break;
                case TowerType.Air:
                    foreach (var enemy in enemies)
                    {
                        if (enemy.GetComponent<EnemyEntity>() is FlyableEntity)
                        {
                            return enemy.GetComponent<Transform>();
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
