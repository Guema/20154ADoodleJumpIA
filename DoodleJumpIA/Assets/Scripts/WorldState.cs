using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameState
{
    Dictionary<Entity, EntityState> actualWorldState = new Dictionary<Entity, EntityState>(10000);

    /// <summary>
    /// This method make the world take the state given in parameter
    /// </summary>
    /// <param name="state">World state to apply</param>
    void UpdateGameState(GameState state)
    {

    }

    /// <summary>
    /// This methode compute next possible worldStates and return this in the form of a tree.
    /// </summary>
    /// <param name="nbFrames">number of frames(time) to precompute</param>
    /// <returns></returns>
    GameState[] ComputeGameStates(GameState state, int nbFrames)
    {
        return new GameState[0];
    }
}
