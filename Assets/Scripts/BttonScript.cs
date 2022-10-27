using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BttonScript : MonoBehaviour
{
    [SerializeField] GameObject gazou =null;
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && gazou != null)
        {
            gazou.SetActive(false);
        }
    }
    public void OnClick()
    {
        if (this.gameObject.name == "Main")
        {
            SceneManager.LoadScene("SampleScene");
        }
        else 
            gazou.SetActive(true);
        }
    }