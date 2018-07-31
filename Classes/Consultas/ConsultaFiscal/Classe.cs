using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Android.App;
using Android.Views;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lorenzetti.DB;

namespace Lor0138.Classes.Consultas.ConsultaFiscal
{
  public class Classe
  {

    public class VariaveisClasse
    {

      #region Privadas

      #region Linha 1
      private Double _codigoGrupoDespesa;
      private String _descricaoGrupoDespesa;
      private String _contaContabil;
      #endregion

      #region Linha 2
      private Double _codigoTipoDespesa;
      private String _descricaoTipoDespesa;
      private String _nomeContaContabil;
      #endregion

      #region Linha 3
      private String _classificacaoFiscal;
      private Double _aliquotaIpi;
      private String _descricaoIncidenciaIpi;
      private String _descricaoIncidenciaIcms;
      #endregion

      #region Linha 4
      private String _codigoFiscal;
      private Boolean _contabiliza;
      private Boolean _creditoPisCofins;
      #endregion

      #region Linha 5
      private String _codigoOrigem;
      private String _descricaoOrigem;
      private String _codigoTipoItemSped;
      private String _descricaoTipoItemSped;
      #endregion

      #endregion

      #region Públicas

      #region Linha 1
      public Double CodigoGrupoDespesa
      {
        get { return _codigoGrupoDespesa; }
        private set { _codigoGrupoDespesa = value; }
      }

      public String DescricaoGrupoDespesa
      {
        get { return _descricaoGrupoDespesa; }
        private set { _descricaoGrupoDespesa = value; }
      }

      public String ContaContabil
      {
        get { return _contaContabil; }
        private set { _contaContabil = value; }
      }
      #endregion

      #region Linha 2
      public Double CodigoTipoDespesa
      {
        get { return _codigoTipoDespesa; }
        private set { _codigoTipoDespesa = value; }
      }

      public String DescricaoTipoDespesa
      {
        get { return _descricaoTipoDespesa; }
        private set { _descricaoTipoDespesa = value; }
      }

      public String NomeContaContabil
      {
        get { return _nomeContaContabil; }
        private set { _nomeContaContabil = value; }
      }
      #endregion

      #region Linha 3
      public String ClassificacaoFiscal
      {
        get { return _classificacaoFiscal; }
        private set { _classificacaoFiscal = value; }
      }

      public Double AliquotaIpi
      {
        get { return _aliquotaIpi; }
        private set { _aliquotaIpi = value; }
      }

      public String DescricaoIncidenciaIpi
      {
        get { return _descricaoIncidenciaIpi; }
        private set { _descricaoIncidenciaIpi = value; }
      }

      public String DescricaoIncidenciaIcms
      {
        get { return _descricaoIncidenciaIcms; }
        private set { _descricaoIncidenciaIcms = value; }
      }
      #endregion

      #region Linha 4
      public String CodigoFiscal
      {
        get { return _codigoFiscal; }
        private set { _codigoFiscal = value; }
      }

      public Boolean Contabiliza
      {
        get { return _contabiliza; }
        private set { _contabiliza = value; }
      }

      public Boolean CreditoPisCofins
      {
        get { return _creditoPisCofins; }
        private set { _creditoPisCofins = value; }
      }
      #endregion

      #region Linha 5
      public String CodigoOrigem
      {
        get { return _codigoOrigem; }
        private set { _codigoOrigem = value; }
      }

      public String DescricaoOrigem
      {
        get { return _descricaoOrigem; }
        private set { _descricaoOrigem = value; }
      }

      public String CodigoTipoItemSped
      {
        get { return _codigoTipoItemSped; }
        private set { _codigoTipoItemSped = value; }
      }

      public String DescricaoTipoItemSped
      {
        get { return _descricaoTipoItemSped; }
        private set { _descricaoTipoItemSped = value; }
      }
      #endregion

      #endregion

