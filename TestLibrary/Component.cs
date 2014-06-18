using System;

namespace TestLibrary
{
    class Component : MarshalByRefObject
    {
        protected long _id = 0;
        public long id { get; set; }
    }
}
