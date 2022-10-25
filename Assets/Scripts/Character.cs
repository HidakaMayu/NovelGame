using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    // Start is called before the first frame update

    void Update()
    {
        Vector3 player = Camera.main.transform.position;
        player.y = transform.position.y;
        transform.LookAt(player);
    }
    
    //もしそのキャラに触れたらセリフにてそのキャラのspliteが差し込まれる
}
