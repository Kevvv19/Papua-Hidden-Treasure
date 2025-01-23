using UnityEngine;
using UnityEngine.SceneManagement;

public class isi : MonoBehaviour
{
    // Fungsi untuk pindah ke Menu Scene
    public void NamaScene(string scenename)
    {
        SceneManager.LoadScene("main menu"); // Ganti dengan nama scene menu Anda
    }
    public void easy(string scenename)
    {
        SceneManager.LoadScene("easy"); // Ganti dengan nama scene menu Anda
    }
    public void normal(string scenename)
    {
        SceneManager.LoadScene("normal"); // Ganti dengan nama scene menu Anda
    }
    public void hard(string scenename)
    {
        SceneManager.LoadScene("hard"); // Ganti dengan nama scene menu Anda
    }
}