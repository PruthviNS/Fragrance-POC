using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public static Avatar instance;
    //public GameObject male;
    //public GameObject female;
    [HideInInspector]
    public bool male;
    [HideInInspector]
    public bool female;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Male()
    {
        //male.SetActive(true);
        male = true;
        female = false;
        Debug.Log("Male Enabled");
    }

    public void Female()
    {
        female = true;
        male = false;
        //female.SetActive(true);
        Debug.Log("Female Enabled");
    }
}
