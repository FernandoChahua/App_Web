using System.Collections.Generic;
using PC2.Domain;
using PC2.Repository;

namespace PC2.Service.implementacion
{
    public class ProyectoService : IProyectoService
    {
        private IProyectoRepository proyectoRepository;

        public ProyectoService(IProyectoRepository proyectoRepository)
        {
            this.proyectoRepository = proyectoRepository;
        }
        public void Delete(Proyecto entity)
        {
            proyectoRepository.Delete(entity);
        }

        public Proyecto FindById(Proyecto entity)
        {
            return proyectoRepository.FindById(entity);
        }

        public List<Proyecto> ListAll()
        {
            return proyectoRepository.ListAll();
        }

        public void Save(Proyecto entity)
        {
            proyectoRepository.Save(entity);
        }

        public void Update(Proyecto entity)
        {
            proyectoRepository.Update(entity);
        }
    }
}