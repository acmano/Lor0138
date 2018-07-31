using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Android.App;
using Android.Views;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lorenzetti.DB;

namespace Lor0138.Classes.Consultas.ConsultaPlanejamento
{
  public class Classe
  {

    public class VariaveisClasse
    {

      #region Privadas

      #region Linha 1
      private String _codigoRoteiro;
      private String _descricaoRoteiro;
      private Double _codigoRoteiroAlternativo;
      #endregion

      #region Linha 2
      private Double _fatorConversao;
      private String _codigoUnidadeMedida;
      private String _descricaoUnidadeMedida;
      #endregion

      #region Linha 3
      private String _codigoLocalProducao;
      private String _descricaoLocalProducao;
      private Double _percentualRefugo;
      #endregion

      #region Linha 4
      private Double _quantidadeEstoqueSeguranca;
      private Double _quantidadeDiasEstoqueSeguranca;
      private String _codigoHorizonte;
      private Double _nivel;
      #endregion

      #region Linha 5
      private Double _tempoRessuprimento;
      private Double _tempoPedido;
      private Double _tempoFabricacao;
      private Double _tempoTransporte;
      private Double _tempoInspecao;
      private Double _tempoContagem;
      #endregion

      #region Linha 6
      private Double _programacaoMinima;
      private Double _programacaoMaxima;
      private Double _programacaoMultipla;
      private Double _programacaoFixa;
      #endregion

      #region Linha 7
      private Double _estoqueSeguranca;
      private Double _estoqueMaximo;
      private Boolean _forcaApontamento;
      private Boolean _sofreBaixa;
      #endregion

      #region Linha 8
      private String _planejamento;
      private String _baixaComponentes;
      #endregion

      #region Linha 9
      private String _apontamentoMrp;
      private String _aberturaLiberacao;
      #endregion

      #region Linha 10
      private String _tipoApontamento;
      private Boolean _impedidoAposInspecao;
      #endregion

      #region Linha 11
      private Boolean _listaOrdens;
      private Boolean _listaRoteiro;
      private Boolean _apontamento;
      private Boolean _apontamentoAutomatico;
      private Double _quantidadeDecimais;
      #endregion

      #region Linha 12
      private String _codigoProgramador;
      private String _nomeProgramador;
      private Boolean _interfereQualidadeProdutoFinal;
      #endregion

      #region Linha 13
      private String _codigoComprador;
      private String _nomeComprador;
      private Boolean _controleFisico;
      private Boolean _produzidoNaEmpresa;
      #endregion

      #endregion

      #region Públicas

      #region Linha 1
      public String CodigoRoteiro
      {
        get { return _codigoRoteiro; }
        private set { _codigoRoteiro = value; }
      }

      public String DescricaoRoteiro
      {
        get { return _descricaoRoteiro; }
        private set { _descricaoRoteiro = value; }
      }

      public Double CodigoRoteiroAlternativo
      {
        get { return _codigoRoteiroAlternativo; }
        private set { _codigoRoteiroAlternativo = value; }
      }
      #endregion

      #region Linha 2
      public Double FatorConversao
      {
        get { return _fatorConversao; }
        private set { _fatorConversao = value; }
      }

      public String CodigoUnidadeMedida
      {
        get { return _codigoUnidadeMedida; }
        private set { _codigoUnidadeMedida = value; }
      }

      public String DescricaoUnidadeMedida
      {
        get { return _descricaoUnidadeMedida; }
        private set { _descricaoUnidadeMedida = value; }
      }
      #endregion

      #region Linha 3
      public String CodigoLocalProducao
      {
        get { return _codigoLocalProducao; }
        private set { _codigoLocalProducao = value; }
      }

      public String DescricaoLocalProducao
      {
        get { return _descricaoLocalProducao; }
        private set { _descricaoLocalProducao = value; }
      }

      public Double PercentualRefugo
      {
        get { return _percentualRefugo; }
        private set { _percentualRefugo = value; }
      }
      #endregion

      #region Linha 4
      public Double QuantidadeEstoqueSeguranca
      {
        get { return _quantidadeEstoqueSeguranca; }
        private set { _quantidadeEstoqueSeguranca = value; }
      }

      public Double QuantidadeDiasEstoqueSeguranca
      {
        get
        {
          return _quantidadeDiasEstoqueSeguranca;
        }
        private set
        {
          _quantidadeDiasEstoqueSeguranca = value;
        }
      }

      public String CodigoHorizonte
      {
        get { return _codigoHorizonte; }
        private set { _codigoHorizonte = value; }
      }

      public Double Nivel
      {
        get { return _nivel; }
        private set { _nivel = value; }
      }
      #endregion

      #region Linha 5
      public Double TempoRessuprimento
      {
        get { return _tempoRessuprimento; }
        private set { _tempoRessuprimento = value; }
      }

      public Double TempoPedido
      {
        get { return _tempoPedido; }
        private set { _tempoPedido = value; }
      }

      public Double TempoFabricacao
      {
        get { return _tempoFabricacao; }
        private set { _tempoFabricacao = value; }
      }

      public Double TempoTransporte
      {
        get { return _tempoTransporte; }
        private set { _tempoTransporte = value; }
      }

      public Double TempoInspecao
      {
        get { return _tempoInspecao; }
        private set { _tempoInspecao = value; }
      }

      public Double TempoContagem
      {
        get { return _tempoContagem; }
        private set { _tempoContagem = value; }
      }
      #endregion

      #region Linha 6
      public Double ProgramacaoMinima
      {
        get { return _programacaoMinima; }
        private set { _programacaoMinima = value; }
      }

      public Double ProgramacaoMaxima
      {
        get
        {
          return _programacaoMaxima;
        }
        private set
        {
          _programacaoMaxima = value;
        }
      }

      public Double ProgramacaoMultipla
      {
        get { return _programacaoMultipla; }
        private set { _programacaoMultipla = value; }
      }

      public Double ProgramacaoFixa
      {
        get { return _programacaoFixa; }
        private set { _programacaoFixa = value; }
      }
      #endregion

      #region Linha 7
      public Double EstoqueSeguranca
      {
        get { return _estoqueSeguranca; }
        private set { _estoqueSeguranca = value; }
      }

      public Double EstoqueMaximo
      {
        get { return _estoqueMaximo; }
        private set { _estoqueMaximo = value; }
      }

      public Boolean ForcaApontamento
      {
        get { return _forcaApontamento; }
        private set { _forcaApontamento = value; }
      }

      public Boolean SofreBaixa
      {
        get { return _sofreBaixa; }
        private set { _sofreBaixa = value; }
      }
      #endregion

      #region Linha 8
      public String Planejamento
      {
        get { return _planejamento; }
        private set { _planejamento = value; }
      }

      public String BaixaComponentes
      {
        get { return _baixaComponentes; }
        private set { _baixaComponentes = value; }
      }
      #endregion

      #region Linha 9
      public String ApontamentoMrp
      {
        get { return _apontamentoMrp; }
        private set { _apontamentoMrp = value; }
      }

      public String AberturaLiberacao
      {
        get { return _aberturaLiberacao; }
        private set { _aberturaLiberacao = value; }
      }
      #endregion

      #region Linha 10
      public String TipoApontamento
      {
        get { return _tipoApontamento; }
        private set { _tipoApontamento = value; }
      }

      public Boolean ImpedidoAposInspecao
      {
        get { return _impedidoAposInspecao; }
        private set { _impedidoAposInspecao = value; }
      }
      #endregion

      #region Linha 11
      public Boolean ListaOrdens
      {
        get { return _listaOrdens; }
        private set { _listaOrdens = value; }
      }

      public Boolean ListaRoteiro
      {
        get { return _listaRoteiro; }
        private set { _listaRoteiro = value; }
      }

      public Boolean Apontamento
      {
        get { return _apontamento; }
        private set { _apontamento = value; }
      }

      public Boolean ApontamentoAutomatico
      {
        get { return _apontamentoAutomatico; }
        private set { _apontamentoAutomatico = value; }
      }

