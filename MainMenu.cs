using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public int Amount;
    public GameObject SpawnPoint;
    public GameObject Monkey;
    // Start is called before the first frame update
    void Start()
    {
        Amount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Amount == 0)
        {
            Amount++;
            Instantiate(Monkey, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "FakeMan")
        {
            Destroy(coll.gameObject);
            Amount--;
        }
       
    }
}
