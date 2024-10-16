using System;
using System.Net.NetworkInformation;

namespace Inheritance;

public class Bird : Animal
{
    public bool canFly { get; set; }

    public string colorFeathers { get; set; }

    public bool isTrainable { get; set; }

    public bool canHunt { get; set; }
}
