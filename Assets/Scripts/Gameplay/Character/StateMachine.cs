using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Gameplay.Actor
{
    public class StateMachine : MonoBehaviour
    {
        public const string Regular = "Regular";
        public const string Performing = "Performing";
        public const string Stun = "Stun";
        public const string Sprint = "Sprint";

        private static Dictionary<TextAsset, List<State>> _generatedTables = new Dictionary<TextAsset, List<State>>();
        
        [SerializeField] private TextAsset _stateTable;
        [Header("RUNTIME DEBUG ONLY")]
        [SerializeField] private State _currentState;
        [SerializeField] private List<State> _states;

        private List<State> States
        {
            get
            {
                if (_states != null && _states.Count > 0) 
                    return _states;
                _states = GeneraleStateList();
                CurrentState = _states[0];
                return _states;
            }
        }

        public State CurrentState
        {
            get => _currentState;
            private set => _currentState = value;
        }

        public State GetState(string stateName)
        {
            ValidateState(stateName);
            return States.Find(state => state.Name.Equals(stateName));
        }

        public bool TryEnterState(string stateName) => TryEnterState(stateName, false);
        
        private bool TryEnterState(string stateName, bool regularAllowed)
        {
            if (!regularAllowed && stateName.Equals(Regular))
                throw new ArgumentException(
                    "Entering Regular state is frohibited." +
                    "Use TryExitState to transit to Regular state from specific state");
            
            ValidateState(stateName);
            State newState = States.FirstOrDefault(state => state.Name.Equals(stateName));
            if (newState == null || !CurrentState.CanSwitchToState(stateName))
                return false;

            State oldState = CurrentState;
            CurrentState = newState;
            oldState.Exited?.Invoke();
            newState.Entered?.Invoke();
            return true;
        }

        public bool TryExitState(string stateName)
        {
            if (IsCurrentState(stateName))
                return TryEnterState(Regular, true);
            return false;
        }

        public bool IsCurrentState(string stateName)
        {
            ValidateState(stateName);
            return CurrentState.Name.Equals(stateName);
        }

        public bool IsCurrentStateOneOf(params string[] stateNames) =>
            stateNames.Any(stateName => CurrentState.Name.Equals(stateName));

        public bool IsCurrentStateNoneOf(params string[] statesNames) => !IsCurrentStateOneOf(statesNames);

        public bool HasState(string stateName) => GetState(stateName) != null;

        private List<State> GeneraleStateList()
        {
            if (_generatedTables.ContainsKey(_stateTable))
                return _generatedTables[_stateTable];

            List<State> states = new List<State>();
            string[] lines = _stateTable.text.Split('\n');
            
            List<string> stateNames = lines[0].Split(',').ToList();
            stateNames.RemoveAt(0);
            
            for (int y = 1; y < lines.Length; y++)
            {
                states.Add(GenerateState(lines, y, stateNames));
            }
            
            _generatedTables.Add(_stateTable, states);
            
            return states;
        }

        private State GenerateState(string[] lines, int y, List<string> stateNames)
        {
            string[] currentLine = lines[y].Split(',');
            List<string> forbiddenTransitions = new List<string>();
            for (int x = 1; x < currentLine.Length; x++)
            {
                if (currentLine[x][0] == 'F')
                    forbiddenTransitions.Add(stateNames[x - 1]);
            }
            State state = new State(currentLine[0], forbiddenTransitions);

            return state;
        }

        private void ValidateState(string stateName)
        {
            if (!States.Any(state => state.Name.Equals(stateName)))
                throw new Exception($"{gameObject.name} has no {stateName} state");
        }
    }

    [Serializable]
    public class State
    {
        [SerializeField] private string _name;
        [SerializeField] private List<string> _forbiddenTransitions;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Action Entered;
        public Action Exited;

        public State(string name, List<string> frobiddenTransitions)
        {
            Name = name;
            _forbiddenTransitions = frobiddenTransitions;
        }

        public bool CanSwitchToState(string stateName)
        {
            return !_forbiddenTransitions.Contains(stateName);
        }
    }
}
