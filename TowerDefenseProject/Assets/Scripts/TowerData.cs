using UnityEngine;

[CreateAssetMenu(menuName = "Towers/Tower")]
public class TowerData : ScriptableObject
{
    [Header("Stats")]
    public TowerType type;
    public int damage;
    public float range;
    public float attackDelay;
}
