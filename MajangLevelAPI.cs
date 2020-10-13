/*
 - 해당 API에 개발자는 Majang(이정진) 입니다.
 - 해당 함수들을 본인 스크립트에서 불러오는 방법은
   ->  MajangLevelAPI.instance.함수(num) 입니다.
 - 시작 설정은 StartLevel, MaxLevel, StartExp, MaxExp 값을 바꾸시면 됩니다.
 - 변수 불러오는 방법 :
    -> 클래스 가져오기! : MajangLevelAPI MajangLevelAPI_value;
    -> Start()함수에서  MajangLevelAPI_value = FindObjectOfType<MajangLevelAPI>(); 변수지장!
    -> MajangLevelAPI_value.변수명 으로 사용하고 싶은 곳에서 사용!
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajangLevelAPI : MonoBehaviour
{

  public static MajangLevelAPI instance;

  public int StartLevel = 0;
  public int MaxLevel = 100; //만렙
  public int Level = 0; //내 레벨

  public int MaxExp = 100;
  public int StartExp = 0;
  public int Exp = 0; //내 경험치

  void Awake()
  {

    if( ! instance )
    instance = this;

  }

  void Start()
  {

    Level = StartLevel; //초기갑 설정
    Exp = StartExp; //초기값 설정

  }
  
  public int getLevel()
  {
    retrun Level;
  }

  public void addExp(int num) //경험치 주기
  {

    int account;
    account = Exp + num;

    if( account >= MaxExp )
    {
      this.addLevel(1);
      Exp = StartExp;
    }
    else
    {
      Exp = account;
    }

  }

  public void reduceExp(int num) //경험치를 num 만큼 줄이기!
  {

    int account;
    account = Exp - num;

    if( account < 0 )
    {
      Exp = StartExp;
    }
    else
    {
      Exp = account;
    }

  }

  public void setExp(int num)//경험치를  num으로 설정하기!
  {

    if( num > MaxExp )
    {
      Exp = MaxExp;
    }
    else
    {
      Exp = num;
    }

  }

  public void addLevel(int num) //레벨을 num 만큼 더하기
  {

    int account;
    account = Level + num;

    if( account > MaxLevel )
    {
      Level = MaxLevel;
    }
    else
    {
      Level = account;
    }

  }

  public void reduceLevel(int num) //레벨을 num만큼 줄이기!
  {

    int account;
    account = Level - num;

    if( account < 0 )
    {
      Level = StartLevel;
    }
    else
    {
      Level = account;
    }
  }

  public void setLevel(int num) //레벨 num 값으로 설정
  {

    if( num > MaxLevel )
    {
      Level = MaxLevel;
    }
    else
    {
      Level = num;
    }

  }


}
