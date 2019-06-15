using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PC2.Domain;
using PC2.Repository.Context;

namespace PC2.Repository.implementacion
{
    public class ActividadRepository : IActividadRepository
    {
        private ApplicationDbContext context;
        public ActividadRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Delete(Actividad entity)
        {
            context.Remove(entity);
        }

        public Actividad FindById(Actividad entity)
        {
            return context.Actividades.Include(x => x.Proyecto).FirstOrDefault(x => x.IdActividad == entity.IdActividad);
        }

        public List<Actividad> ListAll()
        {
            return context.Actividades.Include(x=>x.Proyecto).ToList();
        }

        public void Save(Actividad entity)
        {
            context.Actividades.Add(entity);
            context.SaveChanges();
        }

        public void Update(Actividad entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}