      public Double QuantidadeDecimais
      {
        get { return _quantidadeDecimais; }
        private set { _quantidadeDecimais = value; }
      }
      #endregion

      #region Linha 12
      public String CodigoProgramador
      {
        get { return _codigoProgramador; }
        private set { _codigoProgramador = value; }
      }

      public String NomeProgramador
      {
        get { return _nomeProgramador; }
        private set { _nomeProgramador = value; }
      }

      public Boolean InterfereQualidadeProdutoFinal
      {
        get { return _interfereQualidadeProdutoFinal; }
        private set { _interfereQualidadeProdutoFinal = value; }
      }
      #endregion

      #region Linha 13
      public String CodigoComprador
      {
        get { return _codigoComprador; }
        private set { _codigoComprador = value; }
      }

      public String NomeComprador
      {
        get { return _nomeComprador; }
        private set { _nomeComprador = value; }
      }

      public Boolean ControleFisico
      {
        get { return _controleFisico; }
        private set { _controleFisico = value; }
      }

      public Boolean ProduzidoNaEmpresa
      {
        get { return _produzidoNaEmpresa; }
        private set { _produzidoNaEmpresa = value; }
      }
      #endregion

      #endregion

      private void Clear ( )
      {

        #region Linha 1
        _codigoRoteiro = String.Empty;
        _descricaoRoteiro = String.Empty;
        _codigoRoteiroAlternativo = 0.0f;
        #endregion

        #region Linha 2
        _fatorConversao = 0.0f;
        _codigoUnidadeMedida = String.Empty;
        _descricaoUnidadeMedida = String.Empty;
        #endregion

        #region Linha 3
        _codigoLocalProducao = String.Empty;
        _descricaoLocalProducao = String.Empty;
        _percentualRefugo = 0.0f;
        #endregion

        #region Linha 4
        _quantidadeEstoqueSeguranca = 0.0f;
        _quantidadeDiasEstoqueSeguranca = 0.0f;
        _codigoHorizonte = String.Empty;
        _nivel = 0.0;
        #endregion

        #region Linha 5
        _tempoRessuprimento = 0.0f;
        _tempoPedido = 0.0f;
        _tempoFabricacao = 0.0f;
        _tempoTransporte = 0.0f;
        _tempoInspecao = 0.0f;
        _tempoContagem = 0.0f;
        #endregion

        #region Linha 6
        _programacaoMinima = 0.0f;
        _programacaoMaxima = 0.0f;
        _programacaoMultipla = 0.0f;
        _programacaoFixa = 0.0f;
        #endregion

        #region Linha 7
        _estoqueSeguranca = 0.0f;
        _estoqueMaximo = 0.0f;
        _forcaApontamento = false;
        _sofreBaixa = false;
        #endregion

        #region Linha 8
        _planejamento = String.Empty;
        _baixaComponentes = String.Empty;
        #endregion

        #region Linha 9
        _apontamentoMrp = String.Empty;
        _aberturaLiberacao = String.Empty;
        #endregion

        #region Linha 10
        _tipoApontamento = String.Empty;
        _impedidoAposInspecao = false;
        #endregion

        #region Linha 11
        _listaOrdens = false;
        _listaRoteiro = false;
        _apontamento = false;
        _apontamentoAutomatico = false;
        _quantidadeDecimais = 0.0f;
        #endregion

        #region Linha 12
        _codigoProgramador = String.Empty;
        _nomeProgramador = String.Empty;
        _interfereQualidadeProdutoFinal = false;
        #endregion

        #region Linha 13
        _codigoComprador = String.Empty;
        _nomeComprador = String.Empty;
        _controleFisico = false;
        _produzidoNaEmpresa = false;
        #endregion

      }

      public VariaveisClasse ( )
      {
        Clear ( );
      }

      public VariaveisClasse ( DataRow dataRow )
      {

        #region Linha 1
        _codigoRoteiro = DbConvert.GetString ( dataRow, nameof( CodigoRoteiro ) );
        _descricaoRoteiro = DbConvert.GetString ( dataRow, nameof( DescricaoRoteiro ) );
        _codigoRoteiroAlternativo = DbConvert.GetDouble ( dataRow, nameof( CodigoRoteiroAlternativo ) );
        #endregion

        #region Linha 2
        _fatorConversao = DbConvert.GetDouble ( dataRow, "PesoUnitario" );
        _codigoUnidadeMedida = DbConvert.GetString( dataRow, nameof( CodigoUnidadeMedida ) );
        _descricaoUnidadeMedida = DbConvert.GetString ( dataRow, nameof( DescricaoUnidadeMedida ) );
        #endregion

        #region Linha 3
        _codigoLocalProducao = DbConvert.GetString ( dataRow, nameof( CodigoLocalProducao ) );
        _descricaoLocalProducao = DbConvert.GetString ( dataRow, nameof( DescricaoLocalProducao ) );
        _percentualRefugo = DbConvert.GetDouble ( dataRow, nameof( PercentualRefugo ) );
        #endregion

        #region Linha 4
        _quantidadeEstoqueSeguranca = DbConvert.GetDouble ( dataRow, nameof( QuantidadeEstoqueSeguranca ) );
        _quantidadeDiasEstoqueSeguranca = DbConvert.GetDouble ( dataRow, nameof( QuantidadeDiasEstoqueSeguranca ) );
        _codigoHorizonte = DbConvert.GetString ( dataRow, nameof( CodigoHorizonte ) );
        _nivel = DbConvert.GetDouble ( dataRow, nameof( Nivel ) );
        #endregion

        #region Linha 5
        _tempoRessuprimento = DbConvert.GetDouble ( dataRow, nameof( TempoRessuprimento ) );
        _tempoPedido = DbConvert.GetDouble ( dataRow, nameof( TempoPedido ) );
        _tempoFabricacao = DbConvert.GetDouble ( dataRow, nameof( TempoFabricacao ) );
        _tempoTransporte = DbConvert.GetDouble ( dataRow, nameof( TempoTransporte ) );
        _tempoInspecao = DbConvert.GetDouble ( dataRow, nameof( TempoInspecao ) );
        _tempoContagem = DbConvert.GetDouble ( dataRow, nameof( TempoContagem ) );
        #endregion

        #region Linha 6
        _programacaoMinima = DbConvert.GetDouble ( dataRow, nameof( ProgramacaoMinima ) );
        _programacaoMaxima = DbConvert.GetDouble ( dataRow, nameof( ProgramacaoMaxima ) );
        _programacaoMultipla = DbConvert.GetDouble ( dataRow, nameof( ProgramacaoMultipla ) );
        _programacaoFixa = DbConvert.GetDouble ( dataRow, nameof( ProgramacaoFixa ) );
        #endregion

        #region Linha 7
        _estoqueSeguranca = DbConvert.GetDouble ( dataRow, nameof( EstoqueSeguranca ) );
        _estoqueMaximo = DbConvert.GetDouble ( dataRow, nameof( EstoqueMaximo ) );
        _forcaApontamento = DbConvert.GetBoolean ( dataRow, nameof( ForcaApontamento ) );
        _sofreBaixa = DbConvert.GetBoolean ( dataRow, nameof( SofreBaixa ) );
        #endregion

        #region Linha 8
        _planejamento = DbConvert.GetString ( dataRow, nameof( Planejamento ) );
        _baixaComponentes = DbConvert.GetString ( dataRow, nameof( BaixaComponentes ) );
        #endregion

        #region Linha 9
        _apontamentoMrp = DbConvert.GetString ( dataRow, nameof( ApontamentoMrp ) );
        _aberturaLiberacao = DbConvert.GetString ( dataRow, nameof( AberturaLiberacao ) );
        #endregion

        #region Linha 10
        _tipoApontamento = DbConvert.GetString ( dataRow, nameof( TipoApontamento ) );
        _impedidoAposInspecao = DbConvert.GetBoolean ( dataRow, nameof( ImpedidoAposInspecao ) );
        #endregion

        #region Linha 11
        _listaOrdens = DbConvert.GetBoolean ( dataRow, nameof( ListaOrdens ) );
        _listaRoteiro = DbConvert.GetBoolean ( dataRow, nameof( ListaRoteiro ) );
        _apontamento = DbConvert.GetBoolean ( dataRow, nameof( Apontamento ) );
        _apontamentoAutomatico = DbConvert.GetBoolean ( dataRow, nameof( ApontamentoAutomatico ) );
        _quantidadeDecimais = DbConvert.GetDouble ( dataRow, nameof( QuantidadeDecimais ) );
        #endregion

        #region Linha 12
        _codigoProgramador = DbConvert.GetString ( dataRow, nameof( CodigoProgramador ) );
        _nomeProgramador = DbConvert.GetString ( dataRow, nameof( NomeProgramador ) );
        _interfereQualidadeProdutoFinal = DbConvert.GetBoolean ( dataRow, nameof( InterfereQualidadeProdutoFinal ) );
        #endregion

        #region Linha 13
        _codigoComprador = DbConvert.GetString ( dataRow, nameof( CodigoComprador ) );
        _nomeComprador = DbConvert.GetString ( dataRow, nameof( NomeComprador ) );
        _controleFisico = DbConvert.GetBoolean ( dataRow, nameof( ControleFisico ) );
        _produzidoNaEmpresa = DbConvert.GetBoolean ( dataRow, nameof( ProduzidoNaEmpresa ) );
        #endregion

      }

