using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hallo Warld");

        int age;
        age = 30;
        Debug.Log(age);

        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log("height2");

        string name;
        name = "kitamura";
        Debug.Log(name);

        int answer;
        answer = 1 + 2;
        Debug.Log(answer);
        answer = 3 - 4;
        Debug.Log(answer);
        answer = 5 * 6;
        Debug.Log(answer);
        answer = 8 / 4;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);

        string str1 = "happy";
        string str2 = "birthday";
        string message;
        message = str1 + str2;
        Debug.Log(message);
        
        str1 += str2;
        Debug.Log(str1);

        string str = "happy";
        int num = 123;
        string message1 = str + num;
        Debug.Log(message1);

        int herbNum = 1;
        if (herbNum == 1) {
            Debug.Log("HP が 50 回復 した");
        }

        int hp = 200;
        if (hp >= 100)
        {
            Debug.Log("攻撃");
        }
        else
        {
            Debug.Log("防御");
        }

        int hp1 = 180;
        if (hp1 <= 50)
        {
            Debug.Log("闘争");
        }
        else if (hp >= 200)
        {
            Debug.Log("攻撃");
        }
        else
        {
            Debug.Log("防御");
        }

        int x = 1;
        if (x == 1)
        {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }
        //Debug.Log(y);

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        for (int i = 0; i < 5; i+=2)
        {
            Debug.Log(i);
        }

        for (int i = 3; i <= 5; i++)
        {
            Debug.Log(i);
        }

        for (int i = 3; i <= 0; i--)
        {
            Debug.Log(i);
        }

        int sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            sum += i;
            
        }Debug.Log(sum);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
