using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CodeDiChuyen : MonoBehaviour
{
    // Start is called before the first frame update

    public static int diemSo = 0;
    void Start()
    {
      
    }
    public int speed = 2;
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.A))
        {
           
            transform.Translate
                (Vector3.left * speed * Time.deltaTime);
         
        }
        else if (Input.GetKey(KeyCode.D))
        {
            
            transform.Translate
                (Vector3.right * speed * Time.deltaTime);
        }
       
    }
}
