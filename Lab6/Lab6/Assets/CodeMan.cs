using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeMan : MonoBehaviour
{
    // Start is called before the first frame update
    public CodeGameOver CodeGameOver;
    int maxPlatfrom = 0;
   
    void Start()
    {
  
    }
   
    

    // Update is called once per frame
    void Update()
    {
        if (CodeDiChuyen.diemSo == -1)
        {
            CodeGameOver.Setup(maxPlatfrom);
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.tag.Equals("Mat"))
        {

            Destroy(col.gameObject);

           

            Text diemSo = GameObject.Find("DiemSo").GetComponent<Text>();
            CodeDiChuyen.diemSo--;
            diemSo.text = " " + CodeDiChuyen.diemSo + "0";
            if (CodeDiChuyen.diemSo == -1)
            {
                CodeGameOver.Setup(maxPlatfrom);
            }
        }
        


    }
    void OnCollisionStay2D(Collision2D col)
    {

    }
    void OnCollisionExit2D(Collision2D col)
    {

    }
}
