using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI; //Canvas, panel, Text, Image 등 UI에 해당되는 Component에 접근하기 위해 필요

namespace LNK
{
    public class Water2DScript : MonoBehaviour
    {
        public Vector2 speed = new Vector2(0.01f, 0f);

        private Renderer rend;
        private Material mat;

        private string shaderName;
        private float magnitude;
        private float magnitudeRegular, magnitudeLimit;
        private int RufflingLimit;
        private int onClick; //1이면 click 상태

        Stopwatch RufflingTime; //1이면 Ruffling중, 2면 ReduceRuffling중, 0이면 Ruffling종료


        void Start()
        {
            /*
            버튼이 눌릴시, update에서 진행될 이벤트를 위해 Map button을 불러옴
            */
            rend = GetComponent<Renderer>();
            mat = rend.material;
            RufflingLimit = 7000;
            magnitudeRegular = 0.005f;
            magnitudeLimit = 0.022f;
            magnitude = magnitudeRegular;

            RufflingTime = new Stopwatch();
            shaderName = "Custom/Water2D Surface";

            transform.GetComponent<Renderer>().material.shader = Shader.Find(shaderName); //셰이더 동적접근
            transform.GetComponent<Renderer>().material.SetFloat("_Magnitude", magnitude); //magnitude 값 설정

        }

        void Update()
        {
            if(onClick == 0)
                Ruffling();
            if(onClick == 1)
                Ruffle();
            
        }

        void Ruffle()
        {
            if (RufflingTime.ElapsedMilliseconds == 0) //마우스가 눌린시점에 Ruffling이 멈춰있어야 함
            {
                startRuffling();
                RufflingTime.Start();
            }
            else if (RufflingTime.ElapsedMilliseconds > 0 && RufflingTime.ElapsedMilliseconds < RufflingLimit)
            {
                if (magnitude < magnitudeLimit)
                    startRuffling();
                else if (magnitude >= magnitudeLimit)
                    Ruffling();

            }

            if (RufflingTime.ElapsedMilliseconds >= RufflingLimit)
            {
                RufflingTime.Stop();
                reduceRuffling();
                if (magnitude <= magnitudeRegular)
                {
                    stopRuffling();
                    RufflingTime.Reset();
                }
            }
        }

        void startRuffling()
        {
            magnitude += Time.deltaTime * 0.02f;
            transform.GetComponent<Renderer>().material.SetFloat("_Magnitude", magnitude);
            Vector2 scroll = Time.deltaTime * speed;
            mat.mainTextureOffset += scroll;
            return;
        }

        void Ruffling()
        {
            Vector2 scroll = Time.deltaTime * speed;
            mat.mainTextureOffset += scroll;
            if (mat.mainTextureOffset.y > 0.5) //Offset이 너무 커지면, 더이상 흔들리지않음
                mat.mainTextureOffset = Vector2.zero;
            return;
        }

        void reduceRuffling()
        {
            magnitude -= Time.deltaTime * 0.02f;
            transform.GetComponent<Renderer>().material.SetFloat("_Magnitude", magnitude);
            Vector2 scroll = Time.deltaTime * speed;
            mat.mainTextureOffset += scroll;
            return;
        }

        void stopRuffling()
        {
            magnitude = magnitudeRegular;
            onClick = 0;
            return;
        }

        public void OnClick() //맵 눌림을 확인하는 영역
        {
            onClick = 1;
        }
    }


}