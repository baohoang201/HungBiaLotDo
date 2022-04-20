using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTraiBia : MonoBehaviour
{
    void Start()
    {

    }
    public Sprite Anh1, Anh2;

    // Update is called once per frame
    void Update()
    {
        if (CodeDiChuyen.diemSo == 15)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh1;
        }
        if (CodeDiChuyen.diemSo == 25)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh2;
        }
        

    }
}
