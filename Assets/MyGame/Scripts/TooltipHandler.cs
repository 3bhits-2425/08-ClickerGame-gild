using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject tooltipText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltipText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltipText.SetActive(false);
    }
}
