using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public CubeGenerator[] generatedCubes = new CubeGenerator[5];   //클래스 배열
    //타이머 관련 변수
    public float timer = 0f;         //시간 타이머 설정 float
    public float interval = 3f;      //3초 마다 땅 생성

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= interval)
        {
            RandomizeCubeActivation();
            timer = 0f;
        }
    }
    
    public void RandomizeCubeActivation()
    {
        for(int i = 0; i < generatedCubes. Length; i++)      //각 큐브를 랜덤하게 활성화 또는 비활성화
        {
            int randomNum = Random.Range(0, 2);
            if (randomNum == 1)
            {
                generatedCubes[i].GenCube();
            }
        }

             
    }
}