      private void Clear ( )
      {

        #region Linha 1
        _codigoGrupoDespesa = 0.0f;
        _descricaoGrupoDespesa = String.Empty;
        _contaContabil = String.Empty;
        #endregion

        #region Linha 2
        _codigoTipoDespesa = 0.0f;
        _descricaoTipoDespesa = String.Empty;
        _nomeContaContabil = String.Empty;
        #endregion

        #region Linha 3
        _classificacaoFiscal = String.Empty;
        _aliquotaIpi = 0.0f;
        _descricaoIncidenciaIpi = String.Empty;
        _descricaoIncidenciaIcms = String.Empty;
        #endregion

        #region Linha 4
        _codigoFiscal = String.Empty;
        _contabiliza = false;
        _creditoPisCofins = false;
        #endregion

        #region Linha 5
        _codigoOrigem = String.Empty;
        _descricaoOrigem = String.Empty;
        _codigoTipoItemSped = String.Empty;
        _descricaoTipoItemSped = String.Empty;
        #endregion

      }

      public VariaveisClasse ( )
      {
        Clear ( );
      }

      public VariaveisClasse ( DataRow dataRow )
      {

        #region Linha 1
        _codigoGrupoDespesa = DbConvert.GetDouble ( dataRow, nameof( CodigoGrupoDespesa ) );
        _descricaoGrupoDespesa = DbConvert.GetString ( dataRow, nameof( DescricaoGrupoDespesa ) );
        _contaContabil = DbConvert.GetString ( dataRow, nameof( ContaContabil ) );
        #endregion

        #region Linha 2
        _codigoTipoDespesa = DbConvert.GetDouble ( dataRow, nameof( CodigoTipoDespesa ) );
        _descricaoTipoDespesa = DbConvert.GetString ( dataRow, nameof( DescricaoTipoDespesa ) );
        _nomeContaContabil = DbConvert.GetString ( dataRow, nameof( NomeContaContabil ) );
        #endregion

        #region Linha 3
        _classificacaoFiscal = DbConvert.GetString ( dataRow, nameof( ClassificacaoFiscal ) );
        _aliquotaIpi = DbConvert.GetDouble ( dataRow, nameof( AliquotaIpi ) );
        _descricaoIncidenciaIpi = DbConvert.GetString ( dataRow, nameof( DescricaoIncidenciaIpi ) );
        _descricaoIncidenciaIcms = DbConvert.GetString ( dataRow, nameof( DescricaoIncidenciaIcms ) );
        #endregion

        #region Linha 4
        _codigoFiscal = DbConvert.GetString ( dataRow, nameof( CodigoFiscal ) );
        _contabiliza = DbConvert.GetBoolean ( dataRow, nameof( Contabiliza ) );
        _creditoPisCofins = DbConvert.GetBoolean ( dataRow, nameof( CreditoPisCofins ) );
        #endregion

        #region Linha 5
        _codigoOrigem = DbConvert.GetString ( dataRow, nameof( CodigoOrigem ) );
        _descricaoOrigem = DbConvert.GetString ( dataRow, nameof( DescricaoOrigem ) );
        _codigoTipoItemSped = DbConvert.GetString ( dataRow, nameof( CodigoTipoItemSped ) );
        _descricaoTipoItemSped = DbConvert.GetString ( dataRow, nameof( DescricaoTipoItemSped ) );
        #endregion

      }

