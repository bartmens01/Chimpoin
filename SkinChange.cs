using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChange : MonoBehaviour
{
    public int Amount;
    public Material[] skin = new Material[0];
    public Material assingSkin;
    
  
    // Start is called before the first frame update
    void Start()
    {
       
      int Num  =  Random.Range(0, Amount);
        assingSkin = skin[Num];
        GetComponent<Renderer>().material = assingSkin;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
