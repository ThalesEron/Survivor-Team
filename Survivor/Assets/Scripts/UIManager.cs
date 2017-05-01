using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Slider stamina;
    public float perda;
    public float ganho;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //perca de stamina conforme for pressionado o shift+w, se eles não forem apertados stamina ganha valor
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)
            || Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
        {
            stamina.value -= perda;
        }
        //perca de stamina conforme for pressionado o shift+a, ou seta shift+ esquerda. Se eles não forem apertados stamina ganha valor
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A)
            || Input.GetKey(KeyCode.LeftShift)  && Input.GetKey(KeyCode.LeftArrow))
        {
            stamina.value -= perda;
        }
        //perca de stamina conforme for pressionado o shift+s, se eles não forem apertados stamina ganha valor
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S)
            || Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.DownArrow))
        {
            stamina.value -= perda;
        }
        //perca de stamina conforme for pressionado o shift+d, se eles não forem apertados stamina ganha valor
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D)
            || Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.RightArrow))
        {
            stamina.value -= perda;
        }
        //se estiver apenas pressionado o W ganha metade do ganho normal de stamina
        if (Input.GetKey(KeyCode.W))
        {
            stamina.value += ganho / 2;
        }
        else
        {
            //se o personagem estiver parado ele ganha stamina na velocidade normal
            stamina.value += ganho;

        }
    }
}
