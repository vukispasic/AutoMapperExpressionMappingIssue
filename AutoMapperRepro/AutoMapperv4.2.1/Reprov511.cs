using AutoMapper;
using OmmitedDatabaseModel3;
using OmmitedDTOModel3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperv511
{
    public class Reprov511
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
                
                cfg.CreateMap<Entity1, EntityDTO1>().ReverseMap();
                cfg.CreateMap<Entity2, EntityDTO2>().ReverseMap();                
                cfg.CreateMap<Entity3, EntityDTO3>().ReverseMap();                
                cfg.CreateMap<Entity4, EntityDTO4>().ReverseMap();                
                cfg.CreateMap<Entity5, EntityDTO5>().ReverseMap();                
                cfg.CreateMap<Entity6, EntityDTO6>().ReverseMap();
                cfg.CreateMap<Entity7, EntityDTO7>().ReverseMap();                
                cfg.CreateMap<Entity8, EntityDTO8>().ReverseMap();                
                cfg.CreateMap<Entity9, EntityDTO9>().ReverseMap();                
                cfg.CreateMap<Entity10, EntityDTO10>().ReverseMap();                
                cfg.CreateMap<Entity11, EntityDTO11>().ReverseMap();                
                cfg.CreateMap<Entity12, EntityDTO12>().ReverseMap();                
                cfg.CreateMap<Entity13, EntityDTO13>().ReverseMap();                
                cfg.CreateMap<Entity14, EntityDTO14>().ReverseMap();                
                cfg.CreateMap<Entity15, EntityDTO15>().ReverseMap();                
                cfg.CreateMap<Entity16, EntityDTO16>().ReverseMap();                
                cfg.CreateMap<Entity17, EntityDTO17>().ReverseMap();                
                cfg.CreateMap<Entity18, EntityDTO18>().ReverseMap();                
                cfg.CreateMap<Entity19, EntityDTO19>().ReverseMap();                
                cfg.CreateMap<Entity20, EntityDTO20>().ReverseMap();                
                cfg.CreateMap<Entity21, EntityDTO21>().ReverseMap();                
                cfg.CreateMap<Entity22, EntityDTO22>().ReverseMap();                
                cfg.CreateMap<Entity23, EntityDTO23>().ReverseMap();                
                cfg.CreateMap<Entity24, EntityDTO24>().ReverseMap();                
                cfg.CreateMap<Entity25, EntityDTO25>().ReverseMap();                
                cfg.CreateMap<Entity26, EntityDTO26>().ReverseMap();
            });

            return config.CreateMapper();
        }
    }
}
