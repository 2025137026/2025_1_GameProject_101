using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class main : MonoBehaviour
{
    public int Health = 100;                           //ü���� ���� �Ѵ�. (����)
    public float Timer = 1.0f;                         //Ÿ�̸Ӹ� ���� �Ѵ�.
    public int AttackPoint = 10;                       //���ݷ��� ���� �Ѵ�.
    // ù ������ ������ �ѹ� ���� �ȴ�.
    void Start()
    {
        Health += 100;                                //ù ������ ������ ����ɶ� 100ü���� �߰� �����ش�.
    }

    // �Ź� ������ �� ȣ�� �ȴ�.
    void Update()
    {
        Timer -= Time.deltaTime;           //�ð��� �� �����Ӹ��� ���� ��Ų��. (deltaTime �����Ӱ��� �ð� ������ �ǹ��Ѵ�.)

        if(Timer <= 0)                    //���� TImer�� ��ġ�� 0���Ϸ� ������ ���
        {
            Timer = 1.0f;                 //�ٽ� 1�ʷ� ���� �����ش�.
            Health += 20;                 //1�ʸ��� ü�� 20�� �÷��ش�.
        }

        if(Input.GetKeyDown(KeyCode.Space))       //�����̽� Ű�� ������ ��.
        {
            Health -= AttackPoint;               //ü�� ����Ʈ�� ���� ����Ʈ ��ŭ ���� �����ش�.(Health = Health - AttackPonit)   
        }

        if (Health <= 0)                   //ü���� 0 ���Ϸ� �������� �ı� ��Ų��.
            Destroy(gameObject);           //�� ������Ʈ�� �ı� �Ѵ�.
    }
}
