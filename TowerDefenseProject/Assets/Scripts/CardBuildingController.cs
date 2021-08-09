using UnityEngine;

public class CardBuildingController : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    public static Building Building { get; set; }

    private Tile _currentTile;

    private void Update()
    {
        if (Building != null)
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000, GameLayers.TileMask))
            {
                _currentTile = hit.collider.GetComponent<Tile>();
                if (Building is Tower)
                {
                    if (_currentTile.Type == TileType.Build && SuitableTile(_currentTile))
                    {
                        Building.transform.position = hit.collider.GetComponent<Tile>().transform.position;
                    }
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                if (_currentTile != null)
                {
                    if (_currentTile.Type == TileType.Build && SuitableTile(_currentTile))
                    {
                        _currentTile.SetContent();
                        Building = null;
                    }
                }
                
            }
        }
    }

    private bool SuitableTile(Tile tile)
    {
        return tile.BuildType == BuildTileType.Empty;
    }

    public void SetBuilding(Building building)
    {
        if (Building == building)
            return;
        Building = building;
    }
}
