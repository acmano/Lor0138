using System;
using Android.App;
using Android.Views;
using Android.OS;
using System.Data.SqlClient;
using System.Text;
using Android.Text;
using Android.Views.InputMethods;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lorenzetti.DB;

namespace Lor0138.Classes.Filtro
{
  public class Classe : Activity
  {

    private class CamposXml
    {
      #region Eventos
      public event EventHandler Pesquisar = ( e, a ) => { };
      public event EventHandler Limpar = ( e, a ) => { };
      #endregion

      #region Privadas
      private Boolean _ok;
      private EditText _txtFiltroCodigoItem;
      private EditText _txtFiltroDescricaoItem;
      private EditText _txtFiltroCodigoTipoItem;
      private EditText _txtFiltroCodigoFamilia;
      private EditText _txtFiltroCodigoGrupoControleEstoque;
      private EditText _txtFiltroCodigoLinhaProduto;
      private EditText _txtFiltroCodigoLinhaReceita;
      private EditText _txtFiltroCodigoSegmentoMercado;
      private EditText _txtFiltroCodigoClasseUso;
      private Button _btnPesquisar;
      private Button _btnLimpar;
      #endregion

      #region Públicas
      public Boolean Ok
      {
        get { return !Vazio(); }
      }

      public EditText TxtFiltroCodigoItem
      {
        get { return _txtFiltroCodigoItem; }
        set { _txtFiltroCodigoItem = value; }
      }

      public EditText TxtFiltroDescricaoItem
      {
        get { return _txtFiltroDescricaoItem; }
        set { _txtFiltroDescricaoItem = value; }
      }

      public EditText TxtFiltroCodigoTipoItem
      {
        get { return _txtFiltroCodigoTipoItem; }
        set { _txtFiltroCodigoTipoItem = value; }
      }

      public EditText TxtFiltroCodigoFamilia
      {
        get { return _txtFiltroCodigoFamilia; }
        set { _txtFiltroCodigoFamilia = value; }
      }

      public EditText TxtFiltroCodigoGrupoControleEstoque
      {
        get { return _txtFiltroCodigoGrupoControleEstoque; }
        set { _txtFiltroCodigoGrupoControleEstoque = value; }
      }

      public EditText TxtFiltroCodigoLinhaProduto
      {
        get { return _txtFiltroCodigoLinhaProduto; }
        set { _txtFiltroCodigoLinhaProduto = value; }
      }

      public EditText TxtFiltroCodigoLinhaReceita
      {
        get { return _txtFiltroCodigoLinhaReceita; }
        set { _txtFiltroCodigoLinhaReceita = value; }
      }

      public EditText TxtFiltroCodigoSegmentoMercado
      {
        get { return _txtFiltroCodigoSegmentoMercado; }
        set { _txtFiltroCodigoSegmentoMercado = value; }
      }

      public EditText TxtFiltroCodigoClasseUso
      {
        get { return _txtFiltroCodigoClasseUso; }
        set { _txtFiltroCodigoClasseUso = value; }
      }

      public Button BtnPesquisar
      {
        get { return _btnPesquisar; }
        set { _btnPesquisar = value; }
      }

      public Button BtnLimpar
      {
        get { return _btnLimpar; }
        set { _btnLimpar = value; }
      }
      #endregion

      #region Bind
      private void Bind( Activity activity )
      {
        BindTxtFiltroCodigoItem(activity);
        BindTxtFiltroDescricaoItem ( activity );
        BindTxtFiltroCodigoTipoItem ( activity );
        BindTxtFiltroCodigoFamilia ( activity );
        BindTxtFiltroCodigoGrupoControleEstoque ( activity );
        BindTxtFiltroCodigoLinhaProduto ( activity );
        BindTxtFiltroCodigoLinhaReceita ( activity );
        BindTxtFiltroCodigoSegmentoMercado ( activity );
        BindTxtFiltroCodigoClasseUso ( activity );
        BindBtnPesquisar ( activity );
        BindBtnLimpar ( activity );
      }

      private void BindTxtFiltroCodigoItem ( Activity activity )
      {
        _txtFiltroCodigoItem = activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoItem );
        _txtFiltroCodigoItem.InputType = InputTypes.ClassPhone;
        _txtFiltroCodigoItem.KeyPress += ( sender, e ) =>
        {
          e.Handled = e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter;
        };
      }

