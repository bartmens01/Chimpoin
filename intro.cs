using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Intro());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Intro()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("MainM");
    }
}
