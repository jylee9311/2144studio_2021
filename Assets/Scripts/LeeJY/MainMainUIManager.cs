using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace LeeJY
{
    public class MainMainUIManager : MonoBehaviour
    {
        public GameObject Tablet;
        public GameObject MainMain;
        public int MainMenuStatus;
        public GameObject Main1Status;
        public GameObject Main2Magic;
        public GameObject Main3MissionLog;
        public GameObject Main4Achievement;
        public GameObject Main5Setting;


        // Start is called before the first frame update
        void Start()
        {
            Tablet.transform.localPosition = new Vector3(3000, 4000, 0);
            Main1Status.transform.localPosition = new Vector3(5000, 4000, 0);
            Main2Magic.transform.localPosition = new Vector3(6000, 4000, 0);
            Main3MissionLog.transform.localPosition = new Vector3(7000, 4000, 0);
            Main4Achievement.transform.localPosition = new Vector3(8000, 4000, 0);
            Main5Setting.transform.localPosition = new Vector3(9000, 4000, 0);
            MainMenuStatus = -1;
            print(MainMenuStatus);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void CharButtonClick()
        {
            if(MainMenuStatus == -1)
            {
                Tablet.transform.localPosition = new Vector3(0, 0, 0);

                MainMenuStatus = 0;
                print(MainMenuStatus);
            }
            else
            {
                Tablet.transform.localPosition = new Vector3(3000, 4000, 0);

                Main1Status.transform.localPosition = new Vector3(5000, 4000, 0);
                Main2Magic.transform.localPosition = new Vector3(6000, 4000, 0);
                Main3MissionLog.transform.localPosition = new Vector3(7000, 4000, 0);
                Main4Achievement.transform.localPosition = new Vector3(8000, 4000, 0);
                Main5Setting.transform.localPosition = new Vector3(9000, 4000, 0);
                MainMenuStatus = -1;
                print(MainMenuStatus);
            }

        }


        public void Main1ButtonClick()
        {
            Main1Status.transform.localPosition = Tablet.gameObject.transform.localPosition;
            Main2Magic.transform.localPosition = new Vector3(6000, 4000, 0);
            Main3MissionLog.transform.localPosition = new Vector3(7000, 4000, 0);
            Main4Achievement.transform.localPosition = new Vector3(8000, 4000, 0);
            Main5Setting.transform.localPosition = new Vector3(9000, 4000, 0);
            MainMenuStatus = 1;
            print(MainMenuStatus);
        }

        public void Main2ButtonClick()
        {
            Main1Status.transform.localPosition = new Vector3(5000, 4000, 0);
            Main2Magic.transform.localPosition = Tablet.gameObject.transform.localPosition;
            Main3MissionLog.transform.localPosition = new Vector3(7000, 4000, 0);
            Main4Achievement.transform.localPosition = new Vector3(8000, 4000, 0);
            Main5Setting.transform.localPosition = new Vector3(9000, 4000, 0);
            MainMenuStatus = 2;
            print(MainMenuStatus);
        }

        public void Main3ButtonClick()
        {
            Main1Status.transform.localPosition = new Vector3(5000, 4000, 0);
            Main2Magic.transform.localPosition = new Vector3(6000, 4000, 0);
            Main3MissionLog.transform.localPosition = Tablet.gameObject.transform.localPosition;
            Main4Achievement.transform.localPosition = new Vector3(8000, 4000, 0);
            Main5Setting.transform.localPosition = new Vector3(9000, 4000, 0);
            MainMenuStatus = 3;
            print(MainMenuStatus);
        }

        public void Main4ButtonClick()
        {
            Main1Status.transform.localPosition = new Vector3(5000, 4000, 0);
            Main2Magic.transform.localPosition = new Vector3(6000, 4000, 0);
            Main3MissionLog.transform.localPosition = new Vector3(7000, 4000, 0);
            Main4Achievement.transform.localPosition = Tablet.gameObject.transform.localPosition;
            Main5Setting.transform.localPosition = new Vector3(9000, 4000, 0);
            MainMenuStatus = 4;
            print(MainMenuStatus);
        }

        public void Main5ButtonClick()
        {
            Main1Status.transform.localPosition = new Vector3(5000, 4000, 0);
            Main2Magic.transform.localPosition = new Vector3(6000, 4000, 0);
            Main3MissionLog.transform.localPosition = new Vector3(7000, 4000, 0);
            Main4Achievement.transform.localPosition = new Vector3(8000, 4000, 0);
            Main5Setting.transform.localPosition = Tablet.gameObject.transform.localPosition;
            MainMenuStatus = 5;
            print(MainMenuStatus);
        }

        public void MainBackButtonClick()
        {
            if (MainMenuStatus == 0)
            {
                Tablet.transform.localPosition = new Vector3(3000, 4000, 0);
                Main1Status.transform.localPosition = new Vector3(5000, 4000, 0);
                Main2Magic.transform.localPosition = new Vector3(6000, 4000, 0);
                Main3MissionLog.transform.localPosition = new Vector3(7000, 4000, 0);
                Main4Achievement.transform.localPosition = new Vector3(8000, 4000, 0);
                Main5Setting.transform.localPosition = new Vector3(9000, 4000, 0);
                MainMenuStatus = -1;
                print(MainMenuStatus);
            }
            else
            {
                Tablet.transform.localPosition = new Vector3(0, 0, 0);
                Main1Status.transform.localPosition = new Vector3(5000, 4000, 0);
                Main2Magic.transform.localPosition = new Vector3(6000, 4000, 0);
                Main3MissionLog.transform.localPosition = new Vector3(7000, 4000, 0);
                Main4Achievement.transform.localPosition = new Vector3(8000, 4000, 0);
                Main5Setting.transform.localPosition = new Vector3(9000, 4000, 0);
                MainMenuStatus = 0;
                print(MainMenuStatus);
            }

        }


    }
}
