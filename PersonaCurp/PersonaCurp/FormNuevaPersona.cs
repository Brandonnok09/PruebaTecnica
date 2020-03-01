using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CurpValidator;
using PersonaCurp.Models;

namespace PersonaCurp
{
    public partial class FormNuevaPersona : Form
    {

        public int? idPersona;
        string curp;

        public FormNuevaPersona()
        {
            InitializeComponent();
            cargaComboBox();

        }


        public FormNuevaPersona(int? id)
        {
            InitializeComponent();

            idPersona = id;
            cargaComboBox();
            getPersona();
        }



        private void cargaComboBox()
        {
            cbox_Sexo.Items.Add("Masculino");
            cbox_Sexo.Items.Add("Femenino");

            cbox_EstadoNacimiento.Items.Add("Aguascalientes");
            cbox_EstadoNacimiento.Items.Add("BajaCalifornia");
            cbox_EstadoNacimiento.Items.Add("BajaCaliforniaSur");
            cbox_EstadoNacimiento.Items.Add("Campeche");
            cbox_EstadoNacimiento.Items.Add("Chiapas");
            cbox_EstadoNacimiento.Items.Add("Chihuahua");
            cbox_EstadoNacimiento.Items.Add("Coahuila");
            cbox_EstadoNacimiento.Items.Add("Colima");
            cbox_EstadoNacimiento.Items.Add("DistritoFederal");
            cbox_EstadoNacimiento.Items.Add("Durango");
            cbox_EstadoNacimiento.Items.Add("Guanajuato");
            cbox_EstadoNacimiento.Items.Add("Guerrero");
            cbox_EstadoNacimiento.Items.Add("Hidalgo");
            cbox_EstadoNacimiento.Items.Add("Jalisco");
            cbox_EstadoNacimiento.Items.Add("Mexico");
            cbox_EstadoNacimiento.Items.Add("Michoacan");
            cbox_EstadoNacimiento.Items.Add("Morelos");
            cbox_EstadoNacimiento.Items.Add("NacidoExtranjero");
            cbox_EstadoNacimiento.Items.Add("Nayarit");
            cbox_EstadoNacimiento.Items.Add("NuevoLeon");
            cbox_EstadoNacimiento.Items.Add("Oaxaca");
            cbox_EstadoNacimiento.Items.Add("Puebla");
            cbox_EstadoNacimiento.Items.Add("Queretaro");
            cbox_EstadoNacimiento.Items.Add("QuintanaRoo");
            cbox_EstadoNacimiento.Items.Add("SanLuisPotosi");
            cbox_EstadoNacimiento.Items.Add("Sinaloa");
            cbox_EstadoNacimiento.Items.Add("Sonora");
            cbox_EstadoNacimiento.Items.Add("Tabasco");
            cbox_EstadoNacimiento.Items.Add("Tamaulipas");
            cbox_EstadoNacimiento.Items.Add("Tlaxcala");
            cbox_EstadoNacimiento.Items.Add("Veracruz");
            cbox_EstadoNacimiento.Items.Add("Yucatan");
            cbox_EstadoNacimiento.Items.Add("Zacatecas");

            cbox_Estado.Items.Add("Aguascalientes");
            cbox_Estado.Items.Add("BajaCalifornia");
            cbox_Estado.Items.Add("BajaCaliforniaSur");
            cbox_Estado.Items.Add("Campeche");
            cbox_Estado.Items.Add("Chiapas");
            cbox_Estado.Items.Add("Chihuahua");
            cbox_Estado.Items.Add("Coahuila");
            cbox_Estado.Items.Add("Colima");
            cbox_Estado.Items.Add("DistritoFederal");
            cbox_Estado.Items.Add("Durango");
            cbox_Estado.Items.Add("Guanajuato");
            cbox_Estado.Items.Add("Guerrero");
            cbox_Estado.Items.Add("Hidalgo");
            cbox_Estado.Items.Add("Jalisco");
            cbox_Estado.Items.Add("Mexico");
            cbox_Estado.Items.Add("Michoacan");
            cbox_Estado.Items.Add("Morelos");            
            cbox_Estado.Items.Add("Nayarit");
            cbox_Estado.Items.Add("NuevoLeon");
            cbox_Estado.Items.Add("Oaxaca");
            cbox_Estado.Items.Add("Puebla");
            cbox_Estado.Items.Add("Queretaro");
            cbox_Estado.Items.Add("QuintanaRoo");
            cbox_Estado.Items.Add("SanLuisPotosi");
            cbox_Estado.Items.Add("Sinaloa");
            cbox_Estado.Items.Add("Sonora");
            cbox_Estado.Items.Add("Tabasco");
            cbox_Estado.Items.Add("Tamaulipas");
            cbox_Estado.Items.Add("Tlaxcala");
            cbox_Estado.Items.Add("Veracruz");
            cbox_Estado.Items.Add("Yucatan");
            cbox_Estado.Items.Add("Zacatecas");
        }

         
        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            ValidarCampos();

