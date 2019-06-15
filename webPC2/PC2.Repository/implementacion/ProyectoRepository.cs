using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PC2.Domain;
using PC2.Repository.Context;

namespace PC2.Repository.implementacion
{
    public class ProyectoRepository : IProyectoRepository
    {
        private ApplicationDbContext context;
        public ProyectoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Delete(Proyecto entity)
        {
             context.Remove(entity);
        }

        public Proyecto FindById(Proyecto entity)
        {
            return context.Proyectos.FirstOrDefault(x => x.IdProyecto == entity.IdProyecto);
        }

        public List<Proyecto> ListAll()
        {
            return context.Proyectos.ToList();
        }

        public void Save(Proyecto entity)
        {
            context.Proyectos.Add(entity);
            context.SaveChanges();
        }

        public void Update(Proyecto entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}