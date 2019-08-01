using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public interface IState
    {
        void Handle(Context context);
    }
}
