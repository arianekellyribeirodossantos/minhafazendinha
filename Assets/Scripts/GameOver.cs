using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField, Tooltip("Texto do timer do jogo")]
    private TextMeshProUGUI textComida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textComida.text = "Parabéns! Você coletou " +
            ComidaBehaviour.quantidade.ToString() +
            " carnes :)";
        Invoke("IrParaMenu", 5);
    }
    void IrParaMenu()
    {
        SceneManager.LoadScene(0);
    }
}
