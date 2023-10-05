using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace LYA1_Lexico2
{
    public class Lexico : Token, IDisposable
    {
        private StreamReader archivo;

        const int F = -1;
        const int E = -2;
        private StreamWriter log;

        int[,] TRAND ={
            {0,1,2,8,1,8,8,8},
{F,1,1,F,1,F,F,F},
{F,F,3,3,5,F,F,F},
{E,E,4,E,E,E,E,E},
{F,F,4,F,5,F,F,F},
{E,E,7,E,E,6,6,E},
{E,E,7,E,E,E,E,E},
{F,F,7,F,F,F,F,F},
{F,F,F,F,F,F,F,F}
        }
        public Lexico()
        {
            archivo = new StreamReader("prueba.cpp");
            log = new StreamWriter("prueba.log");
            log.AutoFlush = true;
        }
        public Lexico(string nombre)
        {
            archivo = new StreamReader(nombre);
            log = new StreamWriter("prueba.log");
            log.AutoFlush = true;
        }
        public void Dispose()
        {
            archivo.Close();
            log.Close();
        }
        public void nextToken()
        {
            char c;
            string buffer = "";

            int estado = 0;


            while (estado >= 0)
            {

                c = (char)archivo.Peek();

                setContenido(buffer);
                log.WriteLine(getContenido() + " = " + getClasificacion());
            }
            public bool FinArchivo()
            {
                return archivo.EndOfStream;
            }
        }
    }