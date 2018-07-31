using System;
using System.Data;
using System.Data.SqlClient;

namespace Lor0138.Classes.Comum
{
  public class ItemAtual
  {

    private Boolean _ok;
    private String _codigoEmpresa;
    private String _codigoItem;

    public bool Ok
    {
      get
      {
        return _ok;
      }
      set
      {
        _ok = value;
      }
    }

    public string CodigoEmpresa
    {
      get
      {
        return _codigoEmpresa;
      }
      set
      {
        _codigoEmpresa = value;
      }
    }

    public string CodigoItem
    {
      get
      {
        return _codigoItem;
      }
      set
      {
        _codigoItem = value;
      }
    }

    public ItemAtual ( )
    {
      Clear();
    }

    public ItemAtual ( String codigoEmpresa, String codigoItem )
    {
      Popula( codigoEmpresa, codigoItem );
    }

    public void Clear()
    {
      Ok = false;
      CodigoEmpresa = String.Empty;
      CodigoItem = String.Empty;
    }

    public void Popula(String codigoEmpresa, String codigoItem)
    {
      try
      {
        CodigoEmpresa = codigoEmpresa;
        CodigoItem = codigoItem;
        Ok = true;
      }
      catch (Exception)
      {
        Clear();
      }
    }

    public void Popula(DataRow dataRow)
    {
      try
      {
        CodigoEmpresa = DbConvert.GetString ( dataRow, "CodigoEmpresa" );
        CodigoItem = DbConvert.GetString ( dataRow, "CodigoItem" );
        Ok = true;
      }
      catch (Exception)
      {
        Clear();
      }
    }

    public void Popula(SqlDataReader dataReader)
    {
      try
      {
        CodigoEmpresa = DbConvert.GetString ( dataReader, "CodigoEmpresa" );
        CodigoItem = DbConvert.GetString ( dataReader, "CodigoItem" );
        Ok = true;
      }
      catch (Exception)
      {
        Clear();
      }
    }


  }
}