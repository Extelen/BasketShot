using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTimer : MonoBehaviour {
	
    //Establecer variables.
		
        //Establecer estructuras.
		
        //Establecer enumeradores.
		

        //Establecer variables estaticas.
		
            //Publicas.
			
            //Privadas
			
        //Establecer variables.
		
            //Publicas.
            [Header("References")]
            public GameObject finishText;
            public UnityEngine.UI.Text text;
            
            [Header("Controller")]
            public float finishTime;
			
            //Privadas.
			
			
    //Funciones
		
        //Funciones de MonoBehaviour
        private void Start() {
			
            StartCoroutine(Finisher());
            }
		
        //Funciones privadas.
		
        //Funciones publicas.
		
        //Funciones heredadas.
		
        //Funciones ha heredar.
		
        //Corotinas.
        private IEnumerator Finisher() {

            for(float i = finishTime; i > 0; i -= Time.unscaledDeltaTime) {

                text.text = "Time Left = " + Mathf.Round(i);
                yield return null;
                }

            for(float i = 0; i < 1f; i += Time.unscaledDeltaTime) {

                Time.timeScale = Mathf.Lerp(1, 0, i/1f);
                yield return null;
                }

            Time.timeScale = 0;
            finishText.SetActive(true);

            while(!Input.GetKeyDown(KeyCode.Space)) {

                yield return null;
                }

            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
