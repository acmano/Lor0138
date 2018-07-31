using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Android.App;
using Android.Views;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lorenzetti.DB;

namespace Lor0138.Classes.Consultas.ConsultaManufatura
{
  public class Classe
  {

    public class VariaveisClasse
    {

      #region Privadas

      #region Linha 1
      private String _codigoUnidadeMedida;
      private String _descricaoUnidadeMedida;
      private Double _fatorConversao;
      #endregion

      #region Linha 2
      private Double _pesoUnitario;
      private Double _pesoEmbalagemVazia;
      private Double _pesoEmbalagem;
      private String _dataCadastro;
      #endregion

      #region Linha 3
      private Boolean _controlaEstoque;
      private String _codigoLocalEstoque;
      private String _descricaoLocalEstoque;
      private String _tipoApontamento;
      #endregion

      #region Linha 4
      private Boolean _controlaInspecao;
      private String _codigoLocalInspecao;
      private String _descricaoLocalInspecao;
      private String _codigoTipoItem;
      private String _descricaoTipoItem;
      #endregion

      #region Linha 5
      private String _codigoFamilia;
      private String _descricaoFamilia;
      private String _codigoSituacao0022;
      private String _descricaoSituacao0022;
      #endregion

      #region Linha 6
      private String _codigoGrupoControleEstoque;
      private String _descricaoGrupoControleEstoque;
      private String _codigoSituacao0770;
      private String _descricaoSituacao0770;
      #endregion

      #region Linha 7
      private String _codigoLinhaProduto;
      private String _descricaoLinhaProduto;
      private String _codigoComponenteCusto;
      private String _descricaoComponenteCusto;
      #endregion

      #region Linha 8
      private String _codigoLinhaReceita;
      private String _descricaoLinhaReceita;
      private Boolean _iqpf;
      #endregion

      #region Linha 9
      private String _codigoSegmentoMercado;
      private String _descricaoSegmentoMercado;
      private Boolean _controlaLote;
      #endregion

      #region Linha 10
      private String _codigoClasseUso;
      private String _descricaoClasseUso;
      private Boolean _produzidoEmpresa;
      #endregion

      #region Linha 11
      private String _descricaoEan13;
      #endregion

      #region Linha 12
      private String _especificacoes;
      #endregion

      #region Linha 13
      private Double _comprimento;
      private Double _largura;
      private Double _altura;
      private Double _volume;
      private Int32 _pecasItem;
      private Int32 _itensCaixa;
      private Int32 _caixasEmbalagem;
      private Int32 _embalagensCamada;
      private Int32 _camadasPalete;
      private Int32 _embalagensPalete;
      #endregion

      #endregion

      #region Públicas

      #region Linha 1
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

      public Double FatorConversao
      {
        get { return _fatorConversao; }
        private set { _fatorConversao = value; }
      }
      #endregion

      #region Linha 2
      public Double PesoUnitario
      {
        get { return _pesoUnitario; }
        private set { _pesoUnitario = value; }
      }

      public Double PesoEmbalagemVazia
      {
        get { return _pesoEmbalagemVazia; }
        private set { _pesoEmbalagemVazia = value; }
      }

      public Double PesoEmbalagem
      {
        get { return _pesoEmbalagem; }
        private set { _pesoEmbalagem = value; }
      }

      public String DataCadastro
      {
        get { return _dataCadastro; }
        private set { _dataCadastro = value; }
      }
      #endregion

      #region Linha 3
      public Boolean ControlaEstoque
      {
        get { return _controlaEstoque; }
        private set { _controlaEstoque = value; }
      }

      public String CodigoLocalEstoque
      {
        get { return _codigoLocalEstoque; }
        private set { _codigoLocalEstoque = value; }
      }

      public String DescricaoLocalEstoque
      {
        get { return _descricaoLocalEstoque; }
        private set { _descricaoLocalEstoque = value; }
      }

      public String TipoApontamento
      {
        get { return _tipoApontamento; }
        private set { _tipoApontamento = value; }
      }
      #endregion

      #region Linha 4
      public Boolean ControlaInspecao
      {
        get { return _controlaInspecao; }
        private set { _controlaInspecao = value; }
      }

      public String CodigoLocalInspecao
      {
        get { return _codigoLocalInspecao; }
        private set { _codigoLocalInspecao = value; }
      }

      public String DescricaoLocalInspecao
      {
        get { return _descricaoLocalInspecao; }
        private set { _descricaoLocalInspecao = value; }
      }

      public String CodigoTipoItem
      {
        get { return _codigoTipoItem; }
        private set { _codigoTipoItem = value; }
      }

      public String DescricaoTipoItem
      {
        get { return _descricaoTipoItem; }
        private set { _descricaoTipoItem = value; }
      }
      #endregion

      #region Linha 5
      public String CodigoFamilia
      {
        get { return _codigoFamilia; }
        private set { _codigoFamilia = value; }
      }

      public String DescricaoFamilia
      {
        get { return _descricaoFamilia; }
        private set { _descricaoFamilia = value; }
      }

      public String CodigoSituacao0022
      {
        get { return _codigoSituacao0022; }
        private set { _codigoSituacao0022 = value; }
      }

      public String DescricaoSituacao0022
      {
        get { return _descricaoSituacao0022; }
        private set { _descricaoSituacao0022 = value; }
      }
      #endregion

      #region Linha 6
      public String CodigoGrupoControleEstoque
      {
        get { return _codigoGrupoControleEstoque; }
        private set { _codigoGrupoControleEstoque = value; }
      }

      public String DescricaoGrupoControleEstoque
      {
        get { return _descricaoGrupoControleEstoque; }
        private set { _descricaoGrupoControleEstoque = value; }
      }

      public String CodigoSituacao0770
      {
        get { return _codigoSituacao0770; }
        private set { _codigoSituacao0770 = value; }
      }

      public String DescricaoSituacao0770
      {
        get { return _descricaoSituacao0770; }
        set { _descricaoSituacao0770 = value; }
      }
      #endregion

      #region Linha 7
      public String CodigoLinhaProduto
      {
        get { return _codigoLinhaProduto; }
        private set { _codigoLinhaProduto = value; }
      }

      public String DescricaoLinhaProduto
      {
        get { return _descricaoLinhaProduto; }
        private set { _descricaoLinhaProduto = value; }
      }

      public String CodigoComponenteCusto
      {
        get { return _codigoComponenteCusto; }
        private set { _codigoComponenteCusto = value; }
      }

      public String DescricaoComponenteCusto
      {
        get { return _descricaoComponenteCusto; }
        private set { _descricaoComponenteCusto = value; }
      }
      #endregion

      #region Linha 8
      public String CodigoLinhaReceita
      {
        get { return _codigoLinhaReceita; }
        private set { _codigoLinhaReceita = value; }
      }

      public String DescricaoLinhaReceita
      {
        get { return _descricaoLinhaReceita; }
        private set { _descricaoLinhaReceita = value; }
      }

      public Boolean Iqpf
      {
        get { return _iqpf; }
        private set { _iqpf = value; }
      }
      #endregion

      #region Linha 9
      public String CodigoSegmentoMercado
      {
        get { return _codigoSegmentoMercado; }
        private set { _codigoSegmentoMercado = value; }
      }

      public String DescricaoSegmentoMercado
      {
        get { return _descricaoSegmentoMercado; }
        private set { _descricaoSegmentoMercado = value; }
      }

      public Boolean ControlaLote
      {
        get { return _controlaLote; }
        private set { _controlaLote = value; }
      }
      #endregion

      #region Linha 10
      public String CodigoClasseUso
      {
        get { return _codigoClasseUso; }
        private set { _codigoClasseUso = value; }
      }

      public String DescricaoClasseUso
      {
        get { return _descricaoClasseUso; }
        private set { _descricaoClasseUso = value; }
      }

