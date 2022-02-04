using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool startcondition;
    public float horizontalInput;
    public float verticalInput;
    public float speed=10;
    public bool spacebar;
    //public float scalInput;
    
    //condition starts
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        spacebar = Input.GetKey("space");
        if(startcondition)
        {            
        Debug.Log(spacebar);
        //scalInput = Input.GetAxis("Jump");
            if(spacebar)
            {
                this.transform.localScale = this.transform.localScale + new Vector3(1f,1f,1f) * Time.deltaTime;
            }
            else{
                this.transform.localScale= new Vector3(0f,0f,0f) +new Vector3(1f,1f,1f);
            }
            transform.Rotate(Vector3.up * horizontalInput * speed);
            transform.Rotate(Vector3.right * verticalInput * speed);
       //transform.localScale(scalInput * Time.deltaTime * speed);

        }

    }

    //condition ends
}
