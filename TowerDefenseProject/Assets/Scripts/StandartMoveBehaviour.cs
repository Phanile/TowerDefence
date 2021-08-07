using UnityEngine;

public class StandartMoveBehaviour : IMovable, IRotatable
{
    private Transform _enemyEntity;

    private Transform[] _allPoints;

    private int _index;

    public StandartMoveBehaviour(Transform enemyEntity)
    {
        _enemyEntity = enemyEntity;
        _allPoints = GameBoard.WayPoints;
        _index = 1;
    }

    public void Move(float moveSpeed)
    {
        _enemyEntity.position = Vector3.MoveTowards(_enemyEntity.position, new Vector3(_allPoints[_index].position.x, _enemyEntity.position.y, _allPoints[_index].position.z), Time.deltaTime * moveSpeed);
        if (_enemyEntity.position == new Vector3(_allPoints[_index].position.x, _enemyEntity.position.y, _allPoints[_index].position.z))
        {
            if (_index + 1 > _allPoints.Length - 1)
            {
                return;
            }
            _index++;
        }
    }

    public void Rotate(float rotateSpeed)
    {
        var lookPos = _allPoints[_index].position - _enemyEntity.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        _enemyEntity.rotation = Quaternion.Slerp(_enemyEntity.rotation, rotation, Time.deltaTime * rotateSpeed);
    }
}
