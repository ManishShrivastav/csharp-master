﻿using System;

namespace InterfaceDemo
{
    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {
        }

        public void CurrentKeyPressed()
        {
        }

        public void Dispose()
        {
            // Do whatever shutdown task needed.
        }
    }
}
