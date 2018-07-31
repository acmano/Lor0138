using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Android.App;
using Android.Views;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lor0138.Classes.Consultas.Item;
using Lorenzetti.DB;

namespace Lor0138.Classes.Consultas.ConsultaDimensionais
{
  public class Classe
  {

    public class VariaveisClasse
    {

      #region Privadas
      #region Linha 1
      private Int32 _quantidadePecasItem;
      private Int32 _quantidadeItensCaixa;
      #endregion

      #region Linha 2
      private Double _produtoComprimento;
      private Double _produtoLargura;
      private Double _produtoAltura;
      #endregion

      #region Linha 3
      private Double _produtoPeso;
      private Double _produtoVolume;
      private Double _produtoVolumeAdicional;
      #endregion

      #region Linha 4
      private Int32 _QuantidadeEmbalagensVendaVarejo;
      #endregion

      #region Linha 5
      private Double _embalagemComprimento;
      private Double _embalagemLargura;
      private Double _embalagemAltura;
      #endregion

      #region Linha 6
      private Double _embalagemPesoVazia;
      private Double _embalagemPesoCheia;
      private Double _embalagemVolume;
      #endregion

      #region Linha 7
      private Int32 _paleteQuantidadeCaixasCamada;
      private Int32 _paleteQuantidadeCamadas;
      #endregion

      #region Linha 8
      private Int32 _paleteQuantidadeCaixasColetivas;
      #endregion

      #region Linha 9
      private Int32 _paleteQuantidadeEmbalagensVendaVarejo;
      private Double _paletePeso;
      #endregion

      #endregion

      #region Públicas

      #region Linha 1
      public Int32 QuantidadePecasItem
      {
        get
        {
          return _quantidadePecasItem;
        }
        private set
        {
          _quantidadePecasItem = value;
        }
      }

      public Int32 QuantidadeItensCaixa
      {
        get
        {
          return _quantidadeItensCaixa;
        }
        private set
        {
          _quantidadeItensCaixa = value;
        }
      }
      #endregion

      #region Linha 2
      public Double ProdutoComprimento
      {
        get
        {
          return _produtoComprimento;
        }
        private set
        {
          _produtoComprimento = value;
        }
      }

      public Double ProdutoLargura
      {
        get
        {
          return _produtoLargura;
        }
        private set
        {
          _produtoLargura = value;
        }
      }

      public Double ProdutoAltura
      {
        get
        {
          return _produtoAltura;
        }
        private set
        {
          _produtoAltura = value;
        }
      }
      #endregion

      #region Linha 3
      public Double ProdutoPeso
      {
        get
        {
          return _produtoPeso;
        }
        private set
        {
          _produtoPeso = value;
        }
      }

      public Double ProdutoVolume
      {
        get
        {
          return _produtoVolume;
        }
        private set
        {
          _produtoVolume = value;
        }
      }

      public Double ProdutoVolumeAdicional
      {
        get
        {
          return _produtoVolumeAdicional;
        }
        private set
        {
          _produtoVolumeAdicional = value;
        }
      }
      #endregion

      #region Linha 4
      public Int32 QuantidadeEmbalagensVendaVarejo
      {
        get
        {
          return _QuantidadeEmbalagensVendaVarejo;
        }
        private set
        {
          _QuantidadeEmbalagensVendaVarejo = value;
        }
      }
      #endregion

      #region Linha 5
      public Double EmbalagemComprimento
      {
        get
        {
          return _embalagemComprimento;
        }
        private set
        {
          _embalagemComprimento = value;
        }
      }

      public Double EmbalagemLargura
      {
        get
        {
          return _embalagemLargura;
        }
        private set
        {
          _embalagemLargura = value;
        }
      }

      public Double EmbalagemAltura
      {
        get
        {
          return _embalagemAltura;
        }
        private set
        {
          _embalagemAltura = value;
        }
      }
      #endregion

      #region Linha 6
      public Double EmbalagemPesoVazia
      {
        get
        {
          return _embalagemPesoVazia;
        }
        private set
        {
          _embalagemPesoVazia = value;
        }
      }

      public Double EmbalagemPesoCheia
      {
        get
        {
          return _embalagemPesoCheia;
        }
        private set
        {
          _embalagemPesoCheia = value;
        }
      }

