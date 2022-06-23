using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public static SceneChange instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void Home()
    //{
    //    SceneManager.LoadScene("Home");
    //}

    //public void Office()
    //{
    //    SceneManager.LoadScene("Office");
    //}

    public void Gym()
    {
        SceneManager.LoadScene("Gym");
    }

    public void Vaction()
    {
        SceneManager.LoadScene("Beach");
    }

    public void AmuzementPark()
    {
        SceneManager.LoadScene("AmuzementPark");
    }

    public void ThankYou()
    {
        SceneManager.LoadScene("ThankYou");
    }
}