      public VariaveisClasse ( SqlDataReader dataReader = null )
      {
        if ( dataReader != null )
        {

          #region Linha 1
          _codigoRoteiro = DbConvert.GetString ( dataReader, nameof( CodigoRoteiro ) );
          _descricaoRoteiro = DbConvert.GetString ( dataReader, nameof( DescricaoRoteiro ) );
          _codigoRoteiroAlternativo = DbConvert.GetDouble ( dataReader, nameof( CodigoRoteiroAlternativo ) );
          #endregion

          #region Linha 2
          _fatorConversao = DbConvert.GetDouble ( dataReader, nameof( FatorConversao ) );
          _codigoUnidadeMedida = DbConvert.GetString ( dataReader, nameof( CodigoUnidadeMedida ) );
          _descricaoUnidadeMedida = DbConvert.GetString ( dataReader, nameof( DescricaoUnidadeMedida ) );
          #endregion

          #region Linha 3
          _codigoLocalProducao = DbConvert.GetString ( dataReader, nameof( CodigoLocalProducao ) );
          _descricaoLocalProducao = DbConvert.GetString ( dataReader, nameof( DescricaoLocalProducao ) );
          _percentualRefugo = DbConvert.GetDouble ( dataReader, nameof( PercentualRefugo ) );
          #endregion

          #region Linha 4
          _quantidadeEstoqueSeguranca = DbConvert.GetDouble ( dataReader, nameof( QuantidadeEstoqueSeguranca ) );
          _quantidadeDiasEstoqueSeguranca = DbConvert.GetDouble ( dataReader, nameof( QuantidadeDiasEstoqueSeguranca ) );
          _codigoHorizonte = DbConvert.GetString ( dataReader, nameof( CodigoHorizonte ) );
          _nivel = DbConvert.GetDouble ( dataReader, nameof( Nivel ) );
          #endregion

          #region Linha 5
          _tempoRessuprimento = DbConvert.GetDouble ( dataReader, nameof( TempoRessuprimento ) );
          _tempoPedido = DbConvert.GetDouble ( dataReader, nameof( TempoPedido ) );
          _tempoFabricacao = DbConvert.GetDouble ( dataReader, nameof( TempoFabricacao ) );
          _tempoTransporte = DbConvert.GetDouble ( dataReader, nameof( TempoTransporte ) );
          _tempoInspecao = DbConvert.GetDouble ( dataReader, nameof( TempoInspecao ) );
          _tempoContagem = DbConvert.GetDouble ( dataReader, nameof( TempoContagem ) );
          #endregion

          #region Linha 6
          _programacaoMinima = DbConvert.GetDouble ( dataReader, nameof( ProgramacaoMinima ) );
          _programacaoMaxima = DbConvert.GetDouble ( dataReader, nameof( ProgramacaoMaxima ) );
          _programacaoMultipla = DbConvert.GetDouble ( dataReader, nameof( ProgramacaoMultipla ) );
          _programacaoFixa = DbConvert.GetDouble ( dataReader, nameof( ProgramacaoFixa ) );
          #endregion

          #region Linha 7
          _estoqueSeguranca = DbConvert.GetDouble ( dataReader, nameof( EstoqueSeguranca ) );
          _estoqueMaximo = DbConvert.GetDouble ( dataReader, nameof( EstoqueMaximo ) );
          _forcaApontamento = DbConvert.GetBoolean ( dataReader, nameof( ForcaApontamento ) );
          _sofreBaixa = DbConvert.GetBoolean ( dataReader, nameof( SofreBaixa ) );
          #endregion

          #region Linha 8
          _planejamento = DbConvert.GetString ( dataReader, nameof( Planejamento ) );
          _baixaComponentes = DbConvert.GetString ( dataReader, nameof( BaixaComponentes ) );
          #endregion

          #region Linha 9
          _apontamentoMrp = DbConvert.GetString ( dataReader, nameof( ApontamentoMrp ) );
          _aberturaLiberacao = DbConvert.GetString ( dataReader, nameof( AberturaLiberacao ) );
          #endregion

          #region Linha 10
          _tipoApontamento = DbConvert.GetString ( dataReader, nameof( TipoApontamento ) );
          _impedidoAposInspecao = DbConvert.GetBoolean ( dataReader, nameof( ImpedidoAposInspecao ) );
          #endregion

          #region Linha 11
          _listaOrdens = DbConvert.GetBoolean ( dataReader, nameof( ListaOrdens ) );
          _listaRoteiro = DbConvert.GetBoolean ( dataReader, nameof( ListaRoteiro ) );
          _apontamento = DbConvert.GetBoolean ( dataReader, nameof( Apontamento ) );
          _apontamentoAutomatico = DbConvert.GetBoolean ( dataReader, nameof( ApontamentoAutomatico ) );
          _quantidadeDecimais = DbConvert.GetDouble ( dataReader, nameof( QuantidadeDecimais ) );
          #endregion

          #region Linha 12
          _codigoProgramador = DbConvert.GetString ( dataReader, nameof( CodigoProgramador ) );
          _nomeProgramador = DbConvert.GetString ( dataReader, nameof( NomeProgramador ) );
          _interfereQualidadeProdutoFinal = DbConvert.GetBoolean ( dataReader, nameof( InterfereQualidadeProdutoFinal ) );
          #endregion

          #region Linha 13
          _codigoComprador = DbConvert.GetString ( dataReader, nameof( CodigoComprador ) );
          _nomeComprador = DbConvert.GetString ( dataReader, nameof( NomeComprador ) );
          _controleFisico = DbConvert.GetBoolean ( dataReader, nameof( ControleFisico ) );
          _produzidoNaEmpresa = DbConvert.GetBoolean ( dataReader, nameof( ProduzidoNaEmpresa ) );
          #endregion

        }
        else
        {
          Clear ( );
        }
      }

    }

    public class CamposXml
    {

      #region Privadas

      #region Estrutura
      private RelativeLayout _rloConsultaPlanejamento;
      private LinearLayout _lloConsultaPlanejamentoBotoes;
      #endregion

      #region Linha 1
      private TextView _txtConsultaPlanejamentoCodigoRoteiro;
      private TextView _txtConsultaPlanejamentoDescricaoRoteiro;
      private TextView _txtConsultaPlanejamentoCodigoRoteiroAlternativo;
      #endregion

      #region Linha 2
      private TextView _txtConsultaPlanejamentoFatorConversao;
      private TextView _txtConsultaPlanejamentoCodigoUnidadeMedida;
      private TextView _txtConsultaPlanejamentoDescricaoUnidadeMedida;
      #endregion

