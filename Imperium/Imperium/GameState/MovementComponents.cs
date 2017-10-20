using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitas;
using Entitas.Generic;
using UnityEngine;

namespace Imperium.GameState
{
    /// <summary>
    /// Sample position component data
    /// </summary>
    [Entitas.Generic.Simulation]
    [ComponentData]
    public struct Position : IComponent
    {
        public Vector3 Location;
        public float Rotation;

        public Position(Vector3 location, float rotation)
        {
            Location = location;
            Rotation = rotation;
        }
    }

    /// <summary>
    /// Sample position component data
    /// </summary>
    [Entitas.Generic.Simulation]
    [ComponentData]
    public struct Destination : IComponent
    {
        public Vector3 Location;

        public Destination(Vector3 linear)
        {
            Location = linear;
        }
    }
}
