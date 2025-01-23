using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
    // Fungsi untuk pindah ke Menu Scene
    public void NamaSceneeasy(string scenename)
    {
        SceneManager.LoadScene("izi"); // Ganti dengan nama scene menu Anda
    }

}