      public VariaveisClasse ( SqlDataReader dataReader = null )
      {
        if ( dataReader != null )
        {

          #region Linha 1
          _codigoGrupoDespesa = DbConvert.GetDouble ( dataReader, nameof( CodigoGrupoDespesa ) );
          _descricaoGrupoDespesa = DbConvert.GetString ( dataReader, nameof( DescricaoGrupoDespesa ) );
          _contaContabil = DbConvert.GetString ( dataReader, nameof( ContaContabil ) );
          #endregion

          #region Linha 2
          _codigoTipoDespesa = DbConvert.GetDouble ( dataReader, nameof( CodigoTipoDespesa ) );
          _descricaoTipoDespesa = DbConvert.GetString ( dataReader, nameof( DescricaoTipoDespesa ) );
          _nomeContaContabil = DbConvert.GetString ( dataReader, nameof( NomeContaContabil ) );
          #endregion

          #region Linha 3
          _classificacaoFiscal = DbConvert.GetString ( dataReader, nameof( ClassificacaoFiscal ) );
          _aliquotaIpi = DbConvert.GetDouble ( dataReader, nameof( AliquotaIpi ) );
          _descricaoIncidenciaIpi = DbConvert.GetString ( dataReader, nameof( DescricaoIncidenciaIpi ) );
          _descricaoIncidenciaIcms = DbConvert.GetString ( dataReader, nameof( DescricaoIncidenciaIcms ) );
          #endregion

          #region Linha 4
          _codigoFiscal = DbConvert.GetString ( dataReader, nameof( CodigoFiscal ) );
          _contabiliza = DbConvert.GetBoolean ( dataReader, nameof( Contabiliza ) );
          _creditoPisCofins = DbConvert.GetBoolean ( dataReader, nameof( CreditoPisCofins ) );
          #endregion

          #region Linha 5
          _codigoOrigem = DbConvert.GetString ( dataReader, nameof( CodigoOrigem ) );
          _descricaoOrigem = DbConvert.GetString ( dataReader, nameof( DescricaoOrigem ) );
          _codigoTipoItemSped = DbConvert.GetString ( dataReader, nameof( CodigoTipoItemSped ) );
          _descricaoTipoItemSped = DbConvert.GetString ( dataReader, nameof( DescricaoTipoItemSped ) );
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
      private RelativeLayout _rloConsultaFiscal;
      private LinearLayout _lloConsultaFiscalBotoes;
      #endregion

      #region Linha 1
      private TextView _txtConsultaFiscalCodigoGrupoDespesa;
      private TextView _txtConsultaFiscalDescricaoGrupoDespesa;
      private TextView _txtConsultaFiscalContaContabil;
      #endregion

      #region Linha 2
      private TextView _txtConsultaFiscalCodigoTipoDespesa;
      private TextView _txtConsultaFiscalDescricaoTipoDespesa;
      private TextView _txtConsultaFiscalNomeContaContabil;
      #endregion

      #region Linha 3
      private TextView _txtConsultaFiscalClassificacaoFiscal;
      private TextView _txtConsultaFiscalAliquotaIpi;
      private TextView _txtConsultaFiscalDescricaoIncidenciaIpi;
      private TextView _txtConsultaFiscalDescricaoIncidenciaIcms;
      #endregion

      #region Linha 4
      private TextView _txtConsultaFiscalCodigoFiscal;
      private CheckBox _cbxConsultaFiscalContabiliza;
      private CheckBox _cbxConsultaFiscalCreditoPisCofins;
      #endregion

      #region Linha 5
      private TextView _txtConsultaFiscalCodigoOrigem;
      private TextView _txtConsultaFiscalDescricaoOrigem;
      private TextView _txtConsultaFiscalCodigoTipoItemSped;
      private TextView _txtConsultaFiscalDescricaoTipoItemSped;
      #endregion

      #endregion

      #region Públicas

      #region Estrutura
      public RelativeLayout RloConsultaFiscal
      {
        get  { return _rloConsultaFiscal; }
        private set { _rloConsultaFiscal = value; }
      }

      public LinearLayout LloConsultaFiscalBotoes
      {
        get { return _lloConsultaFiscalBotoes; }
        private set { _lloConsultaFiscalBotoes = value; }
      }
      #endregion

      #region Linha 1
      public TextView TxtConsultaFiscalCodigoGrupoDespesa
      {
        get { return _txtConsultaFiscalCodigoGrupoDespesa; }
        private set { _txtConsultaFiscalCodigoGrupoDespesa = value; }
      }

      public TextView TxtConsultaFiscalDescricaoGrupoDespesa
      {
        get { return _txtConsultaFiscalDescricaoGrupoDespesa; }
        private set { _txtConsultaFiscalDescricaoGrupoDespesa = value; }
      }

      public TextView TxtConsultaFiscalContaContabil
      {
        get { return _txtConsultaFiscalContaContabil; }
        private set { _txtConsultaFiscalContaContabil = value; }
      }
      #endregion

      #region Linha 2
      public TextView TxtConsultaFiscalCodigoTipoDespesa
      {
        get { return _txtConsultaFiscalCodigoTipoDespesa; }
        private set { _txtConsultaFiscalCodigoTipoDespesa = value; }
      }

      public TextView TxtConsultaFiscalDescricaoTipoDespesa
      {
        get { return _txtConsultaFiscalDescricaoTipoDespesa; }
        private set { _txtConsultaFiscalDescricaoTipoDespesa = value; }
      }

      public TextView TxtConsultaFiscalNomeContaContabil
      {
        get { return _txtConsultaFiscalNomeContaContabil; }
        private set { _txtConsultaFiscalNomeContaContabil = value; }
      }
      #endregion

      #region Linha 3
      public TextView TxtConsultaFiscalClassificacaoFiscal
      {
        get { return _txtConsultaFiscalClassificacaoFiscal; }
        private set { _txtConsultaFiscalClassificacaoFiscal = value; }
      }

      public TextView TxtConsultaFiscalAliquotaIpi
      {
        get { return _txtConsultaFiscalAliquotaIpi; }
        private set { _txtConsultaFiscalAliquotaIpi = value; }
      }

      public TextView TxtConsultaFiscalDescricaoIncidenciaIpi
      {
        get { return _txtConsultaFiscalDescricaoIncidenciaIpi; }
        private set { _txtConsultaFiscalDescricaoIncidenciaIpi = value; }
      }

      public TextView TxtConsultaFiscalDescricaoIncidenciaIcms
      {
        get { return _txtConsultaFiscalDescricaoIncidenciaIcms; }
        private set { _txtConsultaFiscalDescricaoIncidenciaIcms = value; }
      }
      #endregion

      #region Linha 4
      public TextView TxtConsultaFiscalCodigoFiscal
      {
        get { return _txtConsultaFiscalCodigoFiscal; }
        private set { _txtConsultaFiscalCodigoFiscal = value; }
      }

      public CheckBox CbxConsultaFiscalContabiliza
      {
        get { return _cbxConsultaFiscalContabiliza; }
        private set { _cbxConsultaFiscalContabiliza = value; }
      }

      public CheckBox CbxConsultaFiscalCreditoPisCofins
      {
        get { return _cbxConsultaFiscalCreditoPisCofins; }
        private set { _cbxConsultaFiscalCreditoPisCofins = value; }
      }
      #endregion

      #region Linha 5
      public TextView TxtConsultaFiscalCodigoOrigem
      {
        get { return _txtConsultaFiscalCodigoOrigem; }
        private set { _txtConsultaFiscalCodigoOrigem = value; }
      }

      public TextView TxtConsultaFiscalDescricaoOrigem
      {
        get { return _txtConsultaFiscalDescricaoOrigem; }
        private set { _txtConsultaFiscalDescricaoOrigem = value; }
      }

      public TextView TxtConsultaFiscalCodigoTipoItemSped
      {
        get { return _txtConsultaFiscalCodigoTipoItemSped; }
        private set { _txtConsultaFiscalCodigoTipoItemSped = value; }
      }

      public TextView TxtConsultaFiscalDescricaoTipoItemSped
      {
        get { return _txtConsultaFiscalDescricaoTipoItemSped; }
        private set { _txtConsultaFiscalDescricaoTipoItemSped = value; }
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
        BindCodigoGrupoDespesa ( activity );
        BindDescricaoGrupoDespesa ( activity );
        BindContaContabil ( activity );
        #endregion

        #region Linha 2
        BindCodigoTipoDespesa ( activity );
        BindDescricaoTipoDespesa ( activity );
        BindNomeContaContabil ( activity );
        #endregion

        #region Linha 3
        BindClassificacaoFiscal ( activity );
        BindAliquotaIpi ( activity );
        BindDescricaoIncidenciaIpi ( activity );
        BindDescricaoIncidenciaIcms ( activity );
        #endregion

        #region Linha 4
        BindCodigoFiscal ( activity );
        BindContabiliza ( activity );
        BindCreditoPisCofins ( activity );
        #endregion

        #region Linha 5
        BindCodigoOrigem ( activity );
        BindDescricaoOrigem ( activity );
        BindCodigoTipoItemSped ( activity );
        BindDescricaoTipoItemSped ( activity );
        #endregion

      }

      #region Bind - Estrutura
      private void BindEstrutura ( Activity activity )
      {
        RloConsultaFiscal = activity.FindViewById<RelativeLayout> ( Resource.Id.consultaFiscal );
        LloConsultaFiscalBotoes = activity.FindViewById<LinearLayout> ( Resource.Id.consultaFiscalBotoes );
      }
      #endregion

      #region Linha 1
      private void BindCodigoGrupoDespesa ( Activity activity )
      {
        _txtConsultaFiscalCodigoGrupoDespesa = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalCodigoGrupoDespesa );
      }

      private void BindDescricaoGrupoDespesa ( Activity activity )
      {
        _txtConsultaFiscalDescricaoGrupoDespesa = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalDescricaoGrupoDespesa );
      }

