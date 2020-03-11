﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatronDiseno
{
    class Singleton
    {
        private static Singleton instance = null;
        public string mensaje ="";
        protected Singleton() {
            mensaje = "Hola";
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

    }
}
