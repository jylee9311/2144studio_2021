using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LeeJY
{

    public class MainSettingManager : MonoBehaviour
    {
        public GameObject Main5Setting;
        public GameObject MainSetting2;
        public GameObject MainSetting3;
        public GameObject MainSetting4;




        // Start is called before the first frame update
        void Start()
        {
            MainSetting2.transform.localPosition = new Vector3(9000, 2000, 0);
            MainSetting3.transform.localPosition = new Vector3(9000, 1000, 0);
            MainSetting4.transform.localPosition = new Vector3(9000, 0, 0);

        }

        // Update is called once per frame
        void Update()
        {

        }


        public void Setting1ButtonClick()
        {
            MainSetting2.transform.localPosition = new Vector3(9000, 2000, 0);
            MainSetting3.transform.localPosition = new Vector3(9000, 1000, 0);
            MainSetting4.transform.localPosition = new Vector3(9000, 0, 0);

        }
        public void Setting2ButtonClick()
        {
            MainSetting2.transform.localPosition = new Vector3(0, -100, 0);
            MainSetting3.transform.localPosition = new Vector3(9000, 1000, 0);
            MainSetting4.transform.localPosition = new Vector3(9000, 0, 0);

        }
        public void Setting3ButtonClick()
        {
            MainSetting2.transform.localPosition = new Vector3(9000, 2000, 0);
            MainSetting3.transform.localPosition = new Vector3(0, -100, 0);
            MainSetting4.transform.localPosition = new Vector3(9000, 0, 0);

        }
        public void Setting4ButtonClick()
        {
            MainSetting2.transform.localPosition = new Vector3(9000, 2000, 0);
            MainSetting3.transform.localPosition = new Vector3(9000, 1000, 0);
            MainSetting4.transform.localPosition = new Vector3(0, -100, 0);

        }

        public void SettingBackButtonClick()
        {
            MainSetting2.transform.localPosition = new Vector3(9000, 2000, 0);
            MainSetting3.transform.localPosition = new Vector3(9000, 1000, 0);
            MainSetting4.transform.localPosition = new Vector3(9000, 1000, 0);

        }
    }
}
