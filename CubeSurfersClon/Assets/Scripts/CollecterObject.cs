using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollecterObject : MonoBehaviour
{
    public GameObject cube;
    public int high;
    private void Start()
    {
        cube = GameObject.Find("Cube");
    }
    private void Update()
    {
        cube.transform.position = new Vector3(transform.position.x, high + 1, transform.position.z);
        transform.localPosition = new Vector3(0, -high, 0);
    }
    public void highloan()
    {
        high--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect"&& other.gameObject.GetComponent<CollectableCube>().GetIsCollect()==false)
        {
            high += 1;
            other.gameObject.GetComponent<CollectableCube>().MakeCollect();
            other.gameObject.GetComponent<CollectableCube>().IndexSettings(high);
            other.gameObject.transform.parent = cube.transform;
        }
    }
}
