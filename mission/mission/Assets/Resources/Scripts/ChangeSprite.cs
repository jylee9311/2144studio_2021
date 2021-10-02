using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{

    
    private void Start()
    {
        Sprite = gameObject.GetComponent<SpriteRenderer>().sprite; 
    }

    public void Change()
    {
        Sprite = MissionDB.misson
    }
}
