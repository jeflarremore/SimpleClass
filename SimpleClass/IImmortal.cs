using System.Collections.Generic;

namespace SimpleClass
{
    public interface IImmortal
    {
        string Bent { get; set; }
        List<Collectable> Carrying { get; set; }
        string Name { get; set; }
        string Origin { get; set; }
        string Saying { get; set; }
        string Superpower { get; set; }
        int LifeForce { get; set; }

        void CarryingConfirm(string confimationmsg);
        void Pickup(Collectable item);
        void Speak();
    }
}