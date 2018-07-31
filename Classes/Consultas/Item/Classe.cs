using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Android.App;
using Android.Text;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lorenzetti.DB;

namespace Lor0138.Classes.Consultas.Item
{
  public class Classe
  {

    public class VariaveisClasse
    {
      #region Privadas
      private Boolean      _ok;
      private readonly Config       _bcoSql;
      private readonly AcessoSql    _acessoSql;
      private String       _codigoEmpresa;
      private String       _codigoItem;
      private String       _descricaoItem;
      private String       _codigoUnidadeMedida;
      #endregion

      #region Públicas
      public string CodigoEmpresa
      {
        get { return _codigoEmpresa; }
        private set { _codigoEmpresa = value; }
      }

      public string CodigoItem
      {
        get { return _codigoItem; }
        private set { _codigoItem = value; }
      }

      public string DescricaoItem
      {
        get { return _descricaoItem; }
        private set { _descricaoItem = value; }
      }

      public string CodigoUnidadeMedida
      {
        get { return _codigoUnidadeMedida; }
        private set { _codigoUnidadeMedida = value; }
      }

      public bool Ok
      {
        get
        {
          return _ok;
        }
        private set
        {
          _ok = value;
        }
      }

      #endregion

      private void Clear()
      {
        CodigoEmpresa = String.Empty;
        CodigoItem = String.Empty;
        DescricaoItem = String.Empty;
        CodigoUnidadeMedida = String.Empty;
      }

      public VariaveisClasse()
      {
        Clear ( );
      }

      public VariaveisClasse(DataRow dataRow)
      {
        Clear ( );
        Popula ( dataRow );
      }

      public VariaveisClasse(SqlDataReader dataReader = null)
      {
        Clear ( );
        Popula ( dataReader );
      }

      public VariaveisClasse(Config bcoSql, AcessoSql sql, String codigoEmpresa, String codigoItem)
      {
        Clear ( );
        _bcoSql = bcoSql;
        _acessoSql = sql;
        Popula( codigoEmpresa, codigoItem);
      }

      private void Popula(DataRow dataRow)
      {
        CodigoEmpresa = DbConvert.GetString ( dataRow, nameof( CodigoEmpresa ) );
        CodigoItem = DbConvert.GetString ( dataRow, nameof( CodigoItem ) );
        DescricaoItem = DbConvert.GetString(dataRow, nameof( DescricaoItem ) );
        CodigoUnidadeMedida = DbConvert.GetString(dataRow, nameof( CodigoUnidadeMedida ) );
        Ok = true;
      }

      private void Popula(SqlDataReader dataReader = null)
      {
        if (dataReader != null)
        {
          CodigoEmpresa = DbConvert.GetString ( dataReader, nameof( CodigoEmpresa ) );
          CodigoItem = DbConvert.GetString ( dataReader, nameof( CodigoItem ) );
          DescricaoItem = DbConvert.GetString(dataReader, nameof( DescricaoItem ) );
          CodigoUnidadeMedida = DbConvert.GetString(dataReader, nameof( CodigoUnidadeMedida ) );
          Ok = true;
        }
      }

      private void Popula( String codigoEmpresa, String codigoItem )
      {
        var query = new StringBuilder ( );
        query.AppendFormat ( Sql.Query, _acessoSql.OpenQuery, codigoEmpresa, codigoItem );
        var banco = new Msde ( _acessoSql );
        banco.Open ( );
        var reader = banco.DataReader ( query.ToString ( ) );
        while ( reader.Read ( ) )
        {
          Popula(reader);
          break;
        }
        reader.Close ( );
        reader.Dispose ( );
        banco.Close ( );
      }


    }

    public class CamposXml
    {

      #region Privadas
      private TextView _txtItemCodigoItem;
      private TextView _txtItemDescricaoItem;
      private TextView _txtItemCodigoUnidadeMedida;
      private VariaveisClasse _variaveis;
      #endregion

      #region Públicas
      public Boolean Ok
      {
        get { return !Vazio ( ); }
      }

      public TextView TxtItemCodigoItem
      {
        get { return _txtItemCodigoItem; }
        set { _txtItemCodigoItem = value; }
      }

      public TextView TxtItemDescricaoItem
      {
        get { return _txtItemDescricaoItem; }
        set { _txtItemDescricaoItem = value; }
      }

      public TextView TxtItemCodigoUnidadeMedida
      {
        get { return _txtItemCodigoUnidadeMedida; }
        set { _txtItemCodigoUnidadeMedida = value; }
      }

      public VariaveisClasse Variaveis
      {
        get { return _variaveis; }
        set { _variaveis = value; }
      }
      #endregion

