using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.Threading;
using System;

public class test : MonoBehaviour
{
    private float Timer;                            //화면에 보여줄 실수형 변수

    //private Text text;                               //UI Text

    //private DelayTimeMain DelayCount;      //이전의 코루틴 설명에 설명된 딜레이 값.

    void Start()
    {
        //DelayCount = GameObject.Find("Canvas").GetComponent<DelayTimeMain>();

        //text = this.gameObject.GetComponent<Text>();
    }

    // 경과 시간이 작을 수록 1등이니까...
    void Update()
    {
        //if (DelayCount.DelayCount == 0)    //딜레이 값이 0이면

        //{

        //    //실시간 Time.deltaTime 초기화.

        //    Timer = Timer + Time.deltaTime;

        //    //실수형 변수 첫번째 자리까지 포맷하여 UI Text 로 가시화

        //    text.text = string.Format("", Timer);



        //}

        //long start = Stopwatch.GetTimestamp();
        //Thread.Sleep(500);
        //long end = Stopwatch.GetTimestamp();

        //long r1 = end - start; // 500

        //start = Stopwatch.GetTimestamp();
        //Thread.Sleep(100);
        //end = Stopwatch.GetTimestamp();

        //long r2= end - start; // 100

        // 1등이 r2
        // 2등이 r1
    }
}
