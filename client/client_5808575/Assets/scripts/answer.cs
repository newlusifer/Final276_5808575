using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SocketIO;

public class answer : MonoBehaviour
{
    public InputField inPut;
    public int getInput = 0;
    public Text textShow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        networkConnection.socket.On("startGuess",OnStartGuess);
    }

    public void onGetInput()
    {
        getInput = int.Parse(inPut.text);
        textShow.text = getInput.ToString();
        Debug.Log(getInput);
    }

    void OnStartGuess (SocketIOEvent e)
    {
        textShow.text = "StartGuess";
    }
}