      #region Bind
      private void Bind ( Activity activity )
      {
        BindTxtItemCodigoItem ( activity );
        BindTxtItemDescricaoItem ( activity );
        BindTxtItemCodigoUnidadeMedida ( activity );
      }

      private void BindTxtItemCodigoItem ( Activity activity )
      {
        _txtItemCodigoItem = activity.FindViewById<TextView> ( Resource.Id.txtItemCodigoItem );
        _txtItemCodigoItem.InputType = InputTypes.Null;
      }

      private void BindTxtItemDescricaoItem ( Activity activity )
      {
        _txtItemDescricaoItem = activity.FindViewById<TextView> ( Resource.Id.txtItemDescricaoItem );
        _txtItemDescricaoItem.InputType = InputTypes.Null;
      }

      private void BindTxtItemCodigoUnidadeMedida ( Activity activity )
      {
        _txtItemCodigoUnidadeMedida = activity.FindViewById<TextView> ( Resource.Id.txtItemCodigoUnidadeMedida );
        _txtItemCodigoUnidadeMedida.InputType = InputTypes.Null;
      }
      #endregion

      public void Clear ( )
      {
        try
        {
          _txtItemCodigoItem.Text = String.Empty;
          _txtItemDescricaoItem.Text = String.Empty;
          _txtItemCodigoUnidadeMedida.Text = String.Empty;
        }
        catch (Exception)
        {
          // ignored
        }
      }

      private Boolean Vazio ( )
      {
        return
        (
          String.IsNullOrEmpty ( _txtItemCodigoItem.Text )
          && String.IsNullOrEmpty ( _txtItemDescricaoItem.Text )
          && String.IsNullOrEmpty ( _txtItemCodigoUnidadeMedida.Text )
        );
      }

      public CamposXml ( Activity activity )
      {
        Bind ( activity );
        _variaveis = new VariaveisClasse();
      }

      public CamposXml(Activity activity, VariaveisClasse variaveis)
      {
        Bind(activity);
        _variaveis = variaveis;
        Exibe();
      }

      public void Exibe()
      {
        _txtItemCodigoItem.Text = _variaveis.CodigoItem;
        _txtItemDescricaoItem.Text = _variaveis.DescricaoItem;
        _txtItemCodigoUnidadeMedida.Text = _variaveis.CodigoUnidadeMedida;
      }

    }

    #region Privadas
    private Boolean            _ok;
    private readonly Config    _bcoSql;
    private readonly AcessoSql _acessoSql;
    private CamposXml          _campos;
    #endregion

    #region Públicas
    public bool Ok
    {
      get { return _ok; }
      set { _ok = value; }
    }

    public CamposXml Campos
    {
      get { return _campos; }
      set { _campos = value; }
    }
    #endregion

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity )
    {
      _bcoSql = bcoSql;
      _acessoSql = acessoSql;
      _campos=  new CamposXml(activity);
      Clear ( );
    }

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, DataRow dataRow )
    {
      _bcoSql = bcoSql;
      _acessoSql = acessoSql;
      _campos = new CamposXml(activity);
      Popula ( dataRow );
      _ok = _campos.Variaveis.Ok;
    }

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, SqlDataReader dataReader )
    {
      _bcoSql = bcoSql;
      _acessoSql = acessoSql;
      _campos = new CamposXml(activity);
      Popula ( dataReader );
      _ok = _campos.Variaveis.Ok;
    }

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, String codigoEmpresa, String codigoItem )
    {
      _bcoSql = bcoSql;
      _acessoSql = acessoSql;
      _campos = new CamposXml(activity);
      Popula ( codigoEmpresa, codigoItem );
      _ok = _campos.Variaveis.Ok;
    }

    private void Clear()
    {
      _ok = false;
      _campos.Clear();
    }

    private void Popula(String codigoEmpresa, String codigoItem)
    {
      try
      {
        _campos.Variaveis = new VariaveisClasse( _bcoSql, _acessoSql, codigoEmpresa, codigoItem);
        _ok = true;
      }
      catch (Exception)
      {
        Clear();
      }
    }

    private void Popula(DataRow dataRow)
    {
      try
      {
        _campos.Variaveis = new VariaveisClasse(dataRow);
        _ok = true;
      }
      catch (Exception)
      {
        Clear();
      }
    }

    private void Popula(SqlDataReader dataReader)
    {
      try
      {
        _campos.Variaveis = new VariaveisClasse(dataReader);
        _ok = true;
      }
      catch (Exception)
      {
        Clear();
      }
    }

    public void Exibe()
    {
      _campos.Exibe();
    }

  }
}