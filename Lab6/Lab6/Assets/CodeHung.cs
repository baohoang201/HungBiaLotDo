using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeHung : MonoBehaviour
{

    [SerializeField] private AudioSource mat;
    // Start is called before the first frame update

    
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate
        //    (Vector3.down * speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        

         if (col.gameObject.tag.Equals("Mat"))
        {

            Destroy(col.gameObject) ;
            mat.Play();


            Text diemSo = GameObject.Find("DiemSo").GetComponent<Text>();
            CodeDiChuyen.diemSo++;
            diemSo.text = " " + CodeDiChuyen.diemSo+"0";
        }


    }
    void OnCollisionStay2D(Collision2D col)
    {

    }
    void OnCollisionExit2D(Collision2D col)
    {

    }
}