      #region Linha 3
      private TextView _txtConsultaPlanejamentoCodigoLocalProducao;
      private TextView _txtConsultaPlanejamentoDescricaoLocalProducao;
      private TextView _txtConsultaPlanejamentoPercentualRefugo;
      #endregion

      #region Linha 4
      private TextView _txtConsultaPlanejamentoQuantidadeEstoqueSeguranca;
      private TextView _txtConsultaPlanejamentoQuantidadeDiasEstoqueSeguranca;
      private TextView _txtConsultaPlanejamentoCodigoHorizonte;
      private TextView _txtConsultaPlanejamentoNivel;
      #endregion

      #region Linha 5
      private TextView _txtConsultaPlanejamentoTempoRessuprimento;
      private TextView _txtConsultaPlanejamentoTempoPedido;
      private TextView _txtConsultaPlanejamentoTempoFabricacao;
      private TextView _txtConsultaPlanejamentoTempoTransporte;
      private TextView _txtConsultaPlanejamentoTempoInspecao;
      private TextView _txtConsultaPlanejamentoTempoContagem;
      #endregion

      #region Linha 6
      private TextView _txtConsultaPlanejamentoProgramacaoMinima;
      private TextView _txtConsultaPlanejamentoProgramacaoMaxima;
      private TextView _txtConsultaPlanejamentoProgramacaoMultipla;
      private TextView _txtConsultaPlanejamentoProgramacaoFixa;
      #endregion

      #region Linha 7
      private TextView _txtConsultaPlanejamentoEstoqueSeguranca;
      private TextView _txtConsultaPlanejamentoEstoqueMaximo;
      private CheckBox _cbxConsultaPlanejamentoForcaApontamento;
      private CheckBox _cbxConsultaPlanejamentoSofreBaixa;
      #endregion

      #region Linha 8
      private TextView _txtConsultaPlanejamentoPlanejamento;
      private TextView _txtConsultaPlanejamentoBaixaComponentes;
      #endregion

      #region Linha 9
      private TextView _txtConsultaPlanejamentoApontamentoMrp;
      private TextView _txtConsultaPlanejamentoAberturaLiberacao;
      #endregion

      #region Linha 10
      private TextView _txtConsultaPlanejamentoTipoApontamento;
      private CheckBox _cbxConsultaPlanejamentoImpedidoAposInspecao;
      #endregion

      #region Linha 11
      private CheckBox _cbxConsultaPlanejamentoListaOrdens;
      private CheckBox _cbxConsultaPlanejamentoListaRoteiro;
      private CheckBox _cbxConsultaPlanejamentoApontamento;
      private CheckBox _cbxConsultaPlanejamentoApontamentoAutomatico;
      private TextView _txtConsultaPlanejamentoQuantidadeDecimais;
      #endregion

      #region Linha 12
      private TextView _txtConsultaPlanejamentoCodigoProgramador;
      private TextView _txtConsultaPlanejamentoNomeProgramador;
      private CheckBox _cbxConsultaPlanejamentoInterfereQualidadeProdutoFinal;
      #endregion

      #region Linha 13
      private TextView _txtConsultaPlanejamentoCodigoComprador;
      private TextView _txtConsultaPlanejamentoNomeComprador;
      private CheckBox _cbxConsultaPlanejamentoControleFisico;
      private CheckBox _cbxConsultaPlanejamentoProduzidoNaEmpresa;
      #endregion

      #endregion

      #region Públicas

      #region Estrutura
      public RelativeLayout RloConsultaPlanejamento
      {
        get { return _rloConsultaPlanejamento; }
        private set { _rloConsultaPlanejamento = value; }
      }

      public LinearLayout LloConsultaPlanejamentoBotoes
      {
        get { return _lloConsultaPlanejamentoBotoes; }
        private set { _lloConsultaPlanejamentoBotoes = value; }
      }
      #endregion

      #region Linha 1
      public TextView TxtConsultaPlanejamentoCodigoRoteiro
      {
        get { return _txtConsultaPlanejamentoCodigoRoteiro; }
        private set { _txtConsultaPlanejamentoCodigoRoteiro = value; }
      }

      public TextView TxtConsultaPlanejamentoDescricaoRoteiro
      {
        get { return _txtConsultaPlanejamentoDescricaoRoteiro; }
        private set { _txtConsultaPlanejamentoDescricaoRoteiro = value; }
      }

      public TextView TxtConsultaPlanejamentoCodigoRoteiroAlternativo
      {
        get { return _txtConsultaPlanejamentoCodigoRoteiroAlternativo; }
        private set { _txtConsultaPlanejamentoCodigoRoteiroAlternativo = value; }
      }
      #endregion

      #region Linha 2
      public TextView TxtConsultaPlanejamentoFatorConversao
      {
        get { return _txtConsultaPlanejamentoFatorConversao; }
        private set { _txtConsultaPlanejamentoFatorConversao = value; }
      }

      public TextView TxtConsultaPlanejamentoCodigoUnidadeMedida
      {
        get { return _txtConsultaPlanejamentoCodigoUnidadeMedida; }
        private set { _txtConsultaPlanejamentoCodigoUnidadeMedida = value; }
      }

      public TextView TxtConsultaPlanejamentoDescricaoUnidadeMedida
      {
        get { return _txtConsultaPlanejamentoDescricaoUnidadeMedida; }
        private set { _txtConsultaPlanejamentoDescricaoUnidadeMedida = value; }
      }
      #endregion

      #region Linha 3
      public TextView TxtConsultaPlanejamentoCodigoLocalProducao
      {
        get { return _txtConsultaPlanejamentoCodigoLocalProducao; }
        private set { _txtConsultaPlanejamentoCodigoLocalProducao = value; }
      }

      public TextView TxtConsultaPlanejamentoDescricaoLocalProducao
      {
        get { return _txtConsultaPlanejamentoDescricaoLocalProducao; }
        private set { _txtConsultaPlanejamentoDescricaoLocalProducao = value; }
      }

      public TextView TxtConsultaPlanejamentoPercentualRefugo
      {
        get { return _txtConsultaPlanejamentoPercentualRefugo; }
        private set { _txtConsultaPlanejamentoPercentualRefugo = value; }
      }
      #endregion

      #region Linha 4
      public TextView TxtConsultaPlanejamentoQuantidadeEstoqueSeguranca
      {
        get { return _txtConsultaPlanejamentoQuantidadeEstoqueSeguranca; }
        private set { _txtConsultaPlanejamentoQuantidadeEstoqueSeguranca = value; }
      }

      public TextView TxtConsultaPlanejamentoQuantidadeDiasEstoqueSeguranca
      {
        get { return _txtConsultaPlanejamentoQuantidadeDiasEstoqueSeguranca; }
        private set { _txtConsultaPlanejamentoQuantidadeDiasEstoqueSeguranca = value; }
      }

      public TextView TxtConsultaPlanejamentoCodigoHorizonte
      {
        get { return _txtConsultaPlanejamentoCodigoHorizonte; }
        private set { _txtConsultaPlanejamentoCodigoHorizonte = value; }
      }

      public TextView TxtConsultaPlanejamentoNivel
      {
        get { return _txtConsultaPlanejamentoNivel; }
        private set { _txtConsultaPlanejamentoNivel = value; }
      }
      #endregion

      #region Linha 5
      public TextView TxtConsultaPlanejamentoTempoRessuprimento
      {
        get { return _txtConsultaPlanejamentoTempoRessuprimento; }
        private set { _txtConsultaPlanejamentoTempoRessuprimento = value; }
      }

      public TextView TxtConsultaPlanejamentoTempoPedido
      {
        get { return _txtConsultaPlanejamentoTempoPedido; }
        private set { _txtConsultaPlanejamentoTempoPedido = value; }
      }

