using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {
	
    //Establecer variables.
		
        //Establecer estructuras.
		
        //Establecer enumeradores.
		

        //Establecer variables estaticas.
		
            //Publicas.
			
            //Privadas
			
        //Establecer variables.
		
            //Publicas.
            [Header("References")]
            public Rigidbody2D rb2D;
            
            [Header("Movement")]
            public float movementSpeed;
            public float movementSmoothness;

            [Header("Rotation")]
            public float rotationSpeed;
            public float rotationSmoothness;
			
            //Privadas.
            private Vector2 m_movementVelocity;

            private float m_rotationVelocity;
			private float m_angle;
            private float m_savedAngle;
			
    //Funciones
		
        //Funciones de MonoBehaviour
        private void Start() {
			
            }
        private void Update() {
            
            //Movimiento.
                Vector2 m_axisVelocity;

                m_axisVelocity.x = (Input.GetKey(KeyCode.A) ? -1 : 0) + (Input.GetKey(KeyCode.D) ? 1 : 0);
                m_axisVelocity.y = (Input.GetKey(KeyCode.S) ? -1 : 0) + (Input.GetKey(KeyCode.W) ? 1 : 0);
                m_axisVelocity *= movementSpeed;

                rb2D.velocity = Vector2.SmoothDamp(rb2D.velocity, m_axisVelocity, ref m_movementVelocity, movementSmoothness, Mathf.Infinity, Time.deltaTime);

            //Rotacion.
                m_angle += ((Input.GetKey(KeyCode.E) ? -1 : 0) + (Input.GetKey(KeyCode.Q) ? 1 : 0));
                m_savedAngle = Mathf.SmoothDamp(m_savedAngle, m_angle, ref m_rotationVelocity, rotationSmoothness, Mathf.Infinity, Time.deltaTime);
                
                transform.eulerAngles = new Vector3(0, 0, m_savedAngle);
                }
            
        //Funciones privadas.
		
        //Funciones publicas.
		
        //Funciones heredadas.
		
        //Funciones ha heredar.
		
        //Corotinas.
		
        }
