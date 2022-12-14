using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonCtrl : MonoBehaviour
{
    public GameObject[] tile;
    public GameObject[,] positions=new GameObject[5,5];

    public int X;
    public int Y;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < tile.Length; i++)
        {
            Map tileMap = tile[i].GetComponent<Map>();
            positions[tileMap.H, tileMap.V] = tile[i];
            //print(tile[i].name);
        }
        X = 2;
        Y = 2;
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonDown(int direction)
    {
        switch (direction)
        {
            case 1:
                X--;
                break;
            case 2:
                Y--;
                break;
            case 3:
                Y++;
                break;
            case 4:
                X++;
                break;
        }
        if (X > 4) X = 4;
        if (X < 0) X = 0;
        if (Y > 4) Y = 4;
        if (Y < 0) Y = 0;
        Move();
    }

    public void Move()
    {
        var position = new Vector3(positions[X, Y].transform.position.x, positions[X, Y].transform.position.y+0.1f,0);
        //transform.position = position;
        transform.DOMove(position, 0.1f);
    }
}
