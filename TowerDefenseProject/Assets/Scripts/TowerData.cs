using UnityEngine;

[CreateAssetMenu(menuName = "Towers/Tower")]
public class TowerData : ScriptableObject
{
    [Header("Type")]
    public TowerType type;

    [Header("Stats")]
    public float rotationSpeed;
    public int damage;
    public float range;
    public float attackDelay;
}
