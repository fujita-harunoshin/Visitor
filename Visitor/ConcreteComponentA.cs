﻿namespace Visitor;

internal class ConcreteComponentA : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentA(this);
    }

    public string ExclusiveMethodOfConcreteComponentA()
    {
        return "A";
    }
}
