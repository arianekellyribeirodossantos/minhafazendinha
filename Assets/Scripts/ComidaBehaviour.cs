using UnityEngine;

public class ComidaBehaviour : MonoBehaviour
{
    // Itens da classe
    static public int quantidade;
    // Itens do objeto
    private void OnMouseDown()
    {
        MudarLugarComida();
        ComidaBehaviour.quantidade++;
    }
    void MudarLugarComida() 
    {
        float x = Random.Range(-8f, 8f);
        float y = Random.Range(-4f, 4f);
        Vector3 vetor = new Vector3(x, y, 0);
        this.gameObject.transform.position = vetor;
    }
}
