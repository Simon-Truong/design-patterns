using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoDesignPattern
{
    public class CareTaker
    {
        private List<Momento> _momentoList = new List<Momento>();

        public void Add(Momento momento)
        {
            _momentoList.Add(momento);
        }

        public Momento Get(int index)
        {
            return _momentoList[index];
        }
    }
}