      public Boolean ProduzidoEmpresa
      {
        get { return _produzidoEmpresa; }
        private set { _produzidoEmpresa = value; }
      }
      #endregion

      #region Linha 11
      public String DescricaoEan13
      {
        get { return _descricaoEan13; }
        private set { _descricaoEan13 = value; }
      }
      #endregion

      #region Linha 12
      public String Especificacoes
      {
        get { return _especificacoes; }
        private set { _especificacoes = value; }
      }
      #endregion

      #region Linha 13

      public Double Comprimento
      {
        get { return _comprimento; }
        private set { _comprimento = value;}
      }

      public Double Largura
      {
        get { return _largura; }
        private set { _largura = value;}
      }

      public Double Altura
      {
        get { return _altura; }
        private set { _altura = value;}
      }

      public Double Volume
      {
        get { return _volume; }
        private set { _volume = value;}
      }

      public Int32 PecasItem
      {
        get { return _pecasItem; }
        private set { _pecasItem = value;}
      }

      public Int32 ItensCaixa
      {
        get { return _itensCaixa; }
        private set { _itensCaixa = value;}
      }

      public Int32 CaixasEmbalagem
      {
        get { return _caixasEmbalagem; }
        private set { _caixasEmbalagem = value;}
      }

      public Int32 EmbalagensCamada
      {
        get { return _embalagensCamada; }
        private set { _embalagensCamada = value;}
      }

      public Int32 CamadasPalete
      {
        get { return _camadasPalete; }
        private set { _camadasPalete = value;}
      }

      public Int32 EmbalagensPalete
      {
        get { return _embalagensPalete; }
        private set { _embalagensPalete = value;}
      }

      #endregion

      #endregion

      private void Clear ( )
      {

        #region Linha 1
        CodigoUnidadeMedida = String.Empty;
        DescricaoUnidadeMedida = String.Empty;
        FatorConversao = 0.0f;
        #endregion

        #region Linha 2
        PesoUnitario = 0.0f;
        PesoEmbalagemVazia = 0.0f;
        PesoEmbalagem = 0.0f;
        DataCadastro = String.Empty;
        #endregion

        #region Linha 3
        ControlaEstoque = false;
        CodigoLocalEstoque = String.Empty;
        DescricaoLocalEstoque = String.Empty;
        TipoApontamento = String.Empty;
        #endregion

        #region Linha 4
        ControlaInspecao = false;
        CodigoLocalInspecao = String.Empty;
        DescricaoLocalInspecao = String.Empty;
        CodigoTipoItem = String.Empty;
        DescricaoTipoItem = String.Empty;
        #endregion

        #region Linha 5
        CodigoFamilia = String.Empty;
        DescricaoFamilia = String.Empty;
        CodigoSituacao0022 = String.Empty;
        DescricaoSituacao0022 = String.Empty;
        #endregion

        #region Linha 6
        CodigoGrupoControleEstoque = String.Empty;
        DescricaoGrupoControleEstoque = String.Empty;
        CodigoSituacao0770 = String.Empty;
        DescricaoSituacao0770 = String.Empty;
        #endregion

        #region Linha 7
        CodigoLinhaProduto = String.Empty;
        DescricaoLinhaProduto = String.Empty;
        CodigoComponenteCusto = String.Empty;
        DescricaoComponenteCusto = String.Empty;
        #endregion

        #region Linha 8
        CodigoLinhaReceita = String.Empty;
        DescricaoLinhaReceita = String.Empty;
        Iqpf = false;
        #endregion

        #region Linha 9
        CodigoSegmentoMercado = String.Empty;
        DescricaoSegmentoMercado = String.Empty;
        ControlaLote = false;
        #endregion

        #region Linha 10
        CodigoClasseUso = String.Empty;
        DescricaoClasseUso = String.Empty;
        ProduzidoEmpresa = false;
        #endregion

        #region Linha 11
        DescricaoEan13 = String.Empty;
        #endregion

        #region Linha 12
        Especificacoes = String.Empty;
        #endregion

        #region Linha 13
        Comprimento = 0.0f;
        Largura = 0.0f;
        Altura = 0.0f;
        Volume = 0.0f;
        PecasItem = 0;
        ItensCaixa = 0;
        CaixasEmbalagem = 0;
        EmbalagensCamada = 0;
        CamadasPalete = 0;
        EmbalagensPalete = 0;
        #endregion

      }

      public VariaveisClasse ( )
      {
        Clear ( );
      }

      public VariaveisClasse ( DataRow dataRow )
      {

        #region Linha 1
        CodigoUnidadeMedida = DbConvert.GetString ( dataRow, nameof( CodigoUnidadeMedida ) );
        DescricaoUnidadeMedida = DbConvert.GetString ( dataRow, nameof( DescricaoUnidadeMedida ) );
        FatorConversao = DbConvert.GetDouble ( dataRow, nameof( FatorConversao ) );
        #endregion

        #region Linha 2
        PesoUnitario = DbConvert.GetDouble ( dataRow, nameof( PesoUnitario ) );
        PesoEmbalagemVazia = DbConvert.GetDouble ( dataRow, nameof( PesoEmbalagemVazia ) );
        PesoEmbalagem = DbConvert.GetDouble ( dataRow, nameof( PesoEmbalagem ) );
        DataCadastro = DbConvert.GetString ( dataRow, nameof( DataCadastro ) );
        #endregion

        #region Linha 3
        ControlaEstoque = DbConvert.GetBoolean ( dataRow, nameof( ControlaEstoque ) );
        CodigoLocalEstoque = DbConvert.GetString ( dataRow, nameof( CodigoLocalEstoque ) );
        DescricaoLocalEstoque = DbConvert.GetString ( dataRow, nameof( DescricaoLocalEstoque ) );
        TipoApontamento = DbConvert.GetString ( dataRow, nameof( TipoApontamento ) );
        #endregion

        #region Linha 4
        ControlaInspecao = DbConvert.GetBoolean ( dataRow, nameof( ControlaInspecao ) );
        CodigoLocalInspecao = DbConvert.GetString ( dataRow, nameof( CodigoLocalInspecao ) );
        DescricaoLocalInspecao = DbConvert.GetString ( dataRow, nameof( DescricaoLocalInspecao ) );
        CodigoTipoItem = DbConvert.GetString ( dataRow, nameof( CodigoTipoItem ) );
        DescricaoTipoItem = DbConvert.GetString ( dataRow, nameof( DescricaoTipoItem ) );
        #endregion

        #region Linha 5
        CodigoFamilia = DbConvert.GetString ( dataRow, nameof( CodigoFamilia ) );
        DescricaoFamilia = DbConvert.GetString ( dataRow, nameof( DescricaoFamilia ) );
        CodigoSituacao0022 = DbConvert.GetString ( dataRow, nameof( CodigoSituacao0022 ) );
        DescricaoSituacao0022 = DbConvert.GetString ( dataRow, nameof( DescricaoSituacao0022 ) );
        #endregion

        #region Linha 6
        CodigoGrupoControleEstoque = DbConvert.GetString ( dataRow, nameof( CodigoGrupoControleEstoque ) );
        DescricaoGrupoControleEstoque = DbConvert.GetString ( dataRow, nameof( DescricaoGrupoControleEstoque ) );
        CodigoSituacao0770 = DbConvert.GetString ( dataRow, nameof( CodigoSituacao0770 ) );
        DescricaoSituacao0770 = DbConvert.GetString ( dataRow, nameof( DescricaoSituacao0770 ) );
        #endregion

        #region Linha 7
        CodigoLinhaProduto = DbConvert.GetString ( dataRow, nameof( CodigoLinhaProduto ) );
        DescricaoLinhaProduto = DbConvert.GetString ( dataRow, nameof( DescricaoLinhaProduto ) );
        CodigoComponenteCusto = DbConvert.GetString ( dataRow, nameof( CodigoComponenteCusto ) );
        DescricaoComponenteCusto = DbConvert.GetString ( dataRow, nameof( DescricaoComponenteCusto ) );
        #endregion

        #region Linha 8
        CodigoLinhaReceita = DbConvert.GetString ( dataRow, nameof( CodigoLinhaReceita ) );
        DescricaoLinhaReceita = DbConvert.GetString ( dataRow, nameof( DescricaoLinhaReceita ) );
        Iqpf = DbConvert.GetBoolean ( dataRow, nameof( Iqpf ) );
        #endregion

        #region Linha 9
        CodigoSegmentoMercado = DbConvert.GetString ( dataRow, nameof( CodigoSegmentoMercado ) );
        DescricaoSegmentoMercado = DbConvert.GetString ( dataRow, nameof( DescricaoSegmentoMercado ) );
        ControlaLote = DbConvert.GetBoolean ( dataRow, nameof( ControlaLote ) );
        #endregion

        #region Linha 10
        CodigoClasseUso = DbConvert.GetString ( dataRow, nameof( CodigoClasseUso ) );
        DescricaoClasseUso = DbConvert.GetString ( dataRow, nameof( DescricaoClasseUso ) );
        ProduzidoEmpresa = DbConvert.GetBoolean ( dataRow, nameof( ProduzidoEmpresa ) );
        #endregion

        #region Linha 11
        DescricaoEan13 = DbConvert.GetString ( dataRow, nameof( DescricaoEan13 ) );
        #endregion

        #region Linha 12
        Especificacoes = DbConvert.GetString ( dataRow, nameof( Especificacoes ) );
        #endregion

        #region Linha 13
        Comprimento = DbConvert.GetDouble ( dataRow, nameof( Comprimento ) );
        Largura = DbConvert.GetDouble ( dataRow, nameof( Largura ) );
        Altura = DbConvert.GetDouble ( dataRow, nameof( Altura ) );
        Volume = DbConvert.GetDouble ( dataRow, nameof( Volume ) );
        PecasItem = DbConvert.GetInt32 ( dataRow, nameof( PecasItem ) );
        ItensCaixa = DbConvert.GetInt32 ( dataRow, nameof( ItensCaixa ) );
        CaixasEmbalagem = DbConvert.GetInt32 ( dataRow, nameof( CaixasEmbalagem ) );
        EmbalagensCamada = DbConvert.GetInt32 ( dataRow, nameof( EmbalagensCamada ) );
        CamadasPalete = DbConvert.GetInt32 ( dataRow, nameof( CamadasPalete ) );
        EmbalagensPalete = DbConvert.GetInt32 ( dataRow, nameof( EmbalagensPalete ) );
        #endregion

      }

