using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject[] foods;
    public GameObject Laxto;
    bool canSpawn;
    bool canSpawnLacto;
    public int maxLacto;
    public int lactos;
    public int maxFood;
    public int foodAmount;
    public GameObject maxX;
    public GameObject minX;
    public GameObject maxY;
    public GameObject minY;
    public GameObject maxZ;
    public GameObject minZ;
    // Start is called before the first frame update
    void Start()
    {
        canSpawnLacto = false;
        canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
      
            spawnFood();

        if (lactos >= maxLacto)
        {
            canSpawnLacto = false;
        
        }
        if (lactos < maxLacto)
        {

            canSpawnLacto = true;
        }
        if (foodAmount >= maxFood)
        {
            canSpawn = false;
           
        }
        if (foodAmount < maxFood)
        {

            canSpawn = true;
        }
        if (foodAmount <= 0)
        {
            foodAmount = 0;
            canSpawn = true;
        }
    }
    void spawnFood()
    {
        if (canSpawn == true)
        {
            int foodRnd = Random.Range(0, 8);
            float Y = Random.Range(minY.transform.position.y, maxY.transform.position.y);
            float X = Random.Range(minX.transform.position.x, maxX.transform.position.x);
            float Z = Random.Range(minZ.transform.position.z, maxZ.transform.position.z);
            Instantiate(foods[foodRnd], new Vector3(X, Y, Z), Quaternion.identity);
            foodAmount++;
            if (canSpawnLacto == true)
            {
                int change = Random.Range(0, 20);
                if (change >= 10)
                {
                    spawnLaxto();
                    
                }
            }
            print("Spawned");
        }
    }
    void spawnLaxto()
    {
        float Y = Random.Range(minY.transform.position.y, maxY.transform.position.y);
        float X = Random.Range(minX.transform.position.x, maxX.transform.position.x);
        float Z = Random.Range(minZ.transform.position.z, maxZ.transform.position.z);
        Instantiate(Laxto, new Vector3(X, Y, Z), Quaternion.identity);
        lactos++;
    }
}
