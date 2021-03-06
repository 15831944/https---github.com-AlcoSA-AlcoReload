﻿Public Class ClsRutas
#Region "Variables Reales"
    Public Const RutaTemp As String = "\\servidor\Planos\temp"
    Public Const RutaUnoeeItems As String = "\\servidor\Planos\PlanosItems"
    Public Const RutaUnoeePv As String = "\\servidor\Planos\PlanosPV"
    Public Const RutaUnooRep As String = "\\servidor\Planos\PlanosRep\Plano"
    Public Const Rutaordenproduccion As String = "\\servidor\Datos\Produccion\Depto Tecnico\PROGRAMA\CAMBIADOS1"
    'Public Const Rutaordenproduccion As String = "\\192.168.0.21\D$\CAMBIADOS1"
    Public Const RutaCotizaciones As String = "\\servidor\Datos\Comercial\COTIZACIONES"
    Public Const RutaBarras As String = "\\servidor\Planos\temp\temp.prn"
    Public Const RutaImagenesPP As String = "\\servidor\Datos\Produccion\Depto Tecnico\PROGRAMA\BD\ImagenesPP"
    Public Const RutaImagenesST As String = "\\servidor\Datos\Produccion\Depto Tecnico\PROGRAMA\BD\ImagenesST"
    Public Const RutaUsuarios As String = "\\servidor\Datos\Produccion\Depto Tecnico\PROGRAMA\BD\UsuarioActivo"
    Public Const RutaGaleriaDeptoTecnico As String = "\\servidor\Datos\Produccion\Depto Tecnico\PROGRAMA\BD\GaleriaDeptoTecnico"
    Public Const RutaEXcel As String = "\\servidor\PlanosExcel\"
    Public Const RutasContratos As String = "\\servidor\datos\Administrativo\Financiero\Cartera\CONTRATOS\CONTRATOS ALCOSYS"
    Public Shared rutaTemporales As String = Convert.ToString(Environment.GetEnvironmentVariables(System.EnvironmentVariableTarget.Machine).Item("TMP"))
    Public Const rutaComisiones As String = "\\servidor\datos\Administrativo\Financiero\MARYLUZ\COMISIONES"
    Public Const rutaPrefactura As String = "\\SERVIDOR\Datos\Produccion\Depto Tecnico\PROGRAMA\cotizadosFACT2.xltm"
    Public Const rutaParaFacurar As String = "\\SERVIDOR\Datos\Produccion\Depto Tecnico\PROGRAMA\cotizadosFACT2.xltm"

#End Region
#Region "Variables de Prueba"
    'Public Const RutaTemp As String = "E:\PLANOSPED"
    'Public Const RutaUnoeeItems As String = "E:\PLANOSPED"
    'Public Const RutaUnoeePv As String = "E:\PLANOSPED"
    'Public Const RutaUnooRep As String = "E:\PLANOSPED"
    'Public Const Rutaordenproduccion As String = "\\ALCO-NAS\COPIAS\Datos\Produccion\Depto Tecnico\PROGRAMA\CAMBIADOS1"
    'Public Const RutaCotizaciones As String = "E:\PLANOSPED"
    'Public Const RutaBarras As String = "\\192.168.0.1\Planos\temp\temp.prn"
    'Public Const RutaImagenesPP As String = "\\ALCO-NAS\COPIAS\Datos\Produccion\Depto Tecnico\PROGRAMA\BD\ImagenesPP"
    'Public Const RutaUsuarios As String = "\\ALCO-NAS\COPIAS\Datos\Produccion\Depto Tecnico\PROGRAMA\BD\UsuarioActivo"
    ''Public RutaGaleriaDeptoTecnico As String = My.Computer.FileSystem.SpecialDirectories.MyPictures '"C:\Users\Public\Pictures\Sample Pictures"
    'Public Const RutaGaleriaDeptoTecnico As String = "\\ALCO-NAS\COPIAS\Datos\Produccion\Depto Tecnico\PROGRAMA\BD\GaleriaDeptoTecnico"
    'Public Const RutaImagenesST As String = "\\ALCO-NAS\COPIAS\Datos\Produccion\Depto Tecnico\PROGRAMA\BD\ImagenesST"
    'Public Const RutaEXcel As String = "\\ALCO-NAS\COPIAS\PlanosExcel\"
    'Public Const RutaDiseños As String = "\\ALCO-NAS\COPIAS\Datos\Produccion\Depto Tecnico\PROGRAMA\CAMBIADOS1\"
    'Public Const RutasContratos As String = "\\ALCO-NAS\COPIAS\datos\Administrativo\Financiero\Cartera\CONTRATOS\CONTRATOS ALCOSYS"
    'Public Shared rutaTemporales As String = Environment.GetEnvironmentVariables(System.EnvironmentVariableTarget.Machine).Item("TMP")
#End Region
End Class
