﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositorios
{
    public class EmpleadoRepositorio    // repositorio referencia a enttdades
    {
        public static List<Empleado> Items = new List<Empleado>();      //static una sola instancia de esto // como es estatico
     //   public Dictionary<int,Empleado> emp

        public void Crear(Empleado o)
        {
            Items.Add(o);
        }

        public void Eliminar(Empleado o)            // buscar con constis
        {
            Items.Remove(o);         
        }

        public void Modificar(Empleado o)            // buscar con constis
        {
            Empleado empViejo = Obtener(o.Legajo);
            if(empViejo != null)
            {
                empViejo = o;
            }
        }

        public List<Empleado> ObtenerTodos()
        {
           return Items;           // puedo hacer publica la variable Items o crear este metodo
        }

        public Empleado Obtener(int Legajo)
                {
                    foreach(Empleado em in Items)
                        {
                            if(em.Legajo == Legajo)
                                {
                                    return em;
                                }
                         
                        }
                    // throw new Exception("Empleado no encontrado");
                    return null;
                 }
    }

}
