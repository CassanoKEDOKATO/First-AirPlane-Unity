using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bay : MonoBehaviour
{
 public float speed = 10f;   // Tốc độ di chuyển của máy bay

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        // Điều khiển máy bay di chuyển lên và xuống
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward  * verticalInput * speed * Time.deltaTime);
   transform.Translate(Vector3.up  * verticalInput * speed * Time.deltaTime);
        // Điều khiển máy bay di chuyển sang trái và phải
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