      public Double EmbalagemVolume
      {
        get
        {
          return _embalagemVolume;
        }
        private set
        {
          _embalagemVolume = value;
        }
      }
      #endregion

      #region Linha 7
      public Int32 PaleteQuantidadeCaixasCamada
      {
        get
        {
          return _paleteQuantidadeCaixasCamada;
        }
        private set
        {
          _paleteQuantidadeCaixasCamada = value;
        }
      }

      public Int32 PaleteQuantidadeCamadas
      {
        get
        {
          return _paleteQuantidadeCamadas;
        }
        private set
        {
          _paleteQuantidadeCamadas = value;
        }
      }
      #endregion

      #region Linha 8
      public Int32 PaleteQuantidadeCaixasColetivas
      {
        get
        {
          return _paleteQuantidadeCaixasColetivas;
        }
        private set
        {
          _paleteQuantidadeCaixasColetivas = value;
        }
      }
      #endregion

      #region Linha 9
      public Int32 PaleteQuantidadeEmbalagensVendaVarejo
      {
        get
        {
          return _paleteQuantidadeEmbalagensVendaVarejo;
        }
        private set
        {
          _paleteQuantidadeEmbalagensVendaVarejo = value;
        }
      }

      public Double PaletePeso
      {
        get
        {
          return _paletePeso;
        }
        private set
        {
          _paletePeso = value;
        }
      }
      #endregion

      #endregion

      private void Clear ( )
      {

        #region Linha 1
        QuantidadePecasItem = 0;
        QuantidadeItensCaixa = 0;
        #endregion

        #region Linha 2
        ProdutoComprimento = 0.0f;
        ProdutoLargura = 0.0f;
        ProdutoAltura = 0.0f;
        #endregion

        #region Linha 3
        ProdutoPeso = 0.0f;
        ProdutoVolume = 0.0f;
        ProdutoVolumeAdicional = 0.0f;
        #endregion

        #region Linha 4
        QuantidadeEmbalagensVendaVarejo = 0;
        #endregion

        #region Linha 5
        EmbalagemComprimento = 0.0f;
        EmbalagemLargura = 0.0f;
        #endregion

        #region Linha 6
        EmbalagemPesoVazia = 0.0f;
        EmbalagemPesoCheia = 0.0f;
        EmbalagemVolume = 0.0f;
        #endregion

        #region Linha 7
        PaleteQuantidadeCaixasCamada = 0;
        PaleteQuantidadeCamadas = 0;
        #endregion

        #region Linha 8
        PaleteQuantidadeCaixasColetivas = 0;
        #endregion

        #region Linha 9
        PaleteQuantidadeEmbalagensVendaVarejo = 0;
        PaletePeso = 0;
        #endregion

      }

      public VariaveisClasse ( )
      {
        Clear ( );
      }

