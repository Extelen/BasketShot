using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	
    //Establecer variables.
		
        //Establecer estructuras.
		
        //Establecer enumeradores.
		

        //Establecer variables estaticas.
		
            //Publicas.
            public static ScoreController instance;
			
            //Privadas
            static int highScore;
			
        //Establecer variables.
		
            //Publicas.
            [Header("References")]
            public Text scoreText;
			
            //Privadas.
			private int m_score;
			
    //Funciones
		
        //Funciones de MonoBehaviour
        private void Start() {
            
            instance = this;
            SetScore(m_score, highScore);
            }
		
        //Funciones privadas.
		private void SetScore(int score, int hScore) {

            scoreText.text = "Score = " + score + "   HighScore = " + hScore;
            }
		
        //Funciones publicas.
        public void AddScore(int score) {

            m_score += score;
            highScore = (m_score > highScore) ? m_score : highScore;
            SetScore(m_score, highScore);
            }

        //Funciones heredadas.
		
        //Funciones ha heredar.
		
        //Corotinas.
		
        }
