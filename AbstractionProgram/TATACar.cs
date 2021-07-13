using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionProgram
{
    public class TATACar
    {
        IEngines _engine =null;

        public TATACar(IEngines engine)
        {
             this._engine= engine;
        }
        public void Drive()
        {

            _engine.Start();
        }
        public void Halt()
        {

            _engine.Stop();
        }


    }

    public interface IEngines
    {
        void Start();
        void Stop();
    }
    public class DiCorEngine : IEngines
    {

        public void Start() { }
        public void Stop() { }
    }
    public class VeriCorEngine : IEngines
    {

        public void Start() { }
        public void Stop() { }
    }
    public class MultiJetEngine : IEngines
    {

        public void Start() { }
        public void Stop() { }
    }
    public class RevorTron : IEngines
    {

        public void Start() { }
        public void Stop() { }
    }
}
