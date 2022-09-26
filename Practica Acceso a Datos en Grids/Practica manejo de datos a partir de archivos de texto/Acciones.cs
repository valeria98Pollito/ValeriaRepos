﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListView = System.Windows.Forms.ListView;

namespace Practica_manejo_de_datos_a_partir_de_archivos_de_texto
{
    internal class Acciones
    {
        public static void LlenarGrid(string consulta, DataGridView grid)
        {
            DataTable dt;
            dt = Conexion.EjecutaSeleccion(consulta);
            if (dt == null)
            {
                return;
            }
            grid.DataSource = dt;
        }
        public static void LlenarList(string consulta, ListView list)
        {
            list.Columns.Clear();
            list.Items.Clear();
            DataTable dt;

            dt = Conexion.EjecutaSeleccion(consulta);
            if (dt == null)
            {
                return;
            }
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                list.Columns.Add(dt.Columns[j].ColumnName);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lista = new ListViewItem(dt.Rows[i].ItemArray[0].ToString());
                for (int z = 1; z < dt.Columns.Count; z++)
                {
                    lista.SubItems.Add(dt.Rows[i].ItemArray[z].ToString());
                }
                /*  list.Items.Add(dt.Rows[i].ItemArray[j].ToString());*/
                list.Items.Add(lista);
            }

        }
    }
}
