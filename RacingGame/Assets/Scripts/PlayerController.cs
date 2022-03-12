using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get the player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We'll move the vehicle forward
        //transform.Translate(0, 0, 1);
        // Update i her framede değil her saniyede güncelleyeceğiz.
        //Şuan update method u her frame de çağırılıyor bu da farklı fps
        //alan oyuncuların farklı hareket etmesine sebep olur.
        //deltaTime ile 1 saniyenin aslında ne kadar zamanda geçtiğini buluyoruz.
        //biz kimin kaç fps alacağını kontrol edemeyiz ama
        //ne kadar zaman geçtiğini kontrol edebiliriz.
        //transform.Translate(Vector3.forward * Time.deltaTime);
        //yukarıda ki kod ile aracı saniyede 1 metre ilerletiyoruz, yada 1 unite.

        //We move the vehicle forward and backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
