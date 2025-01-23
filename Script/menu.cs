using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject infopanel;
    public GameObject gambarpanel;
    public GameObject gambar1panel;
    public GameObject gambar2panel;
    public GameObject gambar3panel;
    public GameObject gambar4panel;
    public GameObject gambar5panel;
    public GameObject gambar6panel;
    public GameObject gambar7panel;
    public GameObject gambar8panel;
    public GameObject gambar9panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton(string scenename)

    {
        SceneManager.LoadScene(scenename);
    }

    public void InfoButton()
    {
        menupanel.SetActive(false);
        infopanel.SetActive(true);
    }

    public void NextButtton()
    {
        infopanel.SetActive(false);
        gambarpanel.SetActive(true);
    }

    public void Gambar1Button()
    {
        gambar1panel.SetActive(true);
        gambarpanel.SetActive(false);
    }

    public void Gambar2Button()
    {
        gambar2panel.SetActive(true);
        gambarpanel.SetActive(false);
    }

    public void Gambar3Button()
    {
        gambar3panel.SetActive(true);
        gambarpanel.SetActive(false);
    }

    public void Gambar4Button()
    {
        gambar4panel.SetActive(true);
        gambarpanel.SetActive(false);
    }

    public void Gambar5Button()
    {
        gambar5panel.SetActive(true);
        gambarpanel.SetActive(false);
    }

    public void Gambar6Button()
    {
        gambar6panel.SetActive(true);
        gambarpanel.SetActive(false);
    }

    public void Gambar7Button()
    {
        gambar7panel.SetActive(true);
        gambarpanel.SetActive(false);
    }

    public void Gambar8Button()
    {
        gambar8panel.SetActive(true);
        gambarpanel.SetActive(false);
    }

    public void Gambar9Button()
    {
        gambar9panel.SetActive(true);
        gambarpanel.SetActive(false);
    }
    public void BackButton()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }

    public void Back2Button()
    {
        infopanel.SetActive(true);
        gambarpanel.SetActive(false);
    }

    public void BackButton1()
    {
        infopanel.SetActive(true);
        gambar1panel.SetActive(false);
    }

    public void BackButton2()
    {
        infopanel.SetActive(true);
        gambar2panel.SetActive(false);
    }

    public void BackButton3()
    {
        infopanel.SetActive(true);
        gambar3panel.SetActive(false);
    }

    public void BackButton4()
    {
        infopanel.SetActive(true);
        gambar4panel.SetActive(false);
    }

    public void BackButton5()
    {
        infopanel.SetActive(true);
        gambar5panel.SetActive(false);
    }

    public void BackButton6()
    {
        infopanel.SetActive(true);
        gambar6panel.SetActive(false);
    }

    public void BackButton7()
    {
        infopanel.SetActive(true);
        gambar7panel.SetActive(false);
    }

    public void BackButton8()
    {
        infopanel.SetActive(true);
        gambar8panel.SetActive(false);
    }

    public void BackButton9()
    {
        infopanel.SetActive(true);
        gambar9panel.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}