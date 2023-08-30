

using System.Linq.Expressions;

namespace core.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Criteria{get;}
        List<Expression<Func<T,object>>> Includes{get;}
    }
}