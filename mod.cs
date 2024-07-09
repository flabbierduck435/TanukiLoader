using System;
using UnityEngine;

public interface mod
{
    string Name { get; }
    string Version { get; }

    void initialize();

    void start(GameObject root);


}
