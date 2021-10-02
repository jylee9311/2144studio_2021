using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

namespace LeeJY
{

public class DataManager : MonoBehaviour
{
       
        public SettingData SettingData;
        public SettingData CharData;

        public Slider EXP;

        public Slider BGMSlider;
        public Slider EffectSound;
        public Slider Resolution;

        public AudioSource BGM;

        void Start()
        {
            //From the json
            string path = Path.Combine(Application.dataPath, "settingData.json");
            string jsonSettingData = File.ReadAllText(path);
            SettingData = JsonUtility.FromJson<SettingData>(jsonSettingData);

            BGMSlider.value= SettingData.value[0];
            BGM.volume = SettingData.value[0];

            EffectSound.value = SettingData.value[1];

            Resolution.value = SettingData.value[2];



            string path2 = Path.Combine(Application.dataPath, "charData.json");
            string jsonCharData = File.ReadAllText(path2);
            CharData = JsonUtility.FromJson<SettingData>(jsonCharData);

            EXP.value = CharData.value[0];


        }

        void Update()
        {
            SettingData.value[0] = BGMSlider.value;
            SettingData.value[1] = EffectSound.value;
            SettingData.value[2] = Resolution.value;

            BGM.volume = SettingData.value[0];


            //To the json
            string jsonSettingData = JsonUtility.ToJson(SettingData, true);
            string path = Path.Combine(Application.dataPath, "settingData.json");
            File.WriteAllText(path, jsonSettingData);
        }
    }


    [System.Serializable]
    public class SettingData
    {
        public string[] name;
        public float[] value;
    }


    [System.Serializable]
    public class CharData
    {
        public string[] name;
        public float[] value;

    }

}