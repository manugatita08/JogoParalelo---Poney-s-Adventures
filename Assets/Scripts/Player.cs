using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float veloc  ;
    public float entradaHorizontal;
    public float entradaVertical;

    public GameObject pfEstrela;
    
    public bool possoDisparar = true;
    public float tempoEntreTiros;
  

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Método Start de "+this.name);
        veloc = 3.0f;
        transform.position = new Vector3(0,0,0);

    }

    // Update is called once per frame
    void Update()
    {
       
        Movimento();

        if  (Input.GetKeyDown(KeyCode.Space))
        {
                Instantiate(pfEstrela,transform.position + new Vector3(01.82f,1.82f,0),Quaternion.identity);
        }


    }


    private void Movimento(){

        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * veloc * Time.deltaTime * entradaHorizontal );

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * veloc * Time.deltaTime * entradaVertical );

        if ( transform.position.y > 1.5f ) {
            transform.position = new Vector3(transform.position.x,0,0);
        }

        if ( transform.position.y < 2.5f){
            transform.position = new Vector3(transform.position.x, -2.5f,0);
        }

        if ( transform.position.x > 9.65f){
            transform.position = new Vector3(-9.65f,transform.position.y,0);
        }

         if ( transform.position.x < -9.65f){
            transform.position = new Vector3(9.65f,transform.position.y,0);
        } 

    }
  
}
