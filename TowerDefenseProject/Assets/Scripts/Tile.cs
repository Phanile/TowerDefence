using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private TileType _type;
    [SerializeField] private BuildTileType _buildType;

    public TileType Type { get; private set; }
    public BuildTileType BuildType { get; private set; }


    private void Start()
    {
        Type = _type;
        BuildType = _buildType;
        GetComponent<Renderer>().material = TileMaterials.GetMaterial(_type);
    }

    public void SetContent()
    {
        _buildType = BuildTileType.Full;
        BuildType = _buildType;
    }
}
