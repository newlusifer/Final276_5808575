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
        networkConnection.socket.On("than",OnThan);
        networkConnection.socket.On("less", OnLess);
        networkConnection.socket.On("winner", OnWinner);
    }

    public void onGetInput()
    {
        getInput = int.Parse(inPut.text);
        //textShow.text = getInput.ToString();
        Debug.Log("guess "+getInput);
        JSONObject JoB = new JSONObject(getInput);
        networkConnection.socket.Emit("guess",JoB);
    }

    void OnStartGuess (SocketIOEvent e)
    {
        textShow.text = "StartGuess";
    }

    void OnThan(SocketIOEvent e)
    {
        textShow.text = "Than";
    }

    void OnLess(SocketIOEvent e)
    {
        textShow.text = "Less";
    }

    void OnWinner(SocketIOEvent e)
    {
        textShow.text = "The winner is....";
    }
}
