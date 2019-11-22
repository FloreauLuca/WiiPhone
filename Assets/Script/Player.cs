using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject merge1;
    public GameObject merge2;
    // Start is called before the first frame update
    void Start()
    {
        merge2 = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(merge1);
        Debug.Log("ECS");
        Debug.Log("ECS TEst");
    }
}
