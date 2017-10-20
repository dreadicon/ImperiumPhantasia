using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitas;
using Entitas.Generic;

namespace Imperium.GameState.Diplomacy
{
    public class DiplomacySystems
    {
        //public class MoveSystem : IExecuteSystem
        //{
        //    private readonly IGroup<Entity<Simulation>> _group;

        //    public MoveSystem(Contexts contexts)
        //    {
        //        _group = contexts.Get<Simulation>()
        //            .GetGroup(
        //                Matcher<Entity<Simulation>>.AllOf(
        //                    Matchers.For<Simulation, Position>(),
        //                    Matchers.For<Simulation, DiplomacyComponents.Velocity>()
        //                )
        //            );
        //    }

        //    public void Execute()
        //    {
        //        foreach (var entity in _group.GetEntities())
        //        {
        //            var position = entity.Get<Position>();
        //            var velocity = entity.Get<DiplomacyComponents.Velocity>();
        //            const float dt = 1.0f / 60.0f;

        //            entity.Replace(new Position(position.Location + velocity.Linear * dt,
        //                position.Rotation + velocity.Angular * dt));
        //        }
        //    }
        //}
    }
}
