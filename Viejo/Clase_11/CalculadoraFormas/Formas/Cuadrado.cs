﻿namespace Formas
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(float longitudLado) : base(longitudLado, longitudLado)
        {

        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }
    }
}
