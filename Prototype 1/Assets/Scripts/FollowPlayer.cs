using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(4, 6, -12);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Normal Update methodunu kullanırsak kamera ve araç aynı anda hareket edecek
    // Fakat bazen araç veya kamera farklı zamanlarda hareket edebilir buda stuttering e yol açıyor.
    // LateUpdate, update den sonra çalışır.
    void LateUpdate()
    {
        //Offset the camera behind the player by adding to the player's position.
        transform.position = player.transform.position + offset;
    }
}
