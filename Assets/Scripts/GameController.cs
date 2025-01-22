using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField,Tooltip("Duração do jogo")]
    private float timer = 10f;
    [SerializeField, Tooltip("Texto do timer do jogo")]
    private TextMeshProUGUI textTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ComidaBehaviour.quantidade = 0; //zero a comida coletada
        Invoke("IrParaGameOver",timer); //falo para ir para gameover depois de timer segundos
        textTimer.text = "TIMER: " + timer.ToString();
        InvokeRepeating("DecTimer", 1f, 1f);
    }
    void IrParaGameOver() 
    {
        SceneManager.LoadScene(2);
    }
    private void DecTimer() 
    {
       timer -= 1;
       textTimer.text = "TIMER: " + timer.ToString();
    }
}
