using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class MasStringObject : ScriptableObject
{
    [TextArea]
    public string[] Names;
}
