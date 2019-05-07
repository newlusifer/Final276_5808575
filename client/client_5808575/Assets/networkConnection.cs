using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class networkConnection : MonoBehaviour
{
    public static SocketIOComponent socket;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<SocketIOComponent>();

        socket.On("hello",OnHello);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnHello(SocketIOEvent e)
    {
        Debug.Log("Hello");
    }
}
