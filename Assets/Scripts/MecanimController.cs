using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Añadir este Script a la esfera desde el Inspector
public class MecanimController : MonoBehaviour {

	public Animator animController;

	// Use this for initialization
	void Start () {
		animController = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Avanzar ();
		Salto ();
		Viento ();
		Escala ();
	}

	//Funciones que representan a los parámetros del Animator
	void Avanzar(){ //Es un parámetro del Animator booleano
		//Input es la clase que va a recibir cualquier entrada al juego, ya sea de cámara, teclado, botón, lo que sea...
		if (Input.GetButtonDown ("Fire1")) //Configuración de Fire1 se puede ver en menú Edit/Project Settings/Input
			animController.SetBool ("Avanzar", true);//SetBool ("Avanzar", true); => Cómodo de acceder al parámetro "Avanzar" del Animator pero no es lo recomendado. 
		                                             //"Avanzar" es el nombre del booleano en los parámetros del Animator
	
		if (Input.GetButtonDown ("Fire2"))
			animController.SetBool ("Avanzar", false);	
	}

	void Salto(){ //Es un parámetro del Animator trigger
		if(Input.GetKeyDown(KeyCode.Space))
			animController.SetTrigger("Salto");
	}

	void Viento(){ //Es un parámetro del Animator float
		if (Input.GetKeyDown (KeyCode.V))
			animController.SetFloat ("Viento", 0.5f);

		if (Input.GetKeyDown (KeyCode.B))
			animController.SetFloat ("Viento", 0.0f);
	}

	void Escala(){ //Es un parámetro del Animator entero
		if (Input.GetKeyDown (KeyCode.X))
			animController.SetInteger ("Escala", 4);

		if (Input.GetKeyDown (KeyCode.C))
			animController.SetInteger ("Escala", 0);
	}
}
