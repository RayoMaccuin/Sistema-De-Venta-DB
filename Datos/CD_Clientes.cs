﻿using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CD_Clientes
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Agregar Cliente a la base de datos
        public void AgregarCliente(CE_Clientes clientes)
        {
            Cmd = new SqlCommand("AgregarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", clientes.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", clientes.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Cedula", clientes.Cedula));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", clientes.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", clientes.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", clientes.Email));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Edita Un Cliente en la base de datos

        public void EditarCliente(CE_Clientes clientes)
        {
            Cmd = new SqlCommand("EditarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", clientes.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", clientes.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Cedula", clientes.Cedula));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", clientes.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", clientes.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", clientes.Email));
            Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", clientes.Id_Cliente));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Eliminar Un Cliente en la base de datos
        public void EliminarCliente(CE_Clientes clientes)
        {
            Cmd = new SqlCommand("EliminarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", clientes.Id_Cliente));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }


        //Buscar Por Codigo
        public DataTable Buscar_Cliente_Codigo(CE_Clientes clientes)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Cliente_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", clientes.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Por Nombre
        public DataTable Buscar_Cliente_Nombre(CE_Clientes clientes)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Cliente_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", clientes.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Por Cedula
        public DataTable Buscar_Cliente_Cedula(CE_Clientes clientes)
        {
            Dt = new DataTable("Cedula");
            Cmd = new SqlCommand("Buscar_Cliente_Cedula", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", clientes.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }
    }
}
