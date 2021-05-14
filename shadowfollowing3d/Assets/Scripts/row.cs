using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class row : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ptp = player.transform.position;
        Vector3 ttp = this.transform.position;
        Vector3 tts = this.transform.localScale;

        if (ttp.x - tts.x == ptp.x && ttp.y == ptp.y) player.GetComponent<Player>().Pright = true;
        if (ttp.x + tts.x == ptp.x && ttp.y == ptp.y) player.GetComponent<Player>().Pleft = true;

        Debug.Log("player:"+ptp);
        Debug.Log("road:"+ttp);
    }
}
