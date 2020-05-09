using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorObstacleScript : MonoBehaviour
{

    public float maxTime = 1;
    private float initialTime = 0;
    public GameObject objObstacle;
    public float highObstables;
    public int secondsToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObjObstacle = Instantiate(objObstacle);
        newObjObstacle.transform.position = transform.position + new Vector3(0,0,0);
        Destroy(newObjObstacle, secondsToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        if (initialTime > maxTime){
            initialTime = 0;
            GameObject newObjObstacle = Instantiate(objObstacle);
            newObjObstacle.transform.position = transform.position + new Vector3(0, Random.Range(-highObstables,highObstables),0);
            Destroy(newObjObstacle, secondsToDestroy);
        }else{
            initialTime += Time.deltaTime;
        }
    }

}
