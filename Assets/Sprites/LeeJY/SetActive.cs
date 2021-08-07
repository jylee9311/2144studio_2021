using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{

    private bool state;
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Target.SetActive(false);
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if(state==true)
            {
                Target.SetActive(false);
                state = false;
            }
            else
            {
                Target.SetActive(true);
                state = true;
            }
        }

    }
}
