using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace LeeJY
{ 
public class MainMenuUI : MonoBehaviour
{

    
        public GameObject SettingUI;
        public GameObject BasicPanel;
        public GameObject Panel1;
        public GameObject Panel2;
        public GameObject Panel3;



        // Start is called before the first frame update

        void Start()
        {

        }

    // Update is called once per frame
    
        void Update()
        {

        }

    
        public void SettingMenuButton()
        {
            //float screenHeightHalf = Camera.main.orthographicSize;
            //float screenWidthHalf = screenHeightHalf * Camera.main.aspect;
            SettingUI.transform.localPosition = new Vector3(0, 0, 0);
            BasicPanel.transform.localPosition = new Vector3(0, -50, 0);
        }

        public void ResetUI()
        {
            SettingUI.transform.position = new Vector3(3000, 3000, 0);
            BasicPanel.transform.position = new Vector3(3000, 3000, 0);
            Panel1.transform.position = new Vector3(3000, 3000, 0);
            Panel2.transform.position = new Vector3(3000, 3000, 0);
            Panel3.transform.position = new Vector3(3000, 3000, 0);
        }
    }
}