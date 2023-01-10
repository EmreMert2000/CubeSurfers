using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    public bool isCollect;
    public int index;
    public CollecterObject collecter;
    private void Start()
    {
        isCollect = false;
    }
    private void Update()
    {
        if (isCollect==true)
        {
            if (transform.parent!=null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Enemy")
        {
            collecter.highloan();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GetIsCollect()
    {
        return isCollect;
    }
    public void MakeCollect()
    {
        isCollect = true;
    }
    public void IndexSettings(int index)
    {
        this.index = index;
    }
}
