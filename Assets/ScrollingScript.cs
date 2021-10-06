using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingScript : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed=5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position - new Vector3( movementSpeed * Time.deltaTime,0, 0);

        if (transform.position.x<-10)
        {
            transform.position = new Vector3(10, -5, 0);
        }
    }
}
