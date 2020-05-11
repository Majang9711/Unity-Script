/*
 -  해당 API에 개발자는 Majang(이정진) 입니다.
 - 해당 함수들을 본인 플러그인에 불러오는 방법은
   ->  MajangMoneyAPI.instance.함수(num) 입니다.
 - 시작 돈 설정은 StartMoney의 값을 바꾸시면 됩니다.
 - 변수 불러오는 방법 :
    -> 클래스 가져오기! : MajangMoneyAPI MajangAPI_value;
    -> Start()함수에서  MajangAPI_value = FindObjectOfType<MajangMoneyAPI>(); 변수지장!
    -> MajangAPI_value.변수명 으로 사용하고 싶은 곳에서 사용!
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajangMoneyAPI : MonoBehaviour
{

  public static MajangMoneyAPI instance; //어디서나 접근할 수 있도록 static(정적)으로 자기 자신을 저장할 변수를 만듭니다.
  public int StartMoney; //처음 받을 돈을 정합니다.
  public int Money = 0;

  void Awake()
  {

    if( ! instance )
    instance = this;

  }

  void Start()
  {

    Money = StartMoney; //시작 돈 설정

  }

  public void addMoney(int num)
  {

    Money = Money + num;

  }

  public void reduceMoney(int num)
  {

    if( Money >= 0 ) // 0원 이하의 금액으로 떨어지지 않개!
    {
      Money = Money - num;
    }

  }

  public void setMoney(int num)
  {

    Money = num;

  }


}
