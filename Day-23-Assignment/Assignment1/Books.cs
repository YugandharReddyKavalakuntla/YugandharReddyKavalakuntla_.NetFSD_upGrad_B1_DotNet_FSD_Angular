using System;
using System.Collections.Generic;

namespace Assignment1{

    public class Books{

        public static void Main(string[] args){
            // 4. Stack – Undo Feature in Text Editor
            // Scenario:
            // Implement undo functionality.
            // Assignment:
            // 1. Use Stack<string> to store actions
            // 2. Perform:
            // o Push actions (e.g., "Type A", "Delete B")
            // o Undo last 3 actions using Pop()
            // o Display current top action using Peek()


            Stack<string> actions = new Stack<string>();

            actions.Push("Type A");
            actions.Push("Type B");
            actions.Push("Delete B");
            actions.Push("Type C");
            actions.Push("Paste D");












        }









    }




}