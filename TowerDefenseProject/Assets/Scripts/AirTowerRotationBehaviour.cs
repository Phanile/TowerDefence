using UnityEngine;
public class AirTowerRotationBehaviour : ITowerRotatable
{
    private Transform _turret;
    private Transform _muzzle;

    public AirTowerRotationBehaviour(Transform turret, Transform muzzle)
    {
        _turret = turret;
        _muzzle = muzzle;
    }

    public void Rotate(float rotationSpeed, Transform enemy)
    {
        var lookPos = enemy.position - _turret.position;
        var xPos = enemy.position - _muzzle.position;
        lookPos.y = 0;
        xPos.x = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        var muzzleRotation = Quaternion.LookRotation(lookPos + xPos);
        _turret.rotation = Quaternion.Slerp(_turret.rotation, rotation, Time.deltaTime * rotationSpeed);
        _muzzle.rotation = Quaternion.Slerp(_muzzle.rotation, muzzleRotation, Time.deltaTime * rotationSpeed);
    }
}