      public TextView TxtConsultaPlanejamentoTempoFabricacao
      {
        get { return _txtConsultaPlanejamentoTempoFabricacao; }
        private set { _txtConsultaPlanejamentoTempoFabricacao = value; }
      }

      public TextView TxtConsultaPlanejamentoTempoTransporte
      {
        get { return _txtConsultaPlanejamentoTempoTransporte; }
        private set { _txtConsultaPlanejamentoTempoTransporte = value; }
      }

      public TextView TxtConsultaPlanejamentoTempoInspecao
      {
        get { return _txtConsultaPlanejamentoTempoInspecao; }
        private set { _txtConsultaPlanejamentoTempoInspecao = value; }
      }

      public TextView TxtConsultaPlanejamentoTempoContagem
      {
        get { return _txtConsultaPlanejamentoTempoContagem; }
        private set { _txtConsultaPlanejamentoTempoContagem = value; }
      }
      #endregion

      #region Linha 6
      public TextView TxtConsultaPlanejamentoProgramacaoMinima
      {
        get { return _txtConsultaPlanejamentoProgramacaoMinima; }
        private set { _txtConsultaPlanejamentoProgramacaoMinima = value; }
      }

      public TextView TxtConsultaPlanejamentoProgramacaoMaxima
      {
        get { return _txtConsultaPlanejamentoProgramacaoMaxima; }
        private set { _txtConsultaPlanejamentoProgramacaoMaxima = value; }
      }

      public TextView TxtConsultaPlanejamentoProgramacaoMultipla
      {
        get { return _txtConsultaPlanejamentoProgramacaoMultipla; }
        private set { _txtConsultaPlanejamentoProgramacaoMultipla = value; }
      }

      public TextView TxtConsultaPlanejamentoProgramacaoFixa
      {
        get { return _txtConsultaPlanejamentoProgramacaoFixa; }
        private set { _txtConsultaPlanejamentoProgramacaoFixa = value; }
      }
      #endregion

      #region Linha 7
      public TextView TxtConsultaPlanejamentoEstoqueSeguranca
      {
        get { return _txtConsultaPlanejamentoEstoqueSeguranca; }
        private set { _txtConsultaPlanejamentoEstoqueSeguranca = value; }
      }

      public TextView TxtConsultaPlanejamentoEstoqueMaximo
      {
        get { return _txtConsultaPlanejamentoEstoqueMaximo; }
        private set { _txtConsultaPlanejamentoEstoqueMaximo = value; }
      }

      public CheckBox CbxConsultaPlanejamentoForcaApontamento
      {
        get { return _cbxConsultaPlanejamentoForcaApontamento; }
        private set { _cbxConsultaPlanejamentoForcaApontamento = value; }
      }

      public CheckBox CbxConsultaPlanejamentoSofreBaixa
      {
        get { return _cbxConsultaPlanejamentoSofreBaixa; }
        private set { _cbxConsultaPlanejamentoSofreBaixa = value; }
      }
      #endregion

      #region Linha 8
      public TextView TxtConsultaPlanejamentoPlanejamento
      {
        get { return _txtConsultaPlanejamentoPlanejamento; }
        private set { _txtConsultaPlanejamentoPlanejamento = value; }
      }

      public TextView TxtConsultaPlanejamentoBaixaComponentes
      {
        get { return _txtConsultaPlanejamentoBaixaComponentes; }
        private set { _txtConsultaPlanejamentoBaixaComponentes = value; }
      }
      #endregion

      #region Linha 9
      public TextView TxtConsultaPlanejamentoApontamentoMrp
      {
        get { return _txtConsultaPlanejamentoApontamentoMrp; }
        private set { _txtConsultaPlanejamentoApontamentoMrp = value; }
      }

      public TextView TxtConsultaPlanejamentoAberturaLiberacao
      {
        get { return _txtConsultaPlanejamentoAberturaLiberacao; }
        private set { _txtConsultaPlanejamentoAberturaLiberacao = value; }
      }
      #endregion

      #region Linha 10
      public TextView TxtConsultaPlanejamentoCodigoClasseUso
      {
        get
        {
          return _txtConsultaPlanejamentoTipoApontamento;
        }
        private set
        {
          _txtConsultaPlanejamentoTipoApontamento = value;
        }
      }

      public CheckBox CbxConsultaPlanejamentoImpedidoAposInspecao
      {
        get { return _cbxConsultaPlanejamentoImpedidoAposInspecao; }
        private set { _cbxConsultaPlanejamentoImpedidoAposInspecao = value; }
      }
      #endregion

      #region Linha 11
      public CheckBox CbxConsultaPlanejamentoListaOrdens
      {
        get { return _cbxConsultaPlanejamentoListaOrdens; }
        private set { _cbxConsultaPlanejamentoListaOrdens = value; }
      }

      public CheckBox CbxConsultaPlanejamentoListaRoteiro
      {
        get { return _cbxConsultaPlanejamentoListaRoteiro; }
        private set { _cbxConsultaPlanejamentoListaRoteiro = value; }
      }

      public CheckBox CbxConsultaPlanejamentoApontamento
      {
        get { return _cbxConsultaPlanejamentoApontamento; }
        private set { _cbxConsultaPlanejamentoApontamento = value; }
      }

      public CheckBox CbxConsultaPlanejamentoApontamentoAutomatico
      {
        get { return _cbxConsultaPlanejamentoApontamentoAutomatico; }
        private set { _cbxConsultaPlanejamentoApontamentoAutomatico = value; }
      }

      public TextView TxtConsultaPlanejamentoQuantidadeDecimais
      {
        get { return _txtConsultaPlanejamentoQuantidadeDecimais; }
        private set { _txtConsultaPlanejamentoQuantidadeDecimais = value; }
      }
      #endregion

      #region Linha 12
      public TextView TxtConsultaPlanejamentoCodigoProgramador
      {
        get { return _txtConsultaPlanejamentoCodigoProgramador; }
        private set { _txtConsultaPlanejamentoCodigoProgramador = value; }
      }

      public TextView TxtConsultaPlanejamentoNomeProgramador
      {
        get { return _txtConsultaPlanejamentoNomeProgramador; }
        private set { _txtConsultaPlanejamentoNomeProgramador = value; }
      }

      public CheckBox CbxConsultaPlanejamentoInterfereQualidadeProdutoFinal
      {
        get { return _cbxConsultaPlanejamentoInterfereQualidadeProdutoFinal; }
        private set { _cbxConsultaPlanejamentoInterfereQualidadeProdutoFinal = value; }
      }
      #endregion

      #region Linha 13
      public TextView TxtConsultaPlanejamentoCodigoComprador
      {
        get { return _txtConsultaPlanejamentoCodigoComprador; }
        private set { _txtConsultaPlanejamentoCodigoComprador = value; }
      }

      public TextView TxtConsultaPlanejamentoNomeComprador
      {
        get { return _txtConsultaPlanejamentoNomeComprador; }
        private set { _txtConsultaPlanejamentoNomeComprador = value; }
      }

      public CheckBox CbxConsultaPlanejamentoControleFisico
      {
        get { return _cbxConsultaPlanejamentoControleFisico; }
        private set { _cbxConsultaPlanejamentoControleFisico = value; }
      }

      public CheckBox CbxConsultaPlanejamentoProduzidoNaEmpresa
      {
        get { return _cbxConsultaPlanejamentoProduzidoNaEmpresa; }
        private set { _cbxConsultaPlanejamentoProduzidoNaEmpresa = value; }
      }
      #endregion

      #endregion


      public CamposXml ( Activity activity )
      {
        Bind ( activity );
      }

