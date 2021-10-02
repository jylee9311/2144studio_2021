using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//나중에 이걸 전부 찢어서 각 UI에 스크립트로 넣을 수 있게 할 예정
namespace LNK{
    public class ShowMission : MonoBehaviour
    {

        /*
         * 추후 개선될 예정
         * 게임 설치 시 1회 PARSE되어 
         * 그 후 게임 플레이시마다
         * mission list 에 completeStatusCur이 계속 업데이트 되도록 함
         */
        static int MissionNum = 2; //Excel에서 MissionNum 0번에는 각 정보가 들어있습니다
        int LastMissionNum; //좀더 좋게 안되나?
        //주어진 여러 미션이 있는 창에서 특정 창 선택시 해당 번호를 따오는 것으로 변경할 예정
        //좌우화살표 클릭시 +-1 됨
        //0이하 및 미션 최대수 초과는 접근할 수 없도록, 캡슐화예정

        Text Rank;
        Text MissionImportance;
        Text MissionContents;
        Text CompleteContents;
        Text CompleteStatusGoal;
        Text CompleteStatusCur;


        void InformMission() //무결
        {
            Rank = GameObject.Find("Rank").GetComponent<Text>();
            MissionImportance = GameObject.Find("MissionImportance").GetComponent<Text>();
            MissionContents = GameObject.Find("MissionContents").GetComponent<Text>();
            CompleteContents = GameObject.Find("CompleteContents").GetComponent<Text>();
            CompleteStatusGoal = GameObject.Find("CompleteStatusGoal").GetComponent<Text>();
            CompleteStatusCur = GameObject.Find("CompleteStatusCur").GetComponent<Text>();
        }

        void AllocMission()
        {
            //LastMissionNum = Convert.ToInt32(MissionDB.mission.[0]["MissionNum"]); //해결이 안됨 ㅠㅠ
            Rank.text = MissionDB.mission[MissionNum]["Rank"].ToString();
            MissionImportance.text = MissionImportant(MissionDB.mission[MissionNum]["MissionImportance"].ToString());
            MissionContents.text = MissionDB.mission[MissionNum]["MissionContents"].ToString();
            CompleteContents.text = MissionDB.mission[MissionNum]["CompleteContents"].ToString();
            CompleteStatusGoal.text = MissionDB.mission[MissionNum]["CompleteStatusGoal"].ToString();
            CompleteStatusCur.text = MissionDB.mission[MissionNum]["CompleteStatusCur"].ToString();

            return;
        }


        public void Mission()
        {
            InformMission();
            AllocMission();

            print("Rank: " + Rank);
            print("MissionNum:" + MissionNum);
            print("missionImportance" + MissionImportance.text);
            print("missionContents" + MissionContents.text);
            print("completeContents" + CompleteContents.text);
            print("completeStatusGoal" + CompleteStatusGoal.text);
            print("completeStatusCur" + CompleteStatusCur.text);
        }

        public void ChangeMission(int MoveNum)
        {
            if (MoveNum < 0 || MoveNum > LastMissionNum)
            {
                print("올바르지 않은 숫자");
                return;
            }
            else if(MoveNum == MissionNum)
            {
                print("도대체 어떻게 ?");
                return;
            }

            MissionNum = MoveNum;
            
        }

        string MissionImportant(string Importance)
        {
            if (Importance == "0")
                return "메인";
            else
                return "서브";
        }

        public static int getMissionNum()
        {
            return MissionNum;
        }

    }
}