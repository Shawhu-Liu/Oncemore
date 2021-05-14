using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Player: MonoBehaviour
   
{
    public bool Pup , Pdown  , Pleft  , Pright;
    public int Curlevel;
    public FileStream F = new FileStream("./test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
    void stop()
    {
        Pup = false;
        Pdown = false;
        Pleft = false;
        Pright = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        stop();
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            F.Close();
        }
        float movex = 0, movey = 0;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("您按下了up键");
            if (Pup) 
            {
                
                movey += 2;
                stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("您按下了down键");
            if (Pdown)
            {
                movey -= 2;
                stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("您按下了left键");
            if (Pleft)
            {
                movex -= 2;
                stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("您按下了right键");
            if (Pright)
            {
                movex += 2;
                stop();
            }  
        }
        transform.Translate(movex, movey, 0);
    }


}