      private void Bind ( Activity activity )
      {

        #region Estrutura
        BindEstrutura ( activity );
        #endregion

        #region Linha 1
        BindCodigoRoteiro ( activity );
        BindDescricaoRoteiro ( activity );
        BindCodigoRoteiroAlternativo ( activity );
        #endregion

        #region Linha 2
        BindFatorConversao ( activity );
        BindCodigoUnidadeMedida ( activity );
        BindDescricaoUnidadeMedida ( activity );
        #endregion

        #region Linha 3
        BindCodigoLocalProducao ( activity );
        BindDescricaoLocalProducao ( activity );
        BindPercentualRefugo ( activity );
        #endregion

        #region Linha 4
        BindQuantidadeEstoqueSeguranca ( activity );
        BindQuantidadeDiasEstoqueSeguranca ( activity );
        BindCodigoHorizonte ( activity );
        BindNivel ( activity );
        #endregion

        #region Linha 5
        BindTempoRessuprimento ( activity );
        BindTempoPedido ( activity );
        BindTempoFabricacao ( activity );
        BindTempoTransporte ( activity );
        BindTempoInspecao ( activity );
        BindTempoContagem ( activity );
        #endregion

        #region Linha 6
        BindProgramacaoMinima ( activity );
        BindProgramacaoMaxima ( activity );
        BindProgramacaoMultipla ( activity );
        BindProgramacaoFixa ( activity );
        #endregion

        #region Linha 7
        BindEstoqueSeguranca ( activity );
        BindEstoqueMaximo ( activity );
        BindForcaApontamento ( activity );
        BindSofreBaixa ( activity );
        #endregion

        #region Linha 8
        BindPlanejamento ( activity );
        BindBaixaComponentes ( activity );
        #endregion

        #region Linha 9
        BindApontamentoMrp ( activity );
        BindAberturaLiberacao ( activity );
        #endregion

        #region Linha 10
        BindTipoApontamento ( activity );
        BindImpedidoAposInspecao ( activity );
        #endregion

        #region Linha 11
        BindListaOrdens ( activity );
        BindListaRoteiro ( activity );
        BindApontamento ( activity );
        BindApontamentoAutomatico ( activity );
        BindQuantidadeDecimais ( activity );
        #endregion

        #region Linha 12
        BindCodigoProgramador ( activity );
        BindNomeProgramador ( activity );
        BindInterfereQualidadeProdutoFinal ( activity );
        #endregion

        #region Linha 13
        BindCodigoComprador ( activity );
        BindNomeComprador ( activity );
        BindControleFisico ( activity );
        BindProduzidoNaEmpresa ( activity );
        #endregion

      }

      #region Bind - Estrutura
      private void BindEstrutura ( Activity activity )
      {
        RloConsultaPlanejamento = activity.FindViewById<RelativeLayout> ( Resource.Id.consultaPlanejamento );
        LloConsultaPlanejamentoBotoes = activity.FindViewById<LinearLayout> ( Resource.Id.consultaPlanejamentoBotoes );
      }
      #endregion

      #region Linha 1
      private void BindCodigoRoteiro ( Activity activity )
      {
        _txtConsultaPlanejamentoCodigoRoteiro = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoCodigoRoteiro );
      }

      private void BindDescricaoRoteiro ( Activity activity )
      {
        _txtConsultaPlanejamentoDescricaoRoteiro = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoDescricaoRoteiro );
      }

