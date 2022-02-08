using System;

namespace EventsAndMulticastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an audio system
            AudioSystem audioSystem = new AudioSystem();
            //create a rending engine
            RenderingEngine renderingEngine = new RenderingEngine();
            Player player1 = new Player("Chinook");
            Player player2 = new Player("RainbowTrout");
            Player player3 = new Player("Coho");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running....Press any key to end the game.");

            //pause game
            Console.Read();

            GameEventManager.TriggerGameOver();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class GameEventManager
    {
        //a new delegate type called GameEvent
        public delegate void GameEvent();

        //create two delegates variables called OnGameStart and OnGameOver
        public static event GameEvent OnGameStart, OnGameOver;

        //a static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            //check if the OnGameStart event is not empty,
            //meaning that other methods already subscribed to it
            if (OnGameStart != null)
            {
                //print a simple message
                Console.WriteLine("The game has started....");
                //call the OnGameStart that will trigger all methods subscribed to this event
                OnGameStart();
            }
        }

        //a static method to trigger OnGameOver
        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                //print a simple messge
                Console.WriteLine("The game is over....");
                //call the OnGameOver that will trigger all methods subscribed to this event
                OnGameOver(); 
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    //RenderingEngine Class
    public class RenderingEngine
    {
        
        //simple constructor
        public RenderingEngine()
        {
            //subscribe to OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //at the start of the game, we want to enable the rendering engine and start drawing the visuals
        private void StartGame()
        {
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visuals....");
        }

        //when the game is over, we want to stop our rendering engine
        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class Player
    {


        //Player name
        public string PlayerName { get; set; }

        //simple constructor
        public Player(string name)
        {
            this.PlayerName = name;
            //subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //at the start of the game, spawn the player.
        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID : {PlayerName}");
        }
        //when the game is over, remove the player from the game
        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID : {PlayerName}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class AudioSystem
    {
        
        //simple constructor
        public AudioSystem()
        {
            //subscribe to the OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        
        //at the start of the game, we want to enable the audio system and start playing audio clips
        private void StartGame()
        {
            Console.WriteLine("Audio System Started...");
            Console.WriteLine("Playing Audio...");
        }
        //when the game is over, we want to stop the audio system
        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
