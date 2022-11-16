using System;
using System.Collections;
using System.Collections.Generic;
using Enums;
using Signals;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   #region Self Variables

   #region Serialized Variables

   [SerializeField] private GameStates states;

   #endregion

   #endregion

   private void OnEnable() => SubscribeEvents();

   private void SubscribeEvents()
   {
      CoreGameSignals.Instance.onChanheGameState += OnChangeGameState;
      
   }

   private void UnsubscribeEvents()
   {
      CoreGameSignals.Instance.onChanheGameState -= OnChangeGameState;
   }

   private void OnDisable() => UnsubscribeEvents();

   private void OnChangeGameState(GameStates state)
   {
      states = state;
   }
}
