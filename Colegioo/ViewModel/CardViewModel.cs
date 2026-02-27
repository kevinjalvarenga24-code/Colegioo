using Colegioo.Interface;
using Colegioo.Model;
using Colegioo.Repository;
using System.Collections.Generic;

namespace Colegioo.ViewModel
{
    public class CardViewModel
    {
        private IClasesRepository _repo;
        public List<Asignaturas> Asignaturas { get; set; }

        public CardViewModel()
        {
            _repo = new ClasesRepository();
            Asignaturas = _repo.GetAll();
        }
    }
}