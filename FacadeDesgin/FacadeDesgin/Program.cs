﻿using System;

namespace FacadeDesgin
{
    public class Facade
    {
        protected Cirecle _Cirecle;

        protected Square _Square;

        public Facade(Cirecle Cirecle, Square Square)
        {
            this._Cirecle = Cirecle;
            this._Square = Square;
        }

      
        public string Paint()
        {
            string result = "Drawing subsystems:\n";
            result += this._Cirecle.drawCirecle();
            result += this._Square.drawSquare();
            result += "Drawing subsystems 2:\n";
            result += this._Cirecle.drawHalfSCirecle();
            result += this._Square.drawHalfSquare();
            return result;
        }
    }

    
    public class Cirecle
    {
        public string drawCirecle()
        {
            return "Cirecle!\n";
        }

        public string drawHalfCirecle()
        {
            return "Half Cirecle!\n";
        }
    }

    public class Square
    {
        public string drawSquare()
        {
            return "Square!\n";
        }

        public string drawHalfSquare()
        {
            return "Half Square!\n";
        }
    }


    class Client
    {
       
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Paint());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Cirecle Cirecle = new Cirecle();
            Square Square = new Square();
            Facade facade = new Facade(Cirecle, Square);
            Client.ClientCode(facade);
        }
    }
}
