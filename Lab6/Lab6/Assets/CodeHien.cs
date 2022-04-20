using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeHien : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject Bia;
    public Transform Tren;
    public int A, B;
    void Start()
    {
        StartCoroutine(Hien());

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Hien()
    {
        yield return new WaitForSeconds(Random.Range(A, B));
        Instantiate(Bia, Tren.position, Quaternion.identity);

        StartCoroutine(Hien());
    }
}
