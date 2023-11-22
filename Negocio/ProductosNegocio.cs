﻿using AccesoDatos;
using Modelo;
using Modelo.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductosNegocio
    {
        public List<Productos> ListarProductos()
        {
            return ProductosDatos.ListarProductos();
        }

        public static Productos BuscarProductoId(string productoId)
        {
            bool flag = false;

            //flag = vd.ValidarID(productoId);
            List<Productos> productos = ProductosDatos.ListarProductos();

            if (flag == true)
            {
                productoId = Guid.NewGuid().ToString();
            }
            Guid idGuid;
            if (Guid.TryParse(productoId, out idGuid))
            {
                Productos productoEncontrado = productos.Find(p => p.IdProducto == idGuid);
                if (productoEncontrado != null)
                {
                    return productoEncontrado;
                }
                else
                {
                    throw new UsuarioNoEncontradoException(); // Lanzar una excepción personalizada si el usuario no se encuentra.
                }
            }
            else
            {
                throw new FormatoIDInvalidoException(); // Lanzar una excepción personalizada si el formato del ID es inválido.
            }

        }
        /*
        public void ModificarNombreProd(Nombre, nombreNuevo)
        {
            String idProducto = ProductosDatos.ModificarNombreProd(Nombre, nombreNuevo);
        }
       */
        public void CrearProducto(ProductoModelDatos producto)
        {
            //Este es el idUsuario Master
            producto.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ProductoDatos.CrearProducto(producto);

        }
        public void ModificarProducto(string id, double precio, int stock)
        {
            String idUsuario = ProductosDatos.ModificarProducto(id, precio, stock);
        }
    }
