using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Player player;
    public Image clockImage,checkList,howToPlay;
    public Sprite[] clockArray;
    public int x;
    public bool isCLopen,isHPopen;
    private void Update()
    {
        x = (int)player.remainingTime / 50;
        updateSprite();
        showHP();
        
        if (Input.GetKeyDown(KeyCode.Tab)&& isCLopen==false )
        {
            isCLopen = true;
            checkList.gameObject.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Tab) && isCLopen == true)
        {
            isCLopen = false;
            checkList.gameObject.SetActive(false);
        }
    }
    public void updateSprite()
    {
        clockImage.sprite = clockArray[x];
    }
    public void showHP()
    {
        if (Input.GetKeyDown(KeyCode.T) && isHPopen == false)
        {
            isHPopen = true;
            howToPlay.gameObject.SetActive(true);
        }
        else if (isHPopen && Input.GetKeyDown(KeyCode.T))
        {
            isHPopen = false;
            howToPlay.gameObject.SetActive(false);
        }
    }
}
