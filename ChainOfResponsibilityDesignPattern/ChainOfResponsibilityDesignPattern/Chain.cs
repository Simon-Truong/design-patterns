using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public abstract class Chain
    {
        protected Chain _chain;

        public void SetNextChain(Chain chain)
        {
            _chain = chain;
        }

        public abstract void HandleRequest(Equation equation);
    }
}