      private void BindCodigoRoteiroAlternativo ( Activity activity )
      {
        _txtConsultaPlanejamentoCodigoRoteiroAlternativo = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoCodigoRoteiroAlternativo );
      }
      #endregion

      #region Linha 2
      private void BindFatorConversao ( Activity activity )
      {
        _txtConsultaPlanejamentoFatorConversao = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoFatorConversao );
      }

      private void BindCodigoUnidadeMedida ( Activity activity )
      {
        _txtConsultaPlanejamentoCodigoUnidadeMedida = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoCodigoUnidadeMedida );
      }

      private void BindDescricaoUnidadeMedida ( Activity activity )
      {
        _txtConsultaPlanejamentoDescricaoUnidadeMedida = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoDescricaoUnidadeMedida );
      }
      #endregion

      #region Linha 3
      private void BindCodigoLocalProducao ( Activity activity )
      {
        _txtConsultaPlanejamentoCodigoLocalProducao = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoCodigoLocalProducao );
      }

      private void BindDescricaoLocalProducao ( Activity activity )
      {
        _txtConsultaPlanejamentoDescricaoLocalProducao = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoDescricaoLocalProducao );
      }

      private void BindPercentualRefugo ( Activity activity )
      {
        _txtConsultaPlanejamentoPercentualRefugo = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoPercentualRefugo );
      }
      #endregion

      #region Linha 4
      private void BindQuantidadeEstoqueSeguranca ( Activity activity )
      {
        _txtConsultaPlanejamentoQuantidadeEstoqueSeguranca = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoQuantidadeEstoqueSeguranca );
      }

      private void BindQuantidadeDiasEstoqueSeguranca ( Activity activity )
      {
        _txtConsultaPlanejamentoQuantidadeDiasEstoqueSeguranca = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoQuantidadeDiasEstoqueSeguranca );
      }

      private void BindCodigoHorizonte ( Activity activity )
      {
        _txtConsultaPlanejamentoCodigoHorizonte = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoCodigoHorizonte );
      }

      private void BindNivel ( Activity activity )
      {
        _txtConsultaPlanejamentoNivel = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoNivel );
      }
      #endregion

      #region Linha 5
      private void BindTempoRessuprimento ( Activity activity )
      {
        _txtConsultaPlanejamentoTempoRessuprimento = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoTempoRessuprimento );
      }

      private void BindTempoPedido ( Activity activity )
      {
        _txtConsultaPlanejamentoTempoPedido = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoTempoPedido );
      }

      private void BindTempoFabricacao ( Activity activity )
      {
        _txtConsultaPlanejamentoTempoFabricacao = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoTempoFabricacao );
      }

      private void BindTempoTransporte ( Activity activity )
      {
        _txtConsultaPlanejamentoTempoTransporte = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoTempoTransporte );
      }

      private void BindTempoInspecao ( Activity activity )
      {
        _txtConsultaPlanejamentoTempoInspecao = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoTempoInspecao );
      }

      private void BindTempoContagem ( Activity activity )
      {
        _txtConsultaPlanejamentoTempoContagem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoTempoContagem );
      }
      #endregion

      #region Linha 6
      private void BindProgramacaoMinima ( Activity activity )
      {
        _txtConsultaPlanejamentoProgramacaoMinima = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoProgramacaoMinima );
      }

      private void BindProgramacaoMaxima ( Activity activity )
      {
        _txtConsultaPlanejamentoProgramacaoMaxima = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoProgramacaoMaxima );
      }

      private void BindProgramacaoMultipla ( Activity activity )
      {
        _txtConsultaPlanejamentoProgramacaoMultipla = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoProgramacaoMultipla );
      }

      private void BindProgramacaoFixa ( Activity activity )
      {
        _txtConsultaPlanejamentoProgramacaoFixa = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoProgramacaoFixa );
      }
      #endregion

      #region Linha 7
      private void BindEstoqueSeguranca ( Activity activity )
      {
        _txtConsultaPlanejamentoEstoqueSeguranca = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoEstoqueSeguranca );
      }

      private void BindEstoqueMaximo ( Activity activity )
      {
        _txtConsultaPlanejamentoEstoqueMaximo = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoEstoqueMaximo );
      }

      private void BindForcaApontamento ( Activity activity )
      {
        _cbxConsultaPlanejamentoForcaApontamento = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaPlanejamentoForcaApontamento );
      }

      private void BindSofreBaixa ( Activity activity )
      {
        _cbxConsultaPlanejamentoSofreBaixa = activity.FindViewById<CheckBox> ( Resource.Id.txtConsultaPlanejamentoSofreBaixa );
      }
      #endregion

      #region Linha 8
      private void BindPlanejamento ( Activity activity )
      {
        _txtConsultaPlanejamentoPlanejamento = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoPlanejamento );
      }

      private void BindBaixaComponentes ( Activity activity )
      {
        _txtConsultaPlanejamentoBaixaComponentes = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoBaixaComponentes );
      }
      #endregion

      #region Linha 9
      private void BindApontamentoMrp ( Activity activity )
      {
        _txtConsultaPlanejamentoApontamentoMrp = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoApontamentoMrp );
      }

      private void BindAberturaLiberacao ( Activity activity )
      {
        _txtConsultaPlanejamentoAberturaLiberacao = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoAberturaLiberacao );
      }
      #endregion

      #region Linha 10
      private void BindTipoApontamento ( Activity activity )
      {
        _txtConsultaPlanejamentoTipoApontamento = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoTipoApontamento );
      }

      private void BindImpedidoAposInspecao ( Activity activity )
      {
        _cbxConsultaPlanejamentoImpedidoAposInspecao = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaPlanejamentoImpedidoAposInspecao );
      }
      #endregion

      #region Linha 11
      private void BindListaOrdens ( Activity activity )
      {
        _cbxConsultaPlanejamentoListaOrdens = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaPlanejamentoListaOrdens );
      }

      private void BindListaRoteiro ( Activity activity )
      {
        _cbxConsultaPlanejamentoListaRoteiro = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaPlanejamentoListaRoteiro );
      }

      private void BindApontamento ( Activity activity )
      {
        _cbxConsultaPlanejamentoApontamento = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaPlanejamentoApontamento );
      }

      private void BindApontamentoAutomatico ( Activity activity )
      {
        _cbxConsultaPlanejamentoApontamentoAutomatico = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaPlanejamentoApontamentoAutomatico );
      }

      private void BindQuantidadeDecimais ( Activity activity )
      {
        _txtConsultaPlanejamentoQuantidadeDecimais = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoQuantidadeDecimais );
      }
      #endregion

      #region Linha 12
      private void BindCodigoProgramador ( Activity activity )
      {
        _txtConsultaPlanejamentoCodigoProgramador = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoCodigoProgramador );
      }

      private void BindNomeProgramador ( Activity activity )
      {
        _txtConsultaPlanejamentoNomeProgramador = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoNomeProgramador );
      }

      private void BindInterfereQualidadeProdutoFinal ( Activity activity )
      {
        _cbxConsultaPlanejamentoInterfereQualidadeProdutoFinal = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaPlanejamentoInterfereQualidadeProdutoFinal );
      }
      #endregion

      #region Linha 13
      private void BindCodigoComprador ( Activity activity )
      {
        _txtConsultaPlanejamentoCodigoComprador = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoCodigoComprador );
      }

      private void BindNomeComprador ( Activity activity )
      {
        _txtConsultaPlanejamentoNomeComprador = activity.FindViewById<TextView> ( Resource.Id.txtConsultaPlanejamentoNomeComprador );
      }

      private void BindControleFisico ( Activity activity )
      {
        _cbxConsultaPlanejamentoControleFisico = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaPlanejamentoControleFisico );
      }

      private void BindProduzidoNaEmpresa ( Activity activity )
      {
        _cbxConsultaPlanejamentoProduzidoNaEmpresa = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaPlanejamentoProduzidoNaEmpresa );
      }
      #endregion

      public void Clear ( )
      {

        #region Linha 1
        _txtConsultaPlanejamentoCodigoRoteiro.Text = String.Empty;
        _txtConsultaPlanejamentoDescricaoRoteiro.Text = String.Empty;
        _txtConsultaPlanejamentoCodigoRoteiroAlternativo.Text = String.Empty;
        #endregion

        #region Linha 2
        _txtConsultaPlanejamentoFatorConversao.Text = String.Empty;
        _txtConsultaPlanejamentoCodigoUnidadeMedida.Text = String.Empty;
        _txtConsultaPlanejamentoDescricaoUnidadeMedida.Text = String.Empty;
        #endregion

        #region Linha 3
        _txtConsultaPlanejamentoCodigoLocalProducao.Text = String.Empty;
        _txtConsultaPlanejamentoDescricaoLocalProducao.Text = String.Empty;
        _txtConsultaPlanejamentoPercentualRefugo.Text = String.Empty;
        #endregion

        #region Linha 4
        _txtConsultaPlanejamentoQuantidadeEstoqueSeguranca.Text = String.Empty;
        _txtConsultaPlanejamentoQuantidadeDiasEstoqueSeguranca.Text = String.Empty;
        _txtConsultaPlanejamentoCodigoHorizonte.Text = String.Empty;
        _txtConsultaPlanejamentoNivel.Text = String.Empty;
        #endregion

        #region Linha 5
        _txtConsultaPlanejamentoTempoRessuprimento.Text = String.Empty;
        _txtConsultaPlanejamentoTempoPedido.Text = String.Empty;
        _txtConsultaPlanejamentoTempoFabricacao.Text = String.Empty;
        _txtConsultaPlanejamentoTempoTransporte.Text = String.Empty;
        _txtConsultaPlanejamentoTempoInspecao.Text = String.Empty;
        _txtConsultaPlanejamentoTempoContagem.Text = String.Empty;
        #endregion

        #region Linha 6
        _txtConsultaPlanejamentoProgramacaoMinima.Text = String.Empty;
        _txtConsultaPlanejamentoProgramacaoMaxima.Text = String.Empty;
        _txtConsultaPlanejamentoProgramacaoMultipla.Text = String.Empty;
        _txtConsultaPlanejamentoProgramacaoFixa.Text = String.Empty;
        #endregion

        #region Linha 7
        _txtConsultaPlanejamentoEstoqueSeguranca.Text = String.Empty;
        _txtConsultaPlanejamentoEstoqueMaximo.Text = String.Empty;
        _cbxConsultaPlanejamentoForcaApontamento.Checked = false;
        _cbxConsultaPlanejamentoSofreBaixa.Checked = false;
        #endregion

        #region Linha 8
        _txtConsultaPlanejamentoPlanejamento.Text = String.Empty;
        _txtConsultaPlanejamentoBaixaComponentes.Text = String.Empty;
        #endregion

        #region Linha 9
        _txtConsultaPlanejamentoApontamentoMrp.Text = String.Empty;
        _txtConsultaPlanejamentoAberturaLiberacao.Text = String.Empty;
        #endregion

        #region Linha 10
        _txtConsultaPlanejamentoTipoApontamento.Text = String.Empty;
        _cbxConsultaPlanejamentoImpedidoAposInspecao.Checked = false;
        #endregion

        #region Linha 11
        _cbxConsultaPlanejamentoListaOrdens.Checked = false;
        _cbxConsultaPlanejamentoListaRoteiro.Checked = false;
        _cbxConsultaPlanejamentoApontamento.Checked = false;
        _cbxConsultaPlanejamentoApontamentoAutomatico.Checked = false;
        _txtConsultaPlanejamentoQuantidadeDecimais.Text = String.Empty;
        #endregion

        #region Linha 12
        _txtConsultaPlanejamentoCodigoProgramador.Text = String.Empty;
        _txtConsultaPlanejamentoNomeProgramador.Text = String.Empty;
        _cbxConsultaPlanejamentoInterfereQualidadeProdutoFinal.Checked = false;
        #endregion

        #region Linha 13
        _txtConsultaPlanejamentoCodigoComprador.Text = String.Empty;
        _txtConsultaPlanejamentoNomeComprador.Text = String.Empty;
        _cbxConsultaPlanejamentoControleFisico.Checked = false;
        _cbxConsultaPlanejamentoProduzidoNaEmpresa.Checked = false;
        #endregion

      }

      public void AtualizaCampos ( VariaveisClasse valor )
      {

        #region Linha 1
        _txtConsultaPlanejamentoCodigoRoteiro.Text = valor.CodigoRoteiro.Trim();
        _txtConsultaPlanejamentoDescricaoRoteiro.Text = valor.DescricaoRoteiro.Trim();
        _txtConsultaPlanejamentoCodigoRoteiroAlternativo.Text = valor.CodigoRoteiroAlternativo.ToString("#0").Trim();
        #endregion

        #region Linha 2
        _txtConsultaPlanejamentoFatorConversao.Text = valor.FatorConversao.ToString ( "##0.000000" ).Trim ( );
        _txtConsultaPlanejamentoCodigoUnidadeMedida.Text = valor.CodigoUnidadeMedida.Trim ( );
        _txtConsultaPlanejamentoDescricaoUnidadeMedida.Text = valor.DescricaoUnidadeMedida.Trim ( );
        #endregion

        #region Linha 3
        _txtConsultaPlanejamentoCodigoLocalProducao.Text = valor.CodigoLocalProducao.Trim();
        _txtConsultaPlanejamentoDescricaoLocalProducao.Text = valor.DescricaoLocalProducao.Trim ( );
        _txtConsultaPlanejamentoPercentualRefugo.Text = valor.PercentualRefugo.ToString("##0.000") .Trim ( );
        #endregion

        #region Linha 4
        _txtConsultaPlanejamentoQuantidadeEstoqueSeguranca.Text = valor.QuantidadeEstoqueSeguranca.ToString("####0.000").Trim();
        _txtConsultaPlanejamentoQuantidadeDiasEstoqueSeguranca.Text = valor.QuantidadeDiasEstoqueSeguranca.ToString("###0").Trim ( );
        _txtConsultaPlanejamentoCodigoHorizonte.Text = valor.CodigoHorizonte.Trim ( );
        _txtConsultaPlanejamentoNivel.Text = valor.Nivel.ToString("#0").Trim ( );
        #endregion

        #region Linha 5
        _txtConsultaPlanejamentoTempoRessuprimento.Text = valor.TempoRessuprimento.ToString("###0").Trim ( );
        _txtConsultaPlanejamentoTempoPedido.Text = valor.TempoPedido.ToString("###0").Trim ( );
        _txtConsultaPlanejamentoTempoFabricacao.Text = valor.TempoFabricacao.ToString ( "###0" ).Trim ( );
        _txtConsultaPlanejamentoTempoTransporte.Text = valor.TempoTransporte.ToString ( "###0" ).Trim ( );
        _txtConsultaPlanejamentoTempoInspecao.Text = valor.TempoInspecao.ToString("###0").Trim ( );
        _txtConsultaPlanejamentoTempoContagem.Text = valor.TempoContagem.ToString("###0").Trim();
        #endregion

        #region Linha 6
        _txtConsultaPlanejamentoProgramacaoMinima.Text = valor.ProgramacaoMinima.ToString("####0.000").Trim ( );
        _txtConsultaPlanejamentoProgramacaoMaxima.Text = valor.ProgramacaoMaxima.ToString("####0.000").Trim ( );
        _txtConsultaPlanejamentoProgramacaoMultipla.Text = valor.ProgramacaoMultipla.ToString("####0.000").Trim ( );
        _txtConsultaPlanejamentoProgramacaoFixa.Text = valor.ProgramacaoFixa.ToString("####0.000").Trim ( );
        #endregion

        #region Linha 7
        _txtConsultaPlanejamentoEstoqueSeguranca.Text = valor.EstoqueSeguranca.ToString("####0.000").Trim ( );
        _txtConsultaPlanejamentoEstoqueMaximo.Text = valor.EstoqueMaximo.ToString("####0.000").Trim ( );
        _cbxConsultaPlanejamentoForcaApontamento.Checked = valor.ForcaApontamento;
        _cbxConsultaPlanejamentoSofreBaixa.Checked = valor.SofreBaixa;
        #endregion

        #region Linha 8
        _txtConsultaPlanejamentoPlanejamento.Text = valor.Planejamento.Trim ( );
        _txtConsultaPlanejamentoBaixaComponentes.Text = valor.BaixaComponentes.Trim ( );
        #endregion

        #region Linha 9
        _txtConsultaPlanejamentoApontamentoMrp.Text = valor.ApontamentoMrp.Trim ( );
        _txtConsultaPlanejamentoAberturaLiberacao.Text = valor.AberturaLiberacao.Trim ( );
        #endregion

        #region Linha 10
        _txtConsultaPlanejamentoTipoApontamento.Text = valor.TipoApontamento.Trim ( );
        _cbxConsultaPlanejamentoImpedidoAposInspecao.Checked = valor.ImpedidoAposInspecao;
        #endregion

        #region Linha 11
        _cbxConsultaPlanejamentoListaOrdens.Checked = valor.ListaOrdens;
        _cbxConsultaPlanejamentoListaRoteiro.Checked = valor.ListaRoteiro;
        _cbxConsultaPlanejamentoApontamento.Checked = valor.Apontamento;
        _cbxConsultaPlanejamentoApontamentoAutomatico.Checked = valor.ApontamentoAutomatico;
        _txtConsultaPlanejamentoQuantidadeDecimais.Text = valor.QuantidadeDecimais.ToString("#0").Trim();
        #endregion

        #region Linha 12
        _txtConsultaPlanejamentoCodigoProgramador.Text = valor.CodigoProgramador.Trim ( );
        _txtConsultaPlanejamentoNomeProgramador.Text = valor.NomeProgramador.Trim();
        _cbxConsultaPlanejamentoInterfereQualidadeProdutoFinal.Checked = valor.InterfereQualidadeProdutoFinal;
        #endregion

        #region Linha 13
        _txtConsultaPlanejamentoCodigoComprador.Text = valor.CodigoComprador.Trim ( );
        _txtConsultaPlanejamentoNomeComprador.Text = valor.NomeComprador.Trim();
        _cbxConsultaPlanejamentoControleFisico.Checked = valor.ControleFisico;
        _cbxConsultaPlanejamentoProduzidoNaEmpresa.Checked = valor.ProduzidoNaEmpresa;
        #endregion

      }

    }

    #region Privadas
    private readonly Config    _bcoSql;
    private readonly AcessoSql _acessoSql;
    private Boolean            _ok;
    private Tabela             _consultaPlanejamento;
    private VariaveisClasse    _variaveis;
    private CamposXml          _camposTela;
    private Item.Classe        _item;
    #endregion

    #region Publicas
    public Tabela Tabela
    {
      get { return _consultaPlanejamento; }
      set { _consultaPlanejamento = value; }
    }

    public Boolean Ok
    {
      get { return _ok; }
      set { _ok = value; }
    }

    public Config BcoSql
    {
      get { return _bcoSql; }
    }

    public AcessoSql AcessoSql
    {
      get { return _acessoSql; }
    }

    public Item.Classe Item
    {
      get { return _item; }
      set { _item = value; }
    }

    public CamposXml CamposTela
    {
      get { return _camposTela; }
      set { _camposTela = value; }
    }
    #endregion

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, Item.Classe item )
    {
      _ok = true;
      _bcoSql = bcoSql;
      _acessoSql = acessoSql;
      _item = item;
      ClasseComum ( activity );
    }

    private void ClasseComum ( Activity activity )
    {
      _variaveis = new VariaveisClasse ( );
      CamposTela = new CamposXml ( activity );
      CamposTela.LloConsultaPlanejamentoBotoes.Visibility = ViewStates.Invisible;
      CamposTela.Clear ( );
      _ok = _item.Ok;
      if ( _ok )
      {
        PopulaRecord ( _item );
      }
    }

    public void Show ( )
    {
      _camposTela.RloConsultaPlanejamento.Visibility = ViewStates.Visible;
    }

    public void Hide ( )
    {
      _camposTela.RloConsultaPlanejamento.Visibility = ViewStates.Gone;
    }

    private void PopulaRecord ( Item.Classe item )
    {
      var query = new StringBuilder ( );
      query.AppendFormat ( Sql.Query, _acessoSql.OpenQuery, item.Campos.Variaveis.CodigoEmpresa, item.Campos.Variaveis.CodigoItem );
      var banco = new Msde ( _acessoSql );
      banco.Open ( );
      var reader = banco.DataReader ( query.ToString ( ) );
      while ( reader.Read ( ) )
      {
        _variaveis = new VariaveisClasse ( reader );
        CamposTela.AtualizaCampos ( _variaveis );
        break;
      }
      reader.Close ( );
      reader.Dispose ( );
      banco.Close ( );
    }

  }
}
