using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeAnh : MonoBehaviour
{
    // Start is called before the first frame update
    public CodeGameOver CodeGameOver;
    int maxPlatfrom = 0;
    void Start()
    {
        
    }
    public Sprite Anh1, Anh2, Anh3;

    // Update is called once per frame
    void Update()
    {
        if(CodeDiChuyen.diemSo == 12)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh1;
        }
         if(CodeDiChuyen.diemSo ==18)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh2;
        }
        if (CodeDiChuyen.diemSo == 25)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh3;
            CodeGameOver.Setup(maxPlatfrom);
        }
        
    }
}
