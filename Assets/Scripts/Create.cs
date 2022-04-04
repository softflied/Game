using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Create : MonoBehaviour
{
    
    public GameObject createCoin(GameObject coin,Vector3 x)
    {
        return Instantiate(coin, x, Quaternion.identity);
    }
    
    public GameObject createBomb(GameObject bomb,Vector3 x)
    {
        return Instantiate(bomb, x, Quaternion.identity);
    } 
    
    public GameObject createObstacle(GameObject obstacle, Vector3 x)
    {
        return Instantiate(obstacle, x, Quaternion.identity);
    }
    
}
