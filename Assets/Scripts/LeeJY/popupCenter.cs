using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupCenter : MonoBehaviour
{

    public Transform Window;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Window.transform.position = new Vector3(-1000,-500,0);
    }
}
