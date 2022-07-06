using SisMEC.Context;
using SisMEC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMEC.Controllers.Services
{
    public class GraficoServicosService
    {
        private readonly AppDbContext context;

        public GraficoServicosService(AppDbContext context)
        {
            this.context = context;
        }

        public ServicoGrafico GetServicoGraf()
        {

            var servicos = context.Servicos;

            var lista = new List<ServicoGrafico>();


            var servico = new ServicoGrafico();

            foreach (var item in servicos)
            {
                if(item.ServicoCompleto == false)
                {
                    servico.ServicoPendente++;
                    lista.Add(servico);
                }
                else
                {
                    servico.ServicoCompleto++;
                    lista.Add(servico);
                }
            }

            return servico;
                            

        }
    }
}
