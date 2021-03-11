using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_14_Lock
{
    class Lock
    {
        protected bool Locked =  false;

        public Lock()
        {

        }


        public bool IsLocked()
        {
            return Locked;
        }

        public virtual void OpenLock()
        {
            Locked = false;
        }

        public void CloseLock()
        {
            Locked = true;
        }
    }
}