      public VariaveisClasse ( SqlDataReader dataReader = null )
      {
        if ( dataReader != null )
        {

          #region Linha 1
          CodigoUnidadeMedida = DbConvert.GetString ( dataReader, nameof( CodigoUnidadeMedida ) );
          DescricaoUnidadeMedida = DbConvert.GetString ( dataReader, nameof( DescricaoUnidadeMedida ) );
          FatorConversao = DbConvert.GetDouble ( dataReader, nameof( FatorConversao ) );
          #endregion

          #region Linha 2
          PesoUnitario = DbConvert.GetDouble ( dataReader, nameof( PesoUnitario ) );
          PesoEmbalagemVazia = DbConvert.GetDouble ( dataReader, nameof( PesoEmbalagemVazia ) );
          PesoEmbalagem = DbConvert.GetDouble ( dataReader, nameof( PesoEmbalagem ) );
          DataCadastro = DbConvert.GetString ( dataReader, nameof( DataCadastro ) );
          #endregion

          #region Linha 3
          ControlaEstoque = DbConvert.GetBoolean ( dataReader, nameof( ControlaEstoque ) );
          CodigoLocalEstoque = DbConvert.GetString ( dataReader, nameof( CodigoLocalEstoque ) );
          DescricaoLocalEstoque = DbConvert.GetString ( dataReader, nameof( DescricaoLocalEstoque ) );
          TipoApontamento = DbConvert.GetString ( dataReader, nameof( TipoApontamento ) );
          #endregion

          #region Linha 4
          ControlaInspecao = DbConvert.GetBoolean ( dataReader, nameof( ControlaInspecao ) );
          CodigoLocalInspecao = DbConvert.GetString ( dataReader, nameof( CodigoLocalInspecao ) );
          DescricaoLocalInspecao = DbConvert.GetString ( dataReader, nameof( DescricaoLocalInspecao ) );
          CodigoTipoItem = DbConvert.GetString ( dataReader, nameof( CodigoTipoItem ) );
          DescricaoTipoItem = DbConvert.GetString ( dataReader, nameof( DescricaoTipoItem ) );
          #endregion

          #region Linha 5
          CodigoFamilia = DbConvert.GetString ( dataReader, nameof( CodigoFamilia ) );
          DescricaoFamilia = DbConvert.GetString ( dataReader, nameof( DescricaoFamilia ) );
          CodigoSituacao0022 = DbConvert.GetString ( dataReader, nameof( CodigoSituacao0022 ) );
          DescricaoSituacao0022 = DbConvert.GetString ( dataReader, nameof( DescricaoSituacao0022 ) );
          #endregion

          #region Linha 6
          CodigoGrupoControleEstoque = DbConvert.GetString ( dataReader, nameof( CodigoGrupoControleEstoque ) );
          DescricaoGrupoControleEstoque = DbConvert.GetString ( dataReader, nameof( DescricaoGrupoControleEstoque ) );
          CodigoSituacao0770 = DbConvert.GetString ( dataReader, nameof( CodigoSituacao0770 ) );
          DescricaoSituacao0770 = DbConvert.GetString ( dataReader, nameof( DescricaoSituacao0770 ) );
          #endregion

          #region Linha 7
          CodigoLinhaProduto = DbConvert.GetString ( dataReader, nameof( CodigoLinhaProduto ) );
          DescricaoLinhaProduto = DbConvert.GetString ( dataReader, nameof( DescricaoLinhaProduto ) );
          CodigoComponenteCusto = DbConvert.GetString ( dataReader, nameof( CodigoComponenteCusto ) );
          DescricaoComponenteCusto = DbConvert.GetString ( dataReader, nameof( DescricaoComponenteCusto ) );
          #endregion

          #region Linha 8
          CodigoLinhaReceita = DbConvert.GetString ( dataReader, nameof( CodigoLinhaReceita ) );
          DescricaoLinhaReceita = DbConvert.GetString ( dataReader, nameof( DescricaoLinhaReceita ) );
          Iqpf = DbConvert.GetBoolean ( dataReader, nameof( Iqpf ) );
          #endregion

          #region Linha 9
          CodigoSegmentoMercado = DbConvert.GetString ( dataReader, nameof( CodigoSegmentoMercado ) );
          DescricaoSegmentoMercado = DbConvert.GetString ( dataReader, nameof( DescricaoSegmentoMercado ) );
          ControlaLote = DbConvert.GetBoolean ( dataReader, nameof( ControlaLote ) );
          #endregion

          #region Linha 10
          CodigoClasseUso = DbConvert.GetString ( dataReader, nameof( CodigoClasseUso ) );
          DescricaoClasseUso = DbConvert.GetString ( dataReader, nameof( DescricaoClasseUso ) );
          ProduzidoEmpresa = DbConvert.GetBoolean ( dataReader, nameof( ProduzidoEmpresa ) );
          #endregion

          #region Linha 11
          DescricaoEan13 = DbConvert.GetString ( dataReader, nameof( DescricaoEan13 ) );
          #endregion

          #region Linha 12
          Especificacoes = DbConvert.GetString ( dataReader, nameof( Especificacoes ) );
          #endregion

          #region Linha 13
          Comprimento = DbConvert.GetDouble ( dataReader, nameof( Comprimento ) );
          Largura = DbConvert.GetDouble ( dataReader, nameof( Largura ) );
          Altura = DbConvert.GetDouble ( dataReader, nameof( Altura ) );
          Volume = DbConvert.GetDouble ( dataReader, nameof( Volume ) );
          PecasItem = DbConvert.GetInt32 ( dataReader, nameof( PecasItem ) );
          ItensCaixa = DbConvert.GetInt32 ( dataReader, nameof( ItensCaixa ) );
          CaixasEmbalagem = DbConvert.GetInt32 ( dataReader, nameof( CaixasEmbalagem ) );
          EmbalagensCamada = DbConvert.GetInt32 ( dataReader, nameof( EmbalagensCamada ) );
          CamadasPalete = DbConvert.GetInt32 ( dataReader, nameof( CamadasPalete ) );
          EmbalagensPalete = DbConvert.GetInt32 ( dataReader, nameof( EmbalagensPalete ) );
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
      private RelativeLayout _rloConsultaManufatura;
      private LinearLayout _lloConsultaManufaturaBotoes;
      #endregion

      #region Linha 1
      private TextView _txtConsultaManufaturaCodigoUnidadeMedida;
      private TextView _txtConsultaManufaturaDescricaoUnidadeMedida;
      private TextView _txtConsultaManufaturaFatorConversao;
      #endregion

      #region Linha 2
      private TextView _txtConsultaManufaturaPesoUnitario;
      private TextView _txtConsultaManufaturaPesoEmbalagemVazia;
      private TextView _txtConsultaManufaturaPesoEmbalagem;
      private TextView _txtConsultaManufaturaDataCadastro;
      #endregion

      #region Linha 3
      private CheckBox _cbxConsultaManufaturaControlaEstoque;
      private TextView _txtConsultaManufaturaCodigoLocalEstoque;
      private TextView _txtConsultaManufaturaDescricaoLocalEstoque;
      private TextView _txtConsultaManufaturaTipoApontamento;
      #endregion

      #region Linha 4
      private CheckBox _cbxConsultaManufaturaControlaInspecao;
      private TextView _txtConsultaManufaturaCodigoLocalInspecao;
      private TextView _txtConsultaManufaturaDescricaoLocalInspecao;
      private TextView _txtConsultaManufaturaCodigoTipoItem;
      private TextView _txtConsultaManufaturaDescricaoTipoItem;
      #endregion

      #region Linha 5
      private TextView _txtConsultaManufaturaCodigoFamilia;
      private TextView _txtConsultaManufaturaDescricaoFamilia;
      private TextView _txtConsultaManufaturaCodigoSituacao0022;
      private TextView _txtConsultaManufaturaDescricaoSituacao0022;
      #endregion

      #region Linha 6
      private TextView _txtConsultaManufaturaCodigoGrupoControleEstoque;
      private TextView _txtConsultaManufaturaDescricaoGrupoControleEstoque;
      private TextView _txtConsultaManufaturaCodigoSituacao0770;
      private TextView _txtConsultaManufaturaDescricaoSituacao0770;
      #endregion

      #region Linha 7
      private TextView _txtConsultaManufaturaCodigoLinhaProduto;
      private TextView _txtConsultaManufaturaDescricaoLinhaProduto;
      private TextView _txtConsultaManufaturaCodigoComponenteCusto;
      private TextView _txtConsultaManufaturaDescricaoComponenteCusto;
      #endregion

      #region Linha 8
      private TextView _txtConsultaManufaturaCodigoLinhaReceita;
      private TextView _txtConsultaManufaturaDescricaoLinhaReceita;
      private CheckBox _cbxConsultaManufaturaIqpf;
      #endregion

      #region Linha 9
      private TextView _txtConsultaManufaturaCodigoSegmentoMercado;
      private TextView _txtConsultaManufaturaDescricaoSegmentoMercado;
      private CheckBox _cbxConsultaManufaturaControlaLote;
      #endregion

      #region Linha 10
      private TextView _txtConsultaManufaturaCodigoClasseUso;
      private TextView _txtConsultaManufaturaDescricaoClasseUso;
      private CheckBox _cbxConsultaManufaturaProduzidoEmpresa;
      #endregion

      #region Linha 11
      private TextView _txtConsultaManufaturaDescricaoEan13;
      #endregion

      #region Linha 12
      private TextView _txtConsultaManufaturaEspecificacoes;
      #endregion

      #region Linha 13
      private TextView _txtConsultaManufaturaComprimento;
      private TextView _txtConsultaManufaturaLargura;
      private TextView _txtConsultaManufaturaAltura;
      private TextView _txtConsultaManufaturaVolume;
      private TextView _txtConsultaManufaturaPecasItem;
      private TextView _txtConsultaManufaturaItensCaixa;
      private TextView _txtConsultaManufaturaCaixasEmbalagem;
      private TextView _txtConsultaManufaturaEmbalagensCamada;
      private TextView _txtConsultaManufaturaCamadasPalete;
      private TextView _txtConsultaManufaturaEmbalagensPalete;
      #endregion

      #endregion

      #region Públicas

      #region Estrutura
      public RelativeLayout RloConsultaManufatura
      {
        get { return _rloConsultaManufatura; }
        private set { _rloConsultaManufatura = value; }
      }
      public LinearLayout LloConsultaManufaturaBotoes
      {
        get { return _lloConsultaManufaturaBotoes; }
        private set { _lloConsultaManufaturaBotoes = value; }
      }
      #endregion

      #region Linha 1
      public TextView TxtConsultaManufaturaCodigoUnidadeMedida
      {
        get { return _txtConsultaManufaturaCodigoUnidadeMedida; }
        private set { _txtConsultaManufaturaCodigoUnidadeMedida = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoUnidadeMedida
      {
        get { return _txtConsultaManufaturaDescricaoUnidadeMedida; }
        private set { _txtConsultaManufaturaDescricaoUnidadeMedida = value; }
      }
      public TextView TxtConsultaManufaturaFatorConversao
      {
        get { return _txtConsultaManufaturaFatorConversao; }
        private set { _txtConsultaManufaturaFatorConversao = value; }
      }
      #endregion

      #region Linha 2
      public TextView TxtConsultaManufaturaPesoUnitario
      {
        get { return _txtConsultaManufaturaPesoUnitario; }
        private set { _txtConsultaManufaturaPesoUnitario = value; }
      }
      public TextView TxtConsultaManufaturaPesoEmbalagemVazia
      {
        get { return _txtConsultaManufaturaPesoEmbalagemVazia; }
        private set { _txtConsultaManufaturaPesoEmbalagemVazia = value; }
      }
      public TextView TxtConsultaManufaturaPesoEmbalagem
      {
        get { return _txtConsultaManufaturaPesoEmbalagem; }
        private set { _txtConsultaManufaturaPesoEmbalagem = value; }
      }
      public TextView TxtConsultaManufaturaDataCadastro
      {
        get { return _txtConsultaManufaturaDataCadastro; }
        private set { _txtConsultaManufaturaDataCadastro = value; }
      }
      #endregion

      #region Linha 3
      public CheckBox CbxConsultaManufaturaControlaEstoque
      {
        get { return _cbxConsultaManufaturaControlaEstoque; }
        private set { _cbxConsultaManufaturaControlaEstoque = value; }
      }
      public TextView TxtConsultaManufaturaCodigoLocalEstoque
      {
        get { return _txtConsultaManufaturaCodigoLocalEstoque; }
        private set { _txtConsultaManufaturaCodigoLocalEstoque = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoLocalEstoque
      {
        get { return _txtConsultaManufaturaDescricaoLocalEstoque; }
        private set { _txtConsultaManufaturaDescricaoLocalEstoque = value; }
      }
      public TextView TxtConsultaManufaturaTipoApontamento
      {
        get { return _txtConsultaManufaturaTipoApontamento; }
        private set { _txtConsultaManufaturaTipoApontamento = value; }
      }
      #endregion

      #region Linha 4
      public CheckBox CbxConsultaManufaturaControlaInspecao
      {
        get { return _cbxConsultaManufaturaControlaInspecao; }
        private set { _cbxConsultaManufaturaControlaInspecao = value; }
      }
      public TextView TxtConsultaManufaturaCodigoLocalInspecao
      {
        get { return _txtConsultaManufaturaCodigoLocalInspecao; }
        private set { _txtConsultaManufaturaCodigoLocalInspecao = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoLocalInspecao
      {
        get { return _txtConsultaManufaturaDescricaoLocalInspecao; }
        private set { _txtConsultaManufaturaDescricaoLocalInspecao = value; }
      }
      public TextView TxtConsultaManufaturaCodigoTipoItem
      {
        get { return _txtConsultaManufaturaCodigoTipoItem; }
        private set { _txtConsultaManufaturaCodigoTipoItem = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoTipoItem
      {
        get { return _txtConsultaManufaturaDescricaoTipoItem; }
        private set { _txtConsultaManufaturaDescricaoTipoItem = value; }
      }
      #endregion

      #region Linha 5
      public TextView TxtConsultaManufaturaCodigoFamilia
      {
        get { return _txtConsultaManufaturaCodigoFamilia; }
        private set { _txtConsultaManufaturaCodigoFamilia = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoFamilia
      {
        get { return _txtConsultaManufaturaDescricaoFamilia; }
        private set { _txtConsultaManufaturaDescricaoFamilia = value; }
      }
      public TextView TxtConsultaManufaturaCodigoSituacao0022
      {
        get { return _txtConsultaManufaturaCodigoSituacao0022; }
        private set { _txtConsultaManufaturaCodigoSituacao0022 = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoSituacao0022
      {
        get { return _txtConsultaManufaturaDescricaoSituacao0022; }
        private set { _txtConsultaManufaturaDescricaoSituacao0022 = value; }
      }
      #endregion

      #region Linha 6
      public TextView TxtConsultaManufaturaCodigoGrupoControleEstoque
      {
        get
        {
          return _txtConsultaManufaturaCodigoGrupoControleEstoque;
        }
        private set
        {
          _txtConsultaManufaturaCodigoGrupoControleEstoque = value;
        }
      }
      public TextView TxtConsultaManufaturaDescricaoGrupoControleEstoque
      {
        get
        {
          return _txtConsultaManufaturaDescricaoGrupoControleEstoque;
        }
        private set
        {
          _txtConsultaManufaturaDescricaoGrupoControleEstoque = value;
        }
      }
      public TextView TxtConsultaManufaturaCodigoSituacao0770
      {
        get
        {
          return _txtConsultaManufaturaCodigoSituacao0770;
        }
        private set
        {
          _txtConsultaManufaturaCodigoSituacao0770 = value;
        }
      }
      public TextView TxtConsultaManufaturaDescricaoSituacao0770
      {
        get
        {
          return _txtConsultaManufaturaDescricaoSituacao0770;
        }
        private set
        {
          _txtConsultaManufaturaDescricaoSituacao0770 = value;
        }
      }
      #endregion

      #region Linha 7
      public TextView TxtConsultaManufaturaCodigoLinhaProduto
      {
        get { return _txtConsultaManufaturaCodigoLinhaProduto; }
        private set { _txtConsultaManufaturaCodigoLinhaProduto = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoLinhaProduto
      {
        get { return _txtConsultaManufaturaDescricaoLinhaProduto; }
        private set { _txtConsultaManufaturaDescricaoLinhaProduto = value; }
      }
      public TextView TxtConsultaManufaturaCodigoComponenteCusto
      {
        get { return _txtConsultaManufaturaCodigoComponenteCusto; }
        private set { _txtConsultaManufaturaCodigoComponenteCusto = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoComponenteCusto
      {
        get { return _txtConsultaManufaturaDescricaoComponenteCusto; }
        private set { _txtConsultaManufaturaDescricaoComponenteCusto = value; }
      }
      #endregion

      #region Linha 8
      public TextView TxtConsultaManufaturaCodigoLinhaReceita
      {
        get  { return _txtConsultaManufaturaCodigoLinhaReceita; }
        private set { _txtConsultaManufaturaCodigoLinhaReceita = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoLinhaReceita
      {
        get { return _txtConsultaManufaturaDescricaoLinhaReceita; }
        private set { _txtConsultaManufaturaDescricaoLinhaReceita = value; }
      }
      public CheckBox CbxConsultaManufaturaIqpf
      {
        get { return _cbxConsultaManufaturaIqpf; }
        private set { _cbxConsultaManufaturaIqpf = value; }
      }
      #endregion

      #region Linha 9
      public TextView TxtConsultaManufaturaCodigoSegmentoMercado
      {
        get { return _txtConsultaManufaturaCodigoSegmentoMercado; }
        private set { _txtConsultaManufaturaCodigoSegmentoMercado = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoSegmentoMercado
      {
        get { return _txtConsultaManufaturaDescricaoSegmentoMercado; }
        private set { _txtConsultaManufaturaDescricaoSegmentoMercado = value; }
      }
      public CheckBox CbxConsultaManufaturaControlaLote
      {
        get { return _cbxConsultaManufaturaControlaLote; }
        private set { _cbxConsultaManufaturaControlaLote = value; }
      }
      #endregion

      #region Linha 10
      public TextView TxtConsultaManufaturaCodigoClasseUso
      {
        get { return _txtConsultaManufaturaCodigoClasseUso; }
        private set { _txtConsultaManufaturaCodigoClasseUso = value; }
      }
      public TextView TxtConsultaManufaturaDescricaoClasseUso
      {
        get { return _txtConsultaManufaturaDescricaoClasseUso; }
        private set { _txtConsultaManufaturaDescricaoClasseUso = value; }
      }
      public CheckBox CbxConsultaManufaturaProduzidoEmpresa
      {
        get { return _cbxConsultaManufaturaProduzidoEmpresa; }
        private set { _cbxConsultaManufaturaProduzidoEmpresa = value; }
      }
      #endregion

      #region Linha 11
      public TextView TxtConsultaManufaturaDescricaoEan13
      {
        get { return _txtConsultaManufaturaDescricaoEan13; }
        private set { _txtConsultaManufaturaDescricaoEan13 = value; }
      }
      #endregion

      #region Linha 12
      public TextView TxtConsultaManufaturaEspecificacoes
      {
        get
        {
          return _txtConsultaManufaturaEspecificacoes;
        }
        private set
        {
          _txtConsultaManufaturaEspecificacoes = value;
        }
      }
      #endregion

      #region Linha 13
      public TextView TxtConsultaManufaturaComprimento
      {
        get { return _txtConsultaManufaturaComprimento; }
        private set { _txtConsultaManufaturaComprimento = value; }
      }
      public TextView TxtConsultaManufaturaLargura
      {
        get { return _txtConsultaManufaturaLargura; }
        private set { _txtConsultaManufaturaLargura = value; }
      }
      public TextView TxtConsultaManufaturaAltura
      {
        get { return _txtConsultaManufaturaAltura; }
        private set { _txtConsultaManufaturaAltura = value; }
      }
      public TextView TxtConsultaManufaturaVolume
      {
        get { return _txtConsultaManufaturaVolume; }
        private set { _txtConsultaManufaturaVolume = value; }
      }
      public TextView TxtConsultaManufaturaPecasItem
      {
        get { return _txtConsultaManufaturaPecasItem; }
        private set { _txtConsultaManufaturaPecasItem = value; }
      }
      public TextView TxtConsultaManufaturaItensCaixa
      {
        get { return _txtConsultaManufaturaItensCaixa; }
        private set { _txtConsultaManufaturaItensCaixa = value; }
      }
      public TextView TxtConsultaManufaturaCaixasEmbalagem
      {
        get { return _txtConsultaManufaturaCaixasEmbalagem; }
        private set { _txtConsultaManufaturaCaixasEmbalagem = value; }
      }
      public TextView TxtConsultaManufaturaEmbalagensCamada
      {
        get { return _txtConsultaManufaturaEmbalagensCamada; }
        private set { _txtConsultaManufaturaEmbalagensCamada = value; }
      }
      public TextView TxtConsultaManufaturaCamadasPalete
      {
        get { return _txtConsultaManufaturaCamadasPalete; }
        private set { _txtConsultaManufaturaCamadasPalete = value; }
      }
      public TextView TxtConsultaManufaturaEmbalagensPalete
      {
        get { return _txtConsultaManufaturaEmbalagensPalete; }
        private set { _txtConsultaManufaturaEmbalagensPalete = value; }
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
        BindCodigoUnidadeMedida ( activity );
        BindDescricaoUnidadeMedida ( activity );
        BindFatorConversao ( activity );
        #endregion

        #region Linha 2
        BindPesoUnitario ( activity );
        BindPesoEmbalagemVazia ( activity );
        BindPesoEmbalagem ( activity );
        BindDataCadastro ( activity );
        #endregion

        #region Linha 3
        BindControlaEstoque ( activity );
        BindCodigoLocalEstoque ( activity );
        BindDescricaoLocalEstoque ( activity );
        BindTipoApontamento ( activity );
        #endregion

        #region Linha 4
        BindControlaInspecao ( activity );
        BindCodigoLocalInspecao ( activity );
        BindDescricaoLocalInspecao ( activity );
        BindCodigoTipoItem ( activity );
        BindDescricaoTipoItem ( activity );
        #endregion

        #region Linha 5
        BindCodigoFamilia ( activity );
        BindDescricaoFamilia ( activity );
        BindCodigoSituacao0022 ( activity );
        BindDescricaoSituacao0022 ( activity );
        #endregion

        #region Linha 6
        BindCodigoGrupoControleEstoque ( activity );
        BindDescricaoGrupoControleEstoque ( activity );
        BindCodigoSituacao0770 ( activity );
        BindDescricaoSituacao0770 ( activity );
        #endregion

        #region Linha 7
        BindCodigoLinhaProduto ( activity );
        BindDescricaoLinhaProduto ( activity );
        BindCodigoComponenteCusto ( activity );
        BindDescricaoComponenteCusto ( activity );
        #endregion

        #region Linha 8
        BindCodigoLinhaReceita ( activity );
        BindDescricaoLinhaReceita ( activity );
        BindIqpf ( activity );
        #endregion

        #region Linha 9
        BindCodigoSegmentoMercado ( activity );
        BindDescricaoSegmentoMercado ( activity );
        BindControlaLote ( activity );
        #endregion

        #region Linha 10
        BindCodigoClasseUso ( activity );
        BindDescricaoClasseUso ( activity );
        BindProduzidoEmpresa ( activity );
        #endregion

        #region Linha 11
        BindDescricaoEan13 ( activity );
        #endregion

        #region Linha 12
        BindEspecificacoes ( activity );
        #endregion

        #region Linha 13
        BindComprimento ( activity );
        BindLargura ( activity );
        BindAltura ( activity );
        BindVolume ( activity );
        BindPecasItem ( activity );
        BindItensCaixa ( activity );
        BindCaixasEmbalagem ( activity );
        BindEmbalagensCamada ( activity );
        BindCamadasPalete ( activity );
        BindEmbalagensPalete ( activity );
        #endregion

      }

      #region Bind - Estrutura
      private void BindEstrutura ( Activity activity )
      {
        RloConsultaManufatura = activity.FindViewById<RelativeLayout> ( Resource.Id.consultaManufatura );
        LloConsultaManufaturaBotoes = activity.FindViewById<LinearLayout> ( Resource.Id.consultaManufaturaBotoes );
      }
      #endregion

      #region Linha 1
      private void BindCodigoUnidadeMedida ( Activity activity )
      {
        TxtConsultaManufaturaCodigoUnidadeMedida = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoUnidadeMedida );
      }

      private void BindDescricaoUnidadeMedida ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoUnidadeMedida = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoUnidadeMedida );
      }

      private void BindFatorConversao ( Activity activity )
      {
        TxtConsultaManufaturaFatorConversao = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaFatorConversao );
      }
      #endregion

      #region Linha 2
      private void BindPesoUnitario ( Activity activity )
      {
        TxtConsultaManufaturaPesoUnitario = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaPesoUnitario );
      }

      private void BindPesoEmbalagemVazia ( Activity activity )
      {
        TxtConsultaManufaturaPesoEmbalagemVazia = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaPesoEmbalagemVazia );
      }

      private void BindPesoEmbalagem ( Activity activity )
      {
        TxtConsultaManufaturaPesoEmbalagem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaPesoEmbalagem );
      }

      private void BindDataCadastro ( Activity activity )
      {
        TxtConsultaManufaturaDataCadastro = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDataCadastro );
      }
      #endregion

      #region Linha 3
      private void BindControlaEstoque ( Activity activity )
      {
        CbxConsultaManufaturaControlaEstoque = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaManufaturaControlaEstoque );
      }

      private void BindCodigoLocalEstoque ( Activity activity )
      {
        TxtConsultaManufaturaCodigoLocalEstoque = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoLocalEstoque );
      }

      private void BindDescricaoLocalEstoque ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoLocalEstoque = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoLocalEstoque );
      }

      private void BindTipoApontamento ( Activity activity )
      {
        TxtConsultaManufaturaTipoApontamento = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaTipoApontamento );
      }
      #endregion

      #region Linha 4
      private void BindControlaInspecao ( Activity activity )
      {
        CbxConsultaManufaturaControlaInspecao = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaManufaturaControlaInspecao );
      }

      private void BindCodigoLocalInspecao ( Activity activity )
      {
        TxtConsultaManufaturaCodigoLocalInspecao = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoLocalInspecao );
      }

      private void BindDescricaoLocalInspecao ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoLocalInspecao = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoLocalInspecao );
      }

      private void BindCodigoTipoItem ( Activity activity )
      {
        TxtConsultaManufaturaCodigoTipoItem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoTipoItem );
      }

      private void BindDescricaoTipoItem ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoTipoItem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoTipoItem );
      }
      #endregion

      #region Linha 5
      private void BindCodigoFamilia ( Activity activity )
      {
        TxtConsultaManufaturaCodigoFamilia = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoFamilia );
      }

      private void BindDescricaoFamilia ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoFamilia = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoFamilia );
      }

