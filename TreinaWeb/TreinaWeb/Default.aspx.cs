using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TreinaWeb.Data;
using TreinaWeb.Models;

namespace TreinaWeb
{


    public partial class _Default : Page
    {

        public List<Tasks> Tarefas { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Tarefas = new AppDbContext().Tasks.ToList();
            this.GridView1.AutoGenerateColumns = true;
            this.GridView1.DataSource = Tarefas;
            this.GridView1.DataBind();
            int id = int.Parse(Request.QueryString["id"] ?? "0");
            var ctx = new AppDbContext();
            Tasks tasks;
            tasks = ctx.Tasks.FirstOrDefault(c => c.Id == id);
            if (tasks == null)
                tasks = new Tasks();


            txtData.Text = tasks.Data.ToString();
            txtFinalizadoEm.Text = tasks.FinalizadoEm.ToString();
            txtTitulo.Text = tasks.Titulo;
            txtPrazo.Text = tasks.Prazo.ToString();
            txtDescricao.Text = tasks.Descricao;
            chkFinalizado.Checked = tasks.Finalizado;
            txtResponsavel.Text = tasks.Reponsavel;
            txtPrioridade.Text = tasks.Prioridade.ToString();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            var ctx = new AppDbContext();
            Tasks tasks;
            tasks = ctx.Tasks.FirstOrDefault(c => c.Id == id);
            if(tasks == null)
                tasks = new Tasks();


            tasks.Data = DateTime.Parse(txtData.Text);
            tasks.Titulo = txtTitulo.Text;
            tasks.Prazo = DateTime.Parse(txtPrazo.Text);
            tasks.Descricao = txtDescricao.Text;
            tasks.Finalizado = chkFinalizado.Checked;
            tasks.Reponsavel = txtResponsavel.Text;
            tasks.Prioridade = int.Parse(txtPrioridade.Text);
            ctx.Tasks.Add(tasks);
            ctx.SaveChanges();
            Response.Redirect("/");

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            var ctx = new AppDbContext();
            int id = int.Parse(Request.QueryString["id"]);
            var tasks = ctx.Tasks.FirstOrDefault(c => c.Id == id);
            ctx.Tasks.Remove(tasks);
            ctx.SaveChanges();
            Response.Redirect("/");

        }
    }
}