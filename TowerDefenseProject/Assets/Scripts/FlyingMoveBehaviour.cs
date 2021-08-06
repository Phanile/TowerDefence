using UnityEngine;

public class FlyingMoveBehaviour : IMovable
{
    private Transform _enemyEntity;

    private Transform[] _allPoints;

    private int _index;

    public FlyingMoveBehaviour(Transform enemyEntity)
    {
        _enemyEntity = enemyEntity;
        _allPoints = GameBoard.wayPoints;
        _index = _allPoints.Length - 1;
    }

    public void Move(float moveSpeed)
    {
        _enemyEntity.position = Vector3.MoveTowards(_enemyEntity.position, new Vector3(_allPoints[_index].position.x, _enemyEntity.position.y, _allPoints[_index].position.z), Time.deltaTime * moveSpeed);
    }
}
