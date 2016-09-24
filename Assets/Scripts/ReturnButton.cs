using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class ReturnButton : MonoBehaviour {

	public void carregarCena(string cena){
		SceneManager.LoadScene (cena);
	}
}
