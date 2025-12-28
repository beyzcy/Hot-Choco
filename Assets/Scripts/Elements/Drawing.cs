using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class Drawing : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image targetImage;
    public Wall wall;
    void Start()
    {
        targetImage = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Input.GetMouseButton(0))
        {
            Erase();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }

    void Erase()
    {
        Color currentColor = targetImage.color;
        currentColor.a -= 0.2f;

        targetImage.color = currentColor;

        if (currentColor.a <= 0.01f)
        {
            wall.eraesedCount++;
            Destroy(gameObject);
        }
    }
}