using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.Threading;
using System;

public class test : MonoBehaviour
{
    private float Timer;                            //ȭ�鿡 ������ �Ǽ��� ����

    //private Text text;                               //UI Text

    //private DelayTimeMain DelayCount;      //������ �ڷ�ƾ ���� ����� ������ ��.

    void Start()
    {
        //DelayCount = GameObject.Find("Canvas").GetComponent<DelayTimeMain>();

        //text = this.gameObject.GetComponent<Text>();
    }

    // ��� �ð��� ���� ���� 1���̴ϱ�...
    void Update()
    {
        //if (DelayCount.DelayCount == 0)    //������ ���� 0�̸�

        //{

        //    //�ǽð� Time.deltaTime �ʱ�ȭ.

        //    Timer = Timer + Time.deltaTime;

        //    //�Ǽ��� ���� ù��° �ڸ����� �����Ͽ� UI Text �� ����ȭ

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

        // 1���� r2
        // 2���� r1
    }
}