      public VariaveisClasse ( DataRow dataRow )
      {

        #region Linha 1
        QuantidadePecasItem = DbConvert.GetInt32 ( dataRow, nameof( QuantidadePecasItem ) );
        QuantidadeItensCaixa = DbConvert.GetInt32 ( dataRow, nameof( QuantidadeItensCaixa ) );
        #endregion

        #region Linha 2
        ProdutoComprimento = DbConvert.GetDouble ( dataRow, nameof( ProdutoComprimento ) );
        ProdutoLargura = DbConvert.GetDouble ( dataRow, nameof( ProdutoLargura ) );
        ProdutoAltura = DbConvert.GetDouble ( dataRow, nameof( ProdutoAltura ) );
        #endregion

        #region Linha 3
        ProdutoPeso = DbConvert.GetDouble ( dataRow, nameof( ProdutoPeso ) );
        ProdutoVolume = DbConvert.GetDouble ( dataRow, nameof( ProdutoVolume ) );
        ProdutoVolumeAdicional = DbConvert.GetDouble ( dataRow, nameof( ProdutoVolumeAdicional ) );
        #endregion

        #region Linha 4
        QuantidadeEmbalagensVendaVarejo = DbConvert.GetInt32 ( dataRow, nameof( QuantidadeEmbalagensVendaVarejo ) );
        #endregion

        #region Linha 5
        EmbalagemComprimento = DbConvert.GetDouble ( dataRow, nameof( EmbalagemComprimento ) );
        EmbalagemLargura = DbConvert.GetDouble ( dataRow, nameof( EmbalagemLargura ) );
        #endregion

        #region Linha 6
        EmbalagemPesoVazia = DbConvert.GetDouble ( dataRow, nameof( EmbalagemPesoVazia ) );
        EmbalagemPesoCheia = DbConvert.GetDouble ( dataRow, nameof( EmbalagemPesoCheia ) );
        EmbalagemVolume = DbConvert.GetDouble ( dataRow, nameof( EmbalagemVolume ) );
        #endregion

        #region Linha 7
        PaleteQuantidadeCaixasCamada = DbConvert.GetInt32 ( dataRow, nameof( PaleteQuantidadeCaixasCamada ) );
        PaleteQuantidadeCamadas = DbConvert.GetInt32 ( dataRow, nameof( PaleteQuantidadeCamadas ) );
        #endregion

        #region Linha 8
        PaleteQuantidadeCaixasColetivas = DbConvert.GetInt32 ( dataRow, nameof( PaleteQuantidadeCaixasColetivas ) );
        #endregion

        #region Linha 9
        PaleteQuantidadeEmbalagensVendaVarejo = DbConvert.GetInt32 ( dataRow, nameof( PaleteQuantidadeEmbalagensVendaVarejo ) );
        PaletePeso = DbConvert.GetDouble ( dataRow, nameof( PaletePeso ) );
        #endregion

      }

