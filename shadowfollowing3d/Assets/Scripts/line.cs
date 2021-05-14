using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
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

        if (ttp.y - tts.y == ptp.y && ttp.x == ptp.x) player.GetComponent<Player>().Pup = true;
        if (ttp.y + tts.y == ptp.y && ttp.x == ptp.x) player.GetComponent<Player>().Pdown = true;
    }                                                                  
}
