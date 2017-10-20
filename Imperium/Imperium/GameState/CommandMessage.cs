using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperium.GameState
{
    public class CommandMessage
    {
        public Entitas.Entity Sender { get; set; }
        public Entitas.Entity Target { get; set; }
    }
}
