using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace LeeJY
{
    public class SettingUIActive : MonoBehaviour
    {
        public GameObject SettingUI;

        public GameObject MovingPanel;
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

        public void MiddleofSettingUI()
        {
            MovingPanel.transform.localPosition = new Vector3(0, -50, 0);
            Panel1.transform.position = new Vector3(3000, 3000, 0);
            Panel2.transform.position = new Vector3(3000, 3000, 0);
            Panel3.transform.position = new Vector3(3000, 3000, 0);


        }
    }
}