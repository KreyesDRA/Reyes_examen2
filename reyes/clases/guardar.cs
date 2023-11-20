using System;
using System.Data.Entity;
using System.Web.Mvc;
using Models;

namespace Web.Controllers
{
    public class MantenimientoController : Controller
    {
        private Contexto _contexto;

        public MantenimientoController()
        {
            _contexto = new Contexto();
        }

        [HttpPost]
        public ActionResult Guardar(string equipo, string usuario, string reparacion, string detalle, string asignacion, string tecnico)
        {
            var nuevoEquipo = new Equipo
            {
                EquipolD = equipo
            };
            _contexto.Equipos.Add(nuevoEquipo);

            var nuevoUsuario = new Usuario
            {
                UsuarioID = usuario
            };
            _contexto.Usuarios.Add(nuevoUsuario);

            var nuevaReparacion = new Reparacion
            {
                ReparacionID = reparacion
            };
            _contexto.Reparaciones.Add(nuevaReparacion);

            var nuevoDetalle = new DetalleReparacion
            {
                DetalleID = detalle
            };
            _contexto.DetallesReparacion.Add(nuevoDetalle);

            var nuevaAsignacion = new Asignacion
            {
                AsignacionID = asignacion
            };
            _contexto.Asignaciones.Add(nuevaAsignacion);

            var nuevoTecnico = new Tecnico
            {
                TecnicolD = tecnico
            };
            _contexto.Tecnicos.Add(nuevoTecnico);

            _contexto.SaveChanges();

            return View();
        }
    }
}