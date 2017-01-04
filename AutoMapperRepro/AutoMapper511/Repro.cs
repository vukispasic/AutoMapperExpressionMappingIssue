using AutoMapper;
using OmmitedDatabaseModel3;
using OmmitedDTOModel3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper511
{
    public class Repro
    {
        public void Run()
        {

            var mapperEngine = ConfigureMapper();
            RunMapping(mapperEngine);
        }

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

        private IMapper ConfigureMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Entity1, EntityDTO1>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity2, EntityDTO2>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity3, EntityDTO3>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity4, EntityDTO4>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity5, EntityDTO5>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity6, EntityDTO6>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity7, EntityDTO7>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity8, EntityDTO8>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity9, EntityDTO9>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity10, EntityDTO10>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity11, EntityDTO11>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity12, EntityDTO12>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity13, EntityDTO13>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity14, EntityDTO14>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity15, EntityDTO15>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity16, EntityDTO16>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity17, EntityDTO17>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity18, EntityDTO18>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity19, EntityDTO19>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity20, EntityDTO20>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity21, EntityDTO21>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity22, EntityDTO22>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity23, EntityDTO23>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity24, EntityDTO24>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity25, EntityDTO25>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity26, EntityDTO26>().PreserveReferences().ReverseMap().PreserveReferences();
                //cfg.ForAllPropertyMaps(p => !p.SourceType.IsValueType, (pm, o) => o.DoNotInline());
            });
            return config.CreateMapper();
        }
    }
}