      private void BindCodigoSituacao0022 ( Activity activity )
      {
        TxtConsultaManufaturaCodigoSituacao0022 = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoSituacao0022 );
      }

      private void BindDescricaoSituacao0022 ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoSituacao0022 = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoSituacao0022 );
      }
      #endregion

      #region Linha 6
      private void BindCodigoGrupoControleEstoque ( Activity activity )
      {
        TxtConsultaManufaturaCodigoGrupoControleEstoque = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoGrupoControleEstoque );
      }

      private void BindDescricaoGrupoControleEstoque ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoGrupoControleEstoque = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoGrupoControleEstoque );
      }

      private void BindCodigoSituacao0770 ( Activity activity )
      {
        TxtConsultaManufaturaCodigoSituacao0770 = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoSituacao0770 );
      }

      private void BindDescricaoSituacao0770 ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoSituacao0770 = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoSituacao0770 );
      }
      #endregion

      #region Linha 7
      private void BindCodigoLinhaProduto ( Activity activity )
      {
        TxtConsultaManufaturaCodigoLinhaProduto = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoLinhaProduto );
      }

      private void BindDescricaoLinhaProduto ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoLinhaProduto = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoLinhaProduto );
      }

      private void BindCodigoComponenteCusto ( Activity activity )
      {
        TxtConsultaManufaturaCodigoComponenteCusto = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoComponenteCusto );
      }

      private void BindDescricaoComponenteCusto ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoComponenteCusto = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoComponenteCusto );
      }
      #endregion

      #region Linha 8
      private void BindCodigoLinhaReceita ( Activity activity )
      {
        TxtConsultaManufaturaCodigoLinhaReceita = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoLinhaReceita );
      }

      private void BindDescricaoLinhaReceita ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoLinhaReceita = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoLinhaReceita );
      }

      private void BindIqpf ( Activity activity )
      {
        CbxConsultaManufaturaIqpf = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaManufaturaIqpf );
      }
      #endregion

      #region Linha 9
      private void BindCodigoSegmentoMercado ( Activity activity )
      {
        TxtConsultaManufaturaCodigoSegmentoMercado = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoSegmentoMercado );
      }

      private void BindDescricaoSegmentoMercado ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoSegmentoMercado = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoSegmentoMercado );
      }

      private void BindControlaLote ( Activity activity )
      {
        CbxConsultaManufaturaControlaLote = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaManufaturaControlaLote );
      }
      #endregion

      #region Linha 10
      private void BindCodigoClasseUso ( Activity activity )
      {
        TxtConsultaManufaturaCodigoClasseUso = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCodigoClasseUso );
      }

      private void BindDescricaoClasseUso ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoClasseUso = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoClasseUso );
      }

      private void BindProduzidoEmpresa ( Activity activity )
      {
        CbxConsultaManufaturaProduzidoEmpresa = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsultaManufaturaProduzidoEmpresa );
      }
      #endregion

      #region Linha 11
      private void BindDescricaoEan13 ( Activity activity )
      {
        TxtConsultaManufaturaDescricaoEan13 = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaDescricaoEan13 );
      }
      #endregion

      #region Linha 12
      private void BindEspecificacoes ( Activity activity )
      {
        TxtConsultaManufaturaEspecificacoes = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaEspecificacoes );
      }
      #endregion

      #region Linha 13
      private void BindComprimento ( Activity activity )
      {
        TxtConsultaManufaturaComprimento = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaComprimento );
      }

      private void BindLargura ( Activity activity )
      {
        TxtConsultaManufaturaLargura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaLargura );
      }

      private void BindAltura ( Activity activity )
      {
        TxtConsultaManufaturaAltura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaAltura );
      }

      private void BindVolume ( Activity activity )
      {
        TxtConsultaManufaturaVolume = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaVolume );
      }

      private void BindPecasItem ( Activity activity )
      {
        TxtConsultaManufaturaPecasItem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaPecasItem );
      }

      private void BindItensCaixa ( Activity activity )
      {
        TxtConsultaManufaturaItensCaixa = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaItensCaixa );
      }

      private void BindCaixasEmbalagem ( Activity activity )
      {
        TxtConsultaManufaturaCaixasEmbalagem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCaixasEmbalagem );
      }

      private void BindEmbalagensCamada ( Activity activity )
      {
        TxtConsultaManufaturaEmbalagensCamada = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaEmbalagensCamada );
      }

      private void BindCamadasPalete ( Activity activity )
      {
        TxtConsultaManufaturaCamadasPalete = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaCamadasPalete );
      }

      private void BindEmbalagensPalete ( Activity activity )
      {
        TxtConsultaManufaturaEmbalagensPalete = activity.FindViewById<TextView> ( Resource.Id.txtConsultaManufaturaEmbalagensPalete );
      }
      #endregion


      public void Clear ( )
      {

      #region Linha 1
      _txtConsultaManufaturaCodigoUnidadeMedida.Text = String.Empty;
      _txtConsultaManufaturaDescricaoUnidadeMedida.Text = String.Empty;
      _txtConsultaManufaturaFatorConversao.Text = String.Empty;
      #endregion

      #region Linha 2
      _txtConsultaManufaturaPesoUnitario.Text = String.Empty;
      _txtConsultaManufaturaPesoEmbalagemVazia.Text = String.Empty;
      _txtConsultaManufaturaPesoEmbalagem.Text = String.Empty;
      _txtConsultaManufaturaDataCadastro.Text = String.Empty;
      #endregion

      #region Linha 3
      _cbxConsultaManufaturaControlaEstoque.Checked = false;
      _txtConsultaManufaturaCodigoLocalEstoque.Text = String.Empty;
      _txtConsultaManufaturaDescricaoLocalEstoque.Text = String.Empty;
      _txtConsultaManufaturaTipoApontamento.Text = String.Empty;
      #endregion

      #region Linha 4
      _cbxConsultaManufaturaControlaInspecao.Checked = false;
      _txtConsultaManufaturaCodigoLocalInspecao.Text = String.Empty;
      _txtConsultaManufaturaDescricaoLocalInspecao.Text = String.Empty;
      _txtConsultaManufaturaCodigoTipoItem.Text = String.Empty;
      _txtConsultaManufaturaDescricaoTipoItem.Text = String.Empty;
      #endregion

      #region Linha 5
      _txtConsultaManufaturaCodigoFamilia.Text = String.Empty;
      _txtConsultaManufaturaDescricaoFamilia.Text = String.Empty;
      _txtConsultaManufaturaCodigoSituacao0022.Text = String.Empty;
      _txtConsultaManufaturaDescricaoSituacao0022.Text = String.Empty;
      #endregion

      #region Linha 6
      _txtConsultaManufaturaCodigoGrupoControleEstoque.Text = String.Empty;
      _txtConsultaManufaturaDescricaoGrupoControleEstoque.Text = String.Empty;
      _txtConsultaManufaturaCodigoSituacao0770.Text = String.Empty;
      _txtConsultaManufaturaDescricaoSituacao0770.Text = String.Empty;
      #endregion

      #region Linha 7
      _txtConsultaManufaturaCodigoLinhaProduto.Text = String.Empty;
      _txtConsultaManufaturaDescricaoLinhaProduto.Text = String.Empty;
      _txtConsultaManufaturaCodigoComponenteCusto.Text = String.Empty;
      _txtConsultaManufaturaDescricaoComponenteCusto.Text = String.Empty;
      #endregion

      #region Linha 8
      _txtConsultaManufaturaCodigoLinhaReceita.Text = String.Empty;
      _txtConsultaManufaturaDescricaoLinhaReceita.Text = String.Empty;
      _cbxConsultaManufaturaIqpf.Checked = false;
      #endregion

      #region Linha 9
      _txtConsultaManufaturaCodigoSegmentoMercado.Text = String.Empty;
      _txtConsultaManufaturaDescricaoSegmentoMercado.Text = String.Empty;
      _cbxConsultaManufaturaControlaLote.Checked = false;
      #endregion

      #region Linha 10
      _txtConsultaManufaturaCodigoClasseUso.Text = String.Empty;
      _txtConsultaManufaturaDescricaoClasseUso.Text = String.Empty;
      _cbxConsultaManufaturaProduzidoEmpresa.Checked = false;
      #endregion

      #region Linha 11
      _txtConsultaManufaturaDescricaoEan13.Text = String.Empty;
      #endregion

      #region Linha 12
      _txtConsultaManufaturaEspecificacoes.Text = String.Empty;
      #endregion

      #region Linha 13
      _txtConsultaManufaturaComprimento.Text = String.Empty;
      _txtConsultaManufaturaLargura.Text = String.Empty;
      _txtConsultaManufaturaAltura.Text = String.Empty;
      _txtConsultaManufaturaVolume.Text = String.Empty;
      _txtConsultaManufaturaPecasItem.Text = String.Empty;
      _txtConsultaManufaturaItensCaixa.Text = String.Empty;
      _txtConsultaManufaturaCaixasEmbalagem.Text = String.Empty;
      _txtConsultaManufaturaEmbalagensCamada.Text = String.Empty;
      _txtConsultaManufaturaCamadasPalete.Text = String.Empty;
      _txtConsultaManufaturaEmbalagensPalete.Text = String.Empty;
      #endregion

      }

      public void AtualizaCampos ( VariaveisClasse valor )
      {

        #region Linha 1
        _txtConsultaManufaturaCodigoUnidadeMedida.Text = valor.CodigoUnidadeMedida.Trim();
        _txtConsultaManufaturaDescricaoUnidadeMedida.Text = valor.DescricaoUnidadeMedida.Trim();
        _txtConsultaManufaturaFatorConversao.Text = valor.FatorConversao.ToString("##0.000000").Trim();
        #endregion

        #region Linha 2
        _txtConsultaManufaturaPesoUnitario.Text = valor.PesoUnitario.ToString("##0.0000").Trim();
        _txtConsultaManufaturaPesoEmbalagemVazia.Text = valor.PesoEmbalagemVazia.ToString("##0.0000").Trim();
        _txtConsultaManufaturaPesoEmbalagem.Text = valor.PesoEmbalagem.ToString("##0.0000").Trim();
        _txtConsultaManufaturaDataCadastro.Text = valor.DataCadastro;
        #endregion

        #region Linha 3
        _cbxConsultaManufaturaControlaEstoque.Checked = valor.ControlaEstoque;
        _txtConsultaManufaturaCodigoLocalEstoque.Text = valor.CodigoLocalEstoque.Trim();
        _txtConsultaManufaturaDescricaoLocalEstoque.Text = valor.DescricaoLocalEstoque.Trim();
        _txtConsultaManufaturaTipoApontamento.Text = valor.TipoApontamento;
        #endregion

        #region Linha 4
        _cbxConsultaManufaturaControlaInspecao.Checked = valor.ControlaInspecao;
        _txtConsultaManufaturaCodigoLocalInspecao.Text = valor.CodigoLocalInspecao.Trim();
        _txtConsultaManufaturaDescricaoLocalInspecao.Text = valor.DescricaoLocalInspecao.Trim();
        _txtConsultaManufaturaCodigoTipoItem.Text = valor.CodigoTipoItem.Trim();
        _txtConsultaManufaturaDescricaoTipoItem.Text = valor.DescricaoTipoItem.Trim();
        #endregion

        #region Linha 5
        _txtConsultaManufaturaCodigoFamilia.Text = valor.CodigoFamilia.Trim();
        _txtConsultaManufaturaDescricaoFamilia.Text = valor.DescricaoFamilia.Trim();
        _txtConsultaManufaturaCodigoSituacao0022.Text = valor.CodigoSituacao0022.Trim();
        _txtConsultaManufaturaDescricaoSituacao0022.Text = valor.DescricaoSituacao0022.Trim();
        #endregion

        #region Linha 6
        _txtConsultaManufaturaCodigoGrupoControleEstoque.Text = valor.CodigoGrupoControleEstoque.Trim();
        _txtConsultaManufaturaDescricaoGrupoControleEstoque.Text = valor.DescricaoGrupoControleEstoque.Trim();
        _txtConsultaManufaturaCodigoSituacao0770.Text = valor.CodigoSituacao0770.Trim();
        _txtConsultaManufaturaDescricaoSituacao0770.Text = valor.DescricaoSituacao0770.Trim();
        #endregion

        #region Linha 7
        _txtConsultaManufaturaCodigoLinhaProduto.Text = valor.CodigoLinhaProduto.Trim();
        _txtConsultaManufaturaDescricaoLinhaProduto.Text = valor.DescricaoLinhaProduto.Trim();
        _txtConsultaManufaturaCodigoComponenteCusto.Text = valor.CodigoComponenteCusto.Trim();
        _txtConsultaManufaturaDescricaoComponenteCusto.Text = valor.DescricaoComponenteCusto.Trim();
        #endregion

        #region Linha 8
        _txtConsultaManufaturaCodigoLinhaReceita.Text = valor.CodigoLinhaReceita.Trim();
        _txtConsultaManufaturaDescricaoLinhaReceita.Text = valor.DescricaoLinhaReceita.Trim();
        _cbxConsultaManufaturaIqpf.Checked = valor.Iqpf;
        #endregion

        #region Linha 9
        _txtConsultaManufaturaCodigoSegmentoMercado.Text = valor.CodigoSegmentoMercado.Trim();
        _txtConsultaManufaturaDescricaoSegmentoMercado.Text = valor.DescricaoSegmentoMercado.Trim();
        _cbxConsultaManufaturaControlaLote.Checked = valor.ControlaLote;
        #endregion

        #region Linha 10
        _txtConsultaManufaturaCodigoClasseUso.Text = valor.CodigoClasseUso.Trim();
        _txtConsultaManufaturaDescricaoClasseUso.Text = valor.DescricaoClasseUso.Trim();
        _cbxConsultaManufaturaProduzidoEmpresa.Checked = valor.ProduzidoEmpresa;
        #endregion

        #region Linha 11
        _txtConsultaManufaturaDescricaoEan13.Text = valor.DescricaoEan13.Trim();
        #endregion

        #region Linha 12
        _txtConsultaManufaturaEspecificacoes.Text = valor.Especificacoes.Trim();
        #endregion

        #region Linha 13
        _txtConsultaManufaturaComprimento.Text = valor.Comprimento.ToString ( "#0.000000" ).Trim ( );
        _txtConsultaManufaturaLargura.Text = valor.Largura.ToString ( "#0.000000" ).Trim ( );
        _txtConsultaManufaturaAltura.Text = valor.Altura.ToString ( "#0.000000" ).Trim ( );
        _txtConsultaManufaturaVolume.Text = valor.Volume.ToString ( "#0.000000" ).Trim ( );
        _txtConsultaManufaturaPecasItem.Text = valor.PecasItem.ToString ( "####0" ).Trim ( );
        _txtConsultaManufaturaItensCaixa.Text = valor.ItensCaixa.ToString ( "####0" ).Trim ( );
        _txtConsultaManufaturaCaixasEmbalagem.Text = valor.CaixasEmbalagem.ToString ( "####0" ).Trim ( );
        _txtConsultaManufaturaEmbalagensCamada.Text = valor.EmbalagensCamada.ToString ( "####0" ).Trim ( );
        _txtConsultaManufaturaCamadasPalete.Text = valor.CamadasPalete.ToString ( "####0" ).Trim ( );
        _txtConsultaManufaturaEmbalagensPalete.Text = valor.EmbalagensPalete.ToString ( "####0" ).Trim();
        #endregion


      }

    }

    #region Privadas
    private readonly Config    _bcoSql;
    private readonly AcessoSql _acessoSql;
    private Boolean            _ok;
    private Tabela             _consultaManufatura;
    private VariaveisClasse    _variaveis;
    private CamposXml          _camposTela;
    private Item.Classe        _item;
    #endregion

    #region Publicas
    public Tabela Tabela
    {
      get { return _consultaManufatura; }
      set { _consultaManufatura = value; }
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
      CamposTela.LloConsultaManufaturaBotoes.Visibility = ViewStates.Invisible;
      CamposTela.Clear ( );
      _ok = _item.Ok;
      if ( _ok )
      {
        PopulaRecord ( _item );
      }
    }

    public void Show ( )
    {
      _camposTela.RloConsultaManufatura.Visibility = ViewStates.Visible;
    }

    public void Hide ( )
    {
      _camposTela.RloConsultaManufatura.Visibility = ViewStates.Gone;
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