      private void BindTxtFiltroDescricaoItem ( Activity activity )
      {
        _txtFiltroDescricaoItem = activity.FindViewById<EditText> ( Resource.Id.txtFiltroDescricaoItem );
        _txtFiltroDescricaoItem.InputType = InputTypes.ClassText;
        _txtFiltroDescricaoItem.KeyPress += (sender, e) =>
        {
          e.Handled = e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter;
        };
      }

      private void BindTxtFiltroCodigoTipoItem ( Activity activity )
      {
        _txtFiltroCodigoTipoItem = activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoTipoItem );
        _txtFiltroCodigoTipoItem.InputType = InputTypes.ClassText;
        _txtFiltroCodigoTipoItem.KeyPress += (sender, e) =>
        {
          e.Handled = e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter;
        };
      }

      private void BindTxtFiltroCodigoFamilia ( Activity activity )
      {
        _txtFiltroCodigoFamilia = activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoFamilia );
        _txtFiltroCodigoFamilia.InputType = InputTypes.ClassText;
        _txtFiltroCodigoFamilia.KeyPress += (sender, e) =>
        {
          e.Handled = e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter;
        };
      }

      private void BindTxtFiltroCodigoGrupoControleEstoque ( Activity activity )
      {
        _txtFiltroCodigoGrupoControleEstoque = activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoGrupoControleEstoque );
        _txtFiltroCodigoGrupoControleEstoque.InputType = InputTypes.ClassNumber;
        _txtFiltroCodigoGrupoControleEstoque.KeyPress += ( sender, e ) =>
        {
          e.Handled = e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter;
        };
      }

      private void BindTxtFiltroCodigoLinhaProduto ( Activity activity )
      {
        _txtFiltroCodigoLinhaProduto = activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoLinhaProduto );
        _txtFiltroCodigoLinhaProduto.InputType = InputTypes.ClassPhone;
        _txtFiltroCodigoLinhaProduto.KeyPress += ( sender, e ) =>
        {
          e.Handled = e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter;
        };
      }

      private void BindTxtFiltroCodigoLinhaReceita ( Activity activity )
      {
        _txtFiltroCodigoLinhaReceita = activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoLinhaReceita );
        _txtFiltroCodigoLinhaReceita.InputType = InputTypes.ClassPhone;
        _txtFiltroCodigoLinhaReceita.KeyPress += ( sender, e ) =>
        {
          e.Handled = e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter;
        };
      }

      private void BindTxtFiltroCodigoSegmentoMercado ( Activity activity )
      {
        _txtFiltroCodigoSegmentoMercado = activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoSegmentoMercado );
        _txtFiltroCodigoSegmentoMercado.InputType = InputTypes.ClassPhone;
        _txtFiltroCodigoSegmentoMercado.KeyPress += ( sender, e ) =>
        {
          e.Handled = e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter;
        };
      }

      private void BindTxtFiltroCodigoClasseUso ( Activity activity )
      {
        _txtFiltroCodigoClasseUso = activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoClasseUso );
        _txtFiltroCodigoClasseUso.InputType = InputTypes.ClassPhone;
        _txtFiltroCodigoClasseUso.KeyPress += ( sender, e ) =>
        {
          e.Handled = e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter;
        };
      }

      private void BindBtnPesquisar ( Activity activity )
      {
        _btnPesquisar = activity.FindViewById<Button> ( Resource.Id.btnPesquisar );
        _btnPesquisar.Click += delegate
        {
          Pesquisar(this, EventArgs.Empty);
        };
      }

      private void BindBtnLimpar ( Activity activity )
      {
        _btnLimpar = activity.FindViewById<Button> ( Resource.Id.btnLimpar );
        _btnLimpar.Click += delegate
        {
          Clear();
          Limpar ( this, EventArgs.Empty );
        };
      }
      #endregion

      public void Clear()
      {
        _txtFiltroCodigoItem.Text = String.Empty;
        _txtFiltroDescricaoItem.Text = String.Empty;
        _txtFiltroCodigoTipoItem.Text = String.Empty;
        _txtFiltroCodigoFamilia.Text = String.Empty;
        _txtFiltroCodigoGrupoControleEstoque.Text = String.Empty;
        _txtFiltroCodigoLinhaProduto.Text = String.Empty;
        _txtFiltroCodigoLinhaReceita.Text = String.Empty;
        _txtFiltroCodigoSegmentoMercado.Text = String.Empty;
        _txtFiltroCodigoClasseUso.Text = String.Empty;
      }

      public Boolean Vazio()
      {
        return
        (
           String.IsNullOrEmpty ( _txtFiltroCodigoItem.Text )
        && String.IsNullOrEmpty ( _txtFiltroDescricaoItem.Text )
        && String.IsNullOrEmpty ( _txtFiltroCodigoTipoItem.Text )
        && String.IsNullOrEmpty ( _txtFiltroCodigoFamilia.Text )
        && String.IsNullOrEmpty ( _txtFiltroCodigoGrupoControleEstoque.Text )
        && String.IsNullOrEmpty ( _txtFiltroCodigoLinhaProduto.Text )
        && String.IsNullOrEmpty ( _txtFiltroCodigoLinhaReceita.Text )
        && String.IsNullOrEmpty ( _txtFiltroCodigoSegmentoMercado.Text )
        && String.IsNullOrEmpty ( _txtFiltroCodigoClasseUso.Text )
        );
      }

      public CamposXml ( Activity activity )
      {
        Bind ( activity );
        Clear();
      }

    }

    #region Privadas
    private Boolean               _ok;
    private CamposXml             _campos;
    private Config                _bcoSql;
    private AcessoSql             _acessoSql;
    private String                _codigoEmpresa;
    private Activity              _activityMestre;
    private Consultas.Item.Classe _item;
    private readonly Activity     _activity;
    private ProgressDialog        _progress;
    private Button                _btnPesquisar;
    private Button                _btnLimpar;
    private static PopUp          _popUp;
    private ProgressDialogTask    _task;
    private Msde                  _banco;
    private SqlDataReader         _reader;
    private Int32                 _dataReaderRowsCount;
    #endregion

    #region Públicas
    public bool Ok
    {
      get { return _ok; }
      set { _ok = value; }
    }

    public Consultas.Item.Classe Item
    {
      set { _item = value; }
      get { return _item; }
    }

    public string FiltroQuery
    {
      get { return FiltroQueryString ( ); }
    }
    #endregion

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, String codigoEmpresa )
    {
      _activity = activity;
      _bcoSql = bcoSql;
      _acessoSql = acessoSql;
      _codigoEmpresa = codigoEmpresa;
      InitCampos ( );
      Clear ( );
    }

    private void InitCampos()
    {
      _item = new Consultas.Item.Classe ( _bcoSql, _acessoSql, _activity );
      _campos = new CamposXml ( _activity );
      _campos.Pesquisar += delegate { Pesquisar ( ); };
      _campos.Limpar += delegate { Limpar(); };
    }

    public event EventHandler ObtemItem = new EventHandler ( ( e, a ) => { } );

    public event EventHandler PesquisaOk = new EventHandler((e, a) => { });

    private String FiltroQueryString ( )
    {
      var filtro = new StringBuilder ( );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoEmpresa, _codigoEmpresa ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoItem, _campos.TxtFiltroCodigoItem.Text ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroDescricaoItem, _campos.TxtFiltroDescricaoItem.Text  ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoTipoItem, _campos.TxtFiltroCodigoTipoItem.Text ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoFamilia, _campos.TxtFiltroCodigoFamilia.Text ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroGrupoControleEstoque, _campos.TxtFiltroCodigoGrupoControleEstoque.Text ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoLinhaProduto, _campos.TxtFiltroCodigoLinhaProduto.Text ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoLinhaReceita, _campos.TxtFiltroCodigoLinhaReceita.Text ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoSegmentoMercado, _campos.TxtFiltroCodigoSegmentoMercado.Text ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoClasseUso, _campos.TxtFiltroCodigoClasseUso.Text ) );
      return filtro.ToString ( );
    }

    private String FiltroMonta ( String mascara, String valor )
    {
      var filtroParcial = new StringBuilder ( );
      filtroParcial.Clear ( );
      if ( !String.IsNullOrEmpty ( valor ) )
      {
        filtroParcial.AppendFormat ( mascara, valor.Trim ( ).ToUpper ( ) );
      }
      return ( filtroParcial.ToString ( ) );
    }

    private void Clear ( )
    {
      _campos.Clear();
    }

    private void Pesquisar ( )
    {
      if ( _activity.CurrentFocus != null )
      {
        HideSoftKeyboard ( _activity, _activity.CurrentFocus.WindowToken );
      }
      if ( _campos.Vazio ( ) )
      {
        var tools = new Tools();
        tools.QuestionMessageBox(_activity, ThreadingPesquisar, "Excesso de resultados",
          "Não foi informado nenhum critério de pesquisa. Serão exibidos muitos itens. Confirma a pesquisa?");
      }
      else
      {
        ThreadingPesquisar ( );
      }
    }

    private bool ThreadingPesquisar ( )
    {
      _progress = new ProgressDialog ( _activity )
      {
        Indeterminate = false
      };
      _progress.SetCancelable ( false );
      _progress.SetMessage ( "Aguarde, pesquisando itens ..." );
      _progress.Show ( );
      _task = new ProgressDialogTask
      {
        RunInBackgroundMethod = PesquisaExecuta
      , OnPostExecuteMethod = PesquisaFinaliza
      };
      _task.Execute ( );
      return (true);
    }

    private Boolean PesquisaExecuta ( )
    {
      var query = new StringBuilder ( );
      query.AppendFormat ( Sql.QueryItem, _acessoSql.OpenQuery, FiltroQuery );
      _banco = new Msde ( _acessoSql );
      _banco.Open ( );
      _reader = _banco.DataReader ( query.ToString ( ) );
      _dataReaderRowsCount = 0;
      while (_reader.Read())
      {
        _dataReaderRowsCount++;
      }
      _reader.Close();
      _reader = _banco.DataReader ( query.ToString ( ) );
      return ( true );
    }

    private Boolean PesquisaFinaliza ( )
    {
      _progress.Dismiss ( );
      if ( _dataReaderRowsCount > 1 )
      {
        _popUp = new PopUp ( _bcoSql, _acessoSql, _activity, FiltroQuery );
        _popUp.ObtemItemPopUp += delegate
        {
          ObtemItemPopUp ( );
        };
        _popUp.Exibe ( _campos.TxtFiltroCodigoItem );
      }
      else
      {
        if (_reader.Read())
        {
          ThreadingExibir ( );
        }
      }
      _task = null;
      return ( true );
    }

    private void ObtemItemPopUp()
    {
      _item = _popUp.Item;
      ObtemItem(this, EventArgs.Empty);
      PesquisaOk ( this, EventArgs.Empty );
    }

    private void ThreadingExibir ( )
    {
      _progress = new ProgressDialog ( _activity )
      {
        Indeterminate = false
      };
      _progress.SetCancelable ( false );
      _progress.SetMessage ( "Aguarde, exibindo item ..." );
      _progress.Show ( );
      _task = new ProgressDialogTask
      {
        RunInBackgroundMethod = ExibeExecuta
      , OnPostExecuteMethod = ExibeFinaliza
      };
      _task.Execute ( );
    }

    private Boolean ExibeExecuta ( )
    {
      _item = new Consultas.Item.Classe(_bcoSql, _acessoSql, _activity, _reader);
      return ( true );
    }

    private Boolean ExibeFinaliza ( )
    {
      _progress.Dismiss ( );
      _reader.Close ( );
      _reader.Dispose ( );
      _banco.Close ( );
      ObtemItem ( this, EventArgs.Empty );
      PesquisaOk(this, EventArgs.Empty);
      return ( true );
    }

    public void Limpar ( )
    {
      if ( _activity.CurrentFocus != null )
      {
        HideSoftKeyboard ( _activity, _activity.CurrentFocus.WindowToken );
      }
      Clear ( );
    }

    private void HideSoftKeyboard ( Activity activity, IBinder windowToken )
    {
      var inputMethodManager = ( InputMethodManager )activity.GetSystemService ( InputMethodService );
      inputMethodManager.HideSoftInputFromWindow ( windowToken, 0 );
    }

  }
}