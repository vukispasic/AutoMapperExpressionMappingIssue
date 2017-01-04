using AutoMapper;
using OmmitedDatabaseModel3;
using OmmitedDTOModel3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MappingExpressionIssue
{
    public class Mapping
    {
        public void RunMapping(IMapper mapperEngine)
        {
            var entities = new List<Entity1>();
            var guid = Guid.NewGuid();
            entities.Add(new Entity1 { Id = guid });
            entities.Add(new Entity1 { Id = Guid.NewGuid() });

            Expression<Func<EntityDTO1, bool>> expression = r => r.Id == guid;

            var mappedExpression = mapperEngine.Map<Expression<Func<Entity1, bool>>>(expression);

            var query = entities.AsQueryable();

            query = query.Where(mappedExpression);
            var results = query.ToList();
        }
    }
}