      public VariaveisClasse ( SqlDataReader dataReader = null )
      {
        if ( dataReader != null )
        {

          #region Linha 1
          QuantidadePecasItem = DbConvert.GetInt32 ( dataReader, nameof( QuantidadePecasItem ) );
          QuantidadeItensCaixa = DbConvert.GetInt32 ( dataReader, nameof( QuantidadeItensCaixa ) );
          #endregion

          #region Linha 2
          ProdutoComprimento = DbConvert.GetDouble ( dataReader, nameof( ProdutoComprimento ) );
          ProdutoLargura = DbConvert.GetDouble ( dataReader, nameof( ProdutoLargura ) );
          ProdutoAltura = DbConvert.GetDouble ( dataReader, nameof( ProdutoAltura ) );
          #endregion

          #region Linha 3
          ProdutoPeso = DbConvert.GetDouble ( dataReader, nameof( ProdutoPeso ) );
          ProdutoVolume = DbConvert.GetDouble ( dataReader, nameof( ProdutoVolume ) );
          ProdutoVolume = DbConvert.GetDouble ( dataReader, nameof( ProdutoVolume ) );
          #endregion

          #region Linha 4
          QuantidadeEmbalagensVendaVarejo = DbConvert.GetInt32 ( dataReader, nameof( QuantidadeEmbalagensVendaVarejo ) );
          #endregion

          #region Linha 5
          EmbalagemComprimento = DbConvert.GetDouble ( dataReader, nameof( EmbalagemComprimento ) );
          EmbalagemLargura = DbConvert.GetDouble ( dataReader, nameof( EmbalagemLargura ) );
          #endregion

          #region Linha 6
          EmbalagemPesoVazia = DbConvert.GetDouble ( dataReader, nameof( EmbalagemPesoVazia ) );
          EmbalagemPesoCheia = DbConvert.GetDouble ( dataReader, nameof( EmbalagemPesoCheia ) );
          EmbalagemVolume = DbConvert.GetDouble ( dataReader, nameof( EmbalagemVolume ) );
          #endregion

          #region Linha 7
          PaleteQuantidadeCaixasCamada = DbConvert.GetInt32 ( dataReader, nameof( PaleteQuantidadeCaixasCamada ) );
          PaleteQuantidadeCamadas = DbConvert.GetInt32 ( dataReader, nameof( PaleteQuantidadeCamadas ) );
          #endregion

          #region Linha 8
          PaleteQuantidadeCaixasColetivas = DbConvert.GetInt32 ( dataReader, nameof( PaleteQuantidadeCaixasColetivas ) );
          #endregion

          #region Linha 9
          PaleteQuantidadeEmbalagensVendaVarejo = DbConvert.GetInt32 ( dataReader, nameof( PaleteQuantidadeEmbalagensVendaVarejo ) );
          PaletePeso = DbConvert.GetDouble ( dataReader, nameof( PaletePeso ) );
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
      private RelativeLayout _rloConsultaDimensionais;
      private LinearLayout _lloConsultaDimensionaisBotoes;
      #endregion

      #region Linha 1
      private TextView _txtConsultaDimensionaisQuantidadePecasItem;
      private TextView _txtConsultaDimensionaisQuantidadeItensCaixa;
      #endregion

      #region Linha 2
      private TextView _txtConsultaDimensionaisProdutoComprimento;
      private TextView _txtConsultaDimensionaisProdutoLargura;
      private TextView _txtConsultaDimensionaisProdutoAltura;
      #endregion

      #region Linha 3
      private TextView _txtConsultaDimensionaisProdutoPeso;
      private TextView _txtConsultaDimensionaisProdutoVolume;
      private TextView _txtConsultaDimensionaisProdutoVolumeAdicional;
      #endregion

      #region Linha 4
      private TextView _txtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo;
      #endregion

      #region Linha 5
      private TextView _txtConsultaDimensionaisEmbalagemComprimento;
      private TextView _txtConsultaDimensionaisEmbalagemLargura;
      private TextView _txtConsultaDimensionaisEmbalagemAltura;
      #endregion

      #region Linha 6
      private TextView _txtConsultaDimensionaisEmbalagemPesoVazia;
      private TextView _txtConsultaDimensionaisEmbalagemPesoCheia;
      private TextView _txtConsultaDimensionaisEmbalagemVolume;
      #endregion

      #region Linha 7
      private TextView _txtConsultaDimensionaisPaleteQuantidadeCaixasCamada;
      private TextView _txtConsultaDimensionaisPaleteQuantidadeCamadas;
      #endregion

      #region Linha 8
      private TextView _txtConsultaDimensionaisPaleteQuantidadeCaixasColetivas;
      #endregion

      #region Linha 9
      private TextView _txtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo;
      private TextView _txtConsultaDimensionaisPaletePeso;
      #endregion

      #endregion

      #region Públicas

      #region Estrutura
      public RelativeLayout RloConsultaDimensionais
      {
        get { return _rloConsultaDimensionais; }
        set { _rloConsultaDimensionais = value; }
      }
      public LinearLayout LloConsultaDimensionaisBotoes
      {
        get
        {
          return _lloConsultaDimensionaisBotoes;
        }
        set
        {
          _lloConsultaDimensionaisBotoes = value;
        }
      }
      #endregion

      #region Linha 1
      public TextView TxtConsultaDimensionaisQuantidadePecasItem
      {
        get
        {
          return _txtConsultaDimensionaisQuantidadePecasItem;
        }
        private set
        {
          _txtConsultaDimensionaisQuantidadePecasItem = value;
        }
      }

      public TextView TxtConsultaDimensionaisQuantidadeItensCaixa
      {
        get
        {
          return _txtConsultaDimensionaisQuantidadeItensCaixa;
        }
        private set
        {
          _txtConsultaDimensionaisQuantidadeItensCaixa = value;
        }
      }
      #endregion

      #region Linha 2
      public TextView TxtConsultaDimensionaisProdutoComprimento
      {
        get
        {
          return _txtConsultaDimensionaisProdutoComprimento;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoComprimento = value;
        }
      }

      public TextView TxtConsultaDimensionaisProdutoLargura
      {
        get
        {
          return _txtConsultaDimensionaisProdutoLargura;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoLargura = value;
        }
      }

      public TextView TxtConsultaDimensionaisProdutoAltura
      {
        get
        {
          return _txtConsultaDimensionaisProdutoAltura;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoAltura = value;
        }
      }
      #endregion

      #region Linha 3
      public TextView TxtConsultaDimensionaisProdutoPeso
      {
        get
        {
          return _txtConsultaDimensionaisProdutoPeso;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoPeso = value;
        }
      }

      public TextView TxtConsultaDimensionaisProdutoVolume
      {
        get
        {
          return _txtConsultaDimensionaisProdutoVolume;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoVolume = value;
        }
      }

      public TextView TxtConsultaDimensionaisProdutoVolumeAdicional
      {
        get
        {
          return _txtConsultaDimensionaisProdutoVolumeAdicional;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoVolumeAdicional = value;
        }
      }
      #endregion

      #region Linha 4
      public TextView TxtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo
      {
        get
        {
          return _txtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo;
        }
        private set
        {
          _txtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo = value;
        }
      }
      #endregion

      #region Linha 5
      public TextView TxtConsultaDimensionaisEmbalagemComprimento
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemComprimento;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemComprimento = value;
        }
      }

