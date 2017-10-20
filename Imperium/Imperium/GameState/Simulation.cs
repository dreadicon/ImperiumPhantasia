using System.Collections.Generic;
using Entitas;
using UnityEngine;
using Entitas.Generic;
using static Entitas.Generic.ScopeManager;

namespace Imperium.GameState
{
    public class Simulation : ScriptableObject, IScope
    {
        public Simulation()
        {
            RegisterScopes<Simulation, Entitas.Generic.Input>();
            ComponentTypeManager<Simulation>.Autoscan();

            var contexts = new Contexts(AERCFactories.UnsafeAERCFactory);
        }

        public void EndTurn()
        {            
            //Messages dispatched

            //Provincial queues updated
        }

        /// <summary>
        /// Runs a step in the semi-realtime simulation. 
        /// </summary>
        /// <param name="timeFactor">Number of days to simulate in step.</param>
        public void SimulationStep(float timeFactor)
        {
            //Random events occur (new plague, renegade minotaur herd, comet sighted, leader death by freak accident, natural disasters, etc)

            //Weather updates

            //Move messages (commands, diplomatic missives, etc) towards destination (can be intercepted by spies, units won't react till the recieve the orders)

            //Update espionage Movement & actions

            //Set unit move destination (actual movement handled by the realtime playback using data set here)
            // -If enemy encountered, queue encounter/combat simulations

            //Run Provincial simulations
            // -Apply weather/climate/season
            // -Handle immigration/emigration & population growth
            // -Handle private construction
            // -Private resources produced (food/stone/goods)
            // -Calculate crime & safety
            // -Propogate/simulate trade & trade income
            // -Propogate culture/religion
            // -Simulate unrest
            // -Collect taxes/resources (standard)
            // -Handle production queues/training queues

            //Run queued encounters/combat

            //AI decisions simulated & updated.

            //UI info Updated
        }

        public void StartTurn()
        {
            //Edicts and Laws go into effect

            //Redraw Provincial boarders if needed (including the creation of new provinces or the absorption of old ones)

            //Update fog of war & shroud for leaders (AI and player)

            //Update AI opinions & fill in state logic for AI            

            //Run Cardinal (the background difficulty AI, influencing random events, AI nations, etc.)

            //Enable play
        }

        public List<string> Commands;

        //protected Context<>
    }
}
