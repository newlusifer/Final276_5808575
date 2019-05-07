using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class networkConnection : MonoBehaviour
{
    public static SocketIOComponent socket;
    public static string Name="";

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<SocketIOComponent>();

        socket.On("hello",OnHello);
        
    }

    // Update is called once per frame
    void Update()
    {
        socket.On("name",OnName);
    }

    void OnHello(SocketIOEvent e)
    {
        Debug.Log("Hello");
    }

    void OnName(SocketIOEvent e)
    {
        Debug.Log("Name is "+e.data.ToString());
        Name = e.data.ToString();
    }
}
