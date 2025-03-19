using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int Health = 100;                           //체력을 선언 한다. (정수)
    public float Timer = 1.0f;                         //타이머를 선언 한다.
    public int AttackPoint = 10;                       //공격력을 선언 한다.
    // 첫 프레임 이전에 한번 실행 된다.
    void Start()
    {
        Health += 100;                                //첫 프레임 이전에 실행될때 100체력을 추가 시켜준다.
    }

    // 매번 프레임 때 호출 된다.
    void Update()
    {
        CharacterHealthUp();

        if(Input.GetKeyDown(KeyCode.Space))       //스페이스 키를 눌렀을 때.
        {
            CharacterHit(AttackPoint);   
        }

        CheckDeath();                   //함수 호출

    }

    void CharacterHit(int Damage)         //커스텀 데미지를 받는 함수를 사용한다.
    {
        Health -= Damage;                //받은 공격력에 대한 체력을 감소 시킨다.
    }
    void CheckDeath()                    //함수 선언
    {
        if (Health <= 0)                   //체력이 0 이하로 내려가면 파괴 시킨다.
            Destroy(gameObject);           //이 오브젝트를 파괴 한다.
    }

    
    }
}
