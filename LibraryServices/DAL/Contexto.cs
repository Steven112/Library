﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryServices.Entdades;

namespace LibraryServices.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Editorial> Editorial { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        //public DbSet<Administrador> Administrador { get; set; }
        public DbSet<PrestamoDetalle> Detalle { get; set; }

        public Contexto():base("ConStr")
        {
        }
    }

}