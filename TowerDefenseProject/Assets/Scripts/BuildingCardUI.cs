using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingCardUI : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private Building _building;
    [SerializeField] private CardBuildingController _cardBuildingController;

    public void OnPointerDown(PointerEventData eventData)
    {
        var building = Instantiate(_building, GameBoard.TowersRoot);
        _cardBuildingController.SetBuilding(building);
    }
}