            if ("Aguascalientes".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Aguascalientes);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Aguascalientes);
                }
            }
            else if ("BajaCalifornia".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.BajaCalifornia);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.BajaCaliforniaSur);
                }
            }
            else if ("BajaCaliforniaSur".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.BajaCaliforniaSur);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.BajaCaliforniaSur);
                }
            }
            else if ("Campeche".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Campeche);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Campeche);
                }
            }
            else if ("Chiapas".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Chiapas);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Chiapas);
                }
            }
            else if ("Chihuahua".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Chihuaha);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Chihuaha);
                }
            }
            else if ("Coahuila".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Coahuila);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Coahuila);
                }
            }
            else if ("Colima".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Colima);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Colima);
                }
            }
            else if ("DistritoFederal".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.DistritoFederal);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.DistritoFederal);
                }
            }
            else if ("Durango".Equals(cbox_EstadoNacimiento))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Durango);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Durango);
                }
            }
            else if ("Guanajuato".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Guanajuato);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Guanajuato);
                }
            }
            else if ("Guerrero".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Guerrero);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Guerrero);
                }
            }
            else if ("Hidalgo".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Hidalgo);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Hidalgo);
                }
            }
            else if ("Jalisco".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Jalisco);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Jalisco);
                }
            }
            else if ("Mexico".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Mexico);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Mexico);
                }
            }
            else if ("Michoacan".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Michoacan);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Michoacan);
                }
            }
            else if ("Morelos".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Morelos);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Morelos);
                }
            }
            else if ("NacidoExtranjero".ToString().Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.NacidoExtranjero);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.NacidoExtranjero);
                }
            }
            else if ("Nayarit".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Nayarit);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Nayarit);
                }
            }
            else if ("NuevoLeon".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.NuevoLeon);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.NuevoLeon);
                }
            }
            else if ("Oaxaca".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Oaxaca);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Oaxaca);
                }
            }
            else if ("Puebla".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Puebla);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Puebla);
                }
            }
            else if ("Queretaro".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Queretaro);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Queretaro);
                }
            }
            else if ("QuintanaRoo".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.QuintanaRoo);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.QuintanaRoo);
                }
            }
            else if ("SanLuisPotosi".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.SanLuisPotosi);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.SanLuisPotosi);
                }
            }
            else if ("Sinaloa".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Sinaloa);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Sinaloa);
                }
            }
            else if ("Sonora".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Sonora);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Sonora);
                }
            }
            else if ("Tabasco".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Tabasco);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Tabasco);
                }
            }
            else if ("Tamaulipas".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Tamaulipas);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Tamaulipas);
                }
            }
            else if ("Tlaxcala".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Tlaxcala);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Tlaxcala);
                }
            }
            else if ("Veracruz".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Veracruz);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Veracruz);
                }
            }
            else if ("Yucatan".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Yucatan);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Yucatan);
                }
            }
            else if ("Zacatecas".Equals(cbox_EstadoNacimiento.Text))
            {

                if (cbox_Sexo.Text.Equals("Masculino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Male, FederalEntities.Zacatecas);
                }

                if (cbox_Sexo.Text.Equals("Femenino"))
                {
                    curp = CurpClass.CreateCURP(tbox_Nombres.Text.Trim(), tbox_ApellidP.Text.Trim(), tbox_ApellidpM.Text.Trim(), dtime_FechaNacimiento.Value, Genres.Female, FederalEntities.Zacatecas);
                }
            }



            using (ContextPersona db = new ContextPersona())
            {
                try
                {
                    if (idPersona == null)
                    {

                        Persona p = new Persona();
                        p.Nombre = tbox_Nombres.Text.Trim();
                        p.Apellido_Paterno = tbox_ApellidP.Text.Trim();
                        p.Apellido_Materno = tbox_ApellidpM.Text.Trim();
                        p.Fecha_Nacimiento = dtime_FechaNacimiento.Value;
                        p.Sexo = cbox_Sexo.Text;
                        p.Estado_Nacimiento = cbox_EstadoNacimiento.Text;
                        p.Telefono = Convert.ToInt64(tbox_Telefono.Text.Trim());
                        p.Estado = cbox_Estado.Text;
                        p.Municipio = tbox_Municipio.Text.Trim();
                        p.Colonia = tbox_Colonia.Text.Trim();
                        p.Calle = tbox_Calle.Text.Trim();
                        p.Numero = Convert.ToInt32(tbox_Numero.Text.Trim());
                        p.Curp = curp;
                        db.Persona.Add(p);
                    }
                    else
                    {
                        Persona p = db.Persona.Find(idPersona);
                        p.Nombre = tbox_Nombres.Text.Trim();
                        p.Apellido_Paterno = tbox_ApellidP.Text.Trim();
                        p.Apellido_Materno = tbox_ApellidpM.Text.Trim();
                        p.Fecha_Nacimiento = dtime_FechaNacimiento.Value;
                        p.Sexo = cbox_Sexo.Text;
                        p.Estado_Nacimiento = cbox_EstadoNacimiento.Text;
                        p.Telefono = Convert.ToInt64(tbox_Telefono.Text.Trim());
                        p.Estado = cbox_Estado.Text;
                        p.Municipio = tbox_Municipio.Text.Trim();
                        p.Colonia = tbox_Colonia.Text.Trim();
                        p.Calle = tbox_Calle.Text.Trim();
                        p.Numero = Convert.ToInt32(tbox_Numero.Text.Trim());
                        p.Curp = curp;
                    }

                    db.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);;
                }
                

            }


        }

        public void getPersona()
        {
            try
            {
                using (ContextPersona db = new ContextPersona())
                {
                    Persona p = db.Persona.Find(idPersona);
                    tbox_Nombres.Text = p.Nombre;
                    tbox_ApellidP.Text = p.Apellido_Paterno;
                    tbox_ApellidpM.Text = p.Apellido_Materno;
                    dtime_FechaNacimiento.Text = p.Fecha_Nacimiento.ToString();
                    cbox_Sexo.Text = p.Sexo;
                    cbox_EstadoNacimiento.Text = p.Estado_Nacimiento;
                    tbox_Telefono.Text = p.Telefono.ToString();
                    cbox_Estado.Text = p.Estado;
                    tbox_Municipio.Text = p.Municipio;
                    tbox_Colonia.Text = p.Colonia;
                    tbox_Calle.Text = p.Calle;
                    tbox_Numero.Text = p.Numero.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }

        }


        public bool ValidarCampos()
        {
            bool ok = true;

            if (tbox_Nombres.Text == "")
            {
                ok = false;
                epError.SetError(tbox_Nombres, "Introduce Nombre...");

            }

            if (tbox_ApellidP.Text == "")
            {
                ok = false;
                epError.SetError(tbox_ApellidP, "Introduce Apellido Paterno...");

            }

            if (tbox_ApellidpM.Text == "")
            {
                ok = false;
                epError.SetError(tbox_ApellidpM, "Introduce Apellido Materno...");

            }

            if (cbox_EstadoNacimiento.Text == "")
            {
                ok = false;
                epError.SetError(cbox_EstadoNacimiento, "Introduce Apellido Materno...");

            }

            if (cbox_Sexo.Text == "")
            {
                ok = false;
                epError.SetError(cbox_Sexo, "Introduce Apellido Materno...");

            }
            
            return ok;

        }
    }
}
