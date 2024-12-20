﻿using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Material
    {
        Acceso acceso = new Acceso();

        public int AltaMaterial(Material material) 
        {
            SqlParameter[] parametros = new SqlParameter[5]
            {
                new SqlParameter("@IdMaterial", material.IdMaterial),
                new SqlParameter("@Color", material.Color),
                new SqlParameter("@PesoKg", Convert.ToDecimal(material.PesoKg)),
                new SqlParameter("@Costo", Convert.ToDecimal(material.Costo)),
                new SqlParameter("@Tipo", material.Tipo)
            };

            return acceso.Escribir("AltaMaterial", parametros);
        }

        public int BajaMaterial(Material material) 
        {
            SqlParameter[] parametros = new SqlParameter[1] 
            {
                new SqlParameter("@IdMaterial", material.IdMaterial)
            };

            return acceso.Escribir("BajaMaterial", parametros);
        }

        public int ModificarMaterial(Material material)
        {
            SqlParameter[] parametros = new SqlParameter[5]
            {
                new SqlParameter("@IdMaterial", material.IdMaterial),
                new SqlParameter("@Color", material.Color),
                new SqlParameter("@PesoKg", Convert.ToDecimal(material.PesoKg)),
                new SqlParameter("@Costo", Convert.ToDecimal(material.Costo)),
                new SqlParameter("@Tipo", material.Tipo)
            };

            return acceso.Escribir("ModificarMaterial", parametros);
        }

        public List<Material> ListarMateriales()
        {
            List<Material> materiales = new List<Material>();
            DataTable dt = acceso.Leer("ListarMateriales", null);

            foreach (DataRow dr in dt.Rows)
            {
                Material material = new Material();
                material.IdMaterial = Convert.ToInt32(dr["IdMaterial"]);
                material.Color= Convert.ToString(dr["Color"]);
                material.PesoKg = Convert.ToDouble(dr["PesoKg"]);
                material.Costo = Convert.ToDouble(dr["Costo"]);
                material.Tipo = Convert.ToString(dr["Tipo"]);

                materiales.Add(material);
            }
            
            return materiales;
        }

        public List<Material> ListarMateriales(string tipo) 
        {
            List<Material> materiales = new List<Material>();
            SqlParameter[] parametros = new SqlParameter[1] 
            {
                new SqlParameter("@Tipo", tipo)
            };
            DataTable dt = acceso.Leer("ListarMaterialesPorTipo", parametros);

            foreach (DataRow dr in dt.Rows)
            {
                Material material = new Material();
                material.IdMaterial = Convert.ToInt32(dr["IdMaterial"]);
                material.Color = Convert.ToString(dr["Color"]);
                material.PesoKg = Convert.ToDouble(dr["PesoKg"]);
                material.Costo = Convert.ToDouble(dr["Costo"]);
                material.Tipo = Convert.ToString(dr["Tipo"]);

                materiales.Add(material);
            }

            return materiales;
        }

        public void ExportarXml(string tipo) 
        {
            SqlParameter[] parametros = new SqlParameter[1]
            {
                new SqlParameter("@Tipo", tipo)
            };
            acceso.ExportarSPXML("ListarMaterialesPorTipo", "Stock_" + tipo, parametros);
        }

        public void ExportarXml() 
        {
            acceso.ExportarSPXML("ListarMateriales", "Materiales", null);
        }

    }
}
