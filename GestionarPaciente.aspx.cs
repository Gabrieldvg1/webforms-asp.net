using CapaEntidades;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class frmGestionarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                

            }
        }

        private Paciente GetEntity()
        {
            Paciente objPaciente = new Paciente();
            objPaciente.IdPaciente = 0;
            objPaciente.Nombres = txtNombres.Text;
            objPaciente.ApPaterno = txtApPaterno.Text;
            objPaciente.ApMaterno = txtApMaterno.Text;
            objPaciente.Edad = Convert.ToInt32(txtEdad.Text);
            objPaciente.Sexo = ddlSexo.SelectedValue == "Femenino" ? 'F' : 'M';
            objPaciente.Direccion = txtDireccion.Text;
            objPaciente.Telefono = txtTelefono.Text;
            objPaciente.Estado = true;
            objPaciente.NroDocumento = txtNroDocumento.Text;

            return objPaciente;
        }
        private frmGestionarPaciente GetPaciente()
        {
            return null;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Registro del Paciente
            Paciente objPaciente = GetEntity();

            //Enviar a la capa de negocio
            bool response = PacienteLN.getInstance().RegistrarPaciente(objPaciente);

            if (response == true)
            {
                Response.Write("<script>alert('REGISTRO CORRECTO')</script>");
            }
            else
            {
                Response.Write("<script>alert('REGISTRO INCORRECTO')</script>");
            }
        }
    }
}