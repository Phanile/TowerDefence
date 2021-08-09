using UnityEngine;

public class TileMaterials : MonoBehaviour
{
    [Header("Materials")]
    [SerializeField] private Material _roadMaterial;
    [SerializeField] private Material _buildMaterial;
    [SerializeField] private Material _selectedMaterial;

    private static Material roadMaterial;
    private static Material buildMaterial;
    private static Material selectedMaterial;

    private void Awake()
    {
        roadMaterial = _roadMaterial;
        buildMaterial = _buildMaterial;
        selectedMaterial = _selectedMaterial;
    }

    public static Material GetMaterial(TileType type) => type == TileType.Build ? buildMaterial : roadMaterial;
    public static Material GetMaterial() => selectedMaterial;
}
