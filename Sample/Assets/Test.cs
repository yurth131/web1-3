using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}

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

        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        int[] points = { 83, 99, 52, 93, 15 };

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] >= 90)
            {
                Debug.Log(points[i]);
            }
        }

        SayHello();

        CallName("Tom");

        int answer1;
        answer1 = Add(2, 3);
        Debug.Log(answer1);

        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);

    }
    void SayHello()
        {
            Debug.Log("Hello");
        }

    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a,int b)
    {
        int c = a + b;
        return c;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