      public TextView TxtConsultaDimensionaisEmbalagemLargura
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemLargura;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemLargura = value;
        }
      }

      public TextView TxtConsultaDimensionaisEmbalagemAltura
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemAltura;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemAltura = value;
        }
      }
      #endregion

      #region Linha 6
      public TextView TxtConsultaDimensionaisEmbalagemPesoVazia
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemPesoVazia;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemPesoVazia = value;
        }
      }

      public TextView TxtConsultaDimensionaisEmbalagemPesoCheia
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemPesoCheia;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemPesoCheia = value;
        }
      }

      public TextView TxtConsultaDimensionaisEmbalagemVolume
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemVolume;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemVolume = value;
        }
      }
      #endregion

      #region Linha 7
      public TextView TxtConsultaDimensionaisPaleteQuantidadeCaixasCamada
      {
        get
        {
          return _txtConsultaDimensionaisPaleteQuantidadeCaixasCamada;
        }
        private set
        {
          _txtConsultaDimensionaisPaleteQuantidadeCaixasCamada = value;
        }
      }

      public TextView TxtConsultaDimensionaisPaleteQuantidadeCamadas
      {
        get
        {
          return _txtConsultaDimensionaisPaleteQuantidadeCamadas;
        }
        private set
        {
          _txtConsultaDimensionaisPaleteQuantidadeCamadas = value;
        }
      }
      #endregion

      #region Linha 8
      public TextView TxtConsultaDimensionaisPaleteQuantidadeCaixasColetivas
      {
        get
        {
          return _txtConsultaDimensionaisPaleteQuantidadeCaixasColetivas;
        }
        private set
        {
          _txtConsultaDimensionaisPaleteQuantidadeCaixasColetivas = value;
        }
      }
      #endregion

      #region Linha 9
      public TextView TxtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo
      {
        get
        {
          return _txtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo;
        }
        private set
        {
          _txtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo = value;
        }
      }

      public TextView TxtConsultaDimensionaisPaletePeso
      {
        get
        {
          return _txtConsultaDimensionaisPaletePeso;
        }
        private set
        {
          _txtConsultaDimensionaisPaletePeso = value;
        }
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
        BindQuantidadePecasItem ( activity );
        BindQuantidadeItensCaixa ( activity );
        #endregion

        #region Linha 2
        BindProdutoComprimento ( activity );
        BindProdutoLargura ( activity );
        BindProdutoAltura ( activity );
        #endregion

        #region Linha 3
        BindProdutoPeso ( activity );
        BindProdutoVolume ( activity );
        BindProdutoVolumeAdicional  ( activity );
        #endregion

        #region Linha        BindQuantidadeEmbalagensVendaVarejo ( activity );
        #endregion

        #region Linha 5
        BindEmbalagemComprimento ( activity );
        BindEmbalagemLargura ( activity );
        BindEmbalagemAltura ( activity );
        #endregion

        #region Linha 6
        BindEmbalagemPesoVazia ( activity );
        BindEmbalagemPesoCheia ( activity );
        BindEmbalagemVolume ( activity );
        #endregion

        #region Linha 7
        BindPaleteQuantidadeCaixasCamada ( activity );
        BindPaleteQuantidadeCamadas ( activity );
        #endregion

        #region Linha 8
        BindPaleteQuantidadeCaixasColetivas ( activity );
        #endregion

        #region Linha 9
        BindPaleteQuantidadeEmbalagensVendaVarejo ( activity );
        BindPaletePeso ( activity );
        #endregion
      }

      #region Bind - Estrutura
      private void BindEstrutura ( Activity activity )
      {
        RloConsultaDimensionais = activity.FindViewById<RelativeLayout> ( Resource.Id.consultaDimensionais );
        LloConsultaDimensionaisBotoes = activity.FindViewById<LinearLayout> ( Resource.Id.consultaDimensionaisbotoes );
      }
      #endregion

      #region Bind - Linha 1
      private void BindQuantidadePecasItem ( Activity activity )
      {
        TxtConsultaDimensionaisQuantidadePecasItem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisQuantidadePecasItem );
      }

      private void BindQuantidadeItensCaixa ( Activity activity )
      {
        TxtConsultaDimensionaisQuantidadeItensCaixa = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisQuantidadeItensCaixa );
      }
      #endregion

      #region Bind - Linha 2
      private void BindProdutoComprimento ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoComprimento = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoComprimento );
      }

      private void BindProdutoLargura ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoLargura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoLargura );
      }

      private void BindProdutoAltura ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoAltura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoAltura );
      }
      #endregion

      #region Bind - Linha 3
      private void BindProdutoPeso ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoPeso = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoPeso );
      }

      private void BindProdutoVolume ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoVolume = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoVolume );
      }

      private void BindProdutoVolumeAdicional ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoVolumeAdicional = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoVolumeAdicional );
      }
      #endregion

      #region Bind - Linha 4
      private void BindQuantidadeEmbalagensVendaVarejo ( Activity activity )
      {
        TxtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo );
      }
      #endregion

      #region Bind - Linha 5
      private void BindEmbalagemComprimento ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemComprimento = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemComprimento );
      }

      private void BindEmbalagemLargura ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemLargura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemLargura );
      }

      private void BindEmbalagemAltura ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemAltura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemAltura );
      }
      #endregion

      #region Bind - Linha 6
      private void BindEmbalagemPesoVazia ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemPesoVazia = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemPesoVazia );
      }

      private void BindEmbalagemPesoCheia ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemPesoCheia = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemPesoCheia );
      }

      private void BindEmbalagemVolume ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemVolume = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemVolume );
      }
      #endregion

      #region Bind - Linha 7
      private void BindPaleteQuantidadeCaixasCamada ( Activity activity )
      {
        TxtConsultaDimensionaisPaleteQuantidadeCaixasCamada = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeCaixasCamada );
      }

      private void BindPaleteQuantidadeCamadas ( Activity activity )
      {
        TxtConsultaDimensionaisPaleteQuantidadeCamadas = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeCamadas );
      }
      #endregion

      #region Bind - Linha 8
      private void BindPaleteQuantidadeCaixasColetivas ( Activity activity )
      {
        TxtConsultaDimensionaisPaleteQuantidadeCaixasColetivas = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeCaixasColetivas );
      }
      #endregion

      #region Bind - Linha 9
      private void BindPaleteQuantidadeEmbalagensVendaVarejo ( Activity activity )
      {
        TxtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo );
      }

      private void BindPaletePeso ( Activity activity )
      {
        TxtConsultaDimensionaisPaletePeso = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaletePeso );
      }
      #endregion

      public void Clear ( )
      {

        #region Linha 1
        TxtConsultaDimensionaisQuantidadePecasItem.Text = String.Empty;
        TxtConsultaDimensionaisQuantidadeItensCaixa.Text = String.Empty;
        #endregion

        #region Linha 2
        TxtConsultaDimensionaisProdutoComprimento.Text = String.Empty;
        TxtConsultaDimensionaisProdutoLargura.Text = String.Empty;
        #endregion

        #region Linha 3
        TxtConsultaDimensionaisProdutoPeso.Text = String.Empty;
        TxtConsultaDimensionaisProdutoVolume.Text = String.Empty;
        TxtConsultaDimensionaisProdutoVolumeAdicional.Text = String.Empty;
        #endregion

        #region Linha 4
        TxtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo.Text = String.Empty;
        #endregion

        #region Linha 5
        TxtConsultaDimensionaisEmbalagemComprimento.Text = String.Empty;
        TxtConsultaDimensionaisEmbalagemLargura.Text = String.Empty;
        TxtConsultaDimensionaisEmbalagemAltura.Text = String.Empty;
        #endregion

        #region Linha 6
        TxtConsultaDimensionaisEmbalagemPesoVazia.Text = String.Empty;
        TxtConsultaDimensionaisEmbalagemPesoCheia.Text = String.Empty;
        TxtConsultaDimensionaisEmbalagemVolume.Text = String.Empty;
        #endregion

        #region Linha 7
        TxtConsultaDimensionaisPaleteQuantidadeCaixasCamada.Text = String.Empty;
        TxtConsultaDimensionaisPaleteQuantidadeCamadas.Text = String.Empty;
        #endregion

        #region Linha 8
        TxtConsultaDimensionaisPaleteQuantidadeCaixasColetivas.Text = String.Empty;
        #endregion

        #region Linha 9
        TxtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo.Text = String.Empty;
        TxtConsultaDimensionaisPaletePeso.Text = String.Empty;
        #endregion

      }

      public void AtualizaCampos ( VariaveisClasse valor )
      {

        #region Linha 1
        TxtConsultaDimensionaisQuantidadePecasItem.Text = valor.QuantidadePecasItem.ToString ( "###0" ).Trim ( );
        TxtConsultaDimensionaisQuantidadeItensCaixa.Text = valor.QuantidadeItensCaixa.ToString ( "###0" ).Trim ( );
        #endregion

        #region Linha 2
        TxtConsultaDimensionaisProdutoComprimento.Text = valor.ProdutoComprimento.ToString ( "#0.00000" ).Trim ( );
        TxtConsultaDimensionaisProdutoLargura.Text = valor.ProdutoLargura.ToString ( "#0.00000" ).Trim ( );
        #endregion

        #region Linha 3
        TxtConsultaDimensionaisProdutoPeso.Text = valor.ProdutoPeso.ToString ( "####0.000" ).Trim ( );
        TxtConsultaDimensionaisProdutoVolume.Text = valor.ProdutoVolume.ToString ( "#0.00000" ).Trim ( );
        TxtConsultaDimensionaisProdutoVolumeAdicional.Text = valor.ProdutoVolumeAdicional.ToString ( "#0.00000" ).Trim ( );
        #endregion

        #region Linha 4
        TxtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo.Text = valor.QuantidadeEmbalagensVendaVarejo.ToString ( "###0" ).Trim ( );
        #endregion

        #region Linha 5
        TxtConsultaDimensionaisEmbalagemComprimento.Text = valor.EmbalagemComprimento.ToString ( "#0.00000" ).Trim();
        TxtConsultaDimensionaisEmbalagemLargura.Text = valor.EmbalagemLargura.ToString ( "#0.00000" ).Trim ( );
        TxtConsultaDimensionaisEmbalagemAltura.Text = valor.EmbalagemAltura.ToString ( "#0.00000" ).Trim ( );
        #endregion

        #region Linha 6
        TxtConsultaDimensionaisEmbalagemPesoVazia.Text = valor.EmbalagemPesoVazia.ToString ( "####0.000" ).Trim();
        TxtConsultaDimensionaisEmbalagemPesoCheia.Text = valor.EmbalagemPesoCheia.ToString ( "####0.000" ).Trim ( );
        TxtConsultaDimensionaisEmbalagemVolume.Text = valor.EmbalagemVolume.ToString ( "#0.00000" ).Trim ( );
        #endregion

        #region Linha 7
        TxtConsultaDimensionaisPaleteQuantidadeCaixasCamada.Text = valor.PaleteQuantidadeCaixasCamada.ToString ( "###0" ).Trim ( );
        TxtConsultaDimensionaisPaleteQuantidadeCamadas.Text = valor.PaleteQuantidadeCamadas.ToString ( "###0" ).Trim ( );
        #endregion

        #region Linha 8
        TxtConsultaDimensionaisPaleteQuantidadeCaixasColetivas.Text = valor.PaleteQuantidadeCaixasColetivas.ToString ( "###0" ).Trim ( );
        #endregion

        #region Linha 9
        TxtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo.Text = valor.PaleteQuantidadeEmbalagensVendaVarejo.ToString ( "###0" ).Trim ( );
        TxtConsultaDimensionaisPaletePeso.Text = valor.PaletePeso.ToString ( "####0.000" ).Trim ( );
        #endregion

      }

    }

    #region Privadas
    private readonly Config         _bcoSql;
    private readonly AcessoSql      _acessoSql;
    private Boolean                 _ok;
    private Tabela                  _consultaDimensionais;
    private List<Coluna>            _colunas;
    private VariaveisClasse               _variaveis;
    private CamposXml                  _camposTela;
    private Item.Classe               _item;
    #endregion

    #region Publicas
    public Tabela Tabela
    {
      get
      {
        return _consultaDimensionais;
      }
      set
      {
        _consultaDimensionais = value;
      }
    }

    public Boolean Ok
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

    public List<Coluna> Colunas
    {
      get
      {
        return _colunas;
      }
      set
      {
        _colunas = value;
      }
    }

    public Config BcoSql
    {
      get
      {
        return _bcoSql;
      }
    }

    public AcessoSql AcessoSql
    {
      get
      {
        return _acessoSql;
      }
    }

    public Item.Classe Item
    {
      get
      {
        return _item;
      }
      set
      {
        _item = value;
      }
    }

    public CamposXml CamposTela
    {
      get
      {
        return _camposTela;
      }
      set
      {
        _camposTela = value;
      }
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
      CriaColunas ( );
      _variaveis = new VariaveisClasse ( );
      CamposTela = new CamposXml ( activity );
      CamposTela.LloConsultaDimensionaisBotoes.Visibility = ViewStates.Invisible;
      CamposTela.Clear ( );
      _ok = _item.Ok;
      if ( _ok )
      {
        PopulaRecord ( _item );
      }
    }

    public void Show ( )
    {
      _camposTela.RloConsultaDimensionais.Visibility = ViewStates.Visible;
    }

    public void Hide ( )
    {
      _camposTela.RloConsultaDimensionais.Visibility = ViewStates.Gone;
    }

    private void CriaColunas ( )
    {
      _colunas = new List<Coluna> ( );

      #region Linha 1
      _colunas.Add ( new Coluna ( 3, "QuantidadePecasItem", "", typeof ( Int32 ), false, false, false ) );
      _colunas.Add ( new Coluna ( 4, "QuantidadeItensCaixa", "", typeof ( Int32 ), false, false, false ) );
      #endregion

      #region Linha 2
      _colunas.Add ( new Coluna ( 7, "ProdutoComprimento", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 8, "ProdutoLargura", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 9, "ProdutoAltura", "", typeof ( Double ), false, false, false ) );
      #endregion

      #region Linha 3
      _colunas.Add ( new Coluna ( 13, "ProdutoPeso", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 14, "ProdutoVolume", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 15, "ProdutoVolumeAdicional", "", typeof ( Double ), false, false, false ) );
      #endregion

      #region Linha 4
      _colunas.Add ( new Coluna ( 19, "QuantidadeEmbalagemVarejo", "", typeof ( Int32 ), false, false, false ) );
      #endregion

      #region Linha 5
      _colunas.Add ( new Coluna ( 25, "EmbalagemComprimento", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 26, "EmbalagemLargura", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 27, "EmbalagemAltura", "", typeof ( Double ), false, false, false ) );
      #endregion

      #region Linha 6
      _colunas.Add ( new Coluna ( 30, "EmbalagemPesoVazia", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 31, "EmbalagemPesoCheia", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 32, "EmbalagemVolume", "", typeof ( Double ), false, false, false ) );
      #endregion

      #region Linha 7
      _colunas.Add ( new Coluna ( 37, "PaleteQuantidadeCaixasCamada", "", typeof ( Int32 ), false, false, false ) );
      _colunas.Add ( new Coluna ( 38, "PaleteQuantidadeCamadas", "", typeof ( Int32 ), false, false, false ) );
      #endregion

      #region Linha 8
      _colunas.Add ( new Coluna ( 42, "PaleteQuantidadeCaixasColetivas", "", typeof ( Int32 ), false, false, false ) );
      #endregion

      #region Linha 9
      _colunas.Add ( new Coluna ( 46, "PaleteQuantidadeEmbalagensVendaVarejo", "", typeof ( Int32 ), false, false, false ) );
      _colunas.Add ( new Coluna ( 47, "PaletePeso", "", typeof ( Double ), false, false, false ) );
      #endregion

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
