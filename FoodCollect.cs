using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollect : MonoBehaviour
{
    public GameObject Player;
    private Vector3 scaleChange;
    public float Soda;
    public float Burger;
    public float Apple;
    public float Beard;
    public float Lax;
    public int Score;
    public AudioSource Fart, Eat;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Score <= -1)
        {
            Score = 0;
        }
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Burger")
        {
            Eat.Play();
            scaleChange = new Vector3(+Burger, +Burger, +Burger);
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().foodAmount--;
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().maxFood += 2;
            Player.transform.localScale += scaleChange;
            Destroy(coll.gameObject);
            Score += 10;
        }
        if (coll.gameObject.tag == "Apple")

        {
            Eat.Play();
            scaleChange = new Vector3(+Apple, +Apple, +Apple);
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().foodAmount--;
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().maxFood += 2;
            Player.transform.localScale += scaleChange;
            Destroy(coll.gameObject);
            Score += 1;
        }
        if (coll.gameObject.tag == "Soda")
        {
            Eat.Play();
            scaleChange = new Vector3(+Soda, +Soda, +Soda);
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().foodAmount--;
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().maxFood += 2;
            Player.transform.localScale += scaleChange;
            Destroy(coll.gameObject);
            Score += 3;
        }
        if (coll.gameObject.tag == "Bread")
        {
            Eat.Play();
            scaleChange = new Vector3(+Beard, +Beard, +Beard);
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().foodAmount--;
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().maxFood += 2;
            Player.transform.localScale += scaleChange;
            Destroy(coll.gameObject);
            Score += 5;
        }
        if (coll.gameObject.tag == "Lax")
        {
            Fart.Play();
            scaleChange = new Vector3(-Lax, -Lax, -Lax);
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().lactos--;
            GameManager.Instance.foodSpawn.GetComponent<FoodSpawner>().maxFood += 2;
            if (Player.transform.localScale.x >= 0.2f)
            {
                Player.transform.localScale += scaleChange;

            }
                
            Destroy(coll.gameObject);
            Score -= 20;
        }
    }

}

