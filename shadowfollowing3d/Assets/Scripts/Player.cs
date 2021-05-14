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
            Debug.Log("��������up��");
            if (Pup) 
            {
                
                movey += 2;
                stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("��������down��");
            if (Pdown)
            {
                movey -= 2;
                stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("��������left��");
            if (Pleft)
            {
                movex -= 2;
                stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("��������right��");
            if (Pright)
            {
                movex += 2;
                stop();
            }  
        }
        transform.Translate(movex, movey, 0);
    }


}
