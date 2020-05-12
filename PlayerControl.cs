using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlAPI : MonoBehaviour
{

  public static PlayerControl instance;
  public int Speed = 50; //이동속도


  Rigidbody rigidbody; // 클래스 선언

  void Awake()
  {

    if( ! instance )
    instance = this;

    rigidbody = GetComponent<Rigidbody>(); //컴포넌트 호출

  }

  void Update()
  {

    this.PlayerMove(Speed);

  }

  public void PlayerMove(int speeeed)
  {

    if( Input.GetKey (KeyCode.W) )
    {
      transform.Translate( Vector3.forward * speeeed * Time.deltaTime ); //전진
    }

    if( Input.GetKey (KeyCode.S) )
    {
      transform.Translate( Vector3.back * speeeed * Time.deltaTime ); //후진
    }

    if( Input.GetKey (KeyCode.A) )
    {
      transform.Translate( Vector3.left * speeeed * Time.deltaTime ); //왼쪽
    }

    if( Input.GetKey (KeyCode.D) )
    {
      transform.Translate( Vector3.right * speeeed * Time.deltaTime ); //오른쪽
    }

    if( Input.GetKeyDown (KeyCode.Space) )
    {
      rigidbody.AddForce( Vector3.up * speeeed, ForceMode.Impulse ); //점프
    }

  }

}
