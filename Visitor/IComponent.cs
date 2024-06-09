namespace Visitor;

internal interface IComponent
{
    void Accept(IVisitor visitor);
}