      private void BindContaContabil ( Activity activity )
      {
        _txtConsultaFiscalContaContabil = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalContaContabil );
      }
      #endregion

      #region Linha 2
      private void BindCodigoTipoDespesa ( Activity activity )
      {
        _txtConsultaFiscalCodigoTipoDespesa = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalCodigoTipoDespesa );
      }

      private void BindDescricaoTipoDespesa ( Activity activity )
      {
        _txtConsultaFiscalDescricaoTipoDespesa = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalDescricaoTipoDespesa );
      }

      private void BindNomeContaContabil ( Activity activity )
      {
        _txtConsultaFiscalNomeContaContabil = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalNomeContaContabil );
      }
      #endregion

      #region Linha 3
      private void BindClassificacaoFiscal ( Activity activity )
      {
        _txtConsultaFiscalClassificacaoFiscal = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalClassificacaoFiscal );
      }

      private void BindAliquotaIpi ( Activity activity )
      {
        _txtConsultaFiscalAliquotaIpi = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalAliquotaIpi );
      }

      private void BindDescricaoIncidenciaIpi ( Activity activity )
      {
        _txtConsultaFiscalDescricaoIncidenciaIpi = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalDescricaoIncidenciaIpi );
      }

      private void BindDescricaoIncidenciaIcms ( Activity activity )
      {
        _txtConsultaFiscalDescricaoIncidenciaIcms = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalDescricaoIncidenciaIcms );
      }
      #endregion

      #region Linha 4
      private void BindCodigoFiscal ( Activity activity )
      {
        _txtConsultaFiscalCodigoFiscal = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalCodigoFiscal );
      }

      private void BindContabiliza ( Activity activity )
      {
        _cbxConsultaFiscalContabiliza = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaFiscalContabiliza );
      }

      private void BindCreditoPisCofins ( Activity activity )
      {
        _cbxConsultaFiscalCreditoPisCofins = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaFiscalCreditoPisCofins );
      }
      #endregion

      #region Linha 5
      private void BindCodigoOrigem ( Activity activity )
      {
        _txtConsultaFiscalCodigoOrigem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalCodigoOrigem );
      }

      private void BindDescricaoOrigem ( Activity activity )
      {
        _txtConsultaFiscalDescricaoOrigem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalDescricaoOrigem );
      }

      private void BindCodigoTipoItemSped ( Activity activity )
      {
        _txtConsultaFiscalCodigoTipoItemSped = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalCodigoTipoItemSped );
      }

      private void BindDescricaoTipoItemSped ( Activity activity )
      {
        _txtConsultaFiscalDescricaoTipoItemSped = activity.FindViewById<TextView> ( Resource.Id.txtConsultaFiscalDescricaoTipoItemSped );
      }
      #endregion


      public void Clear ( )
      {

        #region Linha 1
        _txtConsultaFiscalCodigoGrupoDespesa.Text = String.Empty;
        _txtConsultaFiscalDescricaoGrupoDespesa.Text = String.Empty;
        _txtConsultaFiscalContaContabil.Text = String.Empty;
        #endregion

        #region Linha 2
        _txtConsultaFiscalCodigoTipoDespesa.Text = String.Empty;
        _txtConsultaFiscalDescricaoTipoDespesa.Text = String.Empty;
        _txtConsultaFiscalNomeContaContabil.Text = String.Empty;
        #endregion

        #region Linha 3
        _txtConsultaFiscalClassificacaoFiscal.Text = String.Empty;
        _txtConsultaFiscalAliquotaIpi.Text = String.Empty;
        _txtConsultaFiscalDescricaoIncidenciaIpi.Text = String.Empty;
        _txtConsultaFiscalDescricaoIncidenciaIcms.Text = String.Empty;
        #endregion

        #region Linha 4
        _txtConsultaFiscalCodigoFiscal.Text = String.Empty;
        _cbxConsultaFiscalContabiliza.Checked = false;
        _cbxConsultaFiscalCreditoPisCofins.Checked = false;
        #endregion

        #region Linha 5
        _txtConsultaFiscalCodigoOrigem.Text = String.Empty;
        _txtConsultaFiscalDescricaoOrigem.Text = String.Empty;
        _txtConsultaFiscalCodigoTipoItemSped.Text = String.Empty;
        _txtConsultaFiscalDescricaoTipoItemSped.Text = String.Empty;
        #endregion

      }

      public void AtualizaCampos ( VariaveisClasse valor )
      {

        #region Linha 1
        _txtConsultaFiscalCodigoGrupoDespesa.Text = valor.CodigoGrupoDespesa.ToString("###0").Trim ( );
        _txtConsultaFiscalDescricaoGrupoDespesa.Text = valor.DescricaoGrupoDespesa.Trim ( );
        _txtConsultaFiscalContaContabil.Text = valor.ContaContabil.Trim ( );
        #endregion

        #region Linha 2
        _txtConsultaFiscalCodigoTipoDespesa.Text = valor.CodigoTipoDespesa.ToString ( "###0" ).Trim ( );
        _txtConsultaFiscalDescricaoTipoDespesa.Text = valor.DescricaoTipoDespesa.Trim ( );
        _txtConsultaFiscalNomeContaContabil.Text = valor.NomeContaContabil.Trim ( );
        #endregion

        #region Linha 3
        _txtConsultaFiscalClassificacaoFiscal.Text = valor.ClassificacaoFiscal.Trim ( );
        _txtConsultaFiscalAliquotaIpi.Text = valor.AliquotaIpi.ToString("##0.00").Trim ( );
        _txtConsultaFiscalDescricaoIncidenciaIpi.Text = valor.DescricaoIncidenciaIpi.Trim ( );
        _txtConsultaFiscalDescricaoIncidenciaIcms.Text = valor.DescricaoIncidenciaIcms.Trim ( );
        #endregion

        #region Linha 4
        _txtConsultaFiscalCodigoFiscal.Text = valor.CodigoFiscal.Trim ( );
        _cbxConsultaFiscalContabiliza.Checked = valor.Contabiliza;
        _cbxConsultaFiscalCreditoPisCofins.Checked = valor.CreditoPisCofins;
        #endregion

        #region Linha 5
        _txtConsultaFiscalCodigoOrigem.Text = valor.CodigoOrigem.Trim ( );
        _txtConsultaFiscalDescricaoOrigem.Text = valor.DescricaoOrigem.Trim ( );
        _txtConsultaFiscalCodigoTipoItemSped.Text = valor.CodigoTipoItemSped.Trim ( );
        _txtConsultaFiscalDescricaoTipoItemSped.Text = valor.DescricaoTipoItemSped.Trim ( );
        #endregion

      }

    }

    #region Privadas
    private readonly Config    _bcoSql;
    private readonly AcessoSql _acessoSql;
    private Boolean            _ok;
    private Tabela             _consultaFiscal;
    private VariaveisClasse    _variaveis;
    private CamposXml          _camposTela;
    private Item.Classe        _item;
    #endregion

    #region Publicas
    public Tabela Tabela
    {
      get { return _consultaFiscal; }
      set { _consultaFiscal = value; }
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
      CamposTela.LloConsultaFiscalBotoes.Visibility = ViewStates.Invisible;
      CamposTela.Clear ( );
      _ok = _item.Ok;
      if ( _ok )
      {
        PopulaRecord ( _item );
      }
    }

    public void Show ( )
    {
      _camposTela.RloConsultaFiscal.Visibility = ViewStates.Visible;
    }

    public void Hide ( )
    {
      _camposTela.RloConsultaFiscal.Visibility = ViewStates.Gone;
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
