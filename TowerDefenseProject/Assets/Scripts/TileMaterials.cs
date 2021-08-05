using UnityEngine;

public class TileMaterials : MonoBehaviour
{
    [Header("Materials")]
    [SerializeField] private Material _roadMaterial;
    [SerializeField] private Material _buildMaterial;

    private static Material roadMaterial;
    private static Material buildMaterial;

    private void Awake()
    {
        roadMaterial = _roadMaterial;
        buildMaterial = _buildMaterial;
    }

    public static Material GetMaterial(TileType type) => type == TileType.Build ? buildMaterial : roadMaterial;
}
