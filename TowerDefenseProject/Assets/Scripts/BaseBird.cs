using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBird : FlyableEntity
{
    [Header("Stats")]
    [SerializeField] private int _health;
    [SerializeField] private int _moveSpeed;

    protected override void InitBehaviours()
    {
        _movable = new FlyingMoveBehaviour(this.transform);
    }

    private void Start()
    {
        InitBehaviours();    
    }

    private void Update()
    {
        _movable.Move(_moveSpeed);
    }
}
