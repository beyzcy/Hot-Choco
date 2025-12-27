using UnityEngine;
using UnityEngine.UI;

public class ChristmasTree : MonoBehaviour, Interactable
{
    public Image targetImageObject;
    public Sprite[] imageArray;
    public Player player;
    public int currentIndex = 0;
    private void Start()
    {
        targetImageObject.gameObject.SetActive(false);
    }
    public void Interact()
    {
        ShowImage(currentIndex);
      
        if (player.isDecorationCollected == true) 
        {
            if (Input.GetMouseButton(0))
            {
                for (int i = 1; i < imageArray.Length; i++)
                {
                    ShowImage(i);
                    currentIndex = i;
                }
            }
        }
    }
    public void ShowImage(int imageNumber)
    {
        targetImageObject.sprite = imageArray[imageNumber];
        targetImageObject.gameObject.SetActive(true);
    }

    public void HideImage()
    {
        targetImageObject.gameObject.SetActive(false);
    }
}