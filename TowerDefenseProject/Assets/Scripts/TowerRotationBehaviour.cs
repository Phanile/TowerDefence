using UnityEngine;

public class TowerRotationBehaviour : ITowerRotatable
{
    private Transform _turret;

    public TowerRotationBehaviour(Transform turret)
    {
        _turret = turret;
    }

    public void Rotate(float rotationSpeed, Transform enemy)
    {
        var lookPos = enemy.position - _turret.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        _turret.rotation = Quaternion.Slerp(_turret.rotation, rotation, Time.deltaTime * rotationSpeed);
    }
}