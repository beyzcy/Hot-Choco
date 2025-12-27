using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationBox : MonoBehaviour, Interactable
{
    public Player player;
    public void Interact()
    {
        player.isDecorationCollected = true;
        gameObject.SetActive(false);    
        
    }
}
