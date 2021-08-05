using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private TileType _type;

    private void Start()
    {
        GetComponent<Renderer>().material = TileMaterials.GetMaterial(_type);
    }
}
