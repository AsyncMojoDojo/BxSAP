﻿Imports System.Threading
'••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
Namespace API.SAPFunctions.DDIC

	Public Interface IBxS_DDICInfo

		#Region "Methods"

			Function GetDDICInfoAsync(	ByVal DTO						As	IBxS_DDICInfo_DTO	,
																	ByVal CancelToken		As	CancellationToken		)		As Task(Of Boolean )

		#End Region

	End Interface

End Namespace