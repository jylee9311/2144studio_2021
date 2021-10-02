/*
 * ===================================================================
 * 미션을 위한 데이터가 저장되는 파일입니다
 * ===================================================================
 * MissionNum: 미션 번호
 * Map: 맵 번호
 * MissionImportance: 서브(1) 혹 메인(0)
 * Rank: A,B,C,D
 * MissionContents: 미션 내용
 * CompleteContents: 달성 목록
 * CompleteStatusGoal: 목록 목표 개수
 * CompleteStatusCur: 현재 처리 개수
 * Clear: 미션 클리어 유무 성공(1) 미성공(0)
 * ChallengingNum: 도전 횟수 => 추후 도전 가능 횟수 제한이 있는 미션도 만들 수 있음
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LNK;


public class MissionDB : MonoBehaviour
{
    public static List<Dictionary<string, object>> mission;

    public void makeList()
    {
        mission = CSVReader.Read("Mission");
    }
}
