using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymAvatar : MonoBehaviour
{
    public GameObject male;
    public GameObject female;
    // Start is called before the first frame update
    void Start()
    {
        MaleEnable();
        FemaleEnable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void MaleEnable()
    {
        if(Avatar.instance.male == true)
        {
            male.SetActive(true);
            female.SetActive(false);
        }
        
    }
    public void FemaleEnable()
    {
        if(Avatar.instance.female == true)
        {
            female.SetActive(true);
            male.SetActive(false);
        }
        
    }
}
