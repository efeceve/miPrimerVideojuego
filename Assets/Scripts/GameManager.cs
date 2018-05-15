using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    menu,
    inTheGame,
    gameOver
}

public class GameManager : MonoBehaviour {

	// Se usa para iniciar la partida
	public void StartGame()
    {
		
	}
	
    //Se ocupa cuando el jugador muere
    public void GameOver()
    {

    }
	
    //Se llama cuando el jugador decide finalizar y volver al menu principal
    public void BackToMainMenu()
    {

    }
}
