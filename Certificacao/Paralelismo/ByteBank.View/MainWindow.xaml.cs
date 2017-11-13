using ByteBank.Core.Model;
using ByteBank.Core.Repository;
using ByteBank.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ByteBank.View
{
    public partial class MainWindow : Window
    {
        private readonly ContaClienteRepository r_Repositorio;
        private readonly ContaClienteService r_Servico;
        private CancellationTokenSource _cts;

        public MainWindow()
        {
            InitializeComponent();

            r_Repositorio = new ContaClienteRepository();
            r_Servico = new ContaClienteService();
        }

        private async void BtnProcessar_Click(object sender, RoutedEventArgs e)
        {
            BtnProcessar.IsEnabled = false;
            _cts = new CancellationTokenSource();

            var contas = r_Repositorio.GetContaClientes();

            PgsProgresso.Maximum = contas.Count();

            LimparView();

            var inicio = DateTime.Now;
            btnCancelar.IsEnabled = true;
            var progress = new Progress<string>(str => PgsProgresso.Value++);
            

            try {
                var resultado = await ConsolidarContas(contas, progress, _cts.Token);
                var fim = DateTime.Now;
                AtualizarView(resultado, fim - inicio);
            }
            catch (OperationCanceledException)
            {
                TxtTempo.Text = "Op cancelada pelo usuario";
            }
            finally {
                BtnProcessar.IsEnabled = true;
                btnCancelar.IsEnabled = false;
            }

           

            BtnProcessar.IsEnabled = true;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            btnCancelar.IsEnabled = false;
            _cts.Cancel();
        }

        private async Task<string[]> ConsolidarContas(IEnumerable<ContaCliente> contas, IProgress<string> rptProgresso, CancellationToken ct)
        {
            var tasks = contas.Select(conta =>
                 Task.Factory.StartNew(() =>
                 {
                     ct.ThrowIfCancellationRequested();

                     var resultadoConsolidacao = r_Servico.ConsolidarMovimentacao(conta, ct);
                     rptProgresso.Report(resultadoConsolidacao);

                     ct.ThrowIfCancellationRequested();
                     return resultadoConsolidacao;
                 }, ct)
            );

            return await Task.WhenAll(tasks);
        }

        private void LimparView()
        {
            LstResultados.ItemsSource = null;
            TxtTempo.Text = null;
            PgsProgresso.Value = 0;
        }

        private void AtualizarView(IEnumerable<String> result, TimeSpan elapsedTime)
        {
            var tempoDecorrido = $"{ elapsedTime.Seconds }.{ elapsedTime.Milliseconds} segundos!";
            var mensagem = $"Processamento de {result.Count()} clientes em {tempoDecorrido}";

            LstResultados.ItemsSource = result;
            TxtTempo.Text = mensagem;
        }
    }
}
