using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {
	
    //Establecer variables.
		
        //Establecer estructuras.
		
        //Establecer enumeradores.
		

        //Establecer variables estaticas.
		
            //Publicas.
			
            //Privadas
			
        //Establecer variables.
		
            //Publicas.
            [Header("Teleport")]
            public float teleportSeconds;
			public Vector2 teleportRange;

            //Privadas.
			
			
    //Funciones
		
        //Funciones de MonoBehaviour
        private void Start() {
			
            StartCoroutine(TeleportCoroutine());
            }
        private void OnDrawGizmosSelected() {

            Gizmos.color = Color.red;

            Gizmos.DrawLine(new Vector3(-teleportRange.x, -teleportRange.y), new Vector3(teleportRange.x, -teleportRange.y));
            Gizmos.DrawLine(new Vector3(teleportRange.x, -teleportRange.y), new Vector3(teleportRange.x, teleportRange.y));
            Gizmos.DrawLine(new Vector3(teleportRange.x, teleportRange.y), new Vector3(-teleportRange.x, teleportRange.y));
            Gizmos.DrawLine(new Vector3(-teleportRange.x, teleportRange.y), new Vector3(-teleportRange.x, -teleportRange.y));
            }
        private void OnTriggerEnter2D(Collider2D collider) {

            if (collider.CompareTag("Player")) {

                ScoreController.instance.AddScore(10);
                }
            }
		
        //Funciones privadas.
        private void Teleport() {

            transform.position = new Vector3(Random.Range(-teleportRange.x, teleportRange.x), Random.Range(-teleportRange.y, teleportRange.y));
            transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
            }
		
        //Funciones publicas.
		
        //Funciones heredadas.
		
        //Funciones ha heredar.
		
        //Corotinas.
        private IEnumerator TeleportCoroutine() {
            
            Teleport();

            while(true) {

                yield return new WaitForSeconds(teleportSeconds);
                Teleport();
                }
            }
        }
