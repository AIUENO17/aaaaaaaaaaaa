﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMainManager : MonoBehaviour
{
    public enum State
    {
        Init,
        Start,
        Command,
        Action,
        Result,
    }
    public State GameState = State.Init;

    public GameParamUIPresenter gameParamUIPresenter;

    public CharacterParamManager[] CharacterParamManagers = new CharacterParamManager[3];

    private CharacterParam[] characterParams = new CharacterParam[3];

    private void Update()
    {
        switch (GameState)
        {
            case State.Init:
                for (int i = 0; i < 3; i++)
                { 
                    if (CharacterParamManagers[i] != null)
                    {
                        characterParams[i] = CharacterParamManagers[i].CharacterParam;
                    }
        }

        gameParamUIPresenter.SetCharacterParamViewer(characterParams);
        GameState = State.Start;
        break;

            case State.Start:
                break;
                GameState = State.Command;
                break;
            case State.Command:
                 gameParamUIPresenter.CenterUIViwer.SetCharacterActionButtons(CharacterParam);
                break;
                
            case State.Action:
                break;
            case State.Result:
                break;
    }
}
 
}