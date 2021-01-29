using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    /*[SerializeField]
    private List<GameObject> pooledObjects; */
    [SerializeField]
    private GameObject ground;
    [SerializeField]
    private Transform generationPointRight;
    [SerializeField]
    private Transform generationPointLeft;
    private float groundCount = 0;
    private float groundWidth;
    // Start is called before the first frame update
    void Start(){
        groundWidth = ground.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update(){
        if(transform.position.x < generationPointRight.position.x){
            groundCount++;
            Debug.Log(groundCount);
            transform.position = new Vector3(transform.position.x + groundWidth, transform.position.y, transform.position.z);
            Instantiate(ground, transform.position, transform.rotation, transform);
        }
        /*if(transform.position.x > generationPoint.position.x){
            groundCount--;
            Debug.Log(groundCount);
            transform.position = new Vector3(transform.position.x + groundWidth, transform.position.y, transform.position.z);
            Instantiate(ground, transform.position, transform.rotation, transform);
        }*/
        //Debug.Log("False");
    }
}
