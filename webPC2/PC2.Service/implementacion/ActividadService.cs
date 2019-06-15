using System.Collections.Generic;
using PC2.Domain;
using PC2.Repository;

namespace PC2.Service.implementacion
{
    public class ActividadService : IActividadService
    {
        private IActividadRepository actividadRepository;

        public ActividadService(IActividadRepository actividadRepository)
        {
            this.actividadRepository = actividadRepository;
        }
        public void Delete(Actividad entity)
        {
            actividadRepository.Delete(entity);
        }

        public Actividad FindById(Actividad entity)
        {
            return actividadRepository.FindById(entity);
        }

        public List<Actividad> ListAll()
        {
            return actividadRepository.ListAll();
        }

        public void Save(Actividad entity)
        {
            actividadRepository.Save(entity);
        }

        public void Update(Actividad entity)
        {
            actividadRepository.Update(entity);
        }
    }
}