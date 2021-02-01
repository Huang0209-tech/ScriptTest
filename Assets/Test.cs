using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = new int[5];

        array[0] = 400;
        array[1] = 800;
        array[2] = 500;
        array[3] = 900;
        array[4] = 100;

        //for文を使い、配列の各要素の値を順番に表示
        for (int x = 0; x < 5; x++)
        {
            Debug.Log(array[x]);
        }

        //for文を使い、配列の各要素の値を逆順に表示
        for (int y = 4; y >= 0; y--)
        {
            Debug.Log(array[y]);
        }
    }

        // Update is called once per frame
        void Update()
        {

        }
    }
