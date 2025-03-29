using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 4f;
        
    private void Update(){


        //{ input }
        /* -------Eğitimde öğretilen.
        Vector2 inputVector = new Vector2(0,0); //vector2 2D hareketler

        if (Input.GetKey(KeyCode.W)){
            inputVector.y = +1;
        }      
        if (Input.GetKey(KeyCode.A)){
            inputVector.x = -1;
        }  
        if (Input.GetKey(KeyCode.S)){
            inputVector.y = -1;
        }  
        if (Input.GetKey(KeyCode.D)){
            inputVector.x = +1;
        }

        inputVector = inputVector.normalized; //çaprazda hızı eşitleme

        //{ process }
        Vector3 moveDirec = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDirec * moveSpeed * Time.deltaTime;
        */  

    
        //---------- Benim yöntem
        //{ input }
        Vector3 moveDirec = new Vector3(0, 0f, 0);
        if (Input.GetKey(KeyCode.W)){
            moveDirec.z = +1;
        }      
        if (Input.GetKey(KeyCode.A)){
            moveDirec.x = -1;
        }  
        if (Input.GetKey(KeyCode.S)){
            moveDirec.z = -1;
        }  
        if (Input.GetKey(KeyCode.D)){
            moveDirec.x = +1;
        }

        moveDirec = moveDirec.normalized; //çaprazda hızı eşitleme

        //{ process }
        transform.position += moveDirec * moveSpeed * Time.deltaTime;
    }
}
