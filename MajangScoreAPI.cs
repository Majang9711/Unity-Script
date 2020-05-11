/*
 - 해당 API에 개발자는 Majang(이정진) 입니다.
 - 해당 함수들을 본인 스크립트에서 불러오는 방법은
   ->  MajangScoreAPI.instance.함수(num) 입니다.
 - 시작 설정은 StartScore, MaxScore값을 바꾸시면 됩니다.
 - 변수 불러오는 방법 :
    -> 클래스 가져오기! : MajangScoreAPI MajangScoreAPI_value;
    -> Start()함수에서  MajangScoreAPI_value = FindObjectOfType<MajangScoreAPI>(); 변수지정!
    -> MajangScoreAPI_value.변수명 으로 사용하고 싶은 곳에서 사용!
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajangScoreAPI : MonoBehaviour
{

  public static MajangScoreAPI instance;
  public int MaxScore = 100;
  public int StartScore = 0;
  public int Score = 0;

  void Awake()
  {

    if( ! instance )
    instance = this;

  }


  void Start()
  {

    Score = StartScore; //초기값 설정

  }

  public void addScore(int num) // num 값 만큼 점수 추가
  {

    int account;
    account = Score + num;

    if( account > MaxScore )
    {
      Score = MaxScore;
    }
    else
    {
      Score = account;
    }

  }

  public void reduceScore(int num)// num 값 만큼 점수 빼기
  {

    int account;
    account = Score - num;

    if( account < 0 )
    {
      Score = StartScore;
    }
    else
    {
      Score = account;
    }

  }

  public void setScore(int num) // num 값으로 점수 설정
  {

    if( num > MaxScore )
    {
      Score = MaxScore;
    }
    else
    {
      Score = num;
    }

  }



